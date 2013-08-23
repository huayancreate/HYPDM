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
            this.tabFolder = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.chkCheckIN = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkDownLoad = new System.Windows.Forms.CheckBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.chkView = new System.Windows.Forms.CheckBox();
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
            this.CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkUpLoad = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnFolderCancel = new System.Windows.Forms.Button();
            this.btnFolderSubmit = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.trvFolderDir = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.tabFolder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.chkUpLoad);
            this.panel1.Controls.Add(this.chkCheckOut);
            this.panel1.Controls.Add(this.chkCheckIN);
            this.panel1.Controls.Add(this.chkDelete);
            this.panel1.Controls.Add(this.chkDownLoad);
            this.panel1.Controls.Add(this.chkEdit);
            this.panel1.Controls.Add(this.chkView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 81);
            this.panel1.TabIndex = 0;
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(253, 53);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(72, 16);
            this.chkCheckOut.TabIndex = 11;
            this.chkCheckOut.Text = "文件检出";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkCheckIN
            // 
            this.chkCheckIN.AutoSize = true;
            this.chkCheckIN.Location = new System.Drawing.Point(144, 53);
            this.chkCheckIN.Name = "chkCheckIN";
            this.chkCheckIN.Size = new System.Drawing.Size(72, 16);
            this.chkCheckIN.TabIndex = 10;
            this.chkCheckIN.Text = "文件检入";
            this.chkCheckIN.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(41, 53);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(72, 16);
            this.chkDelete.TabIndex = 9;
            this.chkDelete.Text = "文件删除";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkDownLoad
            // 
            this.chkDownLoad.AutoSize = true;
            this.chkDownLoad.Location = new System.Drawing.Point(253, 18);
            this.chkDownLoad.Name = "chkDownLoad";
            this.chkDownLoad.Size = new System.Drawing.Size(72, 16);
            this.chkDownLoad.TabIndex = 8;
            this.chkDownLoad.Text = "文件下载";
            this.chkDownLoad.UseVisualStyleBackColor = true;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(144, 18);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(72, 16);
            this.chkEdit.TabIndex = 7;
            this.chkEdit.Text = "文件编辑";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(41, 18);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(72, 16);
            this.chkView.TabIndex = 6;
            this.chkView.Text = "文件查看";
            this.chkView.UseVisualStyleBackColor = true;
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
            this.CREATEDATE});
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
            this.dGVFileList.Size = new System.Drawing.Size(469, 263);
            this.dGVFileList.TabIndex = 2;
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
            // CREATEDATE
            // 
            this.CREATEDATE.DataPropertyName = "CREATEDATE";
            this.CREATEDATE.HeaderText = "创建日期";
            this.CREATEDATE.Name = "CREATEDATE";
            // 
            // chkUpLoad
            // 
            this.chkUpLoad.AutoSize = true;
            this.chkUpLoad.Location = new System.Drawing.Point(335, 17);
            this.chkUpLoad.Name = "chkUpLoad";
            this.chkUpLoad.Size = new System.Drawing.Size(72, 16);
            this.chkUpLoad.TabIndex = 12;
            this.chkUpLoad.Text = "文件上传";
            this.chkUpLoad.UseVisualStyleBackColor = true;
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
            this.groupBox6.Location = new System.Drawing.Point(3, 300);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(475, 101);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "功能选项";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 81);
            this.panel2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "文件上传";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(253, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "文件检出";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(144, 53);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 16);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "文件检入";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(41, 53);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 16);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "文件删除";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(253, 18);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 16);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "文件下载";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(144, 18);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 16);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "文件编辑";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(41, 18);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 16);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "文件查看";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.btnFolderCancel);
            this.groupBox7.Controls.Add(this.btnFolderSubmit);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(3, 401);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(475, 57);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // btnFolderCancel
            // 
            this.btnFolderCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFolderCancel.Location = new System.Drawing.Point(414, 20);
            this.btnFolderCancel.Name = "btnFolderCancel";
            this.btnFolderCancel.Size = new System.Drawing.Size(61, 28);
            this.btnFolderCancel.TabIndex = 1;
            this.btnFolderCancel.Text = "取消";
            this.btnFolderCancel.UseVisualStyleBackColor = true;
            // 
            // btnFolderSubmit
            // 
            this.btnFolderSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFolderSubmit.Location = new System.Drawing.Point(333, 20);
            this.btnFolderSubmit.Name = "btnFolderSubmit";
            this.btnFolderSubmit.Size = new System.Drawing.Size(61, 28);
            this.btnFolderSubmit.TabIndex = 0;
            this.btnFolderSubmit.Text = "提交";
            this.btnFolderSubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.trvFolderDir);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(475, 283);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "文件夹";
            // 
            // trvFolderDir
            // 
            this.trvFolderDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvFolderDir.Location = new System.Drawing.Point(3, 17);
            this.trvFolderDir.Name = "trvFolderDir";
            this.trvFolderDir.Size = new System.Drawing.Size(469, 263);
            this.trvFolderDir.TabIndex = 1;
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
            this.tabFolder.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.CheckBox chkCheckIN;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkDownLoad;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFileCancel;
        private System.Windows.Forms.Button btnFileSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private HYPDM.BaseControl.DataGridViewExt dGVFileList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_CHILD_PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_VER_LATEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDATE;
        private System.Windows.Forms.TabPage tabFolder;
        private System.Windows.Forms.CheckBox chkUpLoad;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnFolderCancel;
        private System.Windows.Forms.Button btnFolderSubmit;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TreeView trvFolderDir;

    }
}