namespace FileSockClient
{
    partial class FrmWait
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
            this.lblMSg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMSg
            // 
            this.lblMSg.AutoSize = true;
            this.lblMSg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMSg.ForeColor = System.Drawing.Color.Red;
            this.lblMSg.Location = new System.Drawing.Point(1, 8);
            this.lblMSg.Name = "lblMSg";
            this.lblMSg.Size = new System.Drawing.Size(225, 16);
            this.lblMSg.TabIndex = 0;
            this.lblMSg.Text = "文件上传中,请稍等........";
            // 
            // FrmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 32);
            this.ControlBox = false;
            this.Controls.Add(this.lblMSg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWait";
            this.Text = "FrmWait";
            this.Load += new System.EventHandler(this.FrmWait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSg;

    }
}