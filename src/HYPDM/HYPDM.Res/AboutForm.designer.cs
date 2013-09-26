using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EAS.Modularization;

namespace HYPDM.Res
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lbVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLicence = new System.Windows.Forms.Label();
            this.lblRegUserTip = new System.Windows.Forms.Label();
            this.llDeveloper = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.ForeColor = System.Drawing.Color.Black;
            this.lbVersion.Location = new System.Drawing.Point(96, 122);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(23, 12);
            this.lbVersion.TabIndex = 48;
            this.lbVersion.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "版    本：";
            // 
            // lbLicence
            // 
            this.lbLicence.AutoSize = true;
            this.lbLicence.BackColor = System.Drawing.Color.Transparent;
            this.lbLicence.ForeColor = System.Drawing.Color.Black;
            this.lbLicence.Location = new System.Drawing.Point(96, 145);
            this.lbLicence.Name = "lbLicence";
            this.lbLicence.Size = new System.Drawing.Size(0, 12);
            this.lbLicence.TabIndex = 46;
            // 
            // lblRegUserTip
            // 
            this.lblRegUserTip.AutoSize = true;
            this.lblRegUserTip.BackColor = System.Drawing.Color.Transparent;
            this.lblRegUserTip.Location = new System.Drawing.Point(36, 145);
            this.lblRegUserTip.Name = "lblRegUserTip";
            this.lblRegUserTip.Size = new System.Drawing.Size(65, 12);
            this.lblRegUserTip.TabIndex = 45;
            this.lblRegUserTip.Text = "授权用户：";
            // 
            // llDeveloper
            // 
            this.llDeveloper.AutoSize = true;
            this.llDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.llDeveloper.Location = new System.Drawing.Point(36, 273);
            this.llDeveloper.Name = "llDeveloper";
            this.llDeveloper.Size = new System.Drawing.Size(161, 12);
            this.llDeveloper.TabIndex = 44;
            this.llDeveloper.TabStop = true;
            this.llDeveloper.Text = "Copyright(C) 2013-2023  HY";
            this.llDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDeveloper_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(383, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "确定(&O)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(36, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 1);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(469, 102);
            this.panelHeader.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(169, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "http://www.huayancreate.com/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("宋体", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "安徽华研PDM项目";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(470, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(36, 167);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(420, 80);
            this.webBrowser.TabIndex = 49;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // AboutForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(469, 299);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLicence);
            this.Controls.Add(this.lblRegUserTip);
            this.Controls.Add(this.llDeveloper);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLicence;
        private System.Windows.Forms.Label lblRegUserTip;
        private System.Windows.Forms.LinkLabel llDeveloper;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private WebBrowser webBrowser;
        private Label label2;
        private Label label3;
    }
}