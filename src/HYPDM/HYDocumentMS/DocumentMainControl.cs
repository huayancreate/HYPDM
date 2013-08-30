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
            InitialEvent();
        }
        private void InitialEvent()
        {
            this.trvDocumentList.Nodes.Clear();
            fileHelper = new FileHelper();
            fileHelper.getTreeViewByDocFileList(this.trvDocumentList, fileHelper.getDocFileList(true));
            trvDocumentList.ExpandAll();
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

                    IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                    HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                    Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.FolderCreate, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                    if (bl == false)
                    {
                        MessageBox.Show("你没有权限在此文件下创建文件夹!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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
                    IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                    HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                    Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.UpLoad, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                    if (bl == false)
                    {
                        MessageBox.Show("你没有权限上传文件到此文件夹!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
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
            //if (e.Node.Nodes.Count == 0 && e.Node.Parent != null && e.Node.Text.IndexOf(@".") > -1)  //说明是子文件
            //{
            //   // DataRow row = (DataRow)e.Node.Tag;
            //   // filepath = fileHelper.getDocumentAllPathByPathID(row["DFL_FILE_CHILD_PATH"].ToString());
            //    filepath = fileHelper.getDocumentAllPathByFileID(e.Node.Tag.ToString());
            //    //MessageBox.Show("你单击了文件:" + row["DFL_FILE_NAME"].ToString() + "filepath:" + filepath);
            //    filepath += e.Node.Text.ToString();
            //    //  filepath += row["DFL_FILE_NAME"].ToString();
            //    //  MessageBox.Show("你打开了文件:" + filepath);
            //    filepath = @"F:\12.docx";
            //    this.webB.Navigate(filepath);
            //}
            //else
            //{
            //    //MessageBox.Show("你点击的是文件目录并非是文件");
            //}
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
                        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                        HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                        Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.FolderDelete, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                        if (bl == false)
                        {
                            MessageBox.Show("你没有权限删除文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
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
                    IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                    HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                    Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.FolderEdit, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                    if (bl == false)
                    {
                        MessageBox.Show("你没有权限修改此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
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


                IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.View, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                if (bl == false)
                {
                    MessageBox.Show("你没有权限查看此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (tspInView.Checked)
                {
                    this.webB.Navigate(@"D:\swf\漂亮动态ppt模板.swf");
                }
                else
                {
                    ViewFileFrm fileView = new ViewFileFrm();
                    fileView.FileName = "漂亮动态ppt模板.swf";
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
            //this.panel_Find.Visible = true;
            //this.txtName.Focus();
            //this.txtName.SelectAll();
        }

        private void tspFileDownLoad_Click(object sender, EventArgs e)
        {
            string serverpath = "";
            if (chkIsFile())
            {
                IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
                HYDocumentMS.IFileHelper file = new HYDocumentMS.FileHelper();
                TreeNode node = this.trvDocumentList.SelectedNode;
                string dd = node.Text;
                string ee = node.Tag.ToString();

                Boolean bl = file.isHasAuth(HYDocumentMS.DataType.AuthParmsType.DownLoad, LoginInfo.LoginID, this.trvDocumentList.SelectedNode.Tag.ToString());
                if (bl == false)
                {
                    MessageBox.Show("你没有权限下载此文件!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.FileName = this.trvDocumentList.SelectedNode.Text.ToString();
                    saveDialog.Filter = @"Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    DialogResult res = saveDialog.ShowDialog();
                    if (DialogResult.OK == res)
                    {
                        string clientSaveFileAndPath = saveDialog.FileName.ToString();
                        serverpath = file.getDocumentAllPathByFileID(this.trvDocumentList.SelectedNode.Tag.ToString()) + this.trvDocumentList.SelectedNode.Text.ToString();
                        //FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, @"C:\\" + node.Cells[0].Value.ToString());
                        FileSockClient.DownLoadFileSocketClient downSocket = new FileSockClient.DownLoadFileSocketClient(serverpath, clientSaveFileAndPath);
                    }
                    else
                    {
                        MessageBox.Show("请选择需要下载的文件" + ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

        private void pnlFind_Click(object sender, EventArgs e)
        {
            StringBuilder stbQuery = new StringBuilder();
            //stbQuery.Append("SELECT DFL_ID,DFL_FILE_NAME,DFL_FILE_EXTEND,DFL_FILE_CHILD_PATH");
            //stbQuery.Append(" FROM DOC_FILE_LIST");
            stbQuery.Append("WHERE DEL_FLAG='N'");
            CheckBox chkAll = null;
            StringBuilder strFileExt = new StringBuilder();
            if (this.chkFileType.Checked == true)
            {
                foreach (Control ctl in this.pnlFileExt.Controls)
                {
                    // MessageBox.Show(ctl.GetType().Name.ToString());
                    if (ctl.GetType().Name.ToString() == "CheckBox")
                    {
                        if (((CheckBox)ctl).Checked == true)
                        {
                            if (((CheckBox)ctl).Name == "ALL")
                            {
                                chkAll = (CheckBox)ctl;
                                return;
                            }
                            strFileExt.Append("'").Append(((CheckBox)ctl).Name.ToString()).Append("',");
                        }
                    }
                }
            }
            else
            {
                if (this.txtName.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("请输入文件名称！", "查询助手提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.txtName.Focus();
                    return;
                }
            }

            if (this.txtName.Text.ToString().Trim() != "")
            {
                stbQuery.Append(" AND DFL_FILE_NAME LIKE '").Append("%").Append(this.txtName.Text).Append("%'");
            }

            if (this.chkFileType.Checked == true)
            {
                if (chkAll != null && chkAll.Name.ToString() == "ALL")
                {
                    //为ALL标识不区分后缀
                }
                else
                {
                    if (strFileExt == null || strFileExt.Length == 0)
                    {
                        MessageBox.Show("请选择文件类别！", "查询助手提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        strFileExt.Remove(strFileExt.Length - 1, 1);
                        strFileExt.Insert(0, "(").Append(")");
                        stbQuery.Append(" AND upper(DFL_FILE_EXTEND) IN ").Append(strFileExt.ToString());
                    }
                }
            }
            //MessageBox.Show(strFileExt.ToString());
            //stbQuery.Append(" AND upper(DFL_FILE_EXTEND) IN ").Append(strFileExt.ToString());
            //查询生成树
            DataTable dtDocFileList = new FileHelper().getDataTableBySql("DFL_ID,DFL_FILE_NAME,DFL_FILE_EXTEND,DFL_FILE_CHILD_PATH", stbQuery.ToString(), "DOC_FILE_LIST");
            if (dtDocFileList.Rows.Count == 0)
            {
                MessageBox.Show("没有查询到你需要的信息!！", "查询助手提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.trvDocumentList.Nodes.Clear();
                return;
            }
            this.trvDocumentList.Nodes.Clear();
            fileHelper.getTreeViewByDocFileList(this.trvDocumentList, dtDocFileList);
            trvDocumentList.ExpandAll();



            //}
        }

        private void Tool_FindName_CheckedChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(Tool_FindName.Checked.ToString());
            if (Tool_FindName.Checked == true)
            {
                this.panel_Find.Visible = true;
            }
            else
            {
                this.panel_Find.Visible = false;
                this.txtName.Text = "";
            }
        }

        private void chkFileType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFileType.Checked == true)
            {
                this.pnlFileExt.Visible = true;
                this.panel_Find.Height += 119;
                setCheckFileType();
            }
            else
            {
                this.pnlFileExt.Visible = false;
                this.panel_Find.Height -= this.pnlFileExt.Height;
            }
        }
        //自动生成文件类型的选项
        private void setCheckFileType()
        {

            DataTable dtTemp = new FileHelper().getDataTableBySql("distinct upper(DFL_FILE_EXTEND) as ext", "", "DOC_FILE_LIST ORDER BY EXT ASC");
            if (dtTemp != null && dtTemp.Rows.Count > 0)
            {
                ///添加checkbox控件
                CheckBox chkBoxExt = null;
                int x = 15;
                int y = 19;
                int count = 1;
                chkBoxExt = new CheckBox();
                chkBoxExt.Location = new System.Drawing.Point(x, y);
                chkBoxExt.Name = "ALL";
                chkBoxExt.Size = new System.Drawing.Size(78, 16);
                chkBoxExt.Text = "ALL";
                chkBoxExt.UseVisualStyleBackColor = true;
                chkBoxExt.Visible = true;
                chkBoxExt.Checked = false;
                this.pnlFileExt.Controls.Add(chkBoxExt);
                x += 90;
                foreach (DataRow row in dtTemp.Rows)
                {
                    chkBoxExt = new CheckBox();

                    chkBoxExt.Location = new System.Drawing.Point(x, y);
                    chkBoxExt.Name = row["ext"].ToString();
                    chkBoxExt.Size = new System.Drawing.Size(78, 16);
                    chkBoxExt.Text = row["ext"].ToString();
                    chkBoxExt.UseVisualStyleBackColor = true;
                    chkBoxExt.Visible = true;

                    count += 1;
                    if (count % 3 == 0)
                    {
                        x = 15;
                        y += 28;
                    }
                    else
                    {
                        x += 90;
                    }
                    this.pnlFileExt.Controls.Add(chkBoxExt);
                }
            }
            this.txtName.Focus();
            this.txtName.SelectAll();
        }

        private void tspRefresh_Click(object sender, EventArgs e)
        {
            InitialEvent();
        }
    }
}
