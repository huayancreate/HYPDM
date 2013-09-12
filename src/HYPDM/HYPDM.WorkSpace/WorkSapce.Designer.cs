namespace HYPDM.WorkSpace
{
    partial class WorkSapce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSapce));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_navigator = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsl_addNode = new System.Windows.Forms.ToolStripButton();
            this.tsb_del = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsl_test = new System.Windows.Forms.ToolStripButton();
            this.cms_MyFloderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_Del = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cms_MyFloderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_navigator);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "MainPanel";
            this.splitContainer1.Size = new System.Drawing.Size(871, 494);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_navigator
            // 
            this.tv_navigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_navigator.ImageIndex = 0;
            this.tv_navigator.ImageList = this.imageList1;
            this.tv_navigator.Location = new System.Drawing.Point(0, 25);
            this.tv_navigator.Name = "tv_navigator";
            this.tv_navigator.SelectedImageIndex = 0;
            this.tv_navigator.Size = new System.Drawing.Size(198, 469);
            this.tv_navigator.StateImageList = this.imageList1;
            this.tv_navigator.TabIndex = 2;
            this.tv_navigator.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_navigator_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_add.png");
            this.imageList1.Images.SetKeyName(1, "edit_remove.png");
            this.imageList1.Images.SetKeyName(2, "pagination_first.gif");
            this.imageList1.Images.SetKeyName(3, "pagination_last.gif");
            this.imageList1.Images.SetKeyName(4, "pagination_load.png");
            this.imageList1.Images.SetKeyName(5, "pagination_loading.gif");
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsl_addNode,
            this.tsb_del,
            this.tsb_modify,
            this.tsl_test});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(198, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "导航栏";
            // 
            // tsl_addNode
            // 
            this.tsl_addNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsl_addNode.Image = ((System.Drawing.Image)(resources.GetObject("tsl_addNode.Image")));
            this.tsl_addNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_addNode.Name = "tsl_addNode";
            this.tsl_addNode.Size = new System.Drawing.Size(23, 22);
            this.tsl_addNode.Text = "toolStripButton1";
            this.tsl_addNode.Click += new System.EventHandler(this.tsl_addNode_Click);
            // 
            // tsb_del
            // 
            this.tsb_del.Image = ((System.Drawing.Image)(resources.GetObject("tsb_del.Image")));
            this.tsb_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_del.Name = "tsb_del";
            this.tsb_del.Size = new System.Drawing.Size(23, 22);
            this.tsb_del.Click += new System.EventHandler(this.tsb_del_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(23, 22);
            this.tsb_modify.Click += new System.EventHandler(this.tsb_modify_Click);
            // 
            // tsl_test
            // 
            this.tsl_test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsl_test.Image = ((System.Drawing.Image)(resources.GetObject("tsl_test.Image")));
            this.tsl_test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_test.Name = "tsl_test";
            this.tsl_test.Size = new System.Drawing.Size(23, 22);
            this.tsl_test.Text = "测试";
            this.tsl_test.Click += new System.EventHandler(this.tsl_test_Click);
            // 
            // cms_MyFloderMenu
            // 
            this.cms_MyFloderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_New,
            this.tsm_copy,
            this.toolStripSeparator1,
            this.tsm_Del});
            this.cms_MyFloderMenu.Name = "MyFloderMenu";
            this.cms_MyFloderMenu.Size = new System.Drawing.Size(153, 98);
            // 
            // tsmi_New
            // 
            this.tsmi_New.Name = "tsmi_New";
            this.tsmi_New.Size = new System.Drawing.Size(152, 22);
            this.tsmi_New.Text = "新建文件夹";
            this.tsmi_New.Click += new System.EventHandler(this.tsmi_New_Click);
            // 
            // tsm_copy
            // 
            this.tsm_copy.Name = "tsm_copy";
            this.tsm_copy.Size = new System.Drawing.Size(152, 22);
            this.tsm_copy.Text = "复制";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsm_Del
            // 
            this.tsm_Del.Name = "tsm_Del";
            this.tsm_Del.Size = new System.Drawing.Size(152, 22);
            this.tsm_Del.Text = "删除";
            this.tsm_Del.Click += new System.EventHandler(this.tsm_Del_Click);
            // 
            // WorkSapce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "WorkSapce";
            this.Size = new System.Drawing.Size(871, 494);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cms_MyFloderMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView tv_navigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip cms_MyFloderMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_New;
        private System.Windows.Forms.ToolStripMenuItem tsm_copy;
        private System.Windows.Forms.ToolStripButton tsl_addNode;
        private System.Windows.Forms.ToolStripButton tsb_del;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsl_test;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Del;
    }
}
