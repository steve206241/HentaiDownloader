using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;

namespace HantaiDownloader {
    public partial class FormMain : Form {
        Logger logger = new Logger();
        BOOK_INFO bookInfo = null;

        public FormMain() {
            InitializeComponent();

            Central.authUser = new AUTH(Central.UserName, Central.Password);
            Central.logger = this.logger;

        }

        #region EVENT
        private void FormMain_Load(object sender, EventArgs e) {
            this.txtSavePath.Enabled = false;
            this.btnSavePath.Enabled = false;
            this.btnDownload.Enabled = false;

            this.ShowLog("歡迎使用 變態實現下載器，所有動作皆以操作者本人意願，且年齡已達到合法年齡", false);

        }

        private void btnAnalysis_Click(object sender, EventArgs e) {
            this.ShowLog("讀取開始");

            this.btnAnalysis.Enabled = false;
            this.ClearData();

            try {
                this.ShowLog("分析連結");

                string url = this.txtURL.Text;
                this.bookInfo = this.ProcessBook(url);

                this.txtStatus.Text = this.CalcStatus() ? "可以下載" : "不可下載";

                if (!this.CalcStatus()) {
                    throw new Exception("目前無法下載此檔案");

                }

                this.ShowLog("顯示分析結果");
                this.txtProcessCode.Text = string.Format("{0}_{1}", this.bookInfo.p_key, this.bookInfo.s_key);
                this.txtEngTitle.Text = this.bookInfo.eng_title;
                this.txtUniTitle.Text = this.bookInfo.uni_title;
                this.txtPage.Text = this.bookInfo.total_page.ToString();
                this.txtType.Text = this.bookInfo.type.ToUpper();
                this.txtLanguage.Text = this.bookInfo.language;
                this.txtPostedTime.Text = this.bookInfo.posted_time;
                this.txtRateAvg.Text = this.bookInfo.rate_avg;
                this.txtRateTime.Text = this.bookInfo.rate_time;

                if (this.bookInfo.pic_Stream != null) {
                    this.picCover.Image = Image.FromStream(this.bookInfo.pic_Stream);

                }

                this.btnSavePath.Enabled = true;
                this.btnDownload.Enabled = true;

                this.txtSavePath.Text = Environment.CurrentDirectory;
                this.btnDownload.Focus();

                this.ShowLog("讀取完成");

            } catch (Exception ex) {
                this.ShowLog(ex.Message);
                this.ShowLog(ex.StackTrace);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

                this.btnAnalysis.Enabled = true;
                this.txtURL.Focus();

                this.ShowLog("讀取失敗");

            }

        }

        private void txtURL_TextChanged(object sender, EventArgs e) {
            this.txtSavePath.Text = "";
            this.ClearData();

            this.btnAnalysis.Enabled = true;

        }

        private void btnSavePath_Click(object sender, EventArgs e) {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            folder.RootFolder = Environment.SpecialFolder.Desktop;

            if (folder.ShowDialog() == DialogResult.OK) {
                this.txtSavePath.Text = folder.SelectedPath;

            }

        }

        private void btnDownload_Click(object sender, EventArgs e) {
            this.ShowLog("開始下載檔案");
            string pKey = this.txtProcessCode.Text.Split('_')[0];
            string sKey = this.txtProcessCode.Text.Split('_')[1];

            string rootPath = this.txtSavePath.Text;
            string dir = string.Format("{0}_{1}", pKey, sKey);
            string savePath = Path.Combine(rootPath, dir);

            try {
                this.ShowLog("分析下載檔案序列");
                List<PIC_INFO> imgList = this.ProcessDLList();

                this.ShowLog(string.Format("下載檔案數量 = {0}", imgList.Count));
                for(int i = 0 ; i < imgList.Count ; i++){
                    try {
                        PIC_INFO picInfo = imgList[i];

                        this.ShowLog(string.Format("處理下載檔案{0}", i + 1));
                        this.ProcessDownloadPic(picInfo, savePath);

                    } catch (Exception ex) {
                        this.ShowLog(string.Format("處理下載檔案{0}失敗", i + 1));
                        this.ShowLog(ex.Message);

                    }

                }

                this.ShowLog("完成下載檔案");

                this.ProcessBookInfo(this.bookInfo, savePath);

            } catch (Exception ex) {
                this.ShowLog(ex.Message);
                this.ShowLog(ex.StackTrace);
                this.ShowLog("失敗下載檔案");

            }

        }

        #endregion EVENT

        #region BASE
        private BOOK_INFO ProcessBook(string url) {
            Uri uri = new Uri(url);

            HTML htmlObj = new HTML(url);
            htmlObj.GetHtml();

            string html = htmlObj.webHtml;

            Crawler crawler = new Crawler(html);
            crawler.mainUrl = string.Format("{0}://{1}", uri.Scheme, uri.Host);
            string pKey = url.Replace(crawler.mainUrl + "/g/", "").Split('/')[0];
            string sKey = url.Replace(crawler.mainUrl + "/g/", "").Split('/')[1];
            crawler.pKey = pKey;
            crawler.sKey = sKey;

            BOOK_INFO bookInfo = new BOOK_INFO(url);
            bookInfo.p_key = pKey;
            bookInfo.s_key = sKey;
            bookInfo.type = crawler.Get_Type().ToString();
            bookInfo.eng_title = crawler.Get_Eng_Title();
            bookInfo.uni_title = crawler.Get_Uni_Title();
            bookInfo.language = crawler.Get_Language();
            bookInfo.total_page = int.Parse(crawler.Get_Total_Page());
            bookInfo.posted_time = crawler.Get_Posted_Time();
            bookInfo.tab_count = int.Parse(crawler.Get_Tab_Count());
            bookInfo.rate_avg = crawler.Get_Rate_Avg();
            bookInfo.rate_time = crawler.Get_Rate_Time();

            bookInfo.pic = crawler.Get_Cover();

            if (bookInfo.pic != "") {
                HTML picObj = new HTML(bookInfo.pic);

                picObj.GetStream();

                bookInfo.pic_Stream = picObj.webStream;

            }

            return bookInfo;

        }

        public List<PIC_INFO> ProcessDLList() {
            try {
                List<PIC_INFO> pic_info = new List<PIC_INFO>();

                this.logger.WriteInfo(string.Format("開始處理下載清單 : {0}", this.bookInfo.threadUrl));

                //總頁數
                int totalCount = 0;
                //總 Tab
                int totalTab = this.bookInfo.tab_count;

                //處理各頁
                string web = this.bookInfo.threadUrl + "?p={0}";
                for (int i = 0 ; i < this.bookInfo.tab_count ; i++) {
                    //取得頁面
                    string url = string.Format(web, i);
                    this.logger.Write(this, string.Format("開始處理下載清單頁面 : {0}", url));

                    HTML htmlObj = new HTML(url);
                    htmlObj.GetHtml();

                    string html = htmlObj.webHtml;
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    //分析
                    HtmlNode rootNode = doc.DocumentNode;
                    string tableXPath = "/html[1]/body[1]/div[5]";
                    HtmlNode tableNode = rootNode.SelectSingleNode(tableXPath);
                    foreach (HtmlNode node in tableNode.ChildNodes) {
                        if (!node.XPath.StartsWith(tableXPath)) {
                            continue;
                        }

                        string xpath = node.XPath + "/div[1]/a[1]";

                        //頁數 + 1
                        totalCount++;

                        this.logger.Write(this, string.Format(
                            "開始處理下載清單頁面圖片 : {0} PIC_COUNT = {1}", url, totalCount));
                        //處理每個圖片頁面的URL
                        HtmlNode imgNode = rootNode.SelectSingleNode(xpath);
                        if (imgNode != null) {
                            PIC_INFO picInfo = new PIC_INFO();
                            picInfo.threadUrl = bookInfo.pageUrl;
                            picInfo.picNo = totalCount.ToString().PadLeft(this.bookInfo.total_page.ToString().Length, '0');
                            picInfo.picUrl = imgNode.Attributes["href"].Value;

                            pic_info.Add(picInfo);

                        } else {
                            xpath = node.XPath + "/a[1]";
                            totalCount++;
                            imgNode = rootNode.SelectSingleNode(xpath);
                            if (imgNode != null) {
                                PIC_INFO picInfo = new PIC_INFO();
                                picInfo.threadUrl = bookInfo.pageUrl;
                                picInfo.picNo = totalCount.ToString().PadLeft(this.bookInfo.total_page.ToString().Length, '0');
                                picInfo.picUrl = imgNode.Attributes["href"].Value;

                                pic_info.Add(picInfo);

                            }
                        }

                        this.logger.Write(this, string.Format(
                            "完成處理下載清單頁面圖片 : {0} PIC_COUNT = {1}", url, totalCount));

                    }

                    this.logger.Write(this, string.Format("完成處理下載清單頁面 : {0}", url));

                }

                this.logger.WriteInfo(string.Format("完成處理下載清單 : {0}", this.bookInfo.threadUrl));

                return pic_info;

            } catch (Exception ex) {
                throw ex;

            }

        }

        public void ProcessDownloadPic(PIC_INFO pic, string savePath) {
            this.logger.WriteInfo(string.Format("開始下載圖片 : {0}", pic.picUrl));
            HtmlAgilityPack.HtmlDocument doc = null;
            HtmlNode rootNode = null;
            string html = "";
            string xpath = "";

            //分析圖片頁面
            this.logger.Write(this, string.Format("分析下載圖片頁面 : {0}", pic.picUrl));
            HTML htmlObj = new HTML(pic.picUrl);
            htmlObj.GetHtml();

            html = htmlObj.webHtml;
            doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            rootNode = doc.DocumentNode;

            xpath = "/html[1]/body[1]/div[1]/div[2]/a[1]/img[1]";

            HtmlNode imgNode = rootNode.SelectSingleNode(xpath);
            string img = imgNode.Attributes["src"].Value;

            //取得 img 資料
            this.logger.Write(this, string.Format("下載圖片頁面 : {0} 下載圖片:{1}", pic.picUrl, img));
            HTML imgObj = new HTML(img);
            imgObj.GetStream();
            using (Stream imgStream = imgObj.webStream) {
                if (imgStream == null) {
                    return;
                }

                try {
                    //儲存檔案
                    using (Stream stream = imgStream) {
                        if (!Directory.Exists(savePath)) {
                            Directory.CreateDirectory(savePath);
                        }

                        Image i = Image.FromStream(stream);
                        i.Save(Path.Combine(savePath, string.Format("{0}.jpg", pic.picNo)));
                        i.Dispose();

                        pic.success = true;
                    }

                    this.logger.WriteInfo(string.Format("完成下載圖片 : {0}", pic.picUrl));

                } catch (Exception ex) {
                    throw ex;

                }

            }

        }

        public void ProcessBookInfo(BOOK_INFO bookInfo , string savePath) {
            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("BOOK_NAME = {0}", bookInfo.eng_title);
            builder.AppendLine();
            builder.AppendFormat("BOOK_TITLE = {0}", bookInfo.uni_title.Trim() != "" ? bookInfo.uni_title : bookInfo.eng_title);
            builder.AppendLine();
            builder.AppendFormat("PAGE = {0}", bookInfo.total_page);
            builder.AppendLine();
            builder.AppendFormat("LANGUAGE = {0}", bookInfo.language);
            builder.AppendLine();
            builder.AppendFormat("UPLOAD_TIME = {0}", bookInfo.upload_time);
            builder.AppendLine();

            try {
                this.logger.WriteTrace("寫入 Info 文字檔");
                using (StreamWriter writer = new StreamWriter(Path.Combine(savePath, "Info.txt"))) {
                    writer.Write(builder.ToString());

                }

                this.logger.WriteTrace("完成寫入 Info 文字檔");

            } catch (Exception ex) {
                this.logger.WriteError("失敗寫入 Info 文字檔");
                this.logger.WriteError(ex.Message);

            }

        }
        #endregion BASE

        #region FUNCTION
        private void ShowLog(string message , bool newLine = true) {
            this.txtLog.Text += (newLine ? Environment.NewLine : "") + message;
            this.txtLog.SelectionStart = this.txtLog.Text.Length;
            this.txtLog.ScrollToCaret();
            this.Refresh();

        }

        private void ClearData() {
            this.txtProcessCode.Text = "";
            this.txtStatus.Text = "";
            this.txtEngTitle.Text = "";
            this.txtUniTitle.Text = "";
            this.txtLanguage.Text = "";
            this.txtPage.Text = "";
            this.txtType.Text = "";
            this.txtPostedTime.Text = "";
            this.txtRateAvg.Text = "";
            this.txtRateTime.Text = "";
            this.txtSavePath.Text = "";
            this.picCover.Image = null;

            this.btnSavePath.Enabled = false;
            this.btnDownload.Enabled = false;

        }

        private bool CalcStatus() {
            if ((this.bookInfo == null) ||
                (this.bookInfo.p_key == "" || this.bookInfo.s_key == "") ||
                (this.bookInfo.total_page == 0) ||
                (this.bookInfo.pic_Stream == null)) {
                return false;

            }

            return true;

        }

        #endregion FUNCTION

    }
}
