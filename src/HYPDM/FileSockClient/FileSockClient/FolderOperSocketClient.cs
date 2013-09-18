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
        //public int PortFolderOperNewPath
        //{
        //    get { return portFolderOperNewPath; }
        //    set { portFolderOperNewPath = value; }
        //}
        string folderOperFlg = "";
        string folderOperPath = "";
        string folderOperNewPath = "";

        //public string FolderOperNewPath
        //{
        //    get { return folderOperNewPath; }
        //    set { folderOperNewPath = value; }
        //}
        Form frmWait = new FrmWait();

        public Form FrmWait
        {
            get { return frmWait; }
            set { frmWait = value; }
        }
        //public string Host
        //{
        //    get { return host; }
        //    set { host = value; }
        //}
        //public int PortFolderOperFlag
        //{
        //    get { return portFolderOperFlag; }
        //    set { portFolderOperFlag = value; }
        //}
        //public int PortFolderOperPath
        //{
        //    get { return portFolderOperPath; }
        //    set { portFolderOperPath = value; }
        //}
        //public string FolderOperFlg
        //{
        //    get { return folderOperFlg; }
        //    set { folderOperFlg = value; }
        //}
        //public string FolderOperPath
        //{
        //    get { return folderOperPath; }
        //    set { folderOperPath = value; }
        //}
        /// <summary>
        /// 对文件夹的操作
        /// </summary>
        /// <param name="fldOperFlg">操作标识,add:添加 modify:修改</param>
        /// <param name="fldOperPath">原文件夹及含路径</param>
        /// <param name="fldOperNewPath">新文件夹的名称及路径，如果是修改的话</param>
        public FolderOperSocketClient(string fldOperFlg, string fldOperPath, string fldOperNewPath)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.host = System.Configuration.ConfigurationManager.AppSettings["ServerIP"].ToString();
            this.portFolderOperFlag = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperFlag"].ToString());
            this.portFolderOperPath = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperPath"].ToString());
            this.portFolderOperNewPath = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["portFolderOperNewPath"].ToString());
            this.folderOperNewPath = fldOperNewPath;
            folderOperFlg = fldOperFlg;
            this.folderOperPath = fldOperPath;

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
            //Thread th = new Thread(startListen);
            //th.IsBackground = true;
            //th.Start();
            startListen();

        }
        void startListen()
        {

            try
            {
                byte[] folderOperFlgByte = Encoding.UTF8.GetBytes(this.folderOperFlg);
                byte[] folerOperPathByte = Encoding.UTF8.GetBytes(this.folderOperPath);
                byte[] folerOperNewPathByte = Encoding.UTF8.GetBytes(this.folderOperNewPath);
                if (!scoketSend(host, this.portFolderOperFlag, folderOperFlgByte))
                {
                    AckStatus = false;
                    return;
                }
                if (!scoketSend(host, this.portFolderOperPath, folerOperPathByte))
                {
                    AckStatus = false;
                    return;
                }
                if (!scoketSend(host, this.portFolderOperNewPath, folerOperNewPathByte))
                {
                    AckStatus = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                AckStatus = false;
                MessageBox.Show("文件夹操作异常:" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                if (this.FrmWait != null)
                {
                    this.FrmWait.Close();
                }
            }

        }

        private Boolean scoketSend(string host, int port, byte[] bs)
        {
            Socket c = null;
            Boolean bl = true;
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
                    MessageBox.Show("连接服务器失败:" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                finally
                {
                    if (FrmWait != null)
                    {
                        FrmWait.Close();
                    }
                    if (c != null)
                    {
                        c.Close();
                    }
                }
                c.Send(bs, bs.Length, 0);
                c.Close();
            }
            catch (Exception ex)
            {
                bl = false;
                MessageBox.Show("文件夹操作失败:" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                if (FrmWait != null)
                {
                    FrmWait.Close();
                }
                if (c != null)
                {
                    c.Close();
                }
            }
            return bl;
        }
    }
}
