namespace HYPDM.WinUI.Document
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.cobFileType = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "文档分类";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "描述";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "状态";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "修改者";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "创建时间";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "修改日期";
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(97, 48);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(210, 21);
            this.txtDocNo.TabIndex = 14;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(418, 44);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(210, 21);
            this.txtVersion.TabIndex = 15;
            // 
            // cobFileType
            // 
            this.cobFileType.FormattingEnabled = true;
            this.cobFileType.Location = new System.Drawing.Point(97, 74);
            this.cobFileType.Name = "cobFileType";
            this.cobFileType.Size = new System.Drawing.Size(210, 20);
            this.cobFileType.TabIndex = 20;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(418, 71);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 21);
            this.txtDesc.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(97, 101);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(210, 21);
            this.txtStatus.TabIndex = 22;
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Location = new System.Drawing.Point(418, 98);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(210, 21);
            this.txtUpdateUser.TabIndex = 23;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CustomFormat = "yyyy-MM-dd";
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(97, 128);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(210, 21);
            this.dtpCreateDate.TabIndex = 24;
            this.dtpCreateDate.ValueChanged += new System.EventHandler(this.dtpCreateDate_ValueChanged);
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.CustomFormat = "yyyy-MM-dd";
            this.dtpUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateDate.Location = new System.Drawing.Point(418, 125);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(210, 21);
            this.dtpUpdateDate.TabIndex = 25;
            this.dtpUpdateDate.ValueChanged += new System.EventHandler(this.dtpUpdateDate_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(519, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(579, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 166);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpUpdateDate);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.txtUpdateUser);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cobFileType);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.ComboBox cobFileType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}