namespace HYPDM.WinUI.Document
{
    partial class DocRegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocRegForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDocAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.tpRemark = new System.Windows.Forms.TabPage();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.tvFileList = new AdvancedDataGridView.TreeGridView();
            this.Papers = new AdvancedDataGridView.TreeGridColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHYSICALID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARENTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRegPhysicalFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tpVersion = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtUpdateDate = new System.Windows.Forms.TextBox();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmPhysical = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCheckIN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new AdvancedDataGridView.TreeGridColumn();
            this.Column3 = new AdvancedDataGridView.TreeGridColumn();
            this.Column4 = new AdvancedDataGridView.TreeGridColumn();
            this.Column5 = new AdvancedDataGridView.TreeGridColumn();
            this.Column6 = new AdvancedDataGridView.TreeGridColumn();
            this.imageStrip = new System.Windows.Forms.ImageList(this.components);
            this.cobDocType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            this.tbcContent.SuspendLayout();
            this.tpRemark.SuspendLayout();
            this.tpFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvFileList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmPhysical.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsToolbar);
            this.panel1.Controls.Add(this.tbcContent);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 283);
            this.panel1.TabIndex = 0;
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnDocAdd,
            this.toolStripSeparator1});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsToolbar.Size = new System.Drawing.Size(650, 25);
            this.tsToolbar.TabIndex = 4;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDocAdd
            // 
            this.btnDocAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDocAdd.Image")));
            this.btnDocAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocAdd.Name = "btnDocAdd";
            this.btnDocAdd.Size = new System.Drawing.Size(76, 22);
            this.btnDocAdd.Text = "记录保存";
            this.btnDocAdd.ToolTipText = "保存或修改一个新的基础数据记录。";
            this.btnDocAdd.Click += new System.EventHandler(this.btnDocAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbcContent
            // 
            this.tbcContent.Controls.Add(this.tpRemark);
            this.tbcContent.Controls.Add(this.tpFile);
            this.tbcContent.Controls.Add(this.tpVersion);
            this.tbcContent.Location = new System.Drawing.Point(233, 28);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(416, 255);
            this.tbcContent.TabIndex = 2;
            // 
            // tpRemark
            // 
            this.tpRemark.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpRemark.Controls.Add(this.txtRemark);
            this.tpRemark.Location = new System.Drawing.Point(4, 22);
            this.tpRemark.Name = "tpRemark";
            this.tpRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemark.Size = new System.Drawing.Size(408, 229);
            this.tpRemark.TabIndex = 0;
            this.tpRemark.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(9, 9);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(393, 206);
            this.txtRemark.TabIndex = 10;
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.tvFileList);
            this.tpFile.Controls.Add(this.toolStrip1);
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Size = new System.Drawing.Size(408, 229);
            this.tpFile.TabIndex = 1;
            this.tpFile.Text = "文件";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // tvFileList
            // 
            this.tvFileList.AllowUserToAddRows = false;
            this.tvFileList.AllowUserToDeleteRows = false;
            this.tvFileList.AllowUserToOrderColumns = true;
            this.tvFileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.tvFileList.ColumnHeadersHeight = 20;
            this.tvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Papers,
            this.FileName,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.PHYSICALID,
            this.PARENTID});
            this.tvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFileList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tvFileList.ImageList = null;
            this.tvFileList.Location = new System.Drawing.Point(0, 25);
            this.tvFileList.Name = "tvFileList";
            this.tvFileList.RowHeadersVisible = false;
            this.tvFileList.RowHeadersWidth = 20;
            this.tvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tvFileList.Size = new System.Drawing.Size(408, 204);
            this.tvFileList.TabIndex = 8;
            this.tvFileList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tvTaskList_CellMouseDown);
            // 
            // Papers
            // 
            this.Papers.DefaultNodeImage = null;
            this.Papers.HeaderText = "文件";
            this.Papers.Name = "Papers";
            this.Papers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Papers.Width = 150;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "描述";
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "版本";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 50;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "检入日期";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "检出时间";
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PHYSICALID
            // 
            this.PHYSICALID.HeaderText = "physicalId";
            this.PHYSICALID.Name = "PHYSICALID";
            this.PHYSICALID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PHYSICALID.Visible = false;
            // 
            // PARENTID
            // 
            this.PARENTID.HeaderText = "parentId";
            this.PARENTID.Name = "PARENTID";
            this.PARENTID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PARENTID.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnRegPhysicalFile,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(408, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRegPhysicalFile
            // 
            this.btnRegPhysicalFile.Image = ((System.Drawing.Image)(resources.GetObject("btnRegPhysicalFile.Image")));
            this.btnRegPhysicalFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegPhysicalFile.Name = "btnRegPhysicalFile";
            this.btnRegPhysicalFile.Size = new System.Drawing.Size(76, 22);
            this.btnRegPhysicalFile.Text = "文件注册";
            this.btnRegPhysicalFile.ToolTipText = "管理文档的物理文件。";
            this.btnRegPhysicalFile.Click += new System.EventHandler(this.btnRegPhysicalFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton2.Text = "文件下载";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tpVersion
            // 
            this.tpVersion.Location = new System.Drawing.Point(4, 22);
            this.tpVersion.Name = "tpVersion";
            this.tpVersion.Size = new System.Drawing.Size(408, 229);
            this.tpVersion.TabIndex = 2;
            this.tpVersion.Text = "版本";
            this.tpVersion.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(231, 255);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.cobDocType);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.txtCreateDate);
            this.tabPage1.Controls.Add(this.txtUpdateDate);
            this.tabPage1.Controls.Add(this.txtUpdateUser);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.txtDocNo);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(89, 83);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(128, 21);
            this.txtStatus.TabIndex = 6;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(89, 129);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(128, 21);
            this.txtCreateDate.TabIndex = 8;
            // 
            // txtUpdateDate
            // 
            this.txtUpdateDate.Enabled = false;
            this.txtUpdateDate.Location = new System.Drawing.Point(89, 152);
            this.txtUpdateDate.Name = "txtUpdateDate";
            this.txtUpdateDate.Size = new System.Drawing.Size(128, 21);
            this.txtUpdateDate.TabIndex = 9;
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Enabled = false;
            this.txtUpdateUser.Location = new System.Drawing.Point(89, 106);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(128, 21);
            this.txtUpdateUser.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(128, 21);
            this.txtDescription.TabIndex = 4;
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(89, 13);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(128, 21);
            this.txtDocNo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(20, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "修改日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(20, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "创建时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "修改者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文档分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // cmPhysical
            // 
            this.cmPhysical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnView,
            this.btnFileDown,
            this.toolStripSeparator4,
            this.btnCheckIN,
            this.btnCheckOut,
            this.btnCancel,
            this.toolStripSeparator5,
            this.btnDel});
            this.cmPhysical.Name = "contextMenuStrip1";
            this.cmPhysical.Size = new System.Drawing.Size(125, 148);
            // 
            // btnView
            // 
            this.btnView.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(124, 22);
            this.btnView.Text = "查看";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFileDown
            // 
            this.btnFileDown.Image = global::HYPDM.WinUI.Properties.Resources.download;
            this.btnFileDown.Name = "btnFileDown";
            this.btnFileDown.Size = new System.Drawing.Size(124, 22);
            this.btnFileDown.Text = "文件下载";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // btnCheckIN
            // 
            this.btnCheckIN.Name = "btnCheckIN";
            this.btnCheckIN.Size = new System.Drawing.Size(124, 22);
            this.btnCheckIN.Text = "检入";
            this.btnCheckIN.Click += new System.EventHandler(this.btnCheckIN_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 22);
            this.btnCheckOut.Text = "检出";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 22);
            this.btnCancel.Text = "取消检出";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::HYPDM.WinUI.Properties.Resources.delete;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 22);
            this.btnDel.Text = "删除文件";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DefaultNodeImage = null;
            this.Column2.HeaderText = "文件";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DefaultNodeImage = null;
            this.Column3.HeaderText = "文件名";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DefaultNodeImage = null;
            this.Column4.HeaderText = "描述";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DefaultNodeImage = null;
            this.Column5.HeaderText = "版本";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DefaultNodeImage = null;
            this.Column6.HeaderText = "检入日期";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imageStrip
            // 
            this.imageStrip.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cobDocType
            // 
            this.cobDocType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobDocType.FormattingEnabled = true;
            this.cobDocType.Items.AddRange(new object[] {
            "技术文件"});
            this.cobDocType.Location = new System.Drawing.Point(89, 36);
            this.cobDocType.Name = "cobDocType";
            this.cobDocType.Size = new System.Drawing.Size(128, 20);
            this.cobDocType.TabIndex = 10;
            // 
            // DocRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 283);
            this.Controls.Add(this.panel1);
            this.Name = "DocRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文档 注册";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.tbcContent.ResumeLayout(false);
            this.tpRemark.ResumeLayout(false);
            this.tpRemark.PerformLayout();
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvFileList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cmPhysical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.TextBox txtUpdateDate;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton btnDocAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.TabPage tpRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpVersion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRegPhysicalFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private AdvancedDataGridView.TreeGridColumn Column2;
        private AdvancedDataGridView.TreeGridColumn Column3;
        private AdvancedDataGridView.TreeGridColumn Column4;
        private AdvancedDataGridView.TreeGridColumn Column5;
        private AdvancedDataGridView.TreeGridColumn Column6;
        private AdvancedDataGridView.TreeGridView tvFileList;
        private System.Windows.Forms.ImageList imageStrip;
        private System.Windows.Forms.ContextMenuStrip cmPhysical;
        private System.Windows.Forms.ToolStripMenuItem btnCheckIN;
        private System.Windows.Forms.ToolStripMenuItem btnCheckOut;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnFileDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private AdvancedDataGridView.TreeGridColumn Papers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHYSICALID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARENTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobDocType;
    }
}