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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmDocDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
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
            this.dgvDocList = new HYPDM.BaseControl.DataGridViewExt();
            this.DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBTEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTUPDATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTUPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            this.RegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegStardardFlow = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator3,
            this.cmDocDelete,
            this.toolStripSeparator4,
            this.RegToolStripMenuItem});
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
            this.tsToolbar.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.banner;
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnDocToAdd,
            this.btnDocProperty,
            this.btnDocDelete,
            this.toolStripSeparator1,
            this.btnSearch});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsToolbar.Size = new System.Drawing.Size(913, 25);
            this.tsToolbar.TabIndex = 3;
            this.tsToolbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsToolbar_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDocToAdd
            // 
            this.btnDocToAdd.ForeColor = System.Drawing.Color.White;
            this.btnDocToAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDocToAdd.Image")));
            this.btnDocToAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocToAdd.Name = "btnDocToAdd";
            this.btnDocToAdd.Size = new System.Drawing.Size(76, 22);
            this.btnDocToAdd.Text = "文档添加";
            this.btnDocToAdd.ToolTipText = "添加一个新的基础数据记录。";
            this.btnDocToAdd.Click += new System.EventHandler(this.btnDocToAdd_Click);
            // 
            // btnDocProperty
            // 
            this.btnDocProperty.ForeColor = System.Drawing.Color.White;
            this.btnDocProperty.Image = ((System.Drawing.Image)(resources.GetObject("btnDocProperty.Image")));
            this.btnDocProperty.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocProperty.Name = "btnDocProperty";
            this.btnDocProperty.Size = new System.Drawing.Size(76, 22);
            this.btnDocProperty.Text = "文档属性";
            this.btnDocProperty.ToolTipText = "查看或者修改选定的基础数据记录属性。";
            this.btnDocProperty.Click += new System.EventHandler(this.btnDocProperty_Click);
            // 
            // btnDocDelete
            // 
            this.btnDocDelete.ForeColor = System.Drawing.Color.White;
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
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 22);
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // dgvDocList
            // 
            this.dgvDocList.AllowUserToAddRows = false;
            this.dgvDocList.AllowUserToDeleteRows = false;
            this.dgvDocList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDocList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCNO,
            this.DOCID,
            this.DOCNAME,
            this.VERSION,
            this.REMARK,
            this.COMBTEXT,
            this.DocType,
            this.Description,
            this.DocStatus,
            this.LASTUPDATEUSER,
            this.LASTUPDATEDATE,
            this.CREATEUSER,
            this.CreateDate,
            this.DEL_FLAG});
            this.dgvDocList.ContextMenuStrip = this.cmDocument;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocList.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvDocList.Location = new System.Drawing.Point(0, 25);
            this.dgvDocList.MultiSelect = false;
            this.dgvDocList.Name = "dgvDocList";
            this.dgvDocList.ReadOnly = true;
            this.dgvDocList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvDocList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvDocList.RowTemplate.Height = 23;
            this.dgvDocList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocList.Size = new System.Drawing.Size(913, 381);
            this.dgvDocList.TabIndex = 7;
            this.dgvDocList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocList_CellDoubleClick_1);
            // 
            // DOCNO
            // 
            this.DOCNO.DataPropertyName = "DOCNO";
            this.DOCNO.HeaderText = "文档编号";
            this.DOCNO.Name = "DOCNO";
            this.DOCNO.ReadOnly = true;
            // 
            // DOCID
            // 
            this.DOCID.DataPropertyName = "DOCID";
            this.DOCID.HeaderText = "DOCID";
            this.DOCID.Name = "DOCID";
            this.DOCID.ReadOnly = true;
            this.DOCID.Visible = false;
            // 
            // DOCNAME
            // 
            this.DOCNAME.DataPropertyName = "DOCNAME";
            this.DOCNAME.HeaderText = "文件名称";
            this.DOCNAME.Name = "DOCNAME";
            this.DOCNAME.ReadOnly = true;
            this.DOCNAME.Visible = false;
            // 
            // VERSION
            // 
            this.VERSION.DataPropertyName = "VERSION";
            this.VERSION.HeaderText = "版本";
            this.VERSION.Name = "VERSION";
            this.VERSION.ReadOnly = true;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "文件备注";
            this.REMARK.Name = "REMARK";
            this.REMARK.ReadOnly = true;
            this.REMARK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REMARK.Width = 150;
            // 
            // COMBTEXT
            // 
            this.COMBTEXT.DataPropertyName = "COMBTEXT";
            this.COMBTEXT.HeaderText = "文档类别";
            this.COMBTEXT.Name = "COMBTEXT";
            this.COMBTEXT.ReadOnly = true;
            // 
            // DocType
            // 
            this.DocType.DataPropertyName = "DOCTYPE";
            this.DocType.HeaderText = "文档分类";
            this.DocType.Name = "DocType";
            this.DocType.ReadOnly = true;
            this.DocType.Visible = false;
            this.DocType.Width = 120;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 160;
            // 
            // DocStatus
            // 
            this.DocStatus.DataPropertyName = "DOCSTATUS";
            this.DocStatus.HeaderText = "状态";
            this.DocStatus.Name = "DocStatus";
            this.DocStatus.ReadOnly = true;
            // 
            // LASTUPDATEUSER
            // 
            this.LASTUPDATEUSER.DataPropertyName = "LASTUPDATEUSER";
            this.LASTUPDATEUSER.HeaderText = "修改者";
            this.LASTUPDATEUSER.Name = "LASTUPDATEUSER";
            this.LASTUPDATEUSER.ReadOnly = true;
            // 
            // LASTUPDATEDATE
            // 
            this.LASTUPDATEDATE.DataPropertyName = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.HeaderText = "修改时间";
            this.LASTUPDATEDATE.Name = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.ReadOnly = true;
            this.LASTUPDATEDATE.Width = 150;
            // 
            // CREATEUSER
            // 
            this.CREATEUSER.DataPropertyName = "CREATEUSER";
            this.CREATEUSER.HeaderText = "创建用户";
            this.CREATEUSER.Name = "CREATEUSER";
            this.CREATEUSER.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CREATEDATE";
            this.CreateDate.HeaderText = "创建时间";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 150;
            // 
            // DEL_FLAG
            // 
            this.DEL_FLAG.DataPropertyName = "DEL_FLAG";
            this.DEL_FLAG.HeaderText = "DEL_FLAG";
            this.DEL_FLAG.Name = "DEL_FLAG";
            this.DEL_FLAG.ReadOnly = true;
            this.DEL_FLAG.Visible = false;
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = false;
            this.ucPaging1.Location = new System.Drawing.Point(0, 406);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 30;
            this.ucPaging1.Size = new System.Drawing.Size(913, 37);
            this.ucPaging1.TabIndex = 4;
            this.ucPaging1.Load += new System.EventHandler(this.ucPaging1_Load);
            // 
            // RegToolStripMenuItem
            // 
            this.RegToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegStardardFlow});
            this.RegToolStripMenuItem.Name = "RegToolStripMenuItem";
            this.RegToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.RegToolStripMenuItem.Text = "注册流程";
            // 
            // RegStardardFlow
            // 
            this.RegStardardFlow.Name = "RegStardardFlow";
            this.RegStardardFlow.Size = new System.Drawing.Size(152, 22);
            this.RegStardardFlow.Text = "标准流程注册";
            this.RegStardardFlow.Click += new System.EventHandler(this.RegStardardFlow_Click);
            // 
            // DocListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocList);
            this.Controls.Add(this.ucPaging1);
            this.Controls.Add(this.tsToolbar);
            this.Name = "DocListControl";
            this.Size = new System.Drawing.Size(913, 443);
            this.cmDocument.ResumeLayout(false);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmDocDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
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
        private System.Windows.Forms.ToolStripButton btnSearch;
        private BaseControl.UcPaging ucPaging1;
        private BaseControl.DataGridViewExt dgvDocList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBTEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTUPDATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTUPDATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FLAG;
        private System.Windows.Forms.ToolStripMenuItem RegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegStardardFlow;

    }
}
