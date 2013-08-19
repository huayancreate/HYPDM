namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class ProductsListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsListControl));
            this.ts_Tool_Product = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.add_Product = new System.Windows.Forms.ToolStripButton();
            this.conf_Product = new System.Windows.Forms.ToolStripButton();
            this.del_Product = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.print_Product = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.query_Product = new System.Windows.Forms.ToolStripButton();
            this.cm_Memu_Product = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_Product_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.del_Memu_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.conf_Menu_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.checkedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vERSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTUPDATEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTUPDATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRAWINGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Data_Product = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ts_Tool_Product.SuspendLayout();
            this.cm_Memu_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Data_Product)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Tool_Product
            // 
            this.ts_Tool_Product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.add_Product,
            this.conf_Product,
            this.del_Product,
            this.toolStripSeparator2,
            this.print_Product,
            this.toolStripSeparator6,
            this.query_Product});
            this.ts_Tool_Product.Location = new System.Drawing.Point(0, 0);
            this.ts_Tool_Product.Name = "ts_Tool_Product";
            this.ts_Tool_Product.Size = new System.Drawing.Size(833, 25);
            this.ts_Tool_Product.TabIndex = 0;
            this.ts_Tool_Product.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // add_Product
            // 
            this.add_Product.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.add_Product.Name = "add_Product";
            this.add_Product.Size = new System.Drawing.Size(52, 22);
            this.add_Product.Text = "添加";
            this.add_Product.Click += new System.EventHandler(this.add_Product_Click);
            // 
            // conf_Product
            // 
            this.conf_Product.Image = ((System.Drawing.Image)(resources.GetObject("conf_Product.Image")));
            this.conf_Product.Name = "conf_Product";
            this.conf_Product.Size = new System.Drawing.Size(52, 22);
            this.conf_Product.Text = "配置";
            this.conf_Product.Click += new System.EventHandler(this.conf_Product_Click);
            // 
            // del_Product
            // 
            this.del_Product.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.del_Product.Name = "del_Product";
            this.del_Product.Size = new System.Drawing.Size(52, 22);
            this.del_Product.Text = "删除";
            this.del_Product.Click += new System.EventHandler(this.del_Product_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // print_Product
            // 
            this.print_Product.Name = "print_Product";
            this.print_Product.Size = new System.Drawing.Size(36, 22);
            this.print_Product.Text = "打印";
            this.print_Product.Click += new System.EventHandler(this.print_Product_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // query_Product
            // 
            this.query_Product.Image = ((System.Drawing.Image)(resources.GetObject("query_Product.Image")));
            this.query_Product.Name = "query_Product";
            this.query_Product.Size = new System.Drawing.Size(52, 22);
            this.query_Product.Text = "查询";
            this.query_Product.Click += new System.EventHandler(this.query_Product_Click);
            // 
            // cm_Memu_Product
            // 
            this.cm_Memu_Product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Product_Menu,
            this.del_Memu_Product,
            this.toolStripSeparator3,
            this.conf_Menu_Product});
            this.cm_Memu_Product.Name = "cm_Product";
            this.cm_Memu_Product.Size = new System.Drawing.Size(101, 76);
            // 
            // add_Product_Menu
            // 
            this.add_Product_Menu.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.add_Product_Menu.Name = "add_Product_Menu";
            this.add_Product_Menu.Size = new System.Drawing.Size(100, 22);
            this.add_Product_Menu.Text = "添加";
            this.add_Product_Menu.Click += new System.EventHandler(this.add_Product_Menu_Click);
            // 
            // del_Memu_Product
            // 
            this.del_Memu_Product.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.del_Memu_Product.Name = "del_Memu_Product";
            this.del_Memu_Product.Size = new System.Drawing.Size(100, 22);
            this.del_Memu_Product.Text = "删除";
            this.del_Memu_Product.Click += new System.EventHandler(this.del_Memu_Product_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(97, 6);
            // 
            // conf_Menu_Product
            // 
            this.conf_Menu_Product.Image = ((System.Drawing.Image)(resources.GetObject("conf_Menu_Product.Image")));
            this.conf_Menu_Product.Name = "conf_Menu_Product";
            this.conf_Menu_Product.Size = new System.Drawing.Size(100, 22);
            this.conf_Menu_Product.Text = "配置";
            this.conf_Menu_Product.Click += new System.EventHandler(this.conf_Menu_Product_Click);
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.AllowUserToAddRows = false;
            this.dgv_ProductList.AllowUserToDeleteRows = false;
            this.dgv_ProductList.AutoGenerateColumns = false;
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedDataGridViewCheckBoxColumn,
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.vERSIONDataGridViewTextBoxColumn,
            this.mODELNODataGridViewTextBoxColumn,
            this.pRODUCTSTATUSDataGridViewTextBoxColumn,
            this.lASTUPDATEUSERDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.lASTUPDATEDATEDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn,
            this.dRAWINGIDDataGridViewTextBoxColumn,
            this.pRODUCTTYPEDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn,
            this.pRONODataGridViewTextBoxColumn});
            this.dgv_ProductList.DataSource = this.bs_Data_Product;
            this.dgv_ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProductList.Location = new System.Drawing.Point(0, 25);
            this.dgv_ProductList.MultiSelect = false;
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            this.dgv_ProductList.RowTemplate.Height = 23;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(833, 373);
            this.dgv_ProductList.TabIndex = 2;
            this.dgv_ProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellContentClick);
            this.dgv_ProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellDoubleClick);
            this.dgv_ProductList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ProductList_CellMouseDown);
            // 
            // checkedDataGridViewCheckBoxColumn
            // 
            this.checkedDataGridViewCheckBoxColumn.DataPropertyName = "Checked";
            this.checkedDataGridViewCheckBoxColumn.FillWeight = 116.9476F;
            this.checkedDataGridViewCheckBoxColumn.HeaderText = "选择";
            this.checkedDataGridViewCheckBoxColumn.Name = "checkedDataGridViewCheckBoxColumn";
            this.checkedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkedDataGridViewCheckBoxColumn.Width = 56;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.FillWeight = 112.8477F;
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "品号";
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTIDDataGridViewTextBoxColumn.Width = 57;
            // 
            // vERSIONDataGridViewTextBoxColumn
            // 
            this.vERSIONDataGridViewTextBoxColumn.DataPropertyName = "VERSION";
            this.vERSIONDataGridViewTextBoxColumn.FillWeight = 105.7418F;
            this.vERSIONDataGridViewTextBoxColumn.HeaderText = "版本";
            this.vERSIONDataGridViewTextBoxColumn.Name = "vERSIONDataGridViewTextBoxColumn";
            this.vERSIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.vERSIONDataGridViewTextBoxColumn.Width = 56;
            // 
            // mODELNODataGridViewTextBoxColumn
            // 
            this.mODELNODataGridViewTextBoxColumn.DataPropertyName = "MODELNO";
            this.mODELNODataGridViewTextBoxColumn.FillWeight = 103.5497F;
            this.mODELNODataGridViewTextBoxColumn.HeaderText = "产品型号";
            this.mODELNODataGridViewTextBoxColumn.Name = "mODELNODataGridViewTextBoxColumn";
            this.mODELNODataGridViewTextBoxColumn.ReadOnly = true;
            this.mODELNODataGridViewTextBoxColumn.Width = 57;
            // 
            // pRODUCTSTATUSDataGridViewTextBoxColumn
            // 
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTSTATUS";
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.FillWeight = 98.47646F;
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.HeaderText = "状态";
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.Name = "pRODUCTSTATUSDataGridViewTextBoxColumn";
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTSTATUSDataGridViewTextBoxColumn.Width = 56;
            // 
            // lASTUPDATEUSERDataGridViewTextBoxColumn
            // 
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.DataPropertyName = "LASTUPDATEUSER";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.FillWeight = 97.86431F;
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.HeaderText = "修改者";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.Name = "lASTUPDATEUSERDataGridViewTextBoxColumn";
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.ReadOnly = true;
            this.lASTUPDATEUSERDataGridViewTextBoxColumn.Width = 57;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.FillWeight = 94.42243F;
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "创建日期";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDATEDataGridViewTextBoxColumn.Width = 56;
            // 
            // lASTUPDATEDATEDataGridViewTextBoxColumn
            // 
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.DataPropertyName = "LASTUPDATEDATE";
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.FillWeight = 93.36309F;
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.HeaderText = "修改时间";
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.Name = "lASTUPDATEDATEDataGridViewTextBoxColumn";
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lASTUPDATEDATEDataGridViewTextBoxColumn.Width = 56;
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.FillWeight = 94.70753F;
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "备注";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            this.rEMARKDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEMARKDataGridViewTextBoxColumn.Width = 57;
            // 
            // dRAWINGIDDataGridViewTextBoxColumn
            // 
            this.dRAWINGIDDataGridViewTextBoxColumn.DataPropertyName = "DRAWINGID";
            this.dRAWINGIDDataGridViewTextBoxColumn.FillWeight = 93.18613F;
            this.dRAWINGIDDataGridViewTextBoxColumn.HeaderText = "图号";
            this.dRAWINGIDDataGridViewTextBoxColumn.Name = "dRAWINGIDDataGridViewTextBoxColumn";
            this.dRAWINGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRAWINGIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // pRODUCTTYPEDataGridViewTextBoxColumn
            // 
            this.pRODUCTTYPEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTTYPE";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.FillWeight = 95.6747F;
            this.pRODUCTTYPEDataGridViewTextBoxColumn.HeaderText = "产品类型";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.Name = "pRODUCTTYPEDataGridViewTextBoxColumn";
            this.pRODUCTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCTTYPEDataGridViewTextBoxColumn.Width = 57;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.FillWeight = 95.20396F;
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "描述";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 56;
            // 
            // eNGDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ENGDESCRIPTION";
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.FillWeight = 98.77415F;
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "英文描述";
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.Name = "eNGDESCRIPTIONDataGridViewTextBoxColumn";
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNGDESCRIPTIONDataGridViewTextBoxColumn.Width = 57;
            // 
            // pRONODataGridViewTextBoxColumn
            // 
            this.pRONODataGridViewTextBoxColumn.DataPropertyName = "PRONO";
            this.pRONODataGridViewTextBoxColumn.FillWeight = 99.24052F;
            this.pRONODataGridViewTextBoxColumn.HeaderText = "产品编号";
            this.pRONODataGridViewTextBoxColumn.Name = "pRONODataGridViewTextBoxColumn";
            this.pRONODataGridViewTextBoxColumn.ReadOnly = true;
            this.pRONODataGridViewTextBoxColumn.Width = 56;
            // 
            // bs_Data_Product
            // 
            this.bs_Data_Product.DataSource = typeof(HYPDM.Entities.PDM_PRODUCT);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ProductList);
            this.panel1.Controls.Add(this.ts_Tool_Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 398);
            this.panel1.TabIndex = 4;
            // 
            // ProductsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "ProductsListControl";
            this.Size = new System.Drawing.Size(833, 398);
            this.ts_Tool_Product.ResumeLayout(false);
            this.ts_Tool_Product.PerformLayout();
            this.cm_Memu_Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Data_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_Tool_Product;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cm_Memu_Product;
        private System.Windows.Forms.ToolStripMenuItem add_Product_Menu;
        private System.Windows.Forms.ToolStripMenuItem del_Memu_Product;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem conf_Menu_Product;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.BindingSource bs_Data_Product;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vERSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTUPDATEUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTUPDATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRAWINGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNGDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONODataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton add_Product;
        private System.Windows.Forms.ToolStripButton conf_Product;
        private System.Windows.Forms.ToolStripButton del_Product;
        private System.Windows.Forms.ToolStripButton print_Product;
        private System.Windows.Forms.ToolStripButton query_Product;
        private System.Windows.Forms.Panel panel1;
    }
}
