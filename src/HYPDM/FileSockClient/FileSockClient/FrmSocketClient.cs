using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Configuration;
using System.Threading;
using System.Collections;
namespace FileSockClient
{
    public partial class FrmSocketClient : Form
    {

            public FrmSocketClient()
            {  
                InitializeComponent();
                CenterToScreen();
           
            }
        private void btnOPen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialOpenFile = new OpenFileDialog();
            dialOpenFile.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            dialOpenFile.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            DialogResult result = dialOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtFilePath.Text = dialOpenFile.FileName;
            }
        }
        
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            string filepath = this.txtFilePath.Text.Trim();
            if (filepath == "")
            {
                MessageBox.Show("请选择需要上传的文件!!");
                return;
            }
            //调用上传文件socke客户端的核心部分
            try
            {
              //  UpLoadFileSocketClient sock = new UpLoadFileSocketClient(filepath);
                UpLoadFileSocketClient sock = new UpLoadFileSocketClient(filepath, @"E:\\PDM文件服务器根目录");
                
               // sock.startUpLoadFile(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDownFile_Click(object sender, EventArgs e)
        {


            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                this.txtFilePath.Text = save.FileName;

                DownLoadFileSocketClient jj = new DownLoadFileSocketClient(this.txtDownLoad.Text.ToString(), this.txtFilePath.Text.ToString());
             //   jj.startListener(this.txtDownLoad.Text.ToString(),this.txtFilePath.Text.ToString());
            }
        }

        private void FrmSocketClient_Load(object sender, EventArgs e)
        {

        }
       
    }
}
