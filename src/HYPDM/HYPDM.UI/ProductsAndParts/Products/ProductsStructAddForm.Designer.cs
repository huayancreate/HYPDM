namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class ProductsStructAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsStructAddForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_struct = new System.Windows.Forms.TreeView();
            this.tv_imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgv_MaterialList = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MATERIALID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_productList = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolSelect = new System.Windows.Forms.ToolStripButton();
            this.dgv_PartsList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolDetailQuery = new System.Windows.Forms.ToolStripButton();
            this.toolVersionComb = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolProComb = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolProValue = new System.Windows.Forms.ToolStripTextBox();
            this.toolQuery = new System.Windows.Forms.ToolStripButton();
            this.productChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCTID_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNO_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartsList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_struct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_MaterialList);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_productList);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_PartsList);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(702, 410);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_struct
            // 
            this.tv_struct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_struct.ImageIndex = 0;
            this.tv_struct.ImageList = this.tv_imageList;
            this.tv_struct.Location = new System.Drawing.Point(0, 0);
            this.tv_struct.Name = "tv_struct";
            this.tv_struct.SelectedImageIndex = 0;
            this.tv_struct.Size = new System.Drawing.Size(183, 410);
            this.tv_struct.TabIndex = 0;
            this.tv_struct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_struct_AfterSelect);
            // 
            // tv_imageList
            // 
            this.tv_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tv_imageList.ImageStream")));
            this.tv_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tv_imageList.Images.SetKeyName(0, "525FLOP1.ICO");
            this.tv_imageList.Images.SetKeyName(1, "CLSDFOLD.ICO");
            this.tv_imageList.Images.SetKeyName(2, "NOTE12.ICO");
            this.tv_imageList.Images.SetKeyName(3, "OPENFOLD.ICO");
            // 
            // dgv_MaterialList
            // 
            this.dgv_MaterialList.AllowUserToAddRows = false;
            this.dgv_MaterialList.AllowUserToDeleteRows = false;
            this.dgv_MaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.MATERIALID,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_MaterialList.Location = new System.Drawing.Point(0, 198);
            this.dgv_MaterialList.Name = "dgv_MaterialList";
            this.dgv_MaterialList.ReadOnly = true;
            this.dgv_MaterialList.RowTemplate.Height = 23;
            this.dgv_MaterialList.RowTemplate.ReadOnly = true;
            this.dgv_MaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MaterialList.Size = new System.Drawing.Size(507, 150);
            this.dgv_MaterialList.TabIndex = 4;
            this.dgv_MaterialList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MaterialList_CellContentClick);
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = true;
            this.checkbox.Width = 50;
            // 
            // MATERIALID
            // 
            this.MATERIALID.DataPropertyName = "MATERIALID";
            this.MATERIALID.HeaderText = "主键";
            this.MATERIALID.Name = "MATERIALID";
            this.MATERIALID.ReadOnly = true;
            this.MATERIALID.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MATERIALNO";
            this.Column6.HeaderText = "材料编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MODELTYPE";
            this.Column7.HeaderText = "材料型号";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MATERIALTYPE";
            this.Column8.HeaderText = "材料类型";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dgv_productList
            // 
            this.dgv_productList.AllowUserToAddRows = false;
            this.dgv_productList.AllowUserToDeleteRows = false;
            this.dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productChecked,
            this.PRODUCTID,
            this.PRODUCTNO,
            this.Column11,
            this.Column12});
            this.dgv_productList.Location = new System.Drawing.Point(0, 98);
            this.dgv_productList.Name = "dgv_productList";
            this.dgv_productList.RowTemplate.Height = 23;
            this.dgv_productList.RowTemplate.ReadOnly = true;
            this.dgv_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productList.Size = new System.Drawing.Size(507, 150);
            this.dgv_productList.TabIndex = 3;
            this.dgv_productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productList_CellContentClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSelect});
            this.toolStrip2.Location = new System.Drawing.Point(0, 385);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(513, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolSelect
            // 
            this.toolSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolSelect.Image")));
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(52, 22);
            this.toolSelect.Text = "选择";
            this.toolSelect.Click += new System.EventHandler(this.toolSelect_Click);
            // 
            // dgv_PartsList
            // 
            this.dgv_PartsList.AllowUserToAddRows = false;
            this.dgv_PartsList.AllowUserToDeleteRows = false;
            this.dgv_PartsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partsChecked,
            this.PRODUCTID_P,
            this.PRODUCTNO_P,
            this.modeltype,
            this.Column4});
            this.dgv_PartsList.Location = new System.Drawing.Point(0, 40);
            this.dgv_PartsList.Name = "dgv_PartsList";
            this.dgv_PartsList.RowTemplate.Height = 23;
            this.dgv_PartsList.RowTemplate.ReadOnly = true;
            this.dgv_PartsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PartsList.Size = new System.Drawing.Size(513, 342);
            this.dgv_PartsList.TabIndex = 1;
            this.dgv_PartsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PartsList_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDetailQuery,
            this.toolVersionComb,
            this.toolStripSeparator2,
            this.toolProComb,
            this.toolStripSeparator1,
            this.toolProValue,
            this.toolQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolDetailQuery
            // 
            this.toolDetailQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDetailQuery.Image = global::HYPDM.WinUI.Properties.Resources.search;
            this.toolDetailQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDetailQuery.Name = "toolDetailQuery";
            this.toolDetailQuery.Size = new System.Drawing.Size(23, 22);
            this.toolDetailQuery.ToolTipText = "详细查询";
            this.toolDetailQuery.Click += new System.EventHandler(this.toolDetailQuery_Click);
            // 
            // toolVersionComb
            // 
            this.toolVersionComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolVersionComb.DropDownWidth = 80;
            this.toolVersionComb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolVersionComb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolVersionComb.Name = "toolVersionComb";
            this.toolVersionComb.Size = new System.Drawing.Size(80, 25);
            this.toolVersionComb.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolProComb
            // 
            this.toolProComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolProComb.DropDownWidth = 100;
            this.toolProComb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolProComb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolProComb.Name = "toolProComb";
            this.toolProComb.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolProValue
            // 
            this.toolProValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolProValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolProValue.Name = "toolProValue";
            this.toolProValue.Size = new System.Drawing.Size(100, 25);
            this.toolProValue.Text = "请输入属性值";
            // 
            // toolQuery
            // 
            this.toolQuery.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.toolQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQuery.Name = "toolQuery";
            this.toolQuery.Size = new System.Drawing.Size(52, 22);
            this.toolQuery.Text = "查询";
            this.toolQuery.Click += new System.EventHandler(this.toolQuery_Click);
            // 
            // productChecked
            // 
            this.productChecked.HeaderText = "";
            this.productChecked.Name = "productChecked";
            this.productChecked.Width = 50;
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.DataPropertyName = "PRODUCTID";
            this.PRODUCTID.HeaderText = "主键";
            this.PRODUCTID.Name = "PRODUCTID";
            this.PRODUCTID.Visible = false;
            // 
            // PRODUCTNO
            // 
            this.PRODUCTNO.DataPropertyName = "PRODUCTNO";
            this.PRODUCTNO.HeaderText = "产品编号";
            this.PRODUCTNO.Name = "PRODUCTNO";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MODELTYPE";
            this.Column11.HeaderText = "产品型号";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "PRODUCTTYPE";
            this.Column12.HeaderText = "产品类型";
            this.Column12.Name = "Column12";
            // 
            // partsChecked
            // 
            this.partsChecked.HeaderText = "";
            this.partsChecked.Name = "partsChecked";
            this.partsChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partsChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partsChecked.Width = 50;
            // 
            // PRODUCTID_P
            // 
            this.PRODUCTID_P.DataPropertyName = "PRODUCTID";
            this.PRODUCTID_P.HeaderText = "主键";
            this.PRODUCTID_P.Name = "PRODUCTID_P";
            this.PRODUCTID_P.Visible = false;
            // 
            // PRODUCTNO_P
            // 
            this.PRODUCTNO_P.DataPropertyName = "PRODUCTNO";
            this.PRODUCTNO_P.HeaderText = "半成品编号";
            this.PRODUCTNO_P.Name = "PRODUCTNO_P";
            // 
            // modeltype
            // 
            this.modeltype.DataPropertyName = "MODELTYPE";
            this.modeltype.HeaderText = "半成品型号";
            this.modeltype.Name = "modeltype";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PRODUCTTYPE";
            this.Column4.HeaderText = "半成品类型";
            this.Column4.Name = "Column4";
            // 
            // ProductsStructAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 410);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProductsStructAddForm";
            this.Text = "产品结构选择";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartsList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView tv_struct;
        private System.Windows.Forms.ToolStripButton toolDetailQuery;
        private System.Windows.Forms.ToolStripComboBox toolVersionComb;
        private System.Windows.Forms.ToolStripComboBox toolProComb;
        private System.Windows.Forms.ToolStripTextBox toolProValue;
        private System.Windows.Forms.ToolStripButton toolQuery;
        private System.Windows.Forms.DataGridView dgv_PartsList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList tv_imageList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolSelect;
        private System.Windows.Forms.DataGridView dgv_MaterialList;
        private System.Windows.Forms.DataGridView dgv_productList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIALID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn productChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn partsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTID_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNO_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}