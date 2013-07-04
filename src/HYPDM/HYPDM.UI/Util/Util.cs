using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.Util
{
    public class Util
    {
        public string GetExtensionToType(string exten)
        {
            var type = "";
            switch (exten)
            {
                case ".doc":
                    type = "Word文件";
                    break;
                case ".pdf":
                    type = "PDF文件";
                    break;
                case ".xls":
                    type = "Excel文件";
                    break;
                case ".dwg":
                    type = "AutoCAD文件";
                    break;
                default:
                    type = "其他文件";
                    break;
            }
            return type;
        }

        /// <summary>
        /// FTP对象
        /// </summary>
        /// <returns></returns>
        public FTPDownUp FtpInfo()
        {
            var serverAddr = ConfigurationManager.AppSettings["serverAddr"].ToString();
            var serverPort = Convert.ToInt32(ConfigurationManager.AppSettings["serverPort"]);
            var userName = ConfigurationManager.AppSettings["userName"].ToString();
            var passWord = ConfigurationManager.AppSettings["passWord"].ToString();
            FTPDownUp ftp = new FTPDownUp(serverAddr, serverPort, userName, passWord);
            return ftp;
        }
    }
}
