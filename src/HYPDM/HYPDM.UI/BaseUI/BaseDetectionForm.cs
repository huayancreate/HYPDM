using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.BaseUI
{
    public partial class BaseDetectionForm : BaseForm
    {
        public BaseDetectionForm()
        {
            InitializeComponent();
        }
        private HYPDM.Entities.PDM_PHYSICAL_FILE physicalFile;
        public HYPDM.Entities.PDM_PHYSICAL_FILE PhysicalFile
        {
            get { return this.physicalFile; }
            set
            {
                this.physicalFile = value;
                if (value != null)
                    this.InitPhysicalInfo();
            }
        }

        private void InitPhysicalInfo()
        {
            if (PhysicalFile != null)
            {
                txtFileName.Text = PhysicalFile.FILENAME;
            }
        }

        /// <summary>
        /// 选择存放路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdFile = new FolderBrowserDialog();
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (fbdFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fbdFile.SelectedPath;
            }
        }

        /// <summary>
        /// 检出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDetect_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == string.Empty || txtFilePath.Text.Trim() == string.Empty)
            {
                MessageBox.Show("文件名或文件路径不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Util.FTPHelper helper = Util.Common.FtpHepler();
                var info = "";
                var result = helper.DownloadFile(txtFilePath.Text, txtFileName.Text, out info);
                if (result)
                {
                    MessageBox.Show("文件检出成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("文件检出失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
