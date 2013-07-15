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
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.dgvDocList = new System.Windows.Forms.DataGridView();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDocument.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
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
            this.btnPrint,
            this.btnSearch});
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
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 22);
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.File,
            this.DocType,
            this.Description,
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
            // File
            // 
            this.File.DataPropertyName = "REMARK";
            this.File.HeaderText = "文件";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            this.File.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DocType
            // 
            this.DocType.DataPropertyName = "DOCTYPE";
            this.DocType.HeaderText = "文档分类";
            this.DocType.Name = "DocType";
            this.DocType.ReadOnly = true;
            this.DocType.Width = 120;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 120;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DOCID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DocID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DOCNO";
            this.dataGridViewTextBoxColumn2.HeaderText = "编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VERSION";
            this.dataGridViewTextBoxColumn3.HeaderText = "版本";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "文件";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DOCTYPE";
            this.dataGridViewTextBoxColumn5.HeaderText = "文档分类";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn6.HeaderText = "描述";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DOCSTATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "状态";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LASTUPDATEUSER";
            this.dataGridViewTextBoxColumn8.HeaderText = "修改者";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CREATEDATE";
            this.dataGridViewTextBoxColumn9.HeaderText = "创建时间";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LASTUPDATEDATE";
            this.dataGridViewTextBoxColumn10.HeaderText = "修改时间";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // DocListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocList);
            this.Controls.Add(this.tsToolbar);
            this.Name = "DocListControl";
            this.Size = new System.Drawing.Size(840, 491);
            this.cmDocument.ResumeLayout(false);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripButton btnSearch;
        public System.Windows.Forms.BindingSource docBindingSource;

    }
}
