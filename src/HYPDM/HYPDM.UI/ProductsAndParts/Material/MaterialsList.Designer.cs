namespace HYPDM.WinUI.ProductsAndParts.Material
{
    partial class MaterialsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts_tool_Materail = new System.Windows.Forms.ToolStrip();
            this.add_Materail = new System.Windows.Forms.ToolStripButton();
            this.conf_Materail = new System.Windows.Forms.ToolStripButton();
            this.edit_Materail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.print_Materail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.query_Materail = new System.Windows.Forms.ToolStripButton();
            this.dgv_MaterailList = new HYPDM.BaseControl.DataGridViewExt();
            this.cms_Memu_Materail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_materail_memu = new System.Windows.Forms.ToolStripMenuItem();
            this.conf_materail_memu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.del_materail_memu = new System.Windows.Forms.ToolStripMenuItem();
            this.pagination1 = new HYPDM.WinUI.DefineControl.Pagination();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts_tool_Materail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaterailList)).BeginInit();
            this.cms_Memu_Materail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_tool_Materail
            // 
            this.ts_tool_Materail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Materail,
            this.conf_Materail,
            this.edit_Materail,
            this.toolStripSeparator1,
            this.print_Materail,
            this.toolStripSeparator2,
            this.query_Materail});
            this.ts_tool_Materail.Location = new System.Drawing.Point(0, 0);
            this.ts_tool_Materail.Name = "ts_tool_Materail";
            this.ts_tool_Materail.Size = new System.Drawing.Size(835, 25);
            this.ts_tool_Materail.TabIndex = 0;
            this.ts_tool_Materail.Text = "toolStrip1";
            // 
            // add_Materail
            // 
            this.add_Materail.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.add_Materail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_Materail.Name = "add_Materail";
            this.add_Materail.Size = new System.Drawing.Size(52, 22);
            this.add_Materail.Text = "增加";
            this.add_Materail.Click += new System.EventHandler(this.add_Materail_Click);
            // 
            // conf_Materail
            // 
            this.conf_Materail.Image = global::HYPDM.WinUI.Properties.Resources.pagination_load;
            this.conf_Materail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.conf_Materail.Name = "conf_Materail";
            this.conf_Materail.Size = new System.Drawing.Size(52, 22);
            this.conf_Materail.Text = "配置";
            this.conf_Materail.Click += new System.EventHandler(this.conf_Materail_Click);
            // 
            // edit_Materail
            // 
            this.edit_Materail.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.edit_Materail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_Materail.Name = "edit_Materail";
            this.edit_Materail.Size = new System.Drawing.Size(52, 22);
            this.edit_Materail.Text = "删除";
            this.edit_Materail.Click += new System.EventHandler(this.edit_Materail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // print_Materail
            // 
            this.print_Materail.Image = ((System.Drawing.Image)(resources.GetObject("print_Materail.Image")));
            this.print_Materail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_Materail.Name = "print_Materail";
            this.print_Materail.Size = new System.Drawing.Size(52, 22);
            this.print_Materail.Text = "打印";
            this.print_Materail.Click += new System.EventHandler(this.print_Materail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // query_Materail
            // 
            this.query_Materail.Image = ((System.Drawing.Image)(resources.GetObject("query_Materail.Image")));
            this.query_Materail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.query_Materail.Name = "query_Materail";
            this.query_Materail.Size = new System.Drawing.Size(52, 22);
            this.query_Materail.Text = "查询";
            this.query_Materail.Click += new System.EventHandler(this.query_Materail_Click);
            // 
            // dgv_MaterailList
            // 
            this.dgv_MaterailList.AllowUserToAddRows = false;
            this.dgv_MaterailList.AllowUserToDeleteRows = false;
            this.dgv_MaterailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MaterailList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_MaterailList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_MaterailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MaterailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_MaterailList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MaterailList.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_MaterailList.Location = new System.Drawing.Point(3, 28);
            this.dgv_MaterailList.MultiSelect = false;
            this.dgv_MaterailList.Name = "dgv_MaterailList";
            this.dgv_MaterailList.ReadOnly = true;
            this.dgv_MaterailList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_MaterailList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_MaterailList.RowTemplate.Height = 23;
            this.dgv_MaterailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MaterailList.Size = new System.Drawing.Size(832, 366);
            this.dgv_MaterailList.TabIndex = 1;
            this.dgv_MaterailList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_MaterailList_CellMouseDown);
            // 
            // cms_Memu_Materail
            // 
            this.cms_Memu_Materail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_materail_memu,
            this.conf_materail_memu,
            this.toolStripSeparator3,
            this.del_materail_memu});
            this.cms_Memu_Materail.Name = "cms_Memu_Materail";
            this.cms_Memu_Materail.Size = new System.Drawing.Size(153, 98);
            // 
            // add_materail_memu
            // 
            this.add_materail_memu.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.add_materail_memu.Name = "add_materail_memu";
            this.add_materail_memu.Size = new System.Drawing.Size(100, 22);
            this.add_materail_memu.Text = "增加";
            this.add_materail_memu.Click += new System.EventHandler(this.add_materail_memu_Click);
            // 
            // conf_materail_memu
            // 
            this.conf_materail_memu.Image = global::HYPDM.WinUI.Properties.Resources.pagination_load;
            this.conf_materail_memu.Name = "conf_materail_memu";
            this.conf_materail_memu.Size = new System.Drawing.Size(152, 22);
            this.conf_materail_memu.Text = "配置";
            this.conf_materail_memu.Click += new System.EventHandler(this.conf_materail_memu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(97, 6);
            // 
            // del_materail_memu
            // 
            this.del_materail_memu.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.del_materail_memu.Name = "del_materail_memu";
            this.del_materail_memu.Size = new System.Drawing.Size(100, 22);
            this.del_materail_memu.Text = "删除";
            this.del_materail_memu.Click += new System.EventHandler(this.del_materail_memu_Click);
            // 
            // pagination1
            // 
            this.pagination1.CurrentPage = 1;
            this.pagination1.CurrentRows = 20;
            this.pagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagination1.Location = new System.Drawing.Point(0, 393);
            this.pagination1.Name = "pagination1";
            this.pagination1.QueryCondition = null;
            this.pagination1.Size = new System.Drawing.Size(835, 26);
            this.pagination1.TabIndex = 2;
            this.pagination1.TotalPage = 0;
            this.pagination1.TotalRows = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATERIALID";
            this.Column1.HeaderText = "主键";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MATERIALNO";
            this.Column2.HeaderText = "编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MODELTYPE";
            this.Column3.HeaderText = "型号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MATERIALTYPE";
            this.Column4.HeaderText = "类型";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RAWMATERIAL";
            this.Column5.HeaderText = "材质";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MATERIALSRC";
            this.Column6.HeaderText = "来源";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "VERSION";
            this.Column7.HeaderText = "版本";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CREATER";
            this.Column8.HeaderText = "创建人";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MODIFIER";
            this.Column9.HeaderText = "修改人";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "CTREATETIME";
            this.Column10.HeaderText = "创建时间";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MODIFYTIME";
            this.Column11.HeaderText = "修改时间";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MEMO_ZH";
            this.Column12.HeaderText = "中文描述";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MEMO_EN";
            this.Column13.HeaderText = "英文描述";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MEMO";
            this.Column14.HeaderText = "备注";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // MaterialsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.dgv_MaterailList);
            this.Controls.Add(this.ts_tool_Materail);
            this.Name = "MaterialsList";
            this.Size = new System.Drawing.Size(835, 419);
            this.ts_tool_Materail.ResumeLayout(false);
            this.ts_tool_Materail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MaterailList)).EndInit();
            this.cms_Memu_Materail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_tool_Materail;
        private System.Windows.Forms.ToolStripButton add_Materail;
        private System.Windows.Forms.ToolStripButton conf_Materail;
        private System.Windows.Forms.ToolStripButton edit_Materail;
        private System.Windows.Forms.ToolStripButton print_Materail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton query_Materail;
        private System.Windows.Forms.ContextMenuStrip cms_Memu_Materail;
        private System.Windows.Forms.ToolStripMenuItem add_materail_memu;
        private System.Windows.Forms.ToolStripMenuItem conf_materail_memu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem del_materail_memu;
        private DefineControl.Pagination pagination1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private BaseControl.DataGridViewExt dgv_MaterailList;

    }
}
