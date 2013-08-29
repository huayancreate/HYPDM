namespace HYPDM.Res
{
    partial class NavigationControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationControl));
            this.Tree = new System.Windows.Forms.TreeView();
            this.imageTree2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.Color.LightCyan;
            this.Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree.ImageIndex = 0;
            this.Tree.ImageList = this.imageTree2;
            this.Tree.Location = new System.Drawing.Point(0, 0);
            this.Tree.Name = "Tree";
            this.Tree.SelectedImageIndex = 0;
            this.Tree.Size = new System.Drawing.Size(200, 400);
            this.Tree.TabIndex = 1;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            this.Tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tree_MouseDown);
            // 
            // imageTree2
            // 
            this.imageTree2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTree2.ImageStream")));
            this.imageTree2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageTree2.Images.SetKeyName(0, "folder_closed_ii.ico");
            this.imageTree2.Images.SetKeyName(1, "desktop.ico");
            this.imageTree2.Images.SetKeyName(2, "closed_floder.ico");
            this.imageTree2.Images.SetKeyName(3, "calendar.ico");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_close2.ico");
            this.imageList1.Images.SetKeyName(1, "folder_open.ico");
            this.imageList1.Images.SetKeyName(2, "closed_floder.ico");
            this.imageList1.Images.SetKeyName(3, "folder2.ico");
            this.imageList1.Images.SetKeyName(4, "opened_folder2.ico");
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册ToolStripMenuItem,
            this.权限ToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(101, 48);
            this.contextMenu.Click += new System.EventHandler(this.contextMenu_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDoc});
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.注册ToolStripMenuItem.Text = "注册";
            // 
            // addNewDoc
            // 
            this.addNewDoc.Name = "addNewDoc";
            this.addNewDoc.Size = new System.Drawing.Size(152, 22);
            this.addNewDoc.Text = "创建新对象";
            this.addNewDoc.Click += new System.EventHandler(this.addNewDoc_Click);
            // 
            // 权限ToolStripMenuItem
            // 
            this.权限ToolStripMenuItem.Name = "权限ToolStripMenuItem";
            this.权限ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.权限ToolStripMenuItem.Text = "权限";
            this.权限ToolStripMenuItem.Click += new System.EventHandler(this.权限ToolStripMenuItem_Click);
            // 
            // NavigationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tree);
            this.Name = "NavigationControl";
            this.Size = new System.Drawing.Size(200, 400);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageTree2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDoc;
    }
}
