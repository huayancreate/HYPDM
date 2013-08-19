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
   public  class DownLoadFileSocketClient
    {
        private int downFileServerPort = 2008;
        private string serverIP;
        private string downFilePath = "";  //需要下载文件的路径包含文件名称
        private string saveFilePath = ""; //保存的本地路径及文件名
        Form frmWait = new FrmWait();

        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
        int totalCount = 0;//存储下载文件的实际字节数组
        public string SaveFilePath
        {
            get { return saveFilePath; }
            set { saveFilePath = value; }
        }
        private int SIZEBUFFER;
        public string DownFilePath
        {
            get { return downFilePath; }
            set { downFilePath = value; }
        }
        public DownLoadFileSocketClient(string filepathname, string saveFileToClienPath)
        {
            
            this.DownFilePath = filepathname;
            this.saveFilePath = saveFileToClienPath;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            downFileServerPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["downFileServerPort"].ToString());
            serverIP = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());

            frmWait.Show();
            Thread th = new Thread(new ThreadStart(startListener));
            th.IsBackground = true;
            th.Start();
           

        }
        Socket sock;
        //Socket ssss;
        public void startListener()
        {


            sendFile();
            //   reciveDate();

        }

        //public void reciveDate()
        //{
        //    try
        //    {
        //        IPAddress ip = IPAddress.Parse(this.serverIP);
        //        //IPEndPoint endpoint = new IPEndPoint(ip, this.downFileServerPort);
        //        IPEndPoint endpoint = new IPEndPoint(ip, 2009);
        //        ssss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //        ssss.Bind(endpoint);
        //        ssss.Listen(0);
        //        while (true)
        //        {
        //            get();
        //        }
        //        ssss.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString()); return;
        //    }
        //}
        //  string recvFileArrayByte = "";

        //public void get()
        //{
        //    try
        //    {
        //        while (true)
        //        {
        //            Socket sc = ssss.Accept();
        //            if (sc.Connected)
        //            {
        //                recvBytes = new byte[SIZEBUFFER];
        //                int bytes;
        //                bytes = sc.Receive(recvBytes, recvBytes.Length, 0);
        //                //UTF8处理中文
        //                //  recvFileArrayByte += Encoding.UTF8.GetString(recvBytes, 0, bytes);
        //                saveFile();
        //                sc.Close(); //关闭
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString()); return;
        //    }
        //    finally
        //    {

        //    }

        //}
        //public void saveFile()
        //{
        //    String fileDir = "";
        //    if (this.SaveFilePath.LastIndexOf(@"/") == -1)
        //    {
        //        fileDir = this.SaveFilePath.Substring(0, this.SaveFilePath.LastIndexOf(@"\"));
        //    }
        //    else
        //    {
        //        fileDir = this.SaveFilePath.Substring(0, this.SaveFilePath.LastIndexOf(@"/"));
        //    }
        //    if (!Directory.Exists(fileDir))
        //    {
        //        Directory.CreateDirectory(fileDir);
        //    }
        //    FileStream file = new FileStream(SaveFilePath, FileMode.Create);
        //    try
        //    {
        //        file.Write(recvBytes, 0, totalCount);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        file.Flush();
        //        file.Close();
        //    }
        //}
        byte[] recvBytes = null;
        public void sendFile()
        {
            totalCount = 0;
            IPAddress ip = IPAddress.Parse(this.serverIP);
            IPEndPoint endpoint = new IPEndPoint(ip, this.downFileServerPort);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            byte[] filePathByteArray = new byte[SIZEBUFFER];
            filePathByteArray = Encoding.UTF8.GetBytes(this.DownFilePath);
            sock.Connect(endpoint);
            sock.Send(filePathByteArray, filePathByteArray.Length, 0);

            String fileDir = "";
            if (this.SaveFilePath.LastIndexOf(@"/") == -1)
            {
                fileDir = this.SaveFilePath.Substring(0, this.SaveFilePath.LastIndexOf(@"\"));
            }
            else
            {
                fileDir = this.SaveFilePath.Substring(0, this.SaveFilePath.LastIndexOf(@"/"));
            }
            if (!Directory.Exists(fileDir))
            {
                Directory.CreateDirectory(fileDir);
            }
            FileStream file = new FileStream(SaveFilePath, FileMode.Create);
            //try
            //{
            //    file.Write(recvBytes, 0, totalCount);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            //finally
            //{
            //    file.Flush();
            //    file.Close();
            //}









            // Socket sc = ssss.Accept();
          //  string endStr = "";
            if (sock.Connected)  //接收需要下载文件的字节流
            {
                recvBytes = new byte[SIZEBUFFER];
                //   int bytes;

                int i = sock.Receive(recvBytes, recvBytes.Length, 0);
                totalCount = i;
                //UTF8处理中文
                while (i > 0)
                {

                   // endStr = Encoding.UTF8.GetString(recvBytes, 0, i);
                    //if (endStr.LastIndexOf("endEND") > -1)
                    //{
                    //    MessageBox.Show(endStr.LastIndexOf("endEND") + ":" + endStr);
                    //}
                    //if (endStr == "endEND")
                    //{
                    //    break;
                    //}
                    //else
                    //{
                        file.Write(recvBytes, 0, i);
                        i = sock.Receive(recvBytes, 0, recvBytes.Length, 0);
                        totalCount += i;
                    //}
                }
                try
                {
                    //saveFile();
                    MessageBox.Show("下载完毕", "下载提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "错误提示-下载异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    file.Flush();
                    file.Close();

                    sock.Close();
                    sock.Dispose();
                    if(frmWait!=null)
                    {
                        frmWait.Close();
                    }
                }


                // MessageBox.Show(aa);

            }

            //if (sock.Connected)  //接收传输的结束标识
            //{
            //    int i = 0;
            //    String endstr = "";
            //    byte[] endByte = new byte[SIZEBUFFER];
            //    i += sock.Receive(endByte, recvBytes.Length, 0);
            //    //UTF8处理中文
            //    endstr += Encoding.UTF8.GetString(endByte, 0, i);
            //    if (endstr == "end")
            //    {
            //        MessageBox.Show("下载完毕","下载提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //        saveFile();
            //    }
            //}

        }
    }
}
