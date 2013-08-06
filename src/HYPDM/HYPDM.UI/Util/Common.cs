using EAS.Modularization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using HYPDM.WinUI.BaseUI;
using EAS.Explorer;
using AdvancedDataGridView;
using System.IO;
using System.Configuration;
using System.Collections;

namespace HYPDM.WinUI.Util
{
    public class Common
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        IPhysicalFileService _physicalService = ServiceContainer.GetService<IPhysicalFileService>();
        IDocumentService _docService = ServiceContainer.GetService<IDocumentService>();

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
        public static FTPDownUp FtpInfo()
        {
            var serverAddr = ConfigurationManager.AppSettings["serverAddr"].ToString();
            var serverPort = Convert.ToInt32(ConfigurationManager.AppSettings["serverPort"]);
            var userName = ConfigurationManager.AppSettings["userName"].ToString();
            var passWord = ConfigurationManager.AppSettings["passWord"].ToString();
            FTPDownUp ftp = new FTPDownUp(serverAddr, serverPort, userName, passWord);
            return ftp;
        }

        public static FTPHelper FtpHepler()
        {
            var serverAddr = ConfigurationManager.AppSettings["serverAddr"].ToString();
            var serverPort = Convert.ToInt32(ConfigurationManager.AppSettings["serverPort"]);
            var userName = ConfigurationManager.AppSettings["userName"].ToString();
            var passWord = ConfigurationManager.AppSettings["passWord"].ToString();
            var file = ConfigurationManager.AppSettings["file"].ToString();
            FTPHelper helper = new FTPHelper(serverAddr, file, userName, passWord);
            return helper;
        }


        /// <summary>
        /// 检入
        /// </summary>
        public void CheckIn(string Id, string fileName)
        {
            HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            if (physicalfile == null) return;
            BaseCheckInForm form = new BaseCheckInForm();
            form.PhysicalFile = physicalfile;

            if (form.ShowDialog() == DialogResult.OK)
            {
                physicalfile.FILESTATUS = "1";
                var version = Convert.ToInt32(physicalfile.FILEVERSION);
                physicalfile.FILEVERSION = (version + 1).ToString();
                physicalfile.Save();

                HYPDM.Entities.PDM_PHYSICAL_FILE file = form.PhysicalFile;
                fileName = file.FILENAME;
                VersionSave("1");
            }
        }
        /// <summary>
        /// 检出
        /// </summary>
        public void CheckOut(string Id, string fileName)
        {
            HYPDM.Entities.PDM_PHYSICAL_FILE physicalfile = _physicalService.GetPhysicalFile(Id, "");
            if (physicalfile == null) return;
            if (physicalfile.FILESTATUS == "0") { MessageBox.Show("当前文档已被检出，不能再次检出，请等待检出人检入！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            BaseDetectionForm form = new BaseDetectionForm();
            form.PhysicalFile = physicalfile;

            if (form.ShowDialog() == DialogResult.OK)
            {
                physicalfile.FILESTATUS = "0";
                physicalfile.Save();

                HYPDM.Entities.PDM_PHYSICAL_FILE file = form.PhysicalFile;
                fileName = file.FILENAME;
                VersionSave("0");
            }
        }
        /// <summary>
        /// 版本历史记录保存
        /// </summary>
        /// <param name="type">0：检出，1：检入</param>
        private void VersionSave(string type)
        {
            PDM_VERSION_HISTORY version = new PDM_VERSION_HISTORY();
            version.ID = _physicalService.GetMaxID().ToString();
            version.VERSIONNO = DateTime.Now.ToString("yyyyMMddHHmmss");
            version.VERSIONSTATUS = type;
            version.OPERATORUSER = LoginInfo.LoginID;
            version.OPERATORDATE = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            version.Save();
        }

        /// <summary>
        /// 查看文件
        /// </summary>
        /// <param name="fileName">文件名称</param>
        public void FileView(string fileName)
        {
            var temp = System.Environment.GetEnvironmentVariable("TEMP");
            FTPHelper helper = FtpHepler();
            var info = "";
            var tempFilePath = temp + "\\" + fileName;
            var result = helper.DownloadFile(temp, fileName, out info);
            if (result)
            {
                System.Diagnostics.Process.Start(tempFilePath);
            }
            else
            {
                MessageBox.Show("文件查看失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="fileName">文件名称</param>
        public void DownFile(string filePath, string fileName)
        {
            var info = "";
            FTPHelper helper = FtpHepler();
            var result = helper.DownloadFile(filePath, fileName, out info);
            if (result)
            {
                MessageBox.Show("文件下载失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
