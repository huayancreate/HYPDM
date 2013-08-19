using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using EAS.Configuration;
using System.IO;
using EAS.Services;
using EAS.Modularization;

namespace HYPDM.Res
{
    partial class LoginForm 
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbOffline = new System.Windows.Forms.CheckBox();
            this.chkSmartLogin = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbLoginID = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbOffline);
            this.panel1.Controls.Add(this.chkSmartLogin);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.cmbLoginID);
            this.panel1.Location = new System.Drawing.Point(438, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 153);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::HYPDM.Res.Properties.Resources.pwd;
            this.pictureBox3.Location = new System.Drawing.Point(167, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::HYPDM.Res.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(166, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HYPDM.Res.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cbOffline
            // 
            this.cbOffline.BackColor = System.Drawing.Color.Gray;
            this.cbOffline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbOffline.ForeColor = System.Drawing.Color.Maroon;
            this.cbOffline.Location = new System.Drawing.Point(147, 126);
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.Size = new System.Drawing.Size(70, 24);
            this.cbOffline.TabIndex = 14;
            this.cbOffline.Text = "离线(&S)";
            this.cbOffline.UseVisualStyleBackColor = false;
            this.cbOffline.Visible = false;
            // 
            // chkSmartLogin
            // 
            this.chkSmartLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkSmartLogin.Checked = true;
            this.chkSmartLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSmartLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSmartLogin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSmartLogin.ForeColor = System.Drawing.Color.Yellow;
            this.chkSmartLogin.Location = new System.Drawing.Point(206, 96);
            this.chkSmartLogin.Name = "chkSmartLogin";
            this.chkSmartLogin.Size = new System.Drawing.Size(110, 24);
            this.chkSmartLogin.TabIndex = 13;
            this.chkSmartLogin.Text = "启用智能登录(&S)";
            this.chkSmartLogin.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(345, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DimGray;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(308, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 15;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Moccasin;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(206, 59);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(177, 24);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cmbLoginID
            // 
            this.cmbLoginID.BackColor = System.Drawing.Color.Moccasin;
            this.cmbLoginID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLoginID.Location = new System.Drawing.Point(206, 21);
            this.cmbLoginID.Name = "cmbLoginID";
            this.cmbLoginID.Size = new System.Drawing.Size(177, 24);
            this.cmbLoginID.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HYPDM.Res.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel panel1;
        private CheckBox cbOffline;
        private CheckBox chkSmartLogin;
        private Button btnCancel;
        private Button btnOK;
        private TextBox txtPassword;
        private ComboBox cmbLoginID;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;

    }
}