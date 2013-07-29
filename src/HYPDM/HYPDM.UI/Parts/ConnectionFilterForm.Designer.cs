namespace HYPDM.WinUI.Parts
{
    partial class ConnectionFilterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cobSurfaceSolve = new System.Windows.Forms.ComboBox();
            this.cobVersionType = new System.Windows.Forms.ComboBox();
            this.txtSingleNetweight = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSpecificationCode = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtPartsNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPrivate = new System.Windows.Forms.RadioButton();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.radPublic = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvFilterList = new System.Windows.Forms.DataGridView();
            this.OwnerShip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecificationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleNetweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurfaceSolve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.cmFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.cobSurfaceSolve);
            this.panel1.Controls.Add(this.cobVersionType);
            this.panel1.Controls.Add(this.txtSingleNetweight);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtSpecificationCode);
            this.panel1.Controls.Add(this.txtSortCode);
            this.panel1.Controls.Add(this.txtVersion);
            this.panel1.Controls.Add(this.txtPartsNo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 427);
            this.panel1.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(99, 199);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(162, 21);
            this.dtpTo.TabIndex = 22;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(99, 169);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(162, 21);
            this.dtpFrom.TabIndex = 21;
            // 
            // cobSurfaceSolve
            // 
            this.cobSurfaceSolve.FormattingEnabled = true;
            this.cobSurfaceSolve.Location = new System.Drawing.Point(99, 380);
            this.cobSurfaceSolve.Name = "cobSurfaceSolve";
            this.cobSurfaceSolve.Size = new System.Drawing.Size(162, 20);
            this.cobSurfaceSolve.TabIndex = 20;
            // 
            // cobVersionType
            // 
            this.cobVersionType.FormattingEnabled = true;
            this.cobVersionType.Items.AddRange(new object[] {
            "工作版本"});
            this.cobVersionType.Location = new System.Drawing.Point(99, 140);
            this.cobVersionType.Name = "cobVersionType";
            this.cobVersionType.Size = new System.Drawing.Size(162, 20);
            this.cobVersionType.TabIndex = 19;
            // 
            // txtSingleNetweight
            // 
            this.txtSingleNetweight.Location = new System.Drawing.Point(99, 350);
            this.txtSingleNetweight.Name = "txtSingleNetweight";
            this.txtSingleNetweight.Size = new System.Drawing.Size(162, 21);
            this.txtSingleNetweight.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(99, 320);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(162, 21);
            this.txtQuantity.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 290);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(162, 21);
            this.txtDescription.TabIndex = 16;
            // 
            // txtSpecificationCode
            // 
            this.txtSpecificationCode.Location = new System.Drawing.Point(99, 260);
            this.txtSpecificationCode.Name = "txtSpecificationCode";
            this.txtSpecificationCode.Size = new System.Drawing.Size(162, 21);
            this.txtSpecificationCode.TabIndex = 15;
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(99, 230);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(162, 21);
            this.txtSortCode.TabIndex = 14;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(99, 110);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(162, 21);
            this.txtVersion.TabIndex = 13;
            // 
            // txtPartsNo
            // 
            this.txtPartsNo.Location = new System.Drawing.Point(99, 80);
            this.txtPartsNo.Name = "txtPartsNo";
            this.txtPartsNo.Size = new System.Drawing.Size(162, 21);
            this.txtPartsNo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "表面处理";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "单位净重";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "数量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "描述";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "规格代号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "顺序";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "版本类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "版本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "编号";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radPrivate);
            this.panel2.Controls.Add(this.chkView);
            this.panel2.Controls.Add(this.radPublic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 70);
            this.panel2.TabIndex = 0;
            // 
            // radPrivate
            // 
            this.radPrivate.AutoSize = true;
            this.radPrivate.Location = new System.Drawing.Point(214, 13);
            this.radPrivate.Name = "radPrivate";
            this.radPrivate.Size = new System.Drawing.Size(47, 16);
            this.radPrivate.TabIndex = 4;
            this.radPrivate.TabStop = true;
            this.radPrivate.Text = "私有";
            this.radPrivate.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(99, 49);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(15, 14);
            this.chkView.TabIndex = 3;
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // radPublic
            // 
            this.radPublic.AutoSize = true;
            this.radPublic.Location = new System.Drawing.Point(99, 13);
            this.radPublic.Name = "radPublic";
            this.radPublic.Size = new System.Drawing.Size(47, 16);
            this.radPublic.TabIndex = 2;
            this.radPublic.TabStop = true;
            this.radPublic.Text = "公有";
            this.radPublic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "视图(View)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "所有权";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnSelect);
            this.panel3.Controls.Add(this.dgvFilterList);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.txtFilterName);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(299, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 427);
            this.panel3.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(188, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(107, 385);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvFilterList
            // 
            this.dgvFilterList.AllowUserToAddRows = false;
            this.dgvFilterList.AllowUserToDeleteRows = false;
            this.dgvFilterList.AutoGenerateColumns = false;
            this.dgvFilterList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnerShip,
            this.FileName,
            this.PartsNo,
            this.Version,
            this.VersionType,
            this.From,
            this.To,
            this.SortCode,
            this.SpecificationCode,
            this.Description,
            this.Quantity,
            this.SingleNetweight,
            this.SurfaceSolve});
            this.dgvFilterList.DataSource = this.filterBindingSource;
            this.dgvFilterList.Location = new System.Drawing.Point(14, 39);
            this.dgvFilterList.MultiSelect = false;
            this.dgvFilterList.Name = "dgvFilterList";
            this.dgvFilterList.ReadOnly = true;
            this.dgvFilterList.RowHeadersVisible = false;
            this.dgvFilterList.RowTemplate.Height = 23;
            this.dgvFilterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilterList.Size = new System.Drawing.Size(329, 340);
            this.dgvFilterList.TabIndex = 7;
            this.dgvFilterList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilterList_CellClick);
            this.dgvFilterList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFilterList_CellMouseDown);
            // 
            // OwnerShip
            // 
            this.OwnerShip.DataPropertyName = "OWNERSHIP";
            this.OwnerShip.HeaderText = "所有权";
            this.OwnerShip.Name = "OwnerShip";
            this.OwnerShip.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FILTERNAME";
            this.FileName.HeaderText = "文件名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
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
            // VersionType
            // 
            this.VersionType.DataPropertyName = "VERSIONTYPE";
            this.VersionType.HeaderText = "版本类型";
            this.VersionType.Name = "VersionType";
            this.VersionType.ReadOnly = true;
            // 
            // From
            // 
            this.From.DataPropertyName = "FROM";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.DataPropertyName = "TO";
            this.To.HeaderText = "To";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // SortCode
            // 
            this.SortCode.DataPropertyName = "SORTCODE";
            this.SortCode.HeaderText = "顺序";
            this.SortCode.Name = "SortCode";
            this.SortCode.ReadOnly = true;
            // 
            // SpecificationCode
            // 
            this.SpecificationCode.DataPropertyName = "SPECIFICATIONCODE";
            this.SpecificationCode.HeaderText = "规格代号";
            this.SpecificationCode.Name = "SpecificationCode";
            this.SpecificationCode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QUANTITY";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SingleNetweight
            // 
            this.SingleNetweight.DataPropertyName = "SINGLENETWEIGHT";
            this.SingleNetweight.HeaderText = "单位净重";
            this.SingleNetweight.Name = "SingleNetweight";
            this.SingleNetweight.ReadOnly = true;
            // 
            // SurfaceSolve
            // 
            this.SurfaceSolve.DataPropertyName = "SURFACESOLVE";
            this.SurfaceSolve.HeaderText = "表面处理";
            this.SurfaceSolve.Name = "SurfaceSolve";
            this.SurfaceSolve.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFilterName
            // 
            this.txtFilterName.Location = new System.Drawing.Point(85, 12);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(204, 21);
            this.txtFilterName.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "过滤器名称";
            // 
            // cmFilter
            // 
            this.cmFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmSelect,
            this.cmDelete});
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(153, 70);
            // 
            // cmSelect
            // 
            this.cmSelect.Name = "cmSelect";
            this.cmSelect.Size = new System.Drawing.Size(152, 22);
            this.cmSelect.Text = "选择";
            this.cmSelect.Click += new System.EventHandler(this.cmSelect_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(152, 22);
            this.cmDelete.Text = "删除";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // ConnectionFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ConnectionFilterForm";
            this.Text = "连接过滤器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.cmFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.RadioButton radPublic;
        private System.Windows.Forms.RadioButton radPrivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPartsNo;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtSingleNetweight;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSpecificationCode;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.ComboBox cobVersionType;
        private System.Windows.Forms.ComboBox cobSurfaceSolve;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvFilterList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerShip;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn SortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecificationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingleNetweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurfaceSolve;
        private System.Windows.Forms.BindingSource filterBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmFilter;
        private System.Windows.Forms.ToolStripMenuItem cmSelect;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
    }
}