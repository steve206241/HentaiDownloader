using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HantaiDownloader {
    public class Central {
        public static string UserName = "";
        public static string Password = "";
        public static string AppCode = "";
        public static string MainUrl = "";

        public static Logger logger = null;
        public static AUTH authUser = null;
        public static FormMain main = null;

        public static string GetPara(string Key) {
            var x = ConfigurationManager.AppSettings.AllKeys.Contains(Key) ?
                ConfigurationManager.AppSettings[Key] : null;

            return x != null ? x.ToString() : "";

        }

        public static Logger.Level GetLevel(string key) {
            return
                key.ToUpper() == "CRITICAL" ? Logger.Level.Critical :
                key.ToUpper() == "ERROR" ? Logger.Level.Error :
                key.ToUpper() == "WARNING" ? Logger.Level.Warning :
                key.ToUpper() == "INFO" ? Logger.Level.Info :
                key.ToUpper() == "LOG" ? Logger.Level.Log :
                key.ToUpper() == "TRACE" ? Logger.Level.Trace :
                Logger.Level.Trace;

        }

    }

}
