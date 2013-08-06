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
    public partial class BaseCheckInForm : Form
    {
        public BaseCheckInForm()
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
        /// 选择文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofdFile.FileName;
            }
        }

        /// <summary>
        /// 检入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckIN_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == string.Empty || txtFilePath.Text.Trim() == string.Empty)
            {
                MessageBox.Show("文件名或文件路径不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Util.FTPHelper helper = Util.Common.FtpHepler();
                var info = "";
                var result = helper.UploadFile(txtFilePath.Text, out info);
                if (result)
                {
                    MessageBox.Show("文件检入成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("文件检入失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
