using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Configuration;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
namespace FileSockClient
{  
    /// <summary>
    /// 
    /// </summary>
    public class CopyOldVerFile
    {
        private string host = "";
        private int portCopyOldVerFile = 2011;

        public int PortCopyOldVerFile
        {
            get { return portCopyOldVerFile; }
            set { portCopyOldVerFile = value; }
        }
        private int portCopyNewFileName = 2012;

        public int PortCopyNewFileName
        {
            get { return portCopyNewFileName; }
            set { portCopyNewFileName = value; }
        }
        Form frmWait = new FrmWait();

        /// <summary>
        /// 
        /// </summary>
        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
        // private int BackDay = 0;
        private int SIZEBUFFER = 0;
        private string filePath = ""; //要上传的文件路径
        private string newFileName = "";
        /// <summary>
        /// 新的文件名
        /// </summary>
        public string NewFileName
        {
            get { return newFileName; }
            set { newFileName = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private string serverSavePath = "";//文件需要保存在服务器上的路径
        /// <summary>
        /// 
        /// </summary>
        public string ServerSavePath
        {
            get { return serverSavePath; }
            set { serverSavePath = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvSavePath"></param>
        /// <param name="newFileName">新的文件名</param>
        public CopyOldVerFile(string srvSavePath, string newFileName)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.ServerSavePath = srvSavePath; //在服务器上的保存路径;
         //   MessageBox.Show(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            PortCopyOldVerFile = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portCopyOldVerFile"].ToString());
            this.NewFileName = newFileName;
            host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            PortCopyNewFileName = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portCopyNewFileName"].ToString());
            frmWait.Show();

            Thread th = new Thread(new ThreadStart(startListen)); //启动新线程来运行start
            th.IsBackground = true;
            th.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        public void startListen()
        {
            try
            {
                byte[] byteArrrayFilePathAndName = Encoding.UTF8.GetBytes(ServerSavePath);
                byte[] byteArrrayNewFileName = Encoding.UTF8.GetBytes(NewFileName);

                scoketSend(host, PortCopyOldVerFile, byteArrrayFilePathAndName);  //传输文件路径与文件名称
              
                scoketSend(host, PortCopyNewFileName, byteArrrayNewFileName);  //传输文件新名称
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message.ToString());
                MessageBox.Show(ex.Message.ToString());

            }
            finally
            {
                if (this.FrmWait != null)
                {
                    this.FrmWait.Close();
                    this.FrmWait.Dispose();
                }
            }
        }
        private void scoketSend(string host, int port, byte[] bs)
        {

            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            c.Connect(ipe);
            c.Send(bs, bs.Length, 0);
            c.Close();
        }
    }
}
