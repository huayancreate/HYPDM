namespace HYPDM.WinUI.Document
{
    partial class FrmDocumentQuery
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cobFileType = new System.Windows.Forms.ComboBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.Panel1.SuspendLayout();
            this.splitmain.Panel2.SuspendLayout();
            this.splitmain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnClear);
            this.pnl.Controls.Add(this.btnSearch);
            this.pnl.Controls.Add(this.dtpUpdateDate);
            this.pnl.Controls.Add(this.dtpCreateDate);
            this.pnl.Controls.Add(this.txtUpdateUser);
            this.pnl.Controls.Add(this.txtStatus);
            this.pnl.Controls.Add(this.txtDesc);
            this.pnl.Controls.Add(this.cobFileType);
            this.pnl.Controls.Add(this.txtVersion);
            this.pnl.Controls.Add(this.txtDocNo);
            this.pnl.Controls.Add(this.label13);
            this.pnl.Controls.Add(this.label12);
            this.pnl.Controls.Add(this.label9);
            this.pnl.Controls.Add(this.label10);
            this.pnl.Controls.Add(this.label8);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Size = new System.Drawing.Size(785, 142);
            // 
            // splitmain
            // 
            this.splitmain.Size = new System.Drawing.Size(785, 168);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(785, 26);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(702, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 23);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(642, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.CustomFormat = "yyyy-MM-dd";
            this.dtpUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateDate.Location = new System.Drawing.Point(414, 99);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(210, 21);
            this.dtpUpdateDate.TabIndex = 45;
            this.dtpUpdateDate.ValueChanged += new System.EventHandler(this.dtpUpdateDate_ValueChanged);
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.CustomFormat = "yyyy-MM-dd";
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(93, 99);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(210, 21);
            this.dtpCreateDate.TabIndex = 44;
            this.dtpCreateDate.ValueChanged += new System.EventHandler(this.dtpCreateDate_ValueChanged);
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Location = new System.Drawing.Point(414, 72);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(210, 21);
            this.txtUpdateUser.TabIndex = 43;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(93, 72);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(210, 21);
            this.txtStatus.TabIndex = 42;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(414, 45);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 21);
            this.txtDesc.TabIndex = 41;
            // 
            // cobFileType
            // 
            this.cobFileType.FormattingEnabled = true;
            this.cobFileType.Location = new System.Drawing.Point(93, 45);
            this.cobFileType.Name = "cobFileType";
            this.cobFileType.Size = new System.Drawing.Size(210, 20);
            this.cobFileType.TabIndex = 40;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(414, 18);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(210, 21);
            this.txtVersion.TabIndex = 39;
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(93, 19);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(210, 21);
            this.txtDocNo.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "修改日期";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "创建时间";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "修改者";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "描述";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "文档分类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "编号";
            // 
            // FrmDocumentQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 168);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmDocumentQuery";
            this.Text = "文档查询";
            this.Load += new System.EventHandler(this.FrmDocumentQuery_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.splitmain.Panel1.ResumeLayout(false);
            this.splitmain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cobFileType;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}