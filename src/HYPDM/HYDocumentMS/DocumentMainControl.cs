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

namespace HYDocumentMS
{
    [Module("{20EE5B83-2353-40DC-ADD4-29B3B2BA3AF9}", "文档管理主界面", "文档管理")]
    public partial class DocumentMainControl : UserControl
    {

        IFileHelper fileHelper;
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
            fileHelper = new FileHelper();
            fileHelper.getTreeViewByDocFileList(this.trvDocumentList, fileHelper.getDocFileList());

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
                if (nodeTemp.Text.LastIndexOf(@".") > -1)
                {
                    MessageBox.Show("请选择文件夹的上层路径,不能选择文件节点！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    //   MessageBox.Show(nodeTemp.Text.ToString());
                    CreateNewFolderFrm frm = new CreateNewFolderFrm();
                    frm.SaveFilepath = fileHelper.getDocumentAllPathByPathID(nodeTemp.Tag.ToString());
                    frm.SaveFileKey = nodeTemp.Tag.ToString();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("请选择文件夹的上层路径！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            }
           
        }

        private void ToolS_FilesAdd_Click(object sender, EventArgs e)
        {

            nodeTemp = this.trvDocumentList.SelectedNode;
            if (nodeTemp != null)
            {
                if (nodeTemp.Text.LastIndexOf(@".") > -1)
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
    }
}
