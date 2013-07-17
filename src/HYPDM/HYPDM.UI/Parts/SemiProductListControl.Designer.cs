namespace HYPDM.WinUI.Parts
{
    partial class PartsListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsListControl));
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProToAdd = new System.Windows.Forms.ToolStripButton();
            this.btnProProperty = new System.Windows.Forms.ToolStripButton();
            this.btnProDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvPartsList = new System.Windows.Forms.DataGridView();
            this.PartsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTSNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTUPDATEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnProToAdd,
            this.btnProProperty,
            this.btnProDelete,
            this.toolStripSeparator1,
            this.btnPrint});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsToolbar.Size = new System.Drawing.Size(840, 25);
            this.tsToolbar.TabIndex = 5;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnProToAdd
            // 
            this.btnProToAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnProToAdd.Image")));
            this.btnProToAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProToAdd.Name = "btnProToAdd";
            this.btnProToAdd.Size = new System.Drawing.Size(73, 22);
            this.btnProToAdd.Text = "记录添加";
            this.btnProToAdd.ToolTipText = "添加一个新的基础数据记录。";
            this.btnProToAdd.Click += new System.EventHandler(this.btnProToAdd_Click);
            // 
            // btnProProperty
            // 
            this.btnProProperty.Image = ((System.Drawing.Image)(resources.GetObject("btnProProperty.Image")));
            this.btnProProperty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProProperty.Name = "btnProProperty";
            this.btnProProperty.Size = new System.Drawing.Size(73, 22);
            this.btnProProperty.Text = "记录属性";
            this.btnProProperty.ToolTipText = "查看或者修改选定的基础数据记录属性。";
            // 
            // btnProDelete
            // 
            this.btnProDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnProDelete.Image")));
            this.btnProDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(73, 22);
            this.btnProDelete.Text = "记录删除";
            this.btnProDelete.ToolTipText = "禁用指定的基础数据记录。";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 22);
            this.btnPrint.Text = "打印";
            this.btnPrint.ToolTipText = "打印当前所选择分组的基础编码记录。";
            // 
            // dgvPartsList
            // 
            this.dgvPartsList.AllowUserToAddRows = false;
            this.dgvPartsList.AllowUserToDeleteRows = false;
            this.dgvPartsList.AutoGenerateColumns = false;
            this.dgvPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartsID,
            this.pARTSNODataGridViewTextBoxColumn,
            this.vERSIONDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.ProType,
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.lASTUPDATEUSERDataGridViewTextBoxColumn});
            this.dgvPartsList.DataSource = this.partsBindingSource;
            this.dgvPartsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartsList.Location = new System.Drawing.Point(0, 25);
            this.dgvPartsList.MultiSelect = false;
            this.dgvPartsList.Name = "dgvPartsList";
            this.dgvPartsList.ReadOnly = true;
            this.dgvPartsList.RowTemplate.Height = 23;
            this.dgvPartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartsList.Size = new System.Drawing.Size(840, 466);
            this.dgvPartsList.TabIndex = 6;
            // 
            // PartsID
            // 
            this.PartsID.DataPropertyName = "PARTSID";
            this.PartsID.HeaderText = "PartsID";
            this.PartsID.Name = "PartsID";
            this.PartsID.ReadOnly = true;
            this.PartsID.Visible = false;
            // 
            // pARTSNODataGridViewTextBoxColumn
            // 
            this.pARTSNODataGridViewTextBoxColumn.DataPropertyName = "PARTSNO";
            this.pARTSNODataGridViewTextBoxColumn.HeaderText = "编号";
            this.pARTSNODataGridViewTextBoxColumn.Name = "pARTSNODataGridViewTextBoxColumn";
            this.pARTSNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vERSIONDataGridViewTextBoxColumn
            // 
            this.vERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.HeaderText = "版本";
            this.vERSIONDataGridViewTextBoxColumn.Name = "vERSIONDataGridViewTextBoxColumn";
            this.vERSIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "描述";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProType
            // 
            this.ProType.DataPropertyName = "PARTSTYPE";
            this.ProType.HeaderText = "零部件类型";
            this.ProType.Name = "ProType";
            this.ProType.ReadOnly = true;
            // 
            // pARTSCLASSFICATIONDataGridViewTextBoxColumn
            // 
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn.DataPropertyName = "PARTSCLASSFICATION";
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn.HeaderText = "零部件分类";
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn.Name = "pARTSCLASSFICATIONDataGridViewTextBoxColumn";
            this.pARTSCLASSFICATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lASTUPDATEUSERDataGridViewTextBoxColumn
            // 
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.DataPropertyName = "LASTUPDATEUSER";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.HeaderText = "修改者";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.Name = "lASTUPDATEUSERDataGridViewTextBoxColumn";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(HYPDM.Entities.PDM_PARTS);
            // 
            // PartsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPartsList);
            this.Controls.Add(this.tsToolbar);
            this.Name = "PartsListControl";
            this.Size = new System.Drawing.Size(840, 491);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton btnProToAdd;
        private System.Windows.Forms.ToolStripButton btnProProperty;
        private System.Windows.Forms.ToolStripButton btnProDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.DataGridView dgvPartsList;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTSNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARTSCLASSFICATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTUPDATEUSERDataGridViewTextBoxColumn;
    }
}
