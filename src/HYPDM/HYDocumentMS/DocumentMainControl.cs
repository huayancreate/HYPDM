using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAS.Modularization;

using EAS.Services;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Data.Linq;

namespace HYDocumentMS
{
    /// <summary>
    /// 
    /// </summary>
    [Module("{20EE5B83-2353-40DC-ADD4-29B3B2BA3AF9}", "文档管理主界面", "文档管理")]
    public partial class DocumentMainControl : UserControl
    {

        IFileHelper fileHelper;
        /// <summary>
        /// 
        /// </summary>
        public DocumentMainControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [ModuleStart]
        public void StartEx()
        {
            this.webB.Navigate(@"D:\PDM文件服务器根目录\Demo.swf");
            IniEvent();

        }

        /// <summary>
        ///// 初始化事件
        /// </summary>
        private void IniEvent()
        {
            this.trvDocumentList.Nodes.Clear();
            fileHelper = new FileHelper();
            fileHelper.getTreeViewByDocFileList(this.trvDocumentList, fileHelper.getDocFileList(true));
        }
        private void trvDocumentList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


        }
        TreeNode nodeTemp;
        private void ToolS_FolderAdd_Click(object sender, EventArgs e)
        {
            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (chkIsFile())
                {
                    MessageBox.Show("请选择文件夹的上层路径,不能选择文件节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    //MessageBox.Show(nodeTemp.Text.ToString());
                    CreateNewFolderFrm frm = new CreateNewFolderFrm();
                    frm.SaveFilepath = fileHelper.getDocumentAllPathByPathID(nodeTemp.Tag.ToString());
                    frm.SaveFileKey = nodeTemp.Tag.ToString();
                    frm.BlAddFlg = true;
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择文件夹的上层路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            IniEvent();

        }

        private void ToolS_FilesAdd_Click(object sender, EventArgs e)
        {

            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (chkIsFile())
                {
                    MessageBox.Show("请选择文件存放的路径，不能选择文件节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    //MessageBox.Show(nodeTemp.Text.ToString());
                    CreateNewFileFrm frm = new CreateNewFileFrm();
                    frm.SaveFilepath = fileHelper.getDocumentAllPathByPathID(nodeTemp.Tag.ToString());
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择文件存放的路径节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }
        string filepath = "";
        private void trvDocumentList_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0 && e.Node.Parent != null && e.Node.Text.IndexOf(@".") > -1)  //说明是子文件
            {
                DataRow row = (DataRow)e.Node.Tag;
                filepath = fileHelper.getDocumentAllPathByPathID(row["DFL_FILE_CHILD_PATH"].ToString());
                //MessageBox.Show("你单击了文件:" + row["DFL_FILE_NAME"].ToString() + "filepath:" + filepath);
                filepath += row["DFL_FILE_NAME"].ToString();
                //  MessageBox.Show("你打开了文件:" + filepath);
                this.webB.Navigate(filepath);
            }
            else
            {
                //MessageBox.Show("你点击的是文件目录并非是文件");
            }
        }

        private void Tool_FolderAdd_Click(object sender, EventArgs e)
        {

        }

        private void trvDocumentList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ToolS_FolderDelete_Click(object sender, EventArgs e)
        {
            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (chkIsFile())
                {
                    MessageBox.Show("请选择文件夹的上层路径,不能选择文件节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    if (checkDel())
                    {
                        DOC_FILE_DIR doc = new DOC_FILE_DIR();
                        //  DocumentDirService docS = new DocumentDirService();
                        DataEntityQuery<DOC_FILE_DIR> query = DataEntityQuery<DOC_FILE_DIR>.Create();
                        IDocumentDirService _docService = ServiceContainer.GetService<DocumentDirService>();
                        Boolean ok = false;
                        doc = _docService.findDoc(nodeTemp.Tag.ToString());
                        doc.DEL_FLAG = "Y";
                        ok = _docService.deleteDocumentDir(doc);
                        if (ok == true)
                        {
                            MessageBox.Show("文件夹删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        }
                        else
                        {
                            MessageBox.Show("文件夹删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("请选择文件夹的上层路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            IniEvent();
        }

        private void ToolS_FolderAmend_Click(object sender, EventArgs e)
        {

            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (chkIsFile())
                {
                    MessageBox.Show("请选择文件夹的上层路径,不能选择文件节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    //MessageBox.Show(nodeTemp.Text.ToString());
                    CreateNewFolderFrm frm = new CreateNewFolderFrm();
                    frm.SaveFilepath = fileHelper.getDocumentAllPathByPathID(nodeTemp.Tag.ToString());
                    frm.SaveFileKey = nodeTemp.Tag.ToString();
                    frm.BlAddFlg = false;
                    frm.FatherFileKey = nodeTemp.Parent.Tag.ToString();
                    frm.ModifyFolderText = nodeTemp.Text.ToString();
                    frm.DocName = nodeTemp.Text.ToString();

                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择文件夹的上层路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            IniEvent();

        }


        private void ToolS_FilesAmend_Click(object sender, EventArgs e)
        {
            //暂时不写
        }

        private void tspViewFile_Click(object sender, EventArgs e)
        {

            if (chkIsFile())
            {
                if (tspInView.Checked)
                {
                    this.webB.Navigate(@"D:\swf\Java网络编程精解.swf");
                }
                else
                {
                    ViewFileFrm fileView = new ViewFileFrm();
                    fileView.FileName = "Java网络编程精解.swf";
                    fileView.ViewFilePath = @"D:\swf\";
                    fileView.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("请在窗体左边的清单中选择需要预览的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }



        }

        private void 查看ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tspViewFile_Click(sender, e);
        }

        /// <summary>
        /// 判定选择的节点是不是文件,是文件返回true,反之
        /// </summary>
        /// <returns></returns>
        private Boolean chkIsFile()
        {
            Boolean bl = true;
            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (nodeTemp.Text.LastIndexOf(@".") > -1)
                {
                    bl = true;
                }
                else
                {
                    bl = false;
                }
            }
            else
            {
                bl = false;
            }
            return bl;
        }

        private void Tool_FindName_Click(object sender, EventArgs e)
        {
            this.panel_Find.Visible = true;
            this.TxtFName.Focus();
            this.TxtFName.SelectAll();
        }

        private void tspFileDownLoad_Click(object sender, EventArgs e)
        {
            if (chkIsFile())
            {
                //ViewFileFrm fileView = new ViewFileFrm();
                //fileView.FileName = "文件名称.txt";
                //fileView.ViewFilePathAndName = @"D:\swf\Java网络编程精解.swf";
                //fileView.ShowDialog();
            }
            else
            {
                MessageBox.Show("请在窗体左边的清单中选择需要预览的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void tspInView_Click(object sender, EventArgs e)
        {

            tspInView.Checked = !tspInView.Checked;
            tspOutView.Checked = !tspInView.Checked;
            //tspOutView.Checked = tspInView.Checked;
            //if (tspInView.Checked ==true)
            //{
            //    tspOutView.Checked = true;
            //}
        }

        private void tspOutView_Click(object sender, EventArgs e)
        {
            tspOutView.Checked = !tspOutView.Checked;
            tspInView.Checked = !tspOutView.Checked;
        }

        /// <summary>
        /// 删除时候的check事件
        /// </summary>
        /// <returns></returns>
        public bool checkDel()
        {
            IDocumentDirService _docService = ServiceContainer.GetService<DocumentDirService>();
            nodeTemp = this.trvDocumentList.SelectedNode;
            //MessageBox.Show(nodeTemp.Tag.ToString());
            if (nodeTemp.Tag.ToString() == "root")
            {
                MessageBox.Show("不能删除根节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (_docService.findSonDocments(nodeTemp.Tag.ToString()) != 0)
            {

                if (MessageBox.Show("您是否确定删除包含此文件夹的子文件夹?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }



    }
}
