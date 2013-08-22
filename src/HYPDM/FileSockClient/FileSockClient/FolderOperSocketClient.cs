using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
namespace FileSockClient
{
    public class FolderOperSocketClient
    {
        string host = "";
        int portFolderOperFlag = 2013;
        int portFolderOperPath = 2014;
        int portFolderOperNewPath = 2015;

        public int PortFolderOperNewPath
        {
            get { return portFolderOperNewPath; }
            set { portFolderOperNewPath = value; }
        }
        string folderOperFlg = "";
        string folderOperPath = "";
        string folderOperNewPath = "";

        public string FolderOperNewPath
        {
            get { return folderOperNewPath; }
            set { folderOperNewPath = value; }
        }
        Form frmWait = new FrmWait();

        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
        public int PortFolderOperFlag
        {
            get { return portFolderOperFlag; }
            set { portFolderOperFlag = value; }
        }
        public int PortFolderOperPath
        {
            get { return portFolderOperPath; }
            set { portFolderOperPath = value; }
        }
        public string FolderOperFlg
        {
            get { return folderOperFlg; }
            set { folderOperFlg = value; }
        }
        public string FolderOperPath
        {
            get { return folderOperPath; }
            set { folderOperPath = value; }
        }
        /// <summary>
        /// 对文件夹的操作
        /// </summary>
        /// <param name="fldOperFlg">操作标识,add:添加 modify:修改</param>
        /// <param name="fldOperPath">原文件夹及含路径</param>
        /// <param name="fldOperNewPath">新文件夹的名称及路径，如果是修改的话</param>
        public FolderOperSocketClient(string fldOperFlg, string fldOperPath, string fldOperNewPath)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.Host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            this.PortFolderOperFlag = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperFlag"].ToString());
            this.PortFolderOperPath = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperPath"].ToString());
            this.PortFolderOperNewPath = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperNewPath"].ToString());
            this.FolderOperNewPath = fldOperNewPath;
            FolderOperFlg = fldOperFlg;
            this.FolderOperPath = fldOperPath;

            if (FrmWait == null)
            {
                FrmWait = new FrmWait();
                FrmWait.Show();
            }
            else
            {
                FrmWait = null;
                FrmWait = new FrmWait();
                FrmWait.Show();
            }
            Thread th = new Thread(startListen);
            th.IsBackground = true;
            th.Start();

        }
        void startListen()
        {

            try
            {
                byte[] folderOperFlgByte = Encoding.UTF8.GetBytes(this.FolderOperFlg);
                byte[] folerOperPathByte = Encoding.UTF8.GetBytes(this.FolderOperPath);
                byte[] folerOperNewPathByte = Encoding.UTF8.GetBytes(this.FolderOperNewPath);
                scoketSend(Host, this.PortFolderOperFlag, folderOperFlgByte);
                scoketSend(Host, this.PortFolderOperPath, folerOperPathByte);
                scoketSend(Host, this.PortFolderOperNewPath, folerOperNewPathByte);
            }
            catch (Exception ex)
            {
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
