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

        //public int PortCopyOldVerFile
        //{
        //    get { return portCopyOldVerFile; }
        //    set { portCopyOldVerFile = value; }
        //}
        private int portCopyNewFileName = 2012;

        //public int PortCopyNewFileName
        //{
        //    get { return portCopyNewFileName; }
        //    set { portCopyNewFileName = value; }
        //}
        Form frmWait = new FrmWait();

        /// <summary>
        /// 
        /// </summary>
        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
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
        // private int BackDay = 0;
        private int SIZEBUFFER = 0;
        private string filePath = ""; //要上传的文件路径
        private string newFileName = "";
        /// <summary>
        /// 新的文件名
        /// </summary>
        //public string NewFileName
        //{
        //    get { return newFileName; }
        //    set { newFileName = value; }
        //}
        /// <summary>
        /// 
        /// </summary>
        //public string FilePath
        //{
        //    get { return filePath; }
        //    set { filePath = value; }
        //}
        private string serverSavePath = "";//文件需要保存在服务器上的路径
        /// <summary>
        /// 
        /// </summary>
        //public string ServerSavePath
        //{
        //    get { return serverSavePath; }
        //    set { serverSavePath = value; }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="srvSavePath"></param>
        /// <param name="newFileName">新的文件名</param>
        public CopyOldVerFile(string srvSavePath, string newFileName)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.serverSavePath = srvSavePath; //在服务器上的保存路径;
            //   MessageBox.Show(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            portCopyOldVerFile = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portCopyOldVerFile"].ToString());
            this.newFileName = newFileName;
            host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            portCopyNewFileName = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portCopyNewFileName"].ToString());
            frmWait.Show();

            //Thread th = new Thread(new ThreadStart(startListen)); //启动新线程来运行start
            //th.IsBackground = true;
            //th.Start();
            startListen();
        }
        /// <summary>
        /// 
        /// </summary>
        public void startListen()
        {
            try
            {
                byte[] byteArrrayFilePathAndName = Encoding.UTF8.GetBytes(serverSavePath);
                byte[] byteArrrayNewFileName = Encoding.UTF8.GetBytes(newFileName);

                if (!scoketSend(host, portCopyOldVerFile, byteArrrayFilePathAndName))  //传输文件路径与文件名称
                {
                    AckStatus = false;
                    return;
                }

                if (!scoketSend(host, portCopyNewFileName, byteArrrayNewFileName))  //传输文件新名称
                {
                    AckStatus = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message.ToString());
                AckStatus = false;
                MessageBox.Show("保存旧版本数据失败" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

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
        private Boolean scoketSend(string host, int port, byte[] bs)
        {
            Boolean bl = true;
            Socket c = null;
            try
            {
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);
                c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    c.Connect(ipe);
                }
                catch (Exception ex)
                {
                    bl = false;
                    MessageBox.Show("连接文件服务器失败" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return bl;
                }
                c.Send(bs, bs.Length, 0);
                c.Close();
            }
            catch (Exception ex)
            {
                bl = false;
                MessageBox.Show("保存旧版本数据失败" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bl;
            }
            finally
            {
                if (c != null)
                {
                    c.Close();
                }
            }
            return bl;
        }
    }
}
