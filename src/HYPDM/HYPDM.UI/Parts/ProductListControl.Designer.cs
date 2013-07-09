namespace HYPDM.WinUI.Parts
{
    partial class ProductListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListControl));
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProToAdd = new System.Windows.Forms.ToolStripButton();
            this.btnProProperty = new System.Windows.Forms.ToolStripButton();
            this.btnProDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvProList = new System.Windows.Forms.DataGridView();
            this.proBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDocAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDocProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmDocDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechInstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNoAttr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).BeginInit();
            this.cmProduct.SuspendLayout();
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
            this.tsToolbar.TabIndex = 4;
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
            this.btnProProperty.Click += new System.EventHandler(this.btnProProperty_Click);
            // 
            // btnProDelete
            // 
            this.btnProDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnProDelete.Image")));
            this.btnProDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProDelete.Name = "btnProDelete";
            this.btnProDelete.Size = new System.Drawing.Size(73, 22);
            this.btnProDelete.Text = "记录删除";
            this.btnProDelete.ToolTipText = "禁用指定的基础数据记录。";
            this.btnProDelete.Click += new System.EventHandler(this.btnProDelete_Click);
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
            // dgvProList
            // 
            this.dgvProList.AllowUserToAddRows = false;
            this.dgvProList.AllowUserToDeleteRows = false;
            this.dgvProList.AutoGenerateColumns = false;
            this.dgvProList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProID,
            this.ProductID,
            this.ProName,
            this.Version,
            this.SortCode,
            this.ModelNo,
            this.ProSize,
            this.Material,
            this.TechName,
            this.TechInstruction,
            this.ProNoAttr,
            this.Unit,
            this.Property,
            this.WorkCenter,
            this.ProStatus,
            this.LastUpdateUser,
            this.CreateDate,
            this.LastUpdateDate,
            this.Remark,
            this.DrawingID,
            this.checkedDataGridViewCheckBoxColumn});
            this.dgvProList.DataSource = this.proBindingSource;
            this.dgvProList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProList.Location = new System.Drawing.Point(0, 25);
            this.dgvProList.MultiSelect = false;
            this.dgvProList.Name = "dgvProList";
            this.dgvProList.ReadOnly = true;
            this.dgvProList.RowTemplate.Height = 23;
            this.dgvProList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProList.Size = new System.Drawing.Size(840, 466);
            this.dgvProList.TabIndex = 5;
            this.dgvProList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProList_CellDoubleClick);
            this.dgvProList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProList_CellMouseDown);
            // 
            // proBindingSource
            // 
            this.proBindingSource.DataSource = typeof(HYPDM.Entities.PDM_PRODUCT);
            // 
            // cmProduct
            // 
            this.cmProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDocAdd,
            this.cmDocProperty,
            this.toolStripSeparator3,
            this.cmDocDelete,
            this.toolStripSeparator4});
            this.cmProduct.Name = "cmGroup";
            this.cmProduct.Size = new System.Drawing.Size(137, 82);
            // 
            // cmDocAdd
            // 
            this.cmDocAdd.Name = "cmDocAdd";
            this.cmDocAdd.Size = new System.Drawing.Size(136, 22);
            this.cmDocAdd.Text = "记录添加(&A)";
            // 
            // cmDocProperty
            // 
            this.cmDocProperty.Name = "cmDocProperty";
            this.cmDocProperty.Size = new System.Drawing.Size(136, 22);
            this.cmDocProperty.Text = "记录属性(&P)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // cmDocDelete
            // 
            this.cmDocDelete.Name = "cmDocDelete";
            this.cmDocDelete.Size = new System.Drawing.Size(136, 22);
            this.cmDocDelete.Text = "记录删除(&D)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // ProID
            // 
            this.ProID.DataPropertyName = "PRODUCTID";
            this.ProID.HeaderText = "ProID";
            this.ProID.Name = "ProID";
            this.ProID.ReadOnly = true;
            this.ProID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "PRODUCTID";
            this.ProductID.HeaderText = "品号";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "PRODUCTNAME";
            this.ProName.HeaderText = "产品名称";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "VERSION";
            this.Version.HeaderText = "版本";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // SortCode
            // 
            this.SortCode.DataPropertyName = "SORTCODE";
            this.SortCode.HeaderText = "顺序";
            this.SortCode.Name = "SortCode";
            this.SortCode.ReadOnly = true;
            // 
            // ModelNo
            // 
            this.ModelNo.DataPropertyName = "MODELNO";
            this.ModelNo.HeaderText = "产品型号";
            this.ModelNo.Name = "ModelNo";
            this.ModelNo.ReadOnly = true;
            // 
            // ProSize
            // 
            this.ProSize.DataPropertyName = "SIZE";
            this.ProSize.HeaderText = "规格/尺寸";
            this.ProSize.Name = "ProSize";
            this.ProSize.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "MATERIAL";
            this.Material.HeaderText = "材料";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // TechName
            // 
            this.TechName.DataPropertyName = "TECHNAME";
            this.TechName.HeaderText = "工艺名称";
            this.TechName.Name = "TechName";
            this.TechName.ReadOnly = true;
            // 
            // TechInstruction
            // 
            this.TechInstruction.DataPropertyName = "TECHINSTRUCTION";
            this.TechInstruction.HeaderText = "工艺说明";
            this.TechInstruction.Name = "TechInstruction";
            this.TechInstruction.ReadOnly = true;
            // 
            // ProNoAttr
            // 
            this.ProNoAttr.DataPropertyName = "PRODUCTNOATTR";
            this.ProNoAttr.HeaderText = "品号属性";
            this.ProNoAttr.Name = "ProNoAttr";
            this.ProNoAttr.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "UNIT";
            this.Unit.HeaderText = "单位ID";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Property
            // 
            this.Property.DataPropertyName = "PROPERTY";
            this.Property.HeaderText = "性质";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // WorkCenter
            // 
            this.WorkCenter.DataPropertyName = "WORKCENTER";
            this.WorkCenter.HeaderText = "工作中心";
            this.WorkCenter.Name = "WorkCenter";
            this.WorkCenter.ReadOnly = true;
            // 
            // ProStatus
            // 
            this.ProStatus.DataPropertyName = "PRODUCTSTATUS";
            this.ProStatus.HeaderText = "状态";
            this.ProStatus.Name = "ProStatus";
            this.ProStatus.ReadOnly = true;
            // 
            // LastUpdateUser
            // 
            this.LastUpdateUser.DataPropertyName = "LASTUPDATEUSER";
            this.LastUpdateUser.HeaderText = "修改者";
            this.LastUpdateUser.Name = "LastUpdateUser";
            this.LastUpdateUser.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CREATEUSER";
            this.CreateDate.HeaderText = "创建日期";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // LastUpdateDate
            // 
            this.LastUpdateDate.DataPropertyName = "LASTUPDATEDATE";
            this.LastUpdateDate.HeaderText = "修改时间";
            this.LastUpdateDate.Name = "LastUpdateDate";
            this.LastUpdateDate.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "REMARK";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // DrawingID
            // 
            this.DrawingID.DataPropertyName = "DRAWINGID";
            this.DrawingID.HeaderText = "图号";
            this.DrawingID.Name = "DrawingID";
            this.DrawingID.ReadOnly = true;
            // 
            // checkedDataGridViewCheckBoxColumn
            // 
            this.checkedDataGridViewCheckBoxColumn.DataPropertyName = "Checked";
            this.checkedDataGridViewCheckBoxColumn.HeaderText = "选择";
            this.checkedDataGridViewCheckBoxColumn.Name = "checkedDataGridViewCheckBoxColumn";
            this.checkedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ProductListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProList);
            this.Controls.Add(this.tsToolbar);
            this.Name = "ProductListControl";
            this.Size = new System.Drawing.Size(840, 491);
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proBindingSource)).EndInit();
            this.cmProduct.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvProList;
        private System.Windows.Forms.BindingSource proBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmProduct;
        private System.Windows.Forms.ToolStripMenuItem cmDocAdd;
        private System.Windows.Forms.ToolStripMenuItem cmDocProperty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmDocDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechInstruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNoAttr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawingID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn;
    }
}
