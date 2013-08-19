namespace FileSockClient
{
    partial class FrmSocketClient
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
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnOPen = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDownFile = new System.Windows.Forms.Button();
            this.txtDownLoad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(535, 32);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(75, 23);
            this.btnUploadFile.TabIndex = 5;
            this.btnUploadFile.Text = "文件上传";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnOPen
            // 
            this.btnOPen.Location = new System.Drawing.Point(440, 33);
            this.btnOPen.Name = "btnOPen";
            this.btnOPen.Size = new System.Drawing.Size(92, 23);
            this.btnOPen.TabIndex = 4;
            this.btnOPen.Text = "文件选择...";
            this.btnOPen.UseVisualStyleBackColor = true;
            this.btnOPen.Click += new System.EventHandler(this.btnOPen_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(17, 33);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(417, 21);
            this.txtFilePath.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(623, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDownFile
            // 
            this.btnDownFile.Location = new System.Drawing.Point(440, 73);
            this.btnDownFile.Name = "btnDownFile";
            this.btnDownFile.Size = new System.Drawing.Size(92, 23);
            this.btnDownFile.TabIndex = 7;
            this.btnDownFile.Text = "文件下载";
            this.btnDownFile.UseVisualStyleBackColor = true;
            this.btnDownFile.Click += new System.EventHandler(this.btnDownFile_Click);
            // 
            // txtDownLoad
            // 
            this.txtDownLoad.Location = new System.Drawing.Point(17, 75);
            this.txtDownLoad.Name = "txtDownLoad";
            this.txtDownLoad.Size = new System.Drawing.Size(417, 21);
            this.txtDownLoad.TabIndex = 8;
            this.txtDownLoad.Text = "D:\\\\SocketUploadFile\\\\";
            // 
            // FrmSocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 129);
            this.Controls.Add(this.txtDownLoad);
            this.Controls.Add(this.btnDownFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnOPen);
            this.Controls.Add(this.txtFilePath);
            this.MaximizeBox = false;
            this.Name = "FrmSocketClient";
            this.Text = "FrmSocketClient";
            this.Load += new System.EventHandler(this.FrmSocketClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnOPen;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDownFile;
        private System.Windows.Forms.TextBox txtDownLoad;

    }
}