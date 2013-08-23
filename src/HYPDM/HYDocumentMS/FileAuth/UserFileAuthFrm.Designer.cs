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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.chkCheckIN = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkDownLoad = new System.Windows.Forms.CheckBox();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dGVFileList = new HYPDM.BaseControl.DataGridViewExt();
            this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DFL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_FILE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_FILE_CHILD_PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_VER_LATEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 133);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "功能选项";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dGVFileList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件清单";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkCheckOut);
            this.panel1.Controls.Add(this.chkCheckIN);
            this.panel1.Controls.Add(this.chkDelete);
            this.panel1.Controls.Add(this.chkDownLoad);
            this.panel1.Controls.Add(this.chkEdit);
            this.panel1.Controls.Add(this.chkView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 113);
            this.panel1.TabIndex = 0;
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(296, 61);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(72, 16);
            this.chkCheckOut.TabIndex = 11;
            this.chkCheckOut.Text = "文件检出";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkCheckIN
            // 
            this.chkCheckIN.AutoSize = true;
            this.chkCheckIN.Location = new System.Drawing.Point(187, 61);
            this.chkCheckIN.Name = "chkCheckIN";
            this.chkCheckIN.Size = new System.Drawing.Size(72, 16);
            this.chkCheckIN.TabIndex = 10;
            this.chkCheckIN.Text = "文件检入";
            this.chkCheckIN.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(84, 61);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(72, 16);
            this.chkDelete.TabIndex = 9;
            this.chkDelete.Text = "文件删除";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkDownLoad
            // 
            this.chkDownLoad.AutoSize = true;
            this.chkDownLoad.Location = new System.Drawing.Point(296, 26);
            this.chkDownLoad.Name = "chkDownLoad";
            this.chkDownLoad.Size = new System.Drawing.Size(72, 16);
            this.chkDownLoad.TabIndex = 8;
            this.chkDownLoad.Text = "文件下载";
            this.chkDownLoad.UseVisualStyleBackColor = true;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(187, 26);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(72, 16);
            this.chkEdit.TabIndex = 7;
            this.chkEdit.Text = "文件编辑";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(84, 26);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(72, 16);
            this.chkView.TabIndex = 6;
            this.chkView.Text = "文件查看";
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubmit.Location = new System.Drawing.Point(333, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(61, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(414, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.dGVFileList.Size = new System.Drawing.Size(483, 263);
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
            // UserFileAuthFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 493);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserFileAuthFrm";
            this.Text = "用户文档权限设定";
            this.Load += new System.EventHandler(this.UserFileAuthFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.CheckBox chkCheckIN;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkDownLoad;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private HYPDM.BaseControl.DataGridViewExt dGVFileList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_FILE_CHILD_PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_VER_LATEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDATE;
    }
}