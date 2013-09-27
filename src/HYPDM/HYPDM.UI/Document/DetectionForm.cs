using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;
using HYDocumentMS;
namespace HYPDM.WinUI.Document
{
    public partial class DetectionForm : BaseForm
    {
        public DetectionForm()
        {
            InitializeComponent();
        }

        private Boolean fileServerAckResult = true;

        public Boolean FileServerAckResult
        {
            get { return fileServerAckResult; }
            set { fileServerAckResult = value; }
        }
        private HYPDM.Entities.DOC_FILE_LIST docFileEntity;

        public HYPDM.Entities.DOC_FILE_LIST DocFileEntity
        {
            get { return docFileEntity; }
            set { docFileEntity = value; }
        } 
     

        private void InitPhysicalInfo()
        {
            if (DocFileEntity != null)
            {
                txtFileName.Text = DocFileEntity.DFL_FILE_NAME;
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
                //Util.FTPHelper helper = Util.Common.FtpHepler();
                var info = "";
                //var result = helper.DownloadFile(txtFilePath.Text, txtFileName.Text, out info);

               // MessageBox.Show(this.txtFilePath.Text.ToString() + @"\" + this.txtFileName.Text.ToString());
                ///下载文件并存放到指定的本地文件夹中
                 HYDocumentMS.IFileHelper fileHelper=new  FileHelper();
                string srvFilePath=fileHelper.getDocumentAllPathByPathID(DocFileEntity.DFL_FILE_CHILD_PATH)+this.txtFileName.Text.ToString();
                FileSockClient.DownLoadFileSocketClient down = new FileSockClient.DownLoadFileSocketClient(srvFilePath, this.txtFilePath.Text.ToString() +@"\"+ this.txtFileName.Text.ToString());

                FileServerAckResult = down.AckStatus;
              
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetectionForm_Load(object sender, EventArgs e)
        {
            this.txtFileName.Text = DocFileEntity.DFL_FILE_NAME;
        }
    }
}
