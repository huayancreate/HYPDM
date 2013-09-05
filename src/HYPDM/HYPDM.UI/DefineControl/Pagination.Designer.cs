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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagination));
            this.ts_Page_ProductToolBar = new System.Windows.Forms.ToolStrip();
            this.page_RowsNum = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tool_firstPage = new System.Windows.Forms.ToolStripButton();
            this.tool_prePage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.page_CurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.tsl_memoFirst = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tool_nextPage = new System.Windows.Forms.ToolStripButton();
            this.tool_lastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tsl_memoTwo = new System.Windows.Forms.ToolStripLabel();
            this.ts_Page_ProductToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Page_ProductToolBar
            // 
            this.ts_Page_ProductToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_Page_ProductToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Page_ProductToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.page_RowsNum,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.tool_firstPage,
            this.tool_prePage,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.page_CurrentPage,
            this.tsl_memoFirst,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.tool_nextPage,
            this.tool_lastPage,
            this.toolStripSeparator4,
            this.toolStripLabel7,
            this.tsl_memoTwo});
            this.ts_Page_ProductToolBar.Location = new System.Drawing.Point(0, 1);
            this.ts_Page_ProductToolBar.Name = "ts_Page_ProductToolBar";
            this.ts_Page_ProductToolBar.Size = new System.Drawing.Size(595, 25);
            this.ts_Page_ProductToolBar.TabIndex = 4;
            this.ts_Page_ProductToolBar.Text = "toolStrip1";
            // 
            // page_RowsNum
            // 
            this.page_RowsNum.AutoSize = false;
            this.page_RowsNum.BackColor = System.Drawing.SystemColors.Window;
            this.page_RowsNum.CausesValidation = false;
            this.page_RowsNum.DropDownWidth = 50;
            this.page_RowsNum.Font = new System.Drawing.Font("新宋体", 9F);
            this.page_RowsNum.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.page_RowsNum.MaxLength = 10;
            this.page_RowsNum.Name = "page_RowsNum";
            this.page_RowsNum.Size = new System.Drawing.Size(35, 20);
            this.page_RowsNum.TextChanged += new System.EventHandler(this.pageRowsCtrl_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoToolTip = true;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel2.ToolTipText = "第一页";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoToolTip = true;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel3.ToolTipText = "前一页";
            // 
            // tool_firstPage
            // 
            this.tool_firstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_firstPage.Image = ((System.Drawing.Image)(resources.GetObject("tool_firstPage.Image")));
            this.tool_firstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_firstPage.Name = "tool_firstPage";
            this.tool_firstPage.Size = new System.Drawing.Size(23, 22);
            this.tool_firstPage.Text = "第一页";
            this.tool_firstPage.ToolTipText = "第一页";
            this.tool_firstPage.Click += new System.EventHandler(this.tool_firstPage_Click);
            // 
            // tool_prePage
            // 
            this.tool_prePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_prePage.Image = ((System.Drawing.Image)(resources.GetObject("tool_prePage.Image")));
            this.tool_prePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_prePage.Name = "tool_prePage";
            this.tool_prePage.Size = new System.Drawing.Size(23, 22);
            this.tool_prePage.Text = "上一页";
            this.tool_prePage.ToolTipText = "上一页";
            this.tool_prePage.Click += new System.EventHandler(this.tool_prePage_Click);
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
            // page_CurrentPage
            // 
            this.page_CurrentPage.AutoSize = false;
            this.page_CurrentPage.BackColor = System.Drawing.SystemColors.Window;
            this.page_CurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.page_CurrentPage.Name = "page_CurrentPage";
            this.page_CurrentPage.Size = new System.Drawing.Size(30, 23);
            this.page_CurrentPage.Text = "100";
            this.page_CurrentPage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pageNumCtrl_KeyUp);
            // 
            // tsl_memoFirst
            // 
            this.tsl_memoFirst.Name = "tsl_memoFirst";
            this.tsl_memoFirst.Size = new System.Drawing.Size(64, 22);
            this.tsl_memoFirst.Text = "页/共{0}页";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.AutoToolTip = true;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel4.ToolTipText = "下一页";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.AutoToolTip = true;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel5.ToolTipText = "最后一页";
            // 
            // tool_nextPage
            // 
            this.tool_nextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_nextPage.Image = ((System.Drawing.Image)(resources.GetObject("tool_nextPage.Image")));
            this.tool_nextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_nextPage.Name = "tool_nextPage";
            this.tool_nextPage.Size = new System.Drawing.Size(23, 22);
            this.tool_nextPage.Text = "下一页";
            this.tool_nextPage.Click += new System.EventHandler(this.tool_nextPage_Click);
            // 
            // tool_lastPage
            // 
            this.tool_lastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_lastPage.Image = ((System.Drawing.Image)(resources.GetObject("tool_lastPage.Image")));
            this.tool_lastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_lastPage.Name = "tool_lastPage";
            this.tool_lastPage.Size = new System.Drawing.Size(23, 22);
            this.tool_lastPage.Text = "最后一页";
            this.tool_lastPage.Click += new System.EventHandler(this.tool_lastPage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.AutoToolTip = true;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel7.ToolTipText = "重新加载";
            this.toolStripLabel7.Visible = false;
            // 
            // tsl_memoTwo
            // 
            this.tsl_memoTwo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_memoTwo.Name = "tsl_memoTwo";
            this.tsl_memoTwo.Size = new System.Drawing.Size(183, 22);
            this.tsl_memoTwo.Text = "显示第{0}-{1}条记录/共{2}条记录";
            this.tsl_memoTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
        private System.Windows.Forms.ToolStripComboBox page_RowsNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel tsl_memoTwo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox page_CurrentPage;
        private System.Windows.Forms.ToolStripLabel tsl_memoFirst;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tool_firstPage;
        private System.Windows.Forms.ToolStripButton tool_prePage;
        private System.Windows.Forms.ToolStripButton tool_nextPage;
        private System.Windows.Forms.ToolStripButton tool_lastPage;

    }
}
