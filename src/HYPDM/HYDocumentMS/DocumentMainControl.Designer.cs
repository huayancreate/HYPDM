namespace HYDocumentMS
{
    partial class DocumentMainControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMainControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tool_M_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FindName = new System.Windows.Forms.ToolStripMenuItem();
            this.预览方式设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspInView = new System.Windows.Forms.ToolStripMenuItem();
            this.tspOutView = new System.Windows.Forms.ToolStripMenuItem();
            this.tspRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvDocumentList = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolS_Folder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Files = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FilesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tspFileDownLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.对象关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零部件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.半成品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspViewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.pnlFileExt = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkFileType = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label_FName = new System.Windows.Forms.Label();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.gpDoc = new System.Windows.Forms.GroupBox();
            this.webB = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.panel_Find.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImage = global::HYDocumentMS.Properties.Resources.Main_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 24);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_M_Find,
            this.预览方式设定ToolStripMenuItem,
            this.tspRefresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tool_M_Find
            // 
            this.Tool_M_Find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_FindName});
            this.Tool_M_Find.Image = global::HYDocumentMS.Properties.Resources.view;
            this.Tool_M_Find.Name = "Tool_M_Find";
            this.Tool_M_Find.Size = new System.Drawing.Size(84, 21);
            this.Tool_M_Find.Text = "文件查询";
            // 
            // Tool_FindName
            // 
            this.Tool_FindName.CheckOnClick = true;
            this.Tool_FindName.Name = "Tool_FindName";
            this.Tool_FindName.Size = new System.Drawing.Size(148, 22);
            this.Tool_FindName.Text = "按文件名查询";
            this.Tool_FindName.CheckedChanged += new System.EventHandler(this.Tool_FindName_CheckedChanged);
            this.Tool_FindName.Click += new System.EventHandler(this.Tool_FindName_Click);
            // 
            // 预览方式设定ToolStripMenuItem
            // 
            this.预览方式设定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspInView,
            this.tspOutView});
            this.预览方式设定ToolStripMenuItem.Name = "预览方式设定ToolStripMenuItem";
            this.预览方式设定ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.预览方式设定ToolStripMenuItem.Text = "预览方式设定";
            // 
            // tspInView
            // 
            this.tspInView.Checked = true;
            this.tspInView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tspInView.Name = "tspInView";
            this.tspInView.Size = new System.Drawing.Size(136, 22);
            this.tspInView.Text = "嵌入式预览";
            this.tspInView.Click += new System.EventHandler(this.tspInView_Click);
            // 
            // tspOutView
            // 
            this.tspOutView.Name = "tspOutView";
            this.tspOutView.Size = new System.Drawing.Size(136, 22);
            this.tspOutView.Text = "弹出框预览";
            this.tspOutView.Click += new System.EventHandler(this.tspOutView_Click);
            // 
            // tspRefresh
            // 
            this.tspRefresh.Image = global::HYDocumentMS.Properties.Resources.pagination_load;
            this.tspRefresh.Name = "tspRefresh";
            this.tspRefresh.Size = new System.Drawing.Size(60, 21);
            this.tspRefresh.Text = "刷新";
            this.tspRefresh.Click += new System.EventHandler(this.tspRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.trvDocumentList);
            this.splitContainer1.Panel1.Controls.Add(this.panel_Find);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.gpDoc);
            this.splitContainer1.Size = new System.Drawing.Size(896, 384);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 8;
            // 
            // trvDocumentList
            // 
            this.trvDocumentList.BackColor = System.Drawing.Color.LightCyan;
            this.trvDocumentList.ContextMenuStrip = this.contextMenuTree;
            this.trvDocumentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDocumentList.Location = new System.Drawing.Point(0, 53);
            this.trvDocumentList.Name = "trvDocumentList";
            this.trvDocumentList.Size = new System.Drawing.Size(203, 331);
            this.trvDocumentList.TabIndex = 7;
            this.trvDocumentList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDocumentList_NodeMouseDoubleClick);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_Folder,
            this.ToolS_Files,
            this.toolStripSeparator3,
            this.对象关联ToolStripMenuItem,
            this.tspViewFile});
            this.contextMenuTree.Name = "contextMenuStrip_Tree";
            this.contextMenuTree.Size = new System.Drawing.Size(137, 98);
            // 
            // ToolS_Folder
            // 
            this.ToolS_Folder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_FolderAdd,
            this.ToolS_FolderAmend,
            this.ToolS_FolderDelete});
            this.ToolS_Folder.Name = "ToolS_Folder";
            this.ToolS_Folder.Size = new System.Drawing.Size(136, 22);
            this.ToolS_Folder.Text = "文件夹管理";
            // 
            // ToolS_FolderAdd
            // 
            this.ToolS_FolderAdd.Image = global::HYDocumentMS.Properties.Resources.edit_add;
            this.ToolS_FolderAdd.Name = "ToolS_FolderAdd";
            this.ToolS_FolderAdd.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FolderAdd.Tag = "0";
            this.ToolS_FolderAdd.Text = "添加";
            this.ToolS_FolderAdd.Click += new System.EventHandler(this.ToolS_FolderAdd_Click);
            // 
            // ToolS_FolderAmend
            // 
            this.ToolS_FolderAmend.Name = "ToolS_FolderAmend";
            this.ToolS_FolderAmend.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FolderAmend.Tag = "1";
            this.ToolS_FolderAmend.Text = "修改";
            this.ToolS_FolderAmend.Click += new System.EventHandler(this.ToolS_FolderAmend_Click);
            // 
            // ToolS_FolderDelete
            // 
            this.ToolS_FolderDelete.Image = global::HYDocumentMS.Properties.Resources.delete1;
            this.ToolS_FolderDelete.Name = "ToolS_FolderDelete";
            this.ToolS_FolderDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FolderDelete.Tag = "2";
            this.ToolS_FolderDelete.Text = "删除";
            this.ToolS_FolderDelete.Click += new System.EventHandler(this.ToolS_FolderDelete_Click);
            // 
            // ToolS_Files
            // 
            this.ToolS_Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_FilesAdd,
            this.查看ToolStripMenuItem1,
            this.tspFileDownLoad});
            this.ToolS_Files.Name = "ToolS_Files";
            this.ToolS_Files.Size = new System.Drawing.Size(136, 22);
            this.ToolS_Files.Text = "文件管理";
            // 
            // ToolS_FilesAdd
            // 
            this.ToolS_FilesAdd.Image = global::HYDocumentMS.Properties.Resources.edit_add;
            this.ToolS_FilesAdd.Name = "ToolS_FilesAdd";
            this.ToolS_FilesAdd.Size = new System.Drawing.Size(152, 22);
            this.ToolS_FilesAdd.Tag = "0";
            this.ToolS_FilesAdd.Text = "添加";
            this.ToolS_FilesAdd.Visible = false;
            this.ToolS_FilesAdd.Click += new System.EventHandler(this.ToolS_FilesAdd_Click);
            // 
            // 查看ToolStripMenuItem1
            // 
            this.查看ToolStripMenuItem1.Image = global::HYDocumentMS.Properties.Resources.view;
            this.查看ToolStripMenuItem1.Name = "查看ToolStripMenuItem1";
            this.查看ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.查看ToolStripMenuItem1.Text = "文件预览";
            this.查看ToolStripMenuItem1.Click += new System.EventHandler(this.查看ToolStripMenuItem1_Click);
            // 
            // tspFileDownLoad
            // 
            this.tspFileDownLoad.Image = global::HYDocumentMS.Properties.Resources.download;
            this.tspFileDownLoad.Name = "tspFileDownLoad";
            this.tspFileDownLoad.Size = new System.Drawing.Size(152, 22);
            this.tspFileDownLoad.Text = "下载";
            this.tspFileDownLoad.Click += new System.EventHandler(this.tspFileDownLoad_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // 对象关联ToolStripMenuItem
            // 
            this.对象关联ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.零部件ToolStripMenuItem,
            this.产品ToolStripMenuItem,
            this.半成品ToolStripMenuItem,
            this.物料ToolStripMenuItem});
            this.对象关联ToolStripMenuItem.Name = "对象关联ToolStripMenuItem";
            this.对象关联ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.对象关联ToolStripMenuItem.Text = "对象关联";
            this.对象关联ToolStripMenuItem.Visible = false;
            // 
            // 零部件ToolStripMenuItem
            // 
            this.零部件ToolStripMenuItem.Name = "零部件ToolStripMenuItem";
            this.零部件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.零部件ToolStripMenuItem.Text = "零部件";
            // 
            // 产品ToolStripMenuItem
            // 
            this.产品ToolStripMenuItem.Name = "产品ToolStripMenuItem";
            this.产品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.产品ToolStripMenuItem.Text = "产品";
            // 
            // 半成品ToolStripMenuItem
            // 
            this.半成品ToolStripMenuItem.Name = "半成品ToolStripMenuItem";
            this.半成品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.半成品ToolStripMenuItem.Text = "半成品";
            // 
            // 物料ToolStripMenuItem
            // 
            this.物料ToolStripMenuItem.Name = "物料ToolStripMenuItem";
            this.物料ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.物料ToolStripMenuItem.Text = "物料";
            // 
            // tspViewFile
            // 
            this.tspViewFile.Image = global::HYDocumentMS.Properties.Resources.view;
            this.tspViewFile.Name = "tspViewFile";
            this.tspViewFile.Size = new System.Drawing.Size(136, 22);
            this.tspViewFile.Text = "文件预览";
            this.tspViewFile.Click += new System.EventHandler(this.tspViewFile_Click);
            // 
            // panel_Find
            // 
            this.panel_Find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Find.BackgroundImage")));
            this.panel_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Find.Controls.Add(this.pnlFileExt);
            this.panel_Find.Controls.Add(this.panel2);
            this.panel_Find.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Find.Location = new System.Drawing.Point(0, 0);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(203, 53);
            this.panel_Find.TabIndex = 6;
            this.panel_Find.Visible = false;
            // 
            // pnlFileExt
            // 
            this.pnlFileExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileExt.Location = new System.Drawing.Point(0, 53);
            this.pnlFileExt.Name = "pnlFileExt";
            this.pnlFileExt.Size = new System.Drawing.Size(203, 0);
            this.pnlFileExt.TabIndex = 9;
            this.pnlFileExt.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkFileType);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label_FName);
            this.panel2.Controls.Add(this.pnlFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 53);
            this.panel2.TabIndex = 8;
            // 
            // chkFileType
            // 
            this.chkFileType.AutoSize = true;
            this.chkFileType.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFileType.Location = new System.Drawing.Point(46, 30);
            this.chkFileType.Name = "chkFileType";
            this.chkFileType.Size = new System.Drawing.Size(120, 16);
            this.chkFileType.TabIndex = 11;
            this.chkFileType.Text = "按照文档类型查找";
            this.chkFileType.UseVisualStyleBackColor = true;
            this.chkFileType.CheckedChanged += new System.EventHandler(this.chkFileType_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(48, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 21);
            this.txtName.TabIndex = 10;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.BackColor = System.Drawing.Color.Transparent;
            this.label_FName.Location = new System.Drawing.Point(1, 7);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(53, 12);
            this.label_FName.TabIndex = 9;
            this.label_FName.Text = "文件名：";
            // 
            // pnlFind
            // 
            this.pnlFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFind.BackgroundImage")));
            this.pnlFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFind.Location = new System.Drawing.Point(155, 3);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(48, 20);
            this.pnlFind.TabIndex = 8;
            this.pnlFind.Click += new System.EventHandler(this.pnlFind_Click);
            // 
            // gpDoc
            // 
            this.gpDoc.Controls.Add(this.webB);
            this.gpDoc.Controls.Add(this.groupBox1);
            this.gpDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDoc.Location = new System.Drawing.Point(0, 0);
            this.gpDoc.Name = "gpDoc";
            this.gpDoc.Size = new System.Drawing.Size(689, 384);
            this.gpDoc.TabIndex = 0;
            this.gpDoc.TabStop = false;
            this.gpDoc.Text = "文档预览区";
            // 
            // webB
            // 
            this.webB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webB.Location = new System.Drawing.Point(3, 17);
            this.webB.MinimumSize = new System.Drawing.Size(20, 20);
            this.webB.Name = "webB";
            this.webB.Size = new System.Drawing.Size(683, 352);
            this.webB.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 12);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DocumentMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HYDocumentMS.Properties.Resources.Max_All;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentMainControl";
            this.Size = new System.Drawing.Size(896, 433);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuTree.ResumeLayout(false);
            this.panel_Find.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpDoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tool_M_Find;
        private System.Windows.Forms.ToolStripMenuItem Tool_FindName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.GroupBox gpDoc;
        private System.Windows.Forms.TreeView trvDocumentList;
        private System.Windows.Forms.WebBrowser webB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Folder;
        private System.Windows.Forms.ToolStripMenuItem ToolS_FolderAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolS_FolderAmend;
        private System.Windows.Forms.ToolStripMenuItem ToolS_FolderDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Files;
        private System.Windows.Forms.ToolStripMenuItem ToolS_FilesAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 对象关联ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零部件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 半成品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tspViewFile;
        private System.Windows.Forms.ToolStripMenuItem tspFileDownLoad;
        private System.Windows.Forms.ToolStripMenuItem 预览方式设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspInView;
        private System.Windows.Forms.ToolStripMenuItem tspOutView;
        private System.Windows.Forms.Panel pnlFileExt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkFileType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.ToolStripMenuItem tspRefresh;
    }
}

