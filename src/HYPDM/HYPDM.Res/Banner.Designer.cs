namespace HYPDM.Res
{
    partial class Banner
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPassword = new System.Windows.Forms.LinkLabel();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbPassword.Location = new System.Drawing.Point(920, 21);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 12);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.TabStop = true;
            this.lbPassword.Text = "修改密码";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPassword.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbPassword_LinkClicked);
            // 
            // llLogout
            // 
            this.llLogout.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llLogout.AutoSize = true;
            this.llLogout.BackColor = System.Drawing.Color.Transparent;
            this.llLogout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llLogout.ForeColor = System.Drawing.Color.Blue;
            this.llLogout.Location = new System.Drawing.Point(987, 21);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(29, 12);
            this.llLogout.TabIndex = 9;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "注销";
            this.llLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llLogout.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.llLogout);
            this.Name = "Banner";
            this.Size = new System.Drawing.Size(1024, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbPassword;
        private System.Windows.Forms.LinkLabel llLogout;
    }
}
