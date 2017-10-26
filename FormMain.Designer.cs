namespace HantaiDownloader {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.pnlAnalysis = new System.Windows.Forms.Panel();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtRateAvg = new System.Windows.Forms.TextBox();
            this.txtRateTime = new System.Windows.Forms.TextBox();
            this.txtPostedTime = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtUniTitle = new System.Windows.Forms.TextBox();
            this.txtEngTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlAnalysis.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("細明體", 12F);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "網址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("細明體", 12F);
            this.txtURL.Location = new System.Drawing.Point(73, 11);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(649, 27);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // pnlAnalysis
            // 
            this.pnlAnalysis.Controls.Add(this.btnAnalysis);
            this.pnlAnalysis.Controls.Add(this.label1);
            this.pnlAnalysis.Controls.Add(this.txtURL);
            this.pnlAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnalysis.Location = new System.Drawing.Point(0, 0);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(734, 77);
            this.pnlAnalysis.TabIndex = 2;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAnalysis.Font = new System.Drawing.Font("細明體", 12F);
            this.btnAnalysis.Location = new System.Drawing.Point(0, 47);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(734, 30);
            this.btnAnalysis.TabIndex = 2;
            this.btnAnalysis.Text = "開始分析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSavePath);
            this.panel2.Controls.Add(this.txtRateAvg);
            this.panel2.Controls.Add(this.txtRateTime);
            this.panel2.Controls.Add(this.txtPostedTime);
            this.panel2.Controls.Add(this.txtLanguage);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.txtPage);
            this.panel2.Controls.Add(this.txtUniTitle);
            this.panel2.Controls.Add(this.txtEngTitle);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSavePath);
            this.panel2.Controls.Add(this.picCover);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtStatus);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProcessCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 345);
            this.panel2.TabIndex = 3;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(626, 258);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(96, 50);
            this.btnSavePath.TabIndex = 28;
            this.btnSavePath.Text = "資料夾選擇";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtRateAvg
            // 
            this.txtRateAvg.Font = new System.Drawing.Font("細明體", 12F);
            this.txtRateAvg.Location = new System.Drawing.Point(307, 223);
            this.txtRateAvg.Name = "txtRateAvg";
            this.txtRateAvg.ReadOnly = true;
            this.txtRateAvg.Size = new System.Drawing.Size(100, 27);
            this.txtRateAvg.TabIndex = 27;
            // 
            // txtRateTime
            // 
            this.txtRateTime.Font = new System.Drawing.Font("細明體", 12F);
            this.txtRateTime.Location = new System.Drawing.Point(519, 224);
            this.txtRateTime.Name = "txtRateTime";
            this.txtRateTime.ReadOnly = true;
            this.txtRateTime.Size = new System.Drawing.Size(100, 27);
            this.txtRateTime.TabIndex = 26;
            // 
            // txtPostedTime
            // 
            this.txtPostedTime.Font = new System.Drawing.Font("細明體", 12F);
            this.txtPostedTime.Location = new System.Drawing.Point(519, 155);
            this.txtPostedTime.Name = "txtPostedTime";
            this.txtPostedTime.ReadOnly = true;
            this.txtPostedTime.Size = new System.Drawing.Size(203, 27);
            this.txtPostedTime.TabIndex = 25;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("細明體", 12F);
            this.txtLanguage.Location = new System.Drawing.Point(519, 191);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(100, 27);
            this.txtLanguage.TabIndex = 24;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("細明體", 12F);
            this.txtType.Location = new System.Drawing.Point(307, 190);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 27);
            this.txtType.TabIndex = 23;
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("細明體", 12F);
            this.txtPage.Location = new System.Drawing.Point(307, 154);
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(100, 27);
            this.txtPage.TabIndex = 22;
            // 
            // txtUniTitle
            // 
            this.txtUniTitle.Font = new System.Drawing.Font("細明體", 12F);
            this.txtUniTitle.Location = new System.Drawing.Point(109, 98);
            this.txtUniTitle.Multiline = true;
            this.txtUniTitle.Name = "txtUniTitle";
            this.txtUniTitle.ReadOnly = true;
            this.txtUniTitle.Size = new System.Drawing.Size(613, 50);
            this.txtUniTitle.TabIndex = 21;
            // 
            // txtEngTitle
            // 
            this.txtEngTitle.Font = new System.Drawing.Font("細明體", 12F);
            this.txtEngTitle.Location = new System.Drawing.Point(109, 42);
            this.txtEngTitle.Multiline = true;
            this.txtEngTitle.Name = "txtEngTitle";
            this.txtEngTitle.ReadOnly = true;
            this.txtEngTitle.Size = new System.Drawing.Size(613, 50);
            this.txtEngTitle.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("細明體", 12F);
            this.label9.Location = new System.Drawing.Point(413, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "評分次數：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("細明體", 12F);
            this.label10.Location = new System.Drawing.Point(201, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "總評分：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("細明體", 12F);
            this.label11.Location = new System.Drawing.Point(413, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "上傳時間：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("細明體", 12F);
            this.label12.Location = new System.Drawing.Point(413, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "語言：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("細明體", 12F);
            this.label7.Location = new System.Drawing.Point(201, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "類型：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("細明體", 12F);
            this.label8.Location = new System.Drawing.Point(201, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "頁數：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("細明體", 12F);
            this.label6.Location = new System.Drawing.Point(3, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "原文名稱：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("細明體", 12F);
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "英文名稱：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("細明體", 12F);
            this.label5.Location = new System.Drawing.Point(3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "下載路徑：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Font = new System.Drawing.Font("細明體", 12F);
            this.txtSavePath.Location = new System.Drawing.Point(109, 281);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(510, 27);
            this.txtSavePath.TabIndex = 12;
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(12, 155);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(177, 120);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCover.TabIndex = 10;
            this.picCover.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("細明體", 12F);
            this.label4.Location = new System.Drawing.Point(512, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "狀態：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("細明體", 12F);
            this.txtStatus.Location = new System.Drawing.Point(582, 9);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(140, 27);
            this.txtStatus.TabIndex = 9;
            // 
            // btnDownload
            // 
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownload.Font = new System.Drawing.Font("細明體", 12F);
            this.btnDownload.Location = new System.Drawing.Point(0, 315);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(734, 30);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "下載";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("細明體", 12F);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "處理代號：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.Enabled = false;
            this.txtProcessCode.Font = new System.Drawing.Font("細明體", 12F);
            this.txtProcessCode.Location = new System.Drawing.Point(109, 9);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Size = new System.Drawing.Size(203, 27);
            this.txtProcessCode.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 190);
            this.panel1.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(734, 190);
            this.txtLog.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAnalysis);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "變態實現下載器 Ver.1.0 20171018";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlAnalysis.ResumeLayout(false);
            this.pnlAnalysis.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Panel pnlAnalysis;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessCode;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.TextBox txtRateAvg;
        private System.Windows.Forms.TextBox txtRateTime;
        private System.Windows.Forms.TextBox txtPostedTime;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtUniTitle;
        private System.Windows.Forms.TextBox txtEngTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSavePath;
    }
}