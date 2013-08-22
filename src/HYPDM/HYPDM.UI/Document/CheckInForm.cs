using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.Document
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
            
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
            this.DialogResult = DialogResult.OK;
            if (txtFileName.Text.Trim() == string.Empty || txtFilePath.Text.Trim() == string.Empty)
            {
                MessageBox.Show("文件名或文件路径不能为空！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean result = true;
                //Util.FTPHelper helper = Util.Common.FtpHepler();
                var info = "";
                //var result = helper.UploadFile(txtFilePath.Text, out info);

                try{
                    string filePath = this.txtFilePath.Text.ToString();
                    int i = filePath.LastIndexOf(@"\");
                    if (i==-1)
                    {
                        i = filePath.LastIndexOf(@"/");
                    }
                    filePath = filePath.Substring(0, i) + @"\" + this.txtFileName.Text.ToString();

                    string tempNewFileName = this.txtFileName.Text.ToString();
                   
                    tempNewFileName = tempNewFileName.Substring(0, tempNewFileName.LastIndexOf(@".")) + DocFileEntity.DFL_VER_LATEST + tempNewFileName.Substring(tempNewFileName.LastIndexOf(@"."));

                  //  MessageBox.Show(filePath);
                    string serPathAndFileName=new HYDocumentMS.FileHelper().getDocumentAllPathByPathID(DocFileEntity.DFL_FILE_CHILD_PATH)+this.txtFileName.Text.ToString();
                    FileSockClient.CopyOldVerFile hh = new FileSockClient.CopyOldVerFile(serPathAndFileName, tempNewFileName); //复制旧版本数据到Vers目录下
                    //上传更新文件覆盖旧文件
                    FileSockClient.UpLoadFileSocketClient upload = new FileSockClient.UpLoadFileSocketClient(filePath,new HYDocumentMS.FileHelper().getDocumentAllPathByPathID(DocFileEntity.DFL_FILE_CHILD_PATH), true);
                    
                }
                catch(Exception ex)
                {  
                    result=false;
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show(ex.Message.ToString());
                }

                if (result)
                {
                    MessageBox.Show("文件检入成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    MessageBox.Show("文件检入失败,具体原因为：" + info, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
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

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            InitPhysicalInfo();
        }
    }
}
