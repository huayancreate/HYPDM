namespace HYDocumentMS.FileAuth
{
    partial class UserFileAuthFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFileUpLoad = new System.Windows.Forms.CheckBox();
            this.chkFileCheckOut = new System.Windows.Forms.CheckBox();
            this.chkFileCheckIn = new System.Windows.Forms.CheckBox();
            this.chkFileDelete = new System.Windows.Forms.CheckBox();
            this.chkFileDownLoad = new System.Windows.Forms.CheckBox();
            this.chkFileEdit = new System.Windows.Forms.CheckBox();
            this.chkFileView = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFileCancel = new System.Windows.Forms.Button();
            this.btnFileSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVFileList = new HYPDM.BaseControl.DataGridViewExt();
            this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DFL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_FILE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_FILE_CHILD_PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_VER_LATEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFolder = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.chkUpLoad = new System.Windows.Forms.CheckBox();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.chkCheckIN = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkDownLoad = new System.Windows.Forms.CheckBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.chkFolderCreate = new System.Windows.Forms.CheckBox();
            this.chkFolderDelete = new System.Windows.Forms.CheckBox();
            this.chkFolderEdit = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFolderCancel = new System.Windows.Forms.Button();
            this.btnFolderSubmit = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.trvFolderDir = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).BeginInit();
            this.tabFolder.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Controls.Add(this.tabFolder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.groupBox1);
            this.tabFile.Location = new System.Drawing.Point(4, 22);
            this.tabFile.Name = "tabFile";
            this.tabFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabFile.Size = new System.Drawing.Size(487, 467);
            this.tabFile.TabIndex = 0;
            this.tabFile.Text = "文件权限";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 101);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "功能选项";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkFileUpLoad);
            this.panel1.Controls.Add(this.chkFileCheckOut);
            this.panel1.Controls.Add(this.chkFileCheckIn);
            this.panel1.Controls.Add(this.chkFileDelete);
            this.panel1.Controls.Add(this.chkFileDownLoad);
            this.panel1.Controls.Add(this.chkFileEdit);
            this.panel1.Controls.Add(this.chkFileView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 81);
            this.panel1.TabIndex = 0;
            // 
            // chkFileUpLoad
            // 
            this.chkFileUpLoad.AutoSize = true;
            this.chkFileUpLoad.Location = new System.Drawing.Point(364, 17);
            this.chkFileUpLoad.Name = "chkFileUpLoad";
            this.chkFileUpLoad.Size = new System.Drawing.Size(72, 16);
            this.chkFileUpLoad.TabIndex = 26;
            this.chkFileUpLoad.Text = "文件上传";
            this.chkFileUpLoad.UseVisualStyleBackColor = true;
            this.chkFileUpLoad.Visible = false;
            // 
            // chkFileCheckOut
            // 
            this.chkFileCheckOut.AutoSize = true;
            this.chkFileCheckOut.Location = new System.Drawing.Point(282, 48);
            this.chkFileCheckOut.Name = "chkFileCheckOut";
            this.chkFileCheckOut.Size = new System.Drawing.Size(72, 16);
            this.chkFileCheckOut.TabIndex = 25;
            this.chkFileCheckOut.Text = "文件检出";
            this.chkFileCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkFileCheckIn
            // 
            this.chkFileCheckIn.AutoSize = true;
            this.chkFileCheckIn.Location = new System.Drawing.Point(173, 48);
            this.chkFileCheckIn.Name = "chkFileCheckIn";
            this.chkFileCheckIn.Size = new System.Drawing.Size(72, 16);
            this.chkFileCheckIn.TabIndex = 24;
            this.chkFileCheckIn.Text = "文件检入";
            this.chkFileCheckIn.UseVisualStyleBackColor = true;
            // 
            // chkFileDelete
            // 
            this.chkFileDelete.AutoSize = true;
            this.chkFileDelete.Location = new System.Drawing.Point(70, 48);
            this.chkFileDelete.Name = "chkFileDelete";
            this.chkFileDelete.Size = new System.Drawing.Size(72, 16);
            this.chkFileDelete.TabIndex = 23;
            this.chkFileDelete.Text = "文件删除";
            this.chkFileDelete.UseVisualStyleBackColor = true;
            // 
            // chkFileDownLoad
            // 
            this.chkFileDownLoad.AutoSize = true;
            this.chkFileDownLoad.Location = new System.Drawing.Point(282, 18);
            this.chkFileDownLoad.Name = "chkFileDownLoad";
            this.chkFileDownLoad.Size = new System.Drawing.Size(72, 16);
            this.chkFileDownLoad.TabIndex = 22;
            this.chkFileDownLoad.Text = "文件下载";
            this.chkFileDownLoad.UseVisualStyleBackColor = true;
            // 
            // chkFileEdit
            // 
            this.chkFileEdit.AutoSize = true;
            this.chkFileEdit.Location = new System.Drawing.Point(173, 18);
            this.chkFileEdit.Name = "chkFileEdit";
            this.chkFileEdit.Size = new System.Drawing.Size(72, 16);
            this.chkFileEdit.TabIndex = 21;
            this.chkFileEdit.Text = "文件编辑";
            this.chkFileEdit.UseVisualStyleBackColor = true;
            // 
            // chkFileView
            // 
            this.chkFileView.AutoSize = true;
            this.chkFileView.Location = new System.Drawing.Point(70, 18);
            this.chkFileView.Name = "chkFileView";
            this.chkFileView.Size = new System.Drawing.Size(72, 16);
            this.chkFileView.TabIndex = 20;
            this.chkFileView.Text = "文件查看";
            this.chkFileView.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnFileCancel);
            this.groupBox3.Controls.Add(this.btnFileSubmit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnFileCancel
            // 
            this.btnFileCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFileCancel.Location = new System.Drawing.Point(414, 20);
            this.btnFileCancel.Name = "btnFileCancel";
            this.btnFileCancel.Size = new System.Drawing.Size(61, 28);
            this.btnFileCancel.TabIndex = 1;
            this.btnFileCancel.Text = "取消";
            this.btnFileCancel.UseVisualStyleBackColor = true;
            this.btnFileCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFileSubmit
            // 
            this.btnFileSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFileSubmit.Location = new System.Drawing.Point(333, 20);
            this.btnFileSubmit.Name = "btnFileSubmit";
            this.btnFileSubmit.Size = new System.Drawing.Size(61, 28);
            this.btnFileSubmit.TabIndex = 0;
            this.btnFileSubmit.Text = "提交";
            this.btnFileSubmit.UseVisualStyleBackColor = true;
            this.btnFileSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dGVFileList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件清单";
            // 
            // dGVFileList
            // 
            this.dGVFileList.AllowUserToAddRows = false;
            this.dGVFileList.AllowUserToDeleteRows = false;
            this.dGVFileList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dGVFileList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHK,
            this.DFL_ID,
            this.DFL_FILE_NAME,
            this.DFL_FILE_CHILD_PATH,
            this.DFL_VER_LATEST,
            this.DEL_FLAG,
            this.CREATEUSER,
            this.CREATEDATE1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVFileList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVFileList.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVFileList.Location = new System.Drawing.Point(3, 17);
            this.dGVFileList.Name = "dGVFileList";
            this.dGVFileList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVFileList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVFileList.RowTemplate.Height = 23;
            this.dGVFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVFileList.Size = new System.Drawing.Size(469, 263);
            this.dGVFileList.TabIndex = 2;
            this.dGVFileList.SelectionChanged += new System.EventHandler(this.dGVFileList_SelectionChanged);
            // 
            // CHK
            // 
            this.CHK.DataPropertyName = "CHK";
            this.CHK.FalseValue = "false";
            this.CHK.Frozen = true;
            this.CHK.HeaderText = "选中";
            this.CHK.Name = "CHK";
            this.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHK.TrueValue = "true";
            this.CHK.Width = 80;
            // 
            // DFL_ID
            // 
            this.DFL_ID.DataPropertyName = "DFL_ID";
            this.DFL_ID.HeaderText = "DFL_ID";
            this.DFL_ID.Name = "DFL_ID";
            this.DFL_ID.Visible = false;
            // 
            // DFL_FILE_NAME
            // 
            this.DFL_FILE_NAME.DataPropertyName = "DFL_FILE_NAME";
            this.DFL_FILE_NAME.HeaderText = "文件名称";
            this.DFL_FILE_NAME.Name = "DFL_FILE_NAME";
            this.DFL_FILE_NAME.Width = 180;
            // 
            // DFL_FILE_CHILD_PATH
            // 
            this.DFL_FILE_CHILD_PATH.DataPropertyName = "DFL_FILE_CHILD_PATH";
            this.DFL_FILE_CHILD_PATH.HeaderText = "DFL_FILE_CHILD_PATH";
            this.DFL_FILE_CHILD_PATH.Name = "DFL_FILE_CHILD_PATH";
            this.DFL_FILE_CHILD_PATH.Visible = false;
            // 
            // DFL_VER_LATEST
            // 
            this.DFL_VER_LATEST.DataPropertyName = "DFL_VER_LATEST";
            this.DFL_VER_LATEST.HeaderText = "最新版本";
            this.DFL_VER_LATEST.Name = "DFL_VER_LATEST";
            // 
            // DEL_FLAG
            // 
            this.DEL_FLAG.DataPropertyName = "DEL_FLAG";
            this.DEL_FLAG.HeaderText = "删除标识";
            this.DEL_FLAG.Name = "DEL_FLAG";
            // 
            // CREATEUSER
            // 
            this.CREATEUSER.DataPropertyName = "CREATEUSER";
            this.CREATEUSER.HeaderText = "创建用户";
            this.CREATEUSER.Name = "CREATEUSER";
            // 
            // CREATEDATE1
            // 
            this.CREATEDATE1.DataPropertyName = "CREATEDATE";
            this.CREATEDATE1.HeaderText = "创建日期";
            this.CREATEDATE1.Name = "CREATEDATE1";
            // 
            // tabFolder
            // 
            this.tabFolder.Controls.Add(this.groupBox5);
            this.tabFolder.Location = new System.Drawing.Point(4, 22);
            this.tabFolder.Name = "tabFolder";
            this.tabFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolder.Size = new System.Drawing.Size(487, 467);
            this.tabFolder.TabIndex = 1;
            this.tabFolder.Text = "文件夹权限";
            this.tabFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 461);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.panel2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 272);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(475, 142);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "功能选项";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 122);
            this.panel2.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.chkUpLoad);
            this.groupBox10.Controls.Add(this.chkCheckOut);
            this.groupBox10.Controls.Add(this.chkCheckIN);
            this.groupBox10.Controls.Add(this.chkDelete);
            this.groupBox10.Controls.Add(this.chkDownLoad);
            this.groupBox10.Controls.Add(this.chkEdit);
            this.groupBox10.Controls.Add(this.chkView);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(0, 42);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(467, 78);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "文件";
            // 
            // chkUpLoad
            // 
            this.chkUpLoad.AutoSize = true;
            this.chkUpLoad.Location = new System.Drawing.Point(392, 22);
            this.chkUpLoad.Name = "chkUpLoad";
            this.chkUpLoad.Size = new System.Drawing.Size(72, 16);
            this.chkUpLoad.TabIndex = 26;
            this.chkUpLoad.Text = "文件上传";
            this.chkUpLoad.UseVisualStyleBackColor = true;
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(310, 51);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(72, 16);
            this.chkCheckOut.TabIndex = 25;
            this.chkCheckOut.Text = "文件检出";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkCheckIN
            // 
            this.chkCheckIN.AutoSize = true;
            this.chkCheckIN.Location = new System.Drawing.Point(201, 51);
            this.chkCheckIN.Name = "chkCheckIN";
            this.chkCheckIN.Size = new System.Drawing.Size(72, 16);
            this.chkCheckIN.TabIndex = 24;
            this.chkCheckIN.Text = "文件检入";
            this.chkCheckIN.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(98, 51);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(72, 16);
            this.chkDelete.TabIndex = 23;
            this.chkDelete.Text = "文件删除";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkDownLoad
            // 
            this.chkDownLoad.AutoSize = true;
            this.chkDownLoad.Location = new System.Drawing.Point(310, 23);
            this.chkDownLoad.Name = "chkDownLoad";
            this.chkDownLoad.Size = new System.Drawing.Size(72, 16);
            this.chkDownLoad.TabIndex = 22;
            this.chkDownLoad.Text = "文件下载";
            this.chkDownLoad.UseVisualStyleBackColor = true;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(201, 23);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(72, 16);
            this.chkEdit.TabIndex = 21;
            this.chkEdit.Text = "文件编辑";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(98, 23);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(72, 16);
            this.chkView.TabIndex = 20;
            this.chkView.Text = "文件查看";
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox9.Controls.Add(this.chkFolderCreate);
            this.groupBox9.Controls.Add(this.chkFolderDelete);
            this.groupBox9.Controls.Add(this.chkFolderEdit);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(467, 42);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "文件夹";
            // 
            // chkFolderCreate
            // 
            this.chkFolderCreate.AutoSize = true;
            this.chkFolderCreate.Location = new System.Drawing.Point(360, 19);
            this.chkFolderCreate.Name = "chkFolderCreate";
            this.chkFolderCreate.Size = new System.Drawing.Size(96, 16);
            this.chkFolderCreate.TabIndex = 10;
            this.chkFolderCreate.Text = "文件夹的创建";
            this.chkFolderCreate.UseVisualStyleBackColor = true;
            // 
            // chkFolderDelete
            // 
            this.chkFolderDelete.AutoSize = true;
            this.chkFolderDelete.Location = new System.Drawing.Point(233, 19);
            this.chkFolderDelete.Name = "chkFolderDelete";
            this.chkFolderDelete.Size = new System.Drawing.Size(96, 16);
            this.chkFolderDelete.TabIndex = 9;
            this.chkFolderDelete.Text = "文件夹的删除";
            this.chkFolderDelete.UseVisualStyleBackColor = true;
            // 
            // chkFolderEdit
            // 
            this.chkFolderEdit.AutoSize = true;
            this.chkFolderEdit.Location = new System.Drawing.Point(99, 19);
            this.chkFolderEdit.Name = "chkFolderEdit";
            this.chkFolderEdit.Size = new System.Drawing.Size(96, 16);
            this.chkFolderEdit.TabIndex = 8;
            this.chkFolderEdit.Text = "文件夹的编辑";
            this.chkFolderEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.btnFolderCancel);
            this.groupBox7.Controls.Add(this.btnFolderSubmit);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(3, 414);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(475, 44);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // btnFolderCancel
            // 
            this.btnFolderCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFolderCancel.Location = new System.Drawing.Point(411, 13);
            this.btnFolderCancel.Name = "btnFolderCancel";
            this.btnFolderCancel.Size = new System.Drawing.Size(61, 28);
            this.btnFolderCancel.TabIndex = 1;
            this.btnFolderCancel.Text = "取消";
            this.btnFolderCancel.UseVisualStyleBackColor = true;
            this.btnFolderCancel.Click += new System.EventHandler(this.btnFolderCancel_Click);
            // 
            // btnFolderSubmit
            // 
            this.btnFolderSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFolderSubmit.Location = new System.Drawing.Point(330, 13);
            this.btnFolderSubmit.Name = "btnFolderSubmit";
            this.btnFolderSubmit.Size = new System.Drawing.Size(61, 28);
            this.btnFolderSubmit.TabIndex = 0;
            this.btnFolderSubmit.Text = "提交";
            this.btnFolderSubmit.UseVisualStyleBackColor = true;
            this.btnFolderSubmit.Click += new System.EventHandler(this.btnFolderSubmit_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.trvFolderDir);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(475, 255);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "文件夹";
            // 
            // trvFolderDir
            // 
            this.trvFolderDir.CheckBoxes = true;
            this.trvFolderDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFolderDir.Location = new System.Drawing.Point(3, 17);
            this.trvFolderDir.Name = "trvFolderDir";
            this.trvFolderDir.Size = new System.Drawing.Size(469, 235);
            this.trvFolderDir.TabIndex = 1;
            this.trvFolderDir.Click += new System.EventHandler(this.trvFolderDir_Click);
            // 
            // UserFileAuthFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserFileAuthFrm";
            this.Text = "用户文档权限设定";
            this.Load += new System.EventHandler(this.UserFileAuthFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFile.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).EndInit();
            this.tabFolder.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFileCancel;
        private System.Windows.Forms.Button btnFileSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private HYPDM.BaseControl.DataGridViewExt dGVFileList;
        private System.Windows.Forms.TabPage tabFolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnFolderCancel;
        private System.Windows.Forms.Button btnFolderSubmit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TreeView trvFolderDir;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox chkFolderCreate;
        private System.Windows.Forms.CheckBox chkFolderDelete;
        private System.Windows.Forms.CheckBox chkFolderEdit;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox chkFileUpLoad;
        private System.Windows.Forms.CheckBox chkFileCheckOut;
        private System.Windows.Forms.CheckBox chkFileCheckIn;
        private System.Windows.Forms.CheckBox chkFileDelete;
        private System.Windows.Forms.CheckBox chkFileDownLoad;
        private System.Windows.Forms.CheckBox chkFileEdit;
        private System.Windows.Forms.CheckBox chkFileView;
        private System.Windows.Forms.CheckBox chkUpLoad;
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.CheckBox chkCheckIN;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkDownLoad;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_CHILD_PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_VER_LATEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDATE1;

    }
}