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
    /// 文件上传类
    /// </summary>
   public class UpLoadFileSocketClient
    {
        private string host = "";
        private int port1 = 0;
        private int port2 = 0;
        private int port3 = 0;
        private int portFileSavePath = 2010;
        private bool IsXuChuan = false;
        private bool IsFuGai = false;
        // private int BackDay = 0;
        private int SIZEBUFFER = 0;
        private string filePath = ""; //要上传的文件路径
        private string serverSavePath = "";//文件需要保存在服务器上的路径

        public string ServerSavePath
        {
            get { return serverSavePath; }
            set { serverSavePath = value; }
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        // private string fileExt = "";
        public ArrayList al = new ArrayList();//定义存储文件和文件夹名的数组
        Form frmWait = new FrmWait();

       /// <summary>
       /// 
       /// </summary>
        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
       ///
        int downFileServerPort;
       /// <summary>
       /// 文件上传
       /// </summary>
        /// <param name="filePathName">需要上传的文件及路径</param>
        /// <param name="srvSavePath">将在服务器保存的路径</param>
        public UpLoadFileSocketClient(string filePathName, string srvSavePath)
        {


            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.ServerSavePath = srvSavePath; //在服务器上的保存路径
            //  path = System.Configuration.ConfigurationManager.AppSettings["APPEmailXML"].ToString();
            //strBaseDir = System.Configuration.ConfigurationManager.AppSettings["strBaseDir"].ToString();
            host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            port1 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port1"].ToString());
            port2 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port2"].ToString());
            port3 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port3"].ToString());
            IsXuChuan = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsXuChuan"].ToString());
            IsFuGai = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsFuGai"].ToString());
            //    BackDay = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["BackDay"].ToString());
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            downFileServerPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["downFileServerPort"].ToString());
            portFileSavePath = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portFileSavePath"].ToString());
            //socketUpLoadFile sock = new socketUpLoadFile();
            FilePath = filePathName;
            frmWait.Show();

            Thread th = new Thread(new ThreadStart(startListen)); //启动新线程来运行start
            th.IsBackground = true;
            th.Start();
        }
       /// <summary>
       /// 上传文件
       /// </summary>
       /// <param name="filePathName">需要上传的文件及路径</param>
       /// <param name="srvSavePath">将在服务器保存的路径</param>
       /// <param name="blIsFuGai">是否替换文件如果指定目录已经存在此文件的情况下</param>
        public UpLoadFileSocketClient(string filePathName, string srvSavePath,Boolean blIsFuGai)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.ServerSavePath = srvSavePath; //在服务器上的保存路径
            //  path = System.Configuration.ConfigurationManager.AppSettings["APPEmailXML"].ToString();
            //strBaseDir = System.Configuration.ConfigurationManager.AppSettings["strBaseDir"].ToString();
            host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            port1 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port1"].ToString());
            port2 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port2"].ToString());
            port3 = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["port3"].ToString());
            IsXuChuan = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsXuChuan"].ToString());
            IsFuGai = blIsFuGai;
           // IsFuGai = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsFuGai"].ToString());
            //    BackDay = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["BackDay"].ToString());
            SIZEBUFFER = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SIZEBUFFER"].ToString());
            downFileServerPort = int.Parse(System.Configuration.ConfigurationManager.AppSettings["downFileServerPort"].ToString());
            portFileSavePath = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["portFileSavePath"].ToString());
            //socketUpLoadFile sock = new socketUpLoadFile();
            FilePath = filePathName;
            frmWait.Show();

            Thread th = new Thread(new ThreadStart(startListen)); //启动新线程来运行start
            th.IsBackground = true;
            th.Start();
        }
        /// <summary>
        /// 启动
        /// </summary>
        public void startListen()
        {
            try
            {
                //  GetAllDirList(strBaseDir, BackDay);  //用于在指定目录中遍历文件清单
                al = new ArrayList();
                al.Add(this.filePath);
                foreach (string filepath in al)
                {
                    //if (pathDir.Contains("\t<目录>"))
                    //{
                    //    string ddddS = pathDir.Substring(pathDir.IndexOf(strBaseDir) + strBaseDir.Length);
                    //    scoketSend(host, port2, Encoding.UTF8.GetBytes(ddddS));  //传输文件名称
                    //    sendFlie(host, port1, pathDir, IsXuChuan, IsFuGai);//传输文件
                    //    continue;
                    //}
                    //string fileName = pathDir.Substring(pathDir.LastIndexOf("\\") + 1);
                    // string fileName = filepath.Substring(filepath.IndexOf(strBaseDir) + strBaseDir.Length);
                    string fileName = filepath.Substring(filepath.LastIndexOf(@"\") + 1);
                    byte[] byteArrrayFileName = Encoding.UTF8.GetBytes(fileName);
                    //  MessageBox.Show("fileName===="+fileName);
                    scoketSend(host, port2, byteArrrayFileName);  //传输文件名称
                   
                    byte[] byteArrrayFileSavePath = Encoding.UTF8.GetBytes(ServerSavePath);
                    //传输文件需要在服务器上保存的路径
                    //scoketSendFileSeverSavePath(host, portFileSavePath, byteArrrayFileSavePath);
                    scoketSend(host, portFileSavePath, byteArrrayFileSavePath);
                    
                    sendFlie(host, port1, filepath, IsXuChuan, IsFuGai);//传输文件

                    //DelFile(filepath);
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            Console.WriteLine("end");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="bs"></param>
        //private void scoketSendFileSeverSavePath(string host, int port, byte[] bs)
        //{

        //    IPAddress ip = IPAddress.Parse(host);
        //    //   int port = 2006;
        //    IPEndPoint ipe = new IPEndPoint(ip, port);
        //    Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    c.Connect(ipe);
        //    c.Send(bs, bs.Length, 0);
        //    c.Close();
        //}

        //连接服务器发送数据
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port">2006</param>
        /// <param name="bs"></param>
        private void scoketSend(string host, int port, byte[] bs)
        {

            IPAddress ip = IPAddress.Parse(host);
            //   int port = 2006;
            IPEndPoint ipe = new IPEndPoint(ip, port);
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            c.Connect(ipe);
            c.Send(bs, bs.Length, 0);
            c.Close();
        }
        //连接服务器接收数据
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port">2006</param>
        /// <returns></returns>
        private string scoketReceive(string host, int port)
        {
            IPAddress ip = IPAddress.Parse(host);
            //   int port = 2006;
            IPEndPoint ipe = new IPEndPoint(ip, port);
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            c.Connect(ipe);
            string startStr = "";
            byte[] startBytes = new byte[SIZEBUFFER];
            int bytess;
            bytess = c.Receive(startBytes, startBytes.Length, 0);
            startStr += Encoding.ASCII.GetString(startBytes, 0, bytess);
            c.Close();
            return startStr;
        }
        //传输文件名称
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">127.0.0.1</param>
        /// <param name="port">2006</param>
        private void sendName(string host, int port, string path)
        {
            //string host = "127.0.0.1";
            IPAddress ip = IPAddress.Parse(host);
            //int port = 2006;
            IPEndPoint ipe = new IPEndPoint(ip, port);
            Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            c.Connect(ipe);

            string fileName = path.Substring(path.LastIndexOf("\\") + 1);
            //UTF8处理中文
            byte[] bs = Encoding.UTF8.GetBytes(fileName);
            c.Send(bs, bs.Length, 0);
            c.Close();
        }
        //所传输的文件是否续传
        /// <summary>
        /// 所传输的文件是否续传
        /// </summary>
        /// <param name="str"></param>
        /// <param name="host">127.0.0.1</param>
        /// <param name="port">port = 2007</param>
        /// <param name="xuchuan">是否续传</param>
        public void setxc(string str, string host, int port)
        {
            Socket c = null;
            try
            {
                IPAddress ip = IPAddress.Parse(host);

                //port = 2007;
                IPEndPoint ipe = new IPEndPoint(ip, port);
                c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                c.Connect(ipe);
                string Str = str;
                byte[] bxc = Encoding.ASCII.GetBytes(Str);
                c.Send(bxc, bxc.Length, 0);
                //c.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
               // c.Close();
                c.Dispose();
                if (frmWait != null)
                {
                    frmWait.Close();
                }
            }
        }

        //传输文件/// <summary>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="host">"127.0.0.1"</param>
        /// <param name="port">port = 2005;</param>
        /// <param name="fileName">带路径的文件名</param>
        /// <param name="xuchuan">是否需要续传</param>
        /// <param name="cover">是否覆盖</param>
        private void sendFlie(string host, int port, string fileName, bool xuchuan, bool IsFuGai)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ipe = new IPEndPoint(ip, port);
                Socket c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                c.Connect(ipe);//建立于远程主机的链接
                //接收服务器返回存在的文件大小
                byte[] startBytes = new byte[SIZEBUFFER];
                string startStr = Encoding.ASCII.GetString(startBytes, 0, c.Receive(startBytes, startBytes.Length, 0));
                //已接受文件长度
                int startSet = int.Parse(startStr);
                byte[] b = new byte[SIZEBUFFER];            //创建文件缓冲区，这里可以认为文件的最大值
                //if (fileName.Contains("\t<目录>"))
                //{
                //    c.Close();        //关闭Socket
                //    return;
                //}
              //  MessageBox.Show(fileName);
                FileStream file = File.Open(fileName, FileMode.Open, FileAccess.Read);   //创建文件流
                //文件字节总长度
                int fileAllLength = (int)file.Length;
                //文件剩余字节长度
                int fileLast = startSet < fileAllLength ? fileAllLength - startSet : 0;

                int intLength = 0;
                #region  续传
                if (startSet > 0 && startSet < fileAllLength && xuchuan == true && IsFuGai==false)
                {
                    //传输文件是否续传
                    setxc("xc", host, port3);
                    file.Seek(long.Parse(startStr), SeekOrigin.Begin); //移动文件流中的当前指针
                    intLength = int.Parse(startStr);
                    while (fileLast > 0)
                    {
                        int count = file.Read(b, 0, b.Length);
                        int readbytes = count >= b.Length ? b.Length : count;
                        readbytes = c.Send(b, 0, readbytes, SocketFlags.None);
                        Encoding.ASCII.GetString(startBytes, 0, c.Receive(startBytes, startBytes.Length, 0));
                        fileLast -= count;
                        intLength += count;
                        file.Seek(intLength, SeekOrigin.Begin);
                        //if (fileLast == 0)
                        //{
                        //    // c.Send(Encoding.UTF8.GetBytes("end"), Encoding.UTF8.GetBytes("end").Length, 0);
                        //}
                    }
                }
                #endregion
                #region
                else
                {
                    if (fileLast == 0 && IsFuGai == false)
                    {
                        setxc("qx", host, port3);
                    }
                    else
                    {
                        //传输文件是否续传
                        setxc("bxc", host, port3);

                        while (fileLast > 0)
                        {
                            int count = file.Read(b, 0, b.Length);
                            int SdCount = fileLast < b.Length ? count : b.Length;
                            SdCount = c.Send(b, 0, SdCount, SocketFlags.None);
                            Encoding.ASCII.GetString(startBytes, 0, c.Receive(startBytes, startBytes.Length, 0));
                            fileLast -= count;//剩余的字节长度
                            intLength += count;//定位指针用
                            file.Seek(intLength, SeekOrigin.Begin);
                            if (fileLast == 0)
                            {
                                // c.Send(Encoding.UTF8.GetBytes("end"), Encoding.UTF8.GetBytes("end").Length, 0);
                            }
                            Console.WriteLine("已传送字节：  " + intLength);
                        }
                    }
                }
                #endregion
                file.Close();     //关闭文件流
                //string recvStr = "";
                //byte[] recvBytes = new byte[SIZEBUFFER];
                //int bytes;
                //bytes = c.Receive(recvBytes, recvBytes.Length, 0);
                //recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
                //MessageBox.Show(recvStr);
                //    MessageBox.Show(recvStr);
                //byte[] endflg=new byte[1024];
                //int k=c.Receive(endflg, endflg.Length, 0);
                //string endStr = "";
                //endStr += Encoding.ASCII.GetString(endflg, 0, endflg.Length);
                // if (recvStr.Equals("Ok!Sucess!"))
                //{
                //    MessageBox.Show("文件上传成功");
                //}
                c.Close();        //关闭Socket
 // MessageBox.Show("文件上传成功","上传提示",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("{0}", e);
                MessageBox.Show(ex.Message.ToString(), "错误提示-上传异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (frmWait != null)
                {
                    frmWait.Close();
                }
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="filePath"></param>
        //public void startUpLoadFile(String filePath)
        //{
        //    //socketUpLoadFile sock = new socketUpLoadFile();
        //    FilePath = filePath;
        //    FrmWait.Show();
        //    Thread th = new Thread(new ThreadStart(startListen)); //启动新线程来运行start
        //    th.IsBackground = true;
        //    th.Start();
        //}
        //public int aaa = 0;//定义标志位参数，递归时判断该参数，若不为0则非第一次递归
        /// <summary>
        /// 获取指定某一天之前的文件,不包括当天
        /// </summary>
        /// <param name="strBaseDir">指定目录</param>
        /// <param name="Day">指定天数</param>
        //public void GetAllDirList(string strBaseDir, int Day)
        //{
        //    DirectoryInfo di = new DirectoryInfo(strBaseDir);
        //    DirectoryInfo[] diA = di.GetDirectories();
        //    if (aaa == 0)
        //    {
        //        FileInfo[] fis2 = di.GetFiles();   //有关目录下的文件   
        //        for (int i2 = 0; i2 < fis2.Length; i2++)
        //        {

        //            if (fis2[i2].CreationTime < DateTime.Now.AddDays(Day) && fis2[i2].FullName.Substring(fis2[i2].FullName.LastIndexOf("\\") + 1).StartsWith("DEL_") == false)//指定时间
        //            {
        //                al.Add(fis2[i2].FullName);
        //            }
        //        }
        //    }
        //    for (int i = 0; i < diA.Length; i++)
        //    {
        //        aaa++;
        //        al.Add(diA[i].FullName + "\t<目录>");
        //        //diA[i].FullName是某个子目录的绝对地址，把它记录在ArrayList中
        //        DirectoryInfo di1 = new DirectoryInfo(diA[i].FullName);
        //        DirectoryInfo[] diA1 = di1.GetDirectories();
        //        FileInfo[] fis1 = di1.GetFiles();   //有关目录下的文件   
        //        for (int ii = 0; ii < fis1.Length; ii++)
        //        {
        //            if (fis1[ii].CreationTime < DateTime.Now.AddDays(Day) && fis1[ii].FullName.Substring(fis1[ii].FullName.LastIndexOf("\\") + 1).StartsWith("DEL_") == false)
        //            {
        //                al.Add(fis1[ii].FullName);
        //            }
        //        }
        //        GetAllDirList(diA[i].FullName, Day);
        //    }
        //}

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="FileName">文件名</param>
        //public void DelFile(string FileName)
        //{
        //    FileInfo fInfo = new FileInfo(FileName);

        //    fInfo.MoveTo(FileName.Replace(FileName.Substring(FileName.LastIndexOf("\\") + 1), "DEL_" + FileName.Substring(FileName.LastIndexOf("\\") + 1)));
        //}

        //private void DeleteInDir(string szDirPath)
        //{
        //    if (szDirPath.Trim() == "" || !Directory.Exists(szDirPath))
        //        return;
        //    DirectoryInfo dirInfo = new DirectoryInfo(szDirPath);

        //    FileInfo[] fileInfos = dirInfo.GetFiles();
        //    if (fileInfos != null && fileInfos.Length > 0)
        //    {
        //        foreach (FileInfo fileInfo in fileInfos)
        //        {

        //        }
        //    }

        //    DirectoryInfo[] dirInfos = dirInfo.GetDirectories();
        //    if (dirInfos != null && dirInfos.Length > 0)
        //    {
        //        foreach (DirectoryInfo childDirInfo in dirInfos)
        //        {
        //            DeleteInDir(childDirInfo.ToString()); //递归
        //        }
        //    }
        //}



    }
}
