namespace HYPDM.WorkSpace.WorkManager
{
    partial class WorkManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkManager));
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsl_delete = new System.Windows.Forms.ToolStripButton();
            this.tsl_export = new System.Windows.Forms.ToolStripButton();
            this.pagination1 = new HYPDM.WinUI.DefineControl.Pagination();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsb_retrive = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(0, 28);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.Size = new System.Drawing.Size(803, 387);
            this.dgv_list.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_delete,
            this.tsl_export,
            this.toolStripButton1,
            this.tsb_retrive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(803, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsl_delete
            // 
            this.tsl_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsl_delete.Image")));
            this.tsl_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_delete.Name = "tsl_delete";
            this.tsl_delete.Size = new System.Drawing.Size(52, 22);
            this.tsl_delete.Text = "删除";
            // 
            // tsl_export
            // 
            this.tsl_export.Image = ((System.Drawing.Image)(resources.GetObject("tsl_export.Image")));
            this.tsl_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_export.Name = "tsl_export";
            this.tsl_export.Size = new System.Drawing.Size(81, 22);
            this.tsl_export.Text = "导出Excel";
            // 
            // pagination1
            // 
            this.pagination1.CurrentPage = 1;
            this.pagination1.CurrentRows = 20;
            this.pagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination1.Location = new System.Drawing.Point(0, 413);
            this.pagination1.Name = "pagination1";
            this.pagination1.QueryCondition = null;
            this.pagination1.Size = new System.Drawing.Size(803, 28);
            this.pagination1.TabIndex = 5;
            this.pagination1.TotalPage = 0;
            this.pagination1.TotalRows = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "查询";
            // 
            // tsb_retrive
            // 
            this.tsb_retrive.Image = ((System.Drawing.Image)(resources.GetObject("tsb_retrive.Image")));
            this.tsb_retrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_retrive.Name = "tsb_retrive";
            this.tsb_retrive.Size = new System.Drawing.Size(52, 22);
            this.tsb_retrive.Text = "回退";
            // 
            // WorkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.toolStrip2);
            this.Name = "WorkManager";
            this.Size = new System.Drawing.Size(803, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinUI.DefineControl.Pagination pagination1;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsl_delete;
        private System.Windows.Forms.ToolStripButton tsl_export;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsb_retrive;
    }
}
