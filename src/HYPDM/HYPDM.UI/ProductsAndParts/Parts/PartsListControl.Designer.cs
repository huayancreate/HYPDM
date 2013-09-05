namespace HYPDM.WinUI.ProductsAndParts.Parts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_Tool_Product.SuspendLayout();
            this.cm_Memu_Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
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
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column18,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column17,
            this.Column7,
            this.Column16,
            this.Column15,
            this.Column14,
            this.MEMO});
            this.dgv_ProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ProductList.Location = new System.Drawing.Point(0, 25);
            this.dgv_ProductList.MultiSelect = false;
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.ReadOnly = true;
            this.dgv_ProductList.RowTemplate.Height = 23;
            this.dgv_ProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductList.Size = new System.Drawing.Size(833, 373);
            this.dgv_ProductList.TabIndex = 2;
            this.dgv_ProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellDoubleClick);
            this.dgv_ProductList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ProductList_CellMouseDown);
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
            // Column8
            // 
            this.Column8.DataPropertyName = "PRODUCTID";
            this.Column8.HeaderText = "主键";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PRODUCTNO";
            this.Column1.HeaderText = "产品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MODELTYPE";
            this.Column2.HeaderText = "产品型号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PRODUCTTYPE";
            this.Column3.HeaderText = "产品类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "PRODUCTLEVEL";
            this.Column18.HeaderText = "产品等级";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VERSION";
            this.Column4.HeaderText = "版本";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "STATUS";
            this.Column5.HeaderText = "状态";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CREATER";
            this.Column6.HeaderText = "创建人";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "MODIFIER";
            this.Column17.HeaderText = "修改人";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "CREATETIME";
            this.Column7.HeaderText = "创建时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "MODIFYTIME";
            this.Column16.HeaderText = "修改时间";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "MEMO_ZH";
            this.Column15.HeaderText = "中文描述";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MEMO_EN";
            this.Column14.HeaderText = "英文描述";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "备注";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
    }
}
