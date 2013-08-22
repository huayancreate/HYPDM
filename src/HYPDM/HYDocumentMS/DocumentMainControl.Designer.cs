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
            this.Tool_M_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_DataM = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_DAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_DAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_DDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_FolderM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FolderAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FolderDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FileM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FileAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FileAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_InM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_InList = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_OutM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_OutFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_OutList = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_M_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_FindName = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvDocumentList = new System.Windows.Forms.TreeView();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolS_Folder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FolderDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Files = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FilesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FilesAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_FilesDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.关联操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对象关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零部件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.半成品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文档文件关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Find = new System.Windows.Forms.Panel();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.label_FName = new System.Windows.Forms.Label();
            this.panel_F = new System.Windows.Forms.Panel();
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
            this.Tool_M_File,
            this.Tool_M_Find});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tool_M_File
            // 
            this.Tool_M_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_DataM,
            this.toolStripSeparator1,
            this.Tool_FolderM,
            this.Tool_FileM,
            this.toolStripSeparator2,
            this.Tool_InM,
            this.Tool_OutM});
            this.Tool_M_File.Name = "Tool_M_File";
            this.Tool_M_File.Size = new System.Drawing.Size(68, 21);
            this.Tool_M_File.Text = "文件管理";
            // 
            // Tool_DataM
            // 
            this.Tool_DataM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_DAdd,
            this.ToolS_DAmend,
            this.ToolS_DDelete});
            this.Tool_DataM.Name = "Tool_DataM";
            this.Tool_DataM.Size = new System.Drawing.Size(136, 22);
            this.Tool_DataM.Text = "资料集管理";
            // 
            // ToolS_DAdd
            // 
            this.ToolS_DAdd.Name = "ToolS_DAdd";
            this.ToolS_DAdd.Size = new System.Drawing.Size(100, 22);
            this.ToolS_DAdd.Tag = "0";
            this.ToolS_DAdd.Text = "添加";
            // 
            // ToolS_DAmend
            // 
            this.ToolS_DAmend.Name = "ToolS_DAmend";
            this.ToolS_DAmend.Size = new System.Drawing.Size(100, 22);
            this.ToolS_DAmend.Tag = "1";
            this.ToolS_DAmend.Text = "修改";
            // 
            // ToolS_DDelete
            // 
            this.ToolS_DDelete.Name = "ToolS_DDelete";
            this.ToolS_DDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolS_DDelete.Text = "删除";
            this.ToolS_DDelete.ToolTipText = "2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // Tool_FolderM
            // 
            this.Tool_FolderM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_FolderAdd,
            this.Tool_FolderAmend,
            this.Tool_FolderDelete});
            this.Tool_FolderM.Name = "Tool_FolderM";
            this.Tool_FolderM.Size = new System.Drawing.Size(136, 22);
            this.Tool_FolderM.Text = "文件夹管理";
            // 
            // Tool_FolderAdd
            // 
            this.Tool_FolderAdd.Name = "Tool_FolderAdd";
            this.Tool_FolderAdd.Size = new System.Drawing.Size(100, 22);
            this.Tool_FolderAdd.Tag = "0";
            this.Tool_FolderAdd.Text = "添加";
            // 
            // Tool_FolderAmend
            // 
            this.Tool_FolderAmend.Name = "Tool_FolderAmend";
            this.Tool_FolderAmend.Size = new System.Drawing.Size(100, 22);
            this.Tool_FolderAmend.Tag = "1";
            this.Tool_FolderAmend.Text = "修改";
            // 
            // Tool_FolderDelete
            // 
            this.Tool_FolderDelete.Name = "Tool_FolderDelete";
            this.Tool_FolderDelete.Size = new System.Drawing.Size(100, 22);
            this.Tool_FolderDelete.Tag = "2";
            this.Tool_FolderDelete.Text = "删除";
            // 
            // Tool_FileM
            // 
            this.Tool_FileM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_FileAdd,
            this.Tool_FileAmend,
            this.Tool_FileDelete});
            this.Tool_FileM.Name = "Tool_FileM";
            this.Tool_FileM.Size = new System.Drawing.Size(136, 22);
            this.Tool_FileM.Text = "文件管理";
            // 
            // Tool_FileAdd
            // 
            this.Tool_FileAdd.Name = "Tool_FileAdd";
            this.Tool_FileAdd.Size = new System.Drawing.Size(100, 22);
            this.Tool_FileAdd.Tag = "0";
            this.Tool_FileAdd.Text = "添加";
            // 
            // Tool_FileAmend
            // 
            this.Tool_FileAmend.Name = "Tool_FileAmend";
            this.Tool_FileAmend.Size = new System.Drawing.Size(100, 22);
            this.Tool_FileAmend.Tag = "1";
            this.Tool_FileAmend.Text = "修改";
            // 
            // Tool_FileDelete
            // 
            this.Tool_FileDelete.Name = "Tool_FileDelete";
            this.Tool_FileDelete.Size = new System.Drawing.Size(100, 22);
            this.Tool_FileDelete.Tag = "2";
            this.Tool_FileDelete.Text = "删除";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // Tool_InM
            // 
            this.Tool_InM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_InList});
            this.Tool_InM.Name = "Tool_InM";
            this.Tool_InM.Size = new System.Drawing.Size(136, 22);
            this.Tool_InM.Text = "导入";
            // 
            // Tool_InList
            // 
            this.Tool_InList.Name = "Tool_InList";
            this.Tool_InList.Size = new System.Drawing.Size(124, 22);
            this.Tool_InList.Tag = "0";
            this.Tool_InList.Text = "导入目录";
            // 
            // Tool_OutM
            // 
            this.Tool_OutM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_OutFile,
            this.Tool_OutList});
            this.Tool_OutM.Name = "Tool_OutM";
            this.Tool_OutM.Size = new System.Drawing.Size(136, 22);
            this.Tool_OutM.Text = "导出";
            // 
            // Tool_OutFile
            // 
            this.Tool_OutFile.Name = "Tool_OutFile";
            this.Tool_OutFile.Size = new System.Drawing.Size(124, 22);
            this.Tool_OutFile.Tag = "2";
            this.Tool_OutFile.Text = "导出文件";
            // 
            // Tool_OutList
            // 
            this.Tool_OutList.Name = "Tool_OutList";
            this.Tool_OutList.Size = new System.Drawing.Size(124, 22);
            this.Tool_OutList.Tag = "1";
            this.Tool_OutList.Text = "导出目录";
            // 
            // Tool_M_Find
            // 
            this.Tool_M_Find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_FindName});
            this.Tool_M_Find.Name = "Tool_M_Find";
            this.Tool_M_Find.Size = new System.Drawing.Size(68, 21);
            this.Tool_M_Find.Text = "文件查询";
            // 
            // Tool_FindName
            // 
            this.Tool_FindName.Name = "Tool_FindName";
            this.Tool_FindName.Size = new System.Drawing.Size(148, 22);
            this.Tool_FindName.Text = "按文件名查询";
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
            this.trvDocumentList.Location = new System.Drawing.Point(0, 33);
            this.trvDocumentList.Name = "trvDocumentList";
            this.trvDocumentList.Size = new System.Drawing.Size(203, 351);
            this.trvDocumentList.TabIndex = 7;
            this.trvDocumentList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDocumentList_NodeMouseClick);
            this.trvDocumentList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvDocumentList_NodeMouseDoubleClick);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_Folder,
            this.ToolS_Files,
            this.toolStripSeparator3,
            this.关联操作ToolStripMenuItem,
            this.对象关联ToolStripMenuItem,
            this.文档文件关联ToolStripMenuItem});
            this.contextMenuTree.Name = "contextMenuStrip_Tree";
            this.contextMenuTree.Size = new System.Drawing.Size(149, 120);
            // 
            // ToolS_Folder
            // 
            this.ToolS_Folder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_FolderAdd,
            this.ToolS_FolderAmend,
            this.ToolS_FolderDelete});
            this.ToolS_Folder.Name = "ToolS_Folder";
            this.ToolS_Folder.Size = new System.Drawing.Size(148, 22);
            this.ToolS_Folder.Text = "文件夹管理";
            // 
            // ToolS_FolderAdd
            // 
            this.ToolS_FolderAdd.Name = "ToolS_FolderAdd";
            this.ToolS_FolderAdd.Size = new System.Drawing.Size(152, 22);
            this.ToolS_FolderAdd.Tag = "0";
            this.ToolS_FolderAdd.Text = "添加";
            this.ToolS_FolderAdd.Click += new System.EventHandler(this.ToolS_FolderAdd_Click);
            // 
            // ToolS_FolderAmend
            // 
            this.ToolS_FolderAmend.Name = "ToolS_FolderAmend";
            this.ToolS_FolderAmend.Size = new System.Drawing.Size(152, 22);
            this.ToolS_FolderAmend.Tag = "1";
            this.ToolS_FolderAmend.Text = "修改";
            this.ToolS_FolderAmend.Click += new System.EventHandler(this.ToolS_FolderAmend_Click);
            // 
            // ToolS_FolderDelete
            // 
            this.ToolS_FolderDelete.Name = "ToolS_FolderDelete";
            this.ToolS_FolderDelete.Size = new System.Drawing.Size(152, 22);
            this.ToolS_FolderDelete.Tag = "2";
            this.ToolS_FolderDelete.Text = "删除";
            this.ToolS_FolderDelete.Click += new System.EventHandler(this.ToolS_FolderDelete_Click);
            // 
            // ToolS_Files
            // 
            this.ToolS_Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_FilesAdd,
            this.ToolS_FilesAmend,
            this.ToolS_FilesDelete});
            this.ToolS_Files.Name = "ToolS_Files";
            this.ToolS_Files.Size = new System.Drawing.Size(148, 22);
            this.ToolS_Files.Text = "文件管理";
            // 
            // ToolS_FilesAdd
            // 
            this.ToolS_FilesAdd.Name = "ToolS_FilesAdd";
            this.ToolS_FilesAdd.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FilesAdd.Tag = "0";
            this.ToolS_FilesAdd.Text = "添加";
            this.ToolS_FilesAdd.Click += new System.EventHandler(this.ToolS_FilesAdd_Click);
            // 
            // ToolS_FilesAmend
            // 
            this.ToolS_FilesAmend.Name = "ToolS_FilesAmend";
            this.ToolS_FilesAmend.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FilesAmend.Tag = "1";
            this.ToolS_FilesAmend.Text = "修改";
            // 
            // ToolS_FilesDelete
            // 
            this.ToolS_FilesDelete.Name = "ToolS_FilesDelete";
            this.ToolS_FilesDelete.Size = new System.Drawing.Size(100, 22);
            this.ToolS_FilesDelete.Tag = "2";
            this.ToolS_FilesDelete.Text = "删除";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // 关联操作ToolStripMenuItem
            // 
            this.关联操作ToolStripMenuItem.Name = "关联操作ToolStripMenuItem";
            this.关联操作ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.关联操作ToolStripMenuItem.Text = "创建文档对象";
            // 
            // 对象关联ToolStripMenuItem
            // 
            this.对象关联ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.零部件ToolStripMenuItem,
            this.产品ToolStripMenuItem,
            this.半成品ToolStripMenuItem,
            this.物料ToolStripMenuItem});
            this.对象关联ToolStripMenuItem.Name = "对象关联ToolStripMenuItem";
            this.对象关联ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.对象关联ToolStripMenuItem.Text = "对象关联";
            // 
            // 零部件ToolStripMenuItem
            // 
            this.零部件ToolStripMenuItem.Name = "零部件ToolStripMenuItem";
            this.零部件ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.零部件ToolStripMenuItem.Text = "零部件";
            // 
            // 产品ToolStripMenuItem
            // 
            this.产品ToolStripMenuItem.Name = "产品ToolStripMenuItem";
            this.产品ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.产品ToolStripMenuItem.Text = "产品";
            // 
            // 半成品ToolStripMenuItem
            // 
            this.半成品ToolStripMenuItem.Name = "半成品ToolStripMenuItem";
            this.半成品ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.半成品ToolStripMenuItem.Text = "半成品";
            // 
            // 物料ToolStripMenuItem
            // 
            this.物料ToolStripMenuItem.Name = "物料ToolStripMenuItem";
            this.物料ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.物料ToolStripMenuItem.Text = "物料";
            // 
            // 文档文件关联ToolStripMenuItem
            // 
            this.文档文件关联ToolStripMenuItem.Name = "文档文件关联ToolStripMenuItem";
            this.文档文件关联ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.文档文件关联ToolStripMenuItem.Text = "文件关联文档";
            // 
            // panel_Find
            // 
            this.panel_Find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Find.BackgroundImage")));
            this.panel_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Find.Controls.Add(this.textBox_FName);
            this.panel_Find.Controls.Add(this.label_FName);
            this.panel_Find.Controls.Add(this.panel_F);
            this.panel_Find.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Find.Location = new System.Drawing.Point(0, 0);
            this.panel_Find.Name = "panel_Find";
            this.panel_Find.Size = new System.Drawing.Size(203, 33);
            this.panel_Find.TabIndex = 6;
            // 
            // textBox_FName
            // 
            this.textBox_FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FName.Location = new System.Drawing.Point(46, 6);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(105, 21);
            this.textBox_FName.TabIndex = 5;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.BackColor = System.Drawing.Color.Transparent;
            this.label_FName.Location = new System.Drawing.Point(-1, 10);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(53, 12);
            this.label_FName.TabIndex = 4;
            this.label_FName.Text = "文件名：";
            // 
            // panel_F
            // 
            this.panel_F.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_F.BackgroundImage")));
            this.panel_F.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_F.Location = new System.Drawing.Point(153, 6);
            this.panel_F.Name = "panel_F";
            this.panel_F.Size = new System.Drawing.Size(48, 20);
            this.panel_F.TabIndex = 3;
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
            this.panel_Find.PerformLayout();
            this.gpDoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tool_M_File;
        private System.Windows.Forms.ToolStripMenuItem Tool_DataM;
        private System.Windows.Forms.ToolStripMenuItem ToolS_DAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolS_DAmend;
        private System.Windows.Forms.ToolStripMenuItem ToolS_DDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Tool_FolderM;
        private System.Windows.Forms.ToolStripMenuItem Tool_FolderAdd;
        private System.Windows.Forms.ToolStripMenuItem Tool_FolderAmend;
        private System.Windows.Forms.ToolStripMenuItem Tool_FolderDelete;
        private System.Windows.Forms.ToolStripMenuItem Tool_FileM;
        private System.Windows.Forms.ToolStripMenuItem Tool_FileAdd;
        private System.Windows.Forms.ToolStripMenuItem Tool_FileAmend;
        private System.Windows.Forms.ToolStripMenuItem Tool_FileDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Tool_InM;
        private System.Windows.Forms.ToolStripMenuItem Tool_InList;
        private System.Windows.Forms.ToolStripMenuItem Tool_OutM;
        private System.Windows.Forms.ToolStripMenuItem Tool_OutFile;
        private System.Windows.Forms.ToolStripMenuItem Tool_OutList;
        private System.Windows.Forms.ToolStripMenuItem Tool_M_Find;
        private System.Windows.Forms.ToolStripMenuItem Tool_FindName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_Find;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Panel panel_F;
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
        private System.Windows.Forms.ToolStripMenuItem ToolS_FilesAmend;
        private System.Windows.Forms.ToolStripMenuItem ToolS_FilesDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 关联操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对象关联ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零部件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 半成品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文档文件关联ToolStripMenuItem;
    }
}

