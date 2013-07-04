using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;

namespace HYPDM.WinUI.Document
{
    public partial class DetectionForm : BaseForm
    {
        public DetectionForm()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdFile = new SaveFileDialog();
            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = sfdFile.FileName;
            }
            Util.Util util=new Util.Util();
            Util.FTPDownUp ftp=util.FtpInfo();
            var info = "";
            ftp.FTPDownload("", "", out info);
        }
    }
}
