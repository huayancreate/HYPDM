namespace HYPDM.WinUI.Document
{
    partial class AddFileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFileFrm));
            this.panel_Delete = new System.Windows.Forms.Panel();
            this.panel_Cancel = new System.Windows.Forms.Panel();
            this.panel_OK = new System.Windows.Forms.Panel();
            this.panel_ADD = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Panel();
            this.panel_Exit = new System.Windows.Forms.Panel();
            this.fileList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Dir = new System.Windows.Forms.ListView();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Delete
            // 
            this.panel_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Delete.BackgroundImage")));
            this.panel_Delete.Location = new System.Drawing.Point(87, 220);
            this.panel_Delete.Name = "panel_Delete";
            this.panel_Delete.Size = new System.Drawing.Size(46, 20);
            this.panel_Delete.TabIndex = 11;
            this.panel_Delete.Click += new System.EventHandler(this.panel_Delete_Click);
            // 
            // panel_Cancel
            // 
            this.panel_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Cancel.BackgroundImage")));
            this.panel_Cancel.Location = new System.Drawing.Point(531, 220);
            this.panel_Cancel.Name = "panel_Cancel";
            this.panel_Cancel.Size = new System.Drawing.Size(51, 20);
            this.panel_Cancel.TabIndex = 10;
            this.panel_Cancel.Click += new System.EventHandler(this.panel_Cancel_Click);
            // 
            // panel_OK
            // 
            this.panel_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_OK.BackgroundImage")));
            this.panel_OK.Location = new System.Drawing.Point(467, 220);
            this.panel_OK.Name = "panel_OK";
            this.panel_OK.Size = new System.Drawing.Size(46, 20);
            this.panel_OK.TabIndex = 9;
            this.panel_OK.Click += new System.EventHandler(this.panel_OK_Click);
            // 
            // panel_ADD
            // 
            this.panel_ADD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_ADD.BackgroundImage")));
            this.panel_ADD.Location = new System.Drawing.Point(35, 220);
            this.panel_ADD.Name = "panel_ADD";
            this.panel_ADD.Size = new System.Drawing.Size(46, 20);
            this.panel_ADD.TabIndex = 8;
            this.panel_ADD.Click += new System.EventHandler(this.panel_ADD_Click);
            this.panel_ADD.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ADD_Paint);
            // 
            // panel_Title
            // 
            this.panel_Title.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.W0_Max;
            this.panel_Title.Controls.Add(this.min);
            this.panel_Title.Controls.Add(this.panel_Exit);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(608, 24);
            this.panel_Title.TabIndex = 1;
            // 
            // min
            // 
            this.min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("min.BackgroundImage")));
            this.min.Location = new System.Drawing.Point(584, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(21, 16);
            this.min.TabIndex = 1;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel_Exit
            // 
            this.panel_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Exit.BackgroundImage")));
            this.panel_Exit.Location = new System.Drawing.Point(611, 3);
            this.panel_Exit.Name = "panel_Exit";
            this.panel_Exit.Size = new System.Drawing.Size(21, 16);
            this.panel_Exit.TabIndex = 0;
            this.panel_Exit.Click += new System.EventHandler(this.panel_Exit_Click);
            // 
            // fileList
            // 
            this.fileList.Text = "选择的文件清单";
            this.fileList.Width = 660;
            // 
            // listView_Dir
            // 
            this.listView_Dir.AutoArrange = false;
            this.listView_Dir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileList});
            this.listView_Dir.FullRowSelect = true;
            this.listView_Dir.GridLines = true;
            this.listView_Dir.LabelWrap = false;
            this.listView_Dir.Location = new System.Drawing.Point(12, 50);
            this.listView_Dir.Name = "listView_Dir";
            this.listView_Dir.Size = new System.Drawing.Size(593, 160);
            this.listView_Dir.TabIndex = 12;
            this.listView_Dir.UseCompatibleStateImageBehavior = false;
            this.listView_Dir.View = System.Windows.Forms.View.Details;
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.BackColor = System.Drawing.Color.Transparent;
            this.lblSavePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSavePath.ForeColor = System.Drawing.Color.Yellow;
            this.lblSavePath.Location = new System.Drawing.Point(12, 27);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(160, 16);
            this.lblSavePath.TabIndex = 13;
            this.lblSavePath.Text = "文件将被保存的路径:";
            // 
            // AddFileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.Max_All;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 253);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.listView_Dir);
            this.Controls.Add(this.panel_Delete);
            this.Controls.Add(this.panel_Cancel);
            this.Controls.Add(this.panel_OK);
            this.Controls.Add(this.panel_ADD);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFileFrm";
            this.Text = "CreateNewFileFrm";
            this.Load += new System.EventHandler(this.CreateNewFileFrm_Load);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel min;
        private System.Windows.Forms.Panel panel_Exit;
        private System.Windows.Forms.Panel panel_Delete;
        private System.Windows.Forms.Panel panel_Cancel;
        private System.Windows.Forms.Panel panel_OK;
        private System.Windows.Forms.Panel panel_ADD;
        private System.Windows.Forms.ColumnHeader fileList;
        private System.Windows.Forms.ListView listView_Dir;
        private System.Windows.Forms.Label lblSavePath;
    }
}