using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HantaiDownloader {
    public class BOOK_TYPE {
        public string name = "";
        public Color color;
        public bool Hantai_Active = false;
        public bool HantaiEX_Active = false;

    }

    public class TYPE_DOUJINSHI : BOOK_TYPE {
        public TYPE_DOUJINSHI() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Red;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_MANGA : BOOK_TYPE {
        public TYPE_MANGA() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.OrangeRed;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_ARTIST_CG : BOOK_TYPE {
        public TYPE_ARTIST_CG() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Orange;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_GAME_CG : BOOK_TYPE {
        public TYPE_GAME_CG() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.GreenYellow;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_WESTERN : BOOK_TYPE {
        public TYPE_WESTERN() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Green;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_NON_H : BOOK_TYPE {
        public TYPE_NON_H() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Blue;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_IMAGE_SET : BOOK_TYPE {
        public TYPE_IMAGE_SET() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.BlueViolet;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_COSPLAY : BOOK_TYPE {
        public TYPE_COSPLAY() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Brown;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_ASIANPORN : BOOK_TYPE {
        public TYPE_ASIANPORN() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.Purple;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

    public class TYPE_MISC : BOOK_TYPE {
        public TYPE_MISC() {
            this.name = this.GetType().Name.Replace("TYPE_", "");
            this.color = Color.DarkGray;
            this.Hantai_Active = true;
            this.HantaiEX_Active = true;

        }

    }

}
