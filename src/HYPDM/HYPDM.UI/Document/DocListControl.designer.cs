namespace HYPDM.WinUI.Document
{
    partial class DocListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocListControl));
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmDocDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmDocProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDocAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDocument = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDocToAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDocProperty = new System.Windows.Forms.ToolStripButton();
            this.btnDocDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvDocList = new System.Windows.Forms.DataGridView();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            this.cmDocument.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // cmDocDelete
            // 
            this.cmDocDelete.Name = "cmDocDelete";
            this.cmDocDelete.Size = new System.Drawing.Size(141, 22);
            this.cmDocDelete.Text = "记录删除(&D)";
            this.cmDocDelete.Click += new System.EventHandler(this.btnDocDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // cmDocProperty
            // 
            this.cmDocProperty.Name = "cmDocProperty";
            this.cmDocProperty.Size = new System.Drawing.Size(141, 22);
            this.cmDocProperty.Text = "记录属性(&P)";
            // 
            // cmDocAdd
            // 
            this.cmDocAdd.Name = "cmDocAdd";
            this.cmDocAdd.Size = new System.Drawing.Size(141, 22);
            this.cmDocAdd.Text = "记录添加(&A)";
            this.cmDocAdd.Click += new System.EventHandler(this.cmDocAdd_Click);
            // 
            // cmDocument
            // 
            this.cmDocument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDocAdd,
            this.cmDocProperty,
            this.toolStripSeparator3,
            this.cmDocDelete,
            this.toolStripSeparator4});
            this.cmDocument.Name = "cmGroup";
            this.cmDocument.Size = new System.Drawing.Size(142, 82);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "属性";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "标志码";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "国家编码";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文名称";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "代码";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.Width = 20;
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnDocToAdd,
            this.btnDocProperty,
            this.btnDocDelete,
            this.toolStripSeparator1,
            this.btnPrint});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsToolbar.Size = new System.Drawing.Size(840, 25);
            this.tsToolbar.TabIndex = 3;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDocToAdd
            // 
            this.btnDocToAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDocToAdd.Image")));
            this.btnDocToAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocToAdd.Name = "btnDocToAdd";
            this.btnDocToAdd.Size = new System.Drawing.Size(76, 22);
            this.btnDocToAdd.Text = "记录添加";
            this.btnDocToAdd.ToolTipText = "添加一个新的基础数据记录。";
            this.btnDocToAdd.Click += new System.EventHandler(this.btnDocToAdd_Click);
            // 
            // btnDocProperty
            // 
            this.btnDocProperty.Image = ((System.Drawing.Image)(resources.GetObject("btnDocProperty.Image")));
            this.btnDocProperty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocProperty.Name = "btnDocProperty";
            this.btnDocProperty.Size = new System.Drawing.Size(76, 22);
            this.btnDocProperty.Text = "记录属性";
            this.btnDocProperty.ToolTipText = "查看或者修改选定的基础数据记录属性。";
            this.btnDocProperty.Click += new System.EventHandler(this.btnDocProperty_Click);
            // 
            // btnDocDelete
            // 
            this.btnDocDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDocDelete.Image")));
            this.btnDocDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocDelete.Name = "btnDocDelete";
            this.btnDocDelete.Size = new System.Drawing.Size(76, 22);
            this.btnDocDelete.Text = "记录删除";
            this.btnDocDelete.ToolTipText = "禁用指定的基础数据记录。";
            this.btnDocDelete.Click += new System.EventHandler(this.btnDocDelete_Click);
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
            this.btnPrint.Size = new System.Drawing.Size(52, 22);
            this.btnPrint.Text = "打印";
            this.btnPrint.ToolTipText = "打印当前所选择分组的基础编码记录。";
            // 
            // dgvDocList
            // 
            this.dgvDocList.AllowUserToAddRows = false;
            this.dgvDocList.AllowUserToDeleteRows = false;
            this.dgvDocList.AutoGenerateColumns = false;
            this.dgvDocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Remark,
            this.DocStatus,
            this.UpdateUser,
            this.CreateDate,
            this.Column5});
            this.dgvDocList.DataSource = this.docBindingSource;
            this.dgvDocList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocList.Location = new System.Drawing.Point(0, 25);
            this.dgvDocList.MultiSelect = false;
            this.dgvDocList.Name = "dgvDocList";
            this.dgvDocList.ReadOnly = true;
            this.dgvDocList.RowTemplate.Height = 23;
            this.dgvDocList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocList.Size = new System.Drawing.Size(840, 466);
            this.dgvDocList.TabIndex = 4;
            this.dgvDocList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocList_CellDoubleClick);
            this.dgvDocList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocList_CellMouseDown);
            // 
            // DocID
            // 
            this.DocID.DataPropertyName = "DOCID";
            this.DocID.HeaderText = "DocID";
            this.DocID.Name = "DocID";
            this.DocID.ReadOnly = true;
            this.DocID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DOCNO";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VERSION";
            this.Column2.HeaderText = "版本";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "文件";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DOCTYPE";
            this.Column4.HeaderText = "文档分类";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "DESCRIPTION";
            this.Remark.HeaderText = "描述";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 120;
            // 
            // DocStatus
            // 
            this.DocStatus.DataPropertyName = "DOCSTATUS";
            this.DocStatus.HeaderText = "状态";
            this.DocStatus.Name = "DocStatus";
            this.DocStatus.ReadOnly = true;
            // 
            // UpdateUser
            // 
            this.UpdateUser.DataPropertyName = "LASTUPDATEUSER";
            this.UpdateUser.HeaderText = "修改者";
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CREATEDATE";
            this.CreateDate.HeaderText = "创建时间";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LASTUPDATEDATE";
            this.Column5.HeaderText = "修改时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DocListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocList);
            this.Controls.Add(this.tsToolbar);
            this.Name = "DocListControl";
            this.Size = new System.Drawing.Size(840, 491);
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.cmDocument.ResumeLayout(false);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource docBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmDocDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmDocProperty;
        private System.Windows.Forms.ToolStripMenuItem cmDocAdd;
        private System.Windows.Forms.ContextMenuStrip cmDocument;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton btnDocToAdd;
        private System.Windows.Forms.ToolStripButton btnDocProperty;
        private System.Windows.Forms.ToolStripButton btnDocDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.DataGridView dgvDocList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}
