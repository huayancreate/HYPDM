namespace HYDocumentMS
{
    partial class CreateNewFolderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewFolderFrm));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Panel();
            this.panel_Exit = new System.Windows.Forms.Panel();
            this.label_Name = new System.Windows.Forms.Label();
            this.txtNewFolder = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastFolder = new System.Windows.Forms.TextBox();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackgroundImage = global::HYDocumentMS.Properties.Resources.Folder;
            this.panel_Title.Controls.Add(this.min);
            this.panel_Title.Controls.Add(this.panel_Exit);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(319, 24);
            this.panel_Title.TabIndex = 1;
            // 
            // min
            // 
            this.min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min.BackgroundImage")));
            this.min.Location = new System.Drawing.Point(266, 4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(21, 16);
            this.min.TabIndex = 3;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel_Exit
            // 
            this.panel_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Exit.BackgroundImage")));
            this.panel_Exit.Location = new System.Drawing.Point(293, 4);
            this.panel_Exit.Name = "panel_Exit";
            this.panel_Exit.Size = new System.Drawing.Size(21, 16);
            this.panel_Exit.TabIndex = 2;
            this.panel_Exit.Click += new System.EventHandler(this.panel_Exit_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name.Location = new System.Drawing.Point(9, 87);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 12);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "添加文件夹";
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.Location = new System.Drawing.Point(80, 82);
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.Size = new System.Drawing.Size(221, 21);
            this.txtNewFolder.TabIndex = 6;
            this.txtNewFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewFolder_KeyPress);
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
            this.Cancel.Location = new System.Drawing.Point(225, 123);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(48, 20);
            this.Cancel.TabIndex = 5;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Cancel.Paint += new System.Windows.Forms.PaintEventHandler(this.Cancel_Paint);
            // 
            // OK
            // 
            this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
            this.OK.Location = new System.Drawing.Point(158, 123);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(48, 20);
            this.OK.TabIndex = 4;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.OK.Paint += new System.Windows.Forms.PaintEventHandler(this.OK_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "上级目录";
            // 
            // txtLastFolder
            // 
            this.txtLastFolder.Location = new System.Drawing.Point(77, 35);
            this.txtLastFolder.Multiline = true;
            this.txtLastFolder.Name = "txtLastFolder";
            this.txtLastFolder.ReadOnly = true;
            this.txtLastFolder.Size = new System.Drawing.Size(224, 41);
            this.txtLastFolder.TabIndex = 8;
            // 
            // CreateNewFolderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HYDocumentMS.Properties.Resources.Min_All;
            this.ClientSize = new System.Drawing.Size(319, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastFolder);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.txtNewFolder);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateNewFolderFrm";
            this.Text = "CreateNewFolderFrm";
            this.Load += new System.EventHandler(this.CreateNewFolderFrm_Load);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox txtNewFolder;
        private System.Windows.Forms.Panel Cancel;
        private System.Windows.Forms.Panel OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastFolder;
        private System.Windows.Forms.Panel min;
        private System.Windows.Forms.Panel panel_Exit;
    }
}