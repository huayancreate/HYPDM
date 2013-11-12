﻿namespace HYPDM.Res
{
    partial class LoginForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.cbOffline = new System.Windows.Forms.CheckBox();
            this.chkSmartLogin = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbLoginID = new System.Windows.Forms.ComboBox();
            this.lblLoginID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::HYPDM.Res.Properties.Resources.华研标志;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(470, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(470, 102);
            this.panelHeader.TabIndex = 4;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.cbOffline);
            this.gbLogin.Controls.Add(this.chkSmartLogin);
            this.gbLogin.Controls.Add(this.btnCancel);
            this.gbLogin.Controls.Add(this.btnOK);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.cmbLoginID);
            this.gbLogin.Controls.Add(this.lblLoginID);
            this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbLogin.Location = new System.Drawing.Point(5, 122);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(460, 154);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "用户登录";
            // 
            // cbOffline
            // 
            this.cbOffline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOffline.Location = new System.Drawing.Point(231, 87);
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.Size = new System.Drawing.Size(70, 24);
            this.cbOffline.TabIndex = 5;
            this.cbOffline.Text = "离线(&S)";
            this.cbOffline.Visible = false;
            // 
            // chkSmartLogin
            // 
            this.chkSmartLogin.Checked = true;
            this.chkSmartLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSmartLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSmartLogin.Location = new System.Drawing.Point(100, 87);
            this.chkSmartLogin.Name = "chkSmartLogin";
            this.chkSmartLogin.Size = new System.Drawing.Size(110, 24);
            this.chkSmartLogin.TabIndex = 4;
            this.chkSmartLogin.Text = "启用智能登录(&S)";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(360, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(280, 116);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 55);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(250, 21);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPassword.Location = new System.Drawing.Point(100, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 12);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "用户密码(&P)：";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLoginID
            // 
            this.cmbLoginID.Location = new System.Drawing.Point(185, 25);
            this.cmbLoginID.Name = "cmbLoginID";
            this.cmbLoginID.Size = new System.Drawing.Size(250, 20);
            this.cmbLoginID.TabIndex = 1;
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLoginID.Location = new System.Drawing.Point(100, 29);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(83, 12);
            this.lblLoginID.TabIndex = 0;
            this.lblLoginID.Text = "用户名称(&N)：";
            this.lblLoginID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 278);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.gbLogin);
            this.Name = "LoginForm2";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.CheckBox cbOffline;
        private System.Windows.Forms.CheckBox chkSmartLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbLoginID;
        private System.Windows.Forms.Label lblLoginID;
    }
}