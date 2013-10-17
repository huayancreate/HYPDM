using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileSockClient
{
    /// <summary>
    /// 文件下载类
    /// </summary>
    public class DownLoadFileSocketClient
    {
        private int downFileServerPort = 2008;
        private string serverIP;
        private string downFilePath = "";  //需要下载文件的路径包含文件名称
        private string saveFilePath = ""; //保存的本地路径及文件名
        FileStream file; //存放接收到的文件
        Form frmWait = new FrmWait();
        /// <summary>
        /// 表示交易的最终状态，成功为true，异常为false
        /// </summary>
        private Boolean ackStatus = true; //表示交易的最终状态，成功为true，异常为false

        /// <summary>
        /// 表示交易的最终状态，成功为true，异常为false
        /// </summary>
        public Boolean AckStatus
        {
            get { return ackStatus; }
            set { ackStatus = value; }
        }
        //public Form FrmWait
        //{
        //    get { return frmWait; }
        //    set { frmWait = value; }
        //}
        int totalCount = 0;//存储下载文件的实际字节数组
        //public string SaveFilePath
        //{
        //    get { return saveFilePath; }
        //    set { saveFilePath = value; }
        //}
        private int SIZEBUFFER = 5242880;
        //public string DownFilePath
        //{
        //    get { return downFilePath; }
        //    set { downFilePath = value; }
        //}
        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="filepathname">需要下载的文件路径(服务器上的路径及文件名称)</param>
        /// <param name="saveFileToClienPath">保存的本地路径及文件名</param>
        public DownLoadFileSocketClient(string filepathname, string saveFileToClienPath)
        {
            this.downFilePath = filepathname;
            this.saveFilePath = saveFileToClienPath;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            downFileServerPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["downFileServerPort"].ToString());
            serverIP = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            frmWait.Show();
            //Thread th = new Thread(new ThreadStart(startListener));
            //th.IsBackground = true;
            //th.Start();
            startListener();
        }

        /// <summary>
        /// 供CAD Client使用
        /// </summary>
        /// <param name="filepathname"></param>
        /// <param name="saveFileToClienPath"></param>
        /// <param name="downLoadServerPort"></param>
        /// <param name="downLoadServerIP"></param>
        public DownLoadFileSocketClient(string filepathname, string saveFileToClienPath, int downLoadServerPort, string downLoadServerIP)
        {
            this.downFilePath = filepathname;
            this.saveFilePath = saveFileToClienPath;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            downFileServerPort = downLoadServerPort;
            serverIP = downLoadServerIP;
            //SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            frmWait.Show();
            //Thread th = new Thread(new ThreadStart(startListener));
            //th.IsBackground = true;
            //th.Start();
            startListener();
        }
        Socket sock;
        //Socket ssss;
        protected void startListener()
        {
            sendFile();
        }
        byte[] recvBytes = null;
        protected void sendFile()
        {
            try
            {

                totalCount = 0;
                IPAddress ip = IPAddress.Parse(this.serverIP);
                IPEndPoint endpoint = new IPEndPoint(ip, this.downFileServerPort);
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                byte[] filePathByteArray = new byte[SIZEBUFFER];
                filePathByteArray = Encoding.UTF8.GetBytes(this.downFilePath);
                try
                {
                    sock.Connect(endpoint);
                }
                catch (Exception ex)
                {
                    AckStatus = false;
                    MessageBox.Show("连接文件服务器异常:\n" + ex.Message.ToString(), "错误提示-下载异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                finally
                {
                }
                sock.Send(filePathByteArray, filePathByteArray.Length, 0);

                String fileDir = "";
                if (this.saveFilePath.LastIndexOf(@"/") == -1)
                {
                    fileDir = this.saveFilePath.Substring(0, this.saveFilePath.LastIndexOf(@"\"));
                }
                else
                {
                    fileDir = this.saveFilePath.Substring(0, this.saveFilePath.LastIndexOf(@"/"));
                }
                if (!Directory.Exists(fileDir))
                {
                    Directory.CreateDirectory(fileDir);
                }
                file = new FileStream(saveFilePath, FileMode.Create);
                if (sock.Connected)  //接收需要下载文件的字节流
                {
                    try
                    {
                        recvBytes = new byte[SIZEBUFFER];
                        //   int bytes;
                        int i = sock.Receive(recvBytes, recvBytes.Length, 0);
                        totalCount = i;
                        //UTF8处理中文
                        while (i > 0)
                        {
                            file.Write(recvBytes, 0, i);
                            i = sock.Receive(recvBytes, 0, recvBytes.Length, 0);
                            totalCount += i;
                        }
                    }
                    catch (Exception ex)
                    {
                        AckStatus = false;
                        MessageBox.Show("接收服务器内容异常:\n"+ex.Message.ToString(), "错误提示-下载异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //MessageBox.Show("下载成功:\n", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                AckStatus = false;
                MessageBox.Show("下载异常:\n"+ex.Message.ToString(), "错误提示-下载异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                if (file != null)
                {
                    file.Flush();
                    file.Close();
                }
                if (sock != null)
                {
                    sock.Close();
                }
                if (frmWait != null)
                {
                    frmWait.Close();
                }
            }
        }
    }
}
