using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYDocumentMS
{
    public partial class ViewFileFrm : Form
    {

        /// <summary>
        ///  窗体标题前部分内容
        /// </summary>
        private string frmText = "文件预览--";
        /// <summary>
        /// 文件名称
        /// </summary>
        private string fileName = "Demo.swf";

        /// <summary>
        /// 需要预览的文件路径
        /// </summary>
        private string viewFilePath = @"D:\swf\";

        public string ViewFilePath
        {
            get { return viewFilePath; }
            set { viewFilePath = value; }
        }


  
        /// <summary>
        /// 窗体标题前部分内容
        /// </summary>
        public string FrmText
        {
            get { return frmText; }
            set { frmText = value; }
        }
       
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public ViewFileFrm()
        {
            InitializeComponent();
        }

        private void ViewFileFrm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Text = this.FrmText + this.FileName;
            if (this.ViewFilePath.Substring(this.ViewFilePath.Length - 1) != @"\")
            {
                if (this.ViewFilePath.Substring(this.ViewFilePath.Length - 1) != @"/")
                {
                    this.ViewFilePath = this.ViewFilePath + @"\";
                }
            }
            this.WBFileView.Navigate(this.ViewFilePath+this.FileName);
        }
    }
}
