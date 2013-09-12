namespace HYPDM.WinUI.DefineControl
{
    partial class Pagination
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
            this.ts_Page_ProductToolBar = new System.Windows.Forms.ToolStrip();
            this.pageRowsCtrl = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pageNumCtrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.ts_Page_ProductToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Page_ProductToolBar
            // 
            this.ts_Page_ProductToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_Page_ProductToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Page_ProductToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageRowsCtrl,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.pageNumCtrl,
            this.toolStripLabel9,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.toolStripSeparator4,
            this.toolStripLabel7,
            this.toolStripSeparator5,
            this.toolStripLabel6});
            this.ts_Page_ProductToolBar.Location = new System.Drawing.Point(0, 1);
            this.ts_Page_ProductToolBar.Name = "ts_Page_ProductToolBar";
            this.ts_Page_ProductToolBar.Size = new System.Drawing.Size(595, 25);
            this.ts_Page_ProductToolBar.TabIndex = 4;
            this.ts_Page_ProductToolBar.Text = "toolStrip1";
            // 
            // pageRowsCtrl
            // 
            this.pageRowsCtrl.AutoSize = false;
            this.pageRowsCtrl.BackColor = System.Drawing.SystemColors.Window;
            this.pageRowsCtrl.CausesValidation = false;
            this.pageRowsCtrl.DropDownWidth = 50;
            this.pageRowsCtrl.Font = new System.Drawing.Font("新宋体", 9F);
            this.pageRowsCtrl.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.pageRowsCtrl.MaxLength = 10;
            this.pageRowsCtrl.Name = "pageRowsCtrl";
            this.pageRowsCtrl.Size = new System.Drawing.Size(35, 20);
            this.pageRowsCtrl.Text = "20";
            this.pageRowsCtrl.TextChanged += new System.EventHandler(this.pageRowsCtrl_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoToolTip = true;
           // this.toolStripLabel2.Image = global::HYPDM.WinUI.Properties.Resources.pagination_first;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel2.ToolTipText = "第一页";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoToolTip = true;
           // this.toolStripLabel3.Image = global::HYPDM.WinUI.Properties.Resources.pagination_prev;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel3.ToolTipText = "前一页";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "当前第";
            // 
            // pageNumCtrl
            // 
            this.pageNumCtrl.AutoSize = false;
            this.pageNumCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.pageNumCtrl.Name = "pageNumCtrl";
            this.pageNumCtrl.Size = new System.Drawing.Size(30, 23);
            this.pageNumCtrl.Text = "100";
            this.pageNumCtrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pageNumCtrl_KeyUp);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel9.Text = "页/共{0}页";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoToolTip = true;
            //this.toolStripLabel4.Image = global::HYPDM.WinUI.Properties.Resources.pagination_next;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel4.ToolTipText = "下一页";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.AutoToolTip = true;
            //this.toolStripLabel5.Image = global::HYPDM.WinUI.Properties.Resources.pagination_last;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel5.ToolTipText = "最后一页";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.AutoToolTip = true;
           // this.toolStripLabel7.Image = global::HYPDM.WinUI.Properties.Resources.pagination_load;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel7.ToolTipText = "重新加载";
            this.toolStripLabel7.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(159, 22);
            this.toolStripLabel6.Text = "显示{0}-{1}的记录/共{2}记录";
            this.toolStripLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ts_Page_ProductToolBar);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(595, 26);
            this.ts_Page_ProductToolBar.ResumeLayout(false);
            this.ts_Page_ProductToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_Page_ProductToolBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox pageRowsCtrl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox pageNumCtrl;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}
