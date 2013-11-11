namespace HYPDM.WinUI.BaseUI
{
    partial class BaseDetectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDetectionForm));
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkFileTransfer = new System.Windows.Forms.CheckBox();
            this.chkCheckOut = new System.Windows.Forms.CheckBox();
            this.chkOpenFile = new System.Windows.Forms.CheckBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(77, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(318, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(77, 45);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(237, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "文件路径";
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(239, 123);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(75, 23);
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "检出";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 123);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkFileTransfer
            // 
            this.chkFileTransfer.AutoSize = true;
            this.chkFileTransfer.Location = new System.Drawing.Point(77, 84);
            this.chkFileTransfer.Name = "chkFileTransfer";
            this.chkFileTransfer.Size = new System.Drawing.Size(72, 16);
            this.chkFileTransfer.TabIndex = 4;
            this.chkFileTransfer.Text = "文件传输";
            this.chkFileTransfer.UseVisualStyleBackColor = true;
            // 
            // chkCheckOut
            // 
            this.chkCheckOut.AutoSize = true;
            this.chkCheckOut.Location = new System.Drawing.Point(155, 84);
            this.chkCheckOut.Name = "chkCheckOut";
            this.chkCheckOut.Size = new System.Drawing.Size(48, 16);
            this.chkCheckOut.TabIndex = 5;
            this.chkCheckOut.Text = "检出";
            this.chkCheckOut.UseVisualStyleBackColor = true;
            // 
            // chkOpenFile
            // 
            this.chkOpenFile.AutoSize = true;
            this.chkOpenFile.Location = new System.Drawing.Point(215, 84);
            this.chkOpenFile.Name = "chkOpenFile";
            this.chkOpenFile.Size = new System.Drawing.Size(72, 16);
            this.chkOpenFile.TabIndex = 6;
            this.chkOpenFile.Text = "执行应用";
            this.chkOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(320, 43);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "选择路径";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // BaseDetectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 157);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.chkOpenFile);
            this.Controls.Add(this.chkCheckOut);
            this.Controls.Add(this.chkFileTransfer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseDetectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkFileTransfer;
        private System.Windows.Forms.CheckBox chkCheckOut;
        private System.Windows.Forms.CheckBox chkOpenFile;
        private System.Windows.Forms.Button btnSelectPath;
    }
}