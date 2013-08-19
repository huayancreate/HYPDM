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
            this.PartsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsClassfication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmSemiPro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmRecordAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRecordProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.cmSemiPro.SuspendLayout();
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
            // dgvPartsList
            // 
            this.dgvPartsList.AllowUserToAddRows = false;
            this.dgvPartsList.AllowUserToDeleteRows = false;
            this.dgvPartsList.AutoGenerateColumns = false;
            this.dgvPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartsID,
            this.PartsNo,
            this.Version,
            this.Description,
            this.PartsType,
            this.PartsClassfication,
            this.Status,
            this.LastUpdateUser});
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
            this.dgvPartsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartsList_CellDoubleClick);
            this.dgvPartsList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPartsList_CellMouseDown);
            // 
            // PartsID
            // 
            this.PartsID.DataPropertyName = "PARTSID";
            this.PartsID.HeaderText = "PartsID";
            this.PartsID.Name = "PartsID";
            this.PartsID.ReadOnly = true;
            this.PartsID.Visible = false;
            // 
            // PartsNo
            // 
            this.PartsNo.DataPropertyName = "PARTSNO";
            this.PartsNo.HeaderText = "编号";
            this.PartsNo.Name = "PartsNo";
            this.PartsNo.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "VERSION";
            this.Version.HeaderText = "版本";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // PartsType
            // 
            this.PartsType.DataPropertyName = "PARTSTYPE";
            this.PartsType.HeaderText = "零部件类型";
            this.PartsType.Name = "PartsType";
            this.PartsType.ReadOnly = true;
            // 
            // PartsClassfication
            // 
            this.PartsClassfication.DataPropertyName = "PARTSCLASSFICATION";
            this.PartsClassfication.HeaderText = "零部件分类";
            this.PartsClassfication.Name = "PartsClassfication";
            this.PartsClassfication.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "STATUS";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LastUpdateUser
            // 
            this.LastUpdateUser.DataPropertyName = "LASTUPDATEUSER";
            this.LastUpdateUser.HeaderText = "修改者";
            this.LastUpdateUser.Name = "LastUpdateUser";
            this.LastUpdateUser.ReadOnly = true;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(HYPDM.Entities.PDM_PARTS);
            // 
            // cmSemiPro
            // 
            this.cmSemiPro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRecordAdd,
            this.cmRecordProperty,
            this.toolStripSeparator2,
            this.cmRecordDelete});
            this.cmSemiPro.Name = "contextMenuStrip1";
            this.cmSemiPro.Size = new System.Drawing.Size(153, 98);
            // 
            // cmRecordAdd
            // 
            this.cmRecordAdd.Name = "cmRecordAdd";
            this.cmRecordAdd.Size = new System.Drawing.Size(152, 22);
            this.cmRecordAdd.Text = "记录添加(&A)";
            this.cmRecordAdd.Click += new System.EventHandler(this.cmRecordAdd_Click);
            // 
            // cmRecordProperty
            // 
            this.cmRecordProperty.Name = "cmRecordProperty";
            this.cmRecordProperty.Size = new System.Drawing.Size(152, 22);
            this.cmRecordProperty.Text = "记录属性(&P)";
            this.cmRecordProperty.Click += new System.EventHandler(this.cmRecordProperty_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // cmRecordDelete
            // 
            this.cmRecordDelete.Name = "cmRecordDelete";
            this.cmRecordDelete.Size = new System.Drawing.Size(152, 22);
            this.cmRecordDelete.Text = "记录删除(&D)";
            this.cmRecordDelete.Click += new System.EventHandler(this.cmRecordDelete_Click);
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
            this.cmSemiPro.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmSemiPro;
        private System.Windows.Forms.ToolStripMenuItem cmRecordAdd;
        private System.Windows.Forms.ToolStripMenuItem cmRecordProperty;
        private System.Windows.Forms.ToolStripMenuItem cmRecordDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsClassfication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateUser;
    }
}
