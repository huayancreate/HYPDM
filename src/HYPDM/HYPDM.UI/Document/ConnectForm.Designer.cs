namespace HYPDM.WinUI.Document
{
    partial class ConnectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMaterial = new HYPDM.BaseControl.DataGridViewExt();
            this.chk1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MATERIALID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIALNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIALTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAWMATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIALSRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTREATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFYTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_ZH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVProduct = new HYPDM.BaseControl.DataGridViewExt();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELTYPE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTLEVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERSION1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATER1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFIER1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFYTIME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_ZH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO_EN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.comboMaterialNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combQueryType = new System.Windows.Forms.ComboBox();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 360);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMaterial);
            this.groupBox2.Controls.Add(this.dGVProduct);
            this.groupBox2.Controls.Add(this.ucPaging1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 313);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据列表";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk1,
            this.MATERIALID,
            this.MATERIALNO,
            this.MODELTYPE,
            this.MATERIALTYPE,
            this.RAWMATERIAL,
            this.MATERIALSRC,
            this.VERSION,
            this.CREATER,
            this.MODIFIER,
            this.CTREATETIME,
            this.MODIFYTIME,
            this.MEMO_ZH,
            this.MEMO_EN});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterial.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvMaterial.Location = new System.Drawing.Point(3, 17);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvMaterial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvMaterial.RowTemplate.Height = 23;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(726, 256);
            this.dgvMaterial.TabIndex = 2;
            // 
            // chk1
            // 
            this.chk1.DataPropertyName = "chk";
            this.chk1.FalseValue = "false";
            this.chk1.Frozen = true;
            this.chk1.HeaderText = "选择";
            this.chk1.Name = "chk1";
            this.chk1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk1.TrueValue = "true";
            // 
            // MATERIALID
            // 
            this.MATERIALID.DataPropertyName = "MATERIALID";
            this.MATERIALID.Frozen = true;
            this.MATERIALID.HeaderText = "物料主键";
            this.MATERIALID.Name = "MATERIALID";
            this.MATERIALID.Visible = false;
            // 
            // MATERIALNO
            // 
            this.MATERIALNO.DataPropertyName = "MATERIALNO";
            this.MATERIALNO.Frozen = true;
            this.MATERIALNO.HeaderText = "物料号";
            this.MATERIALNO.Name = "MATERIALNO";
            // 
            // MODELTYPE
            // 
            this.MODELTYPE.DataPropertyName = "MODELTYPE";
            this.MODELTYPE.HeaderText = "MODELTYPE";
            this.MODELTYPE.Name = "MODELTYPE";
            // 
            // MATERIALTYPE
            // 
            this.MATERIALTYPE.DataPropertyName = "MATERIALTYPE";
            this.MATERIALTYPE.HeaderText = "MATERIALTYPE";
            this.MATERIALTYPE.Name = "MATERIALTYPE";
            // 
            // RAWMATERIAL
            // 
            this.RAWMATERIAL.DataPropertyName = "RAWMATERIAL";
            this.RAWMATERIAL.HeaderText = "RAWMATERIAL";
            this.RAWMATERIAL.Name = "RAWMATERIAL";
            // 
            // MATERIALSRC
            // 
            this.MATERIALSRC.DataPropertyName = "MATERIALSRC";
            this.MATERIALSRC.HeaderText = "MATERIALSRC";
            this.MATERIALSRC.Name = "MATERIALSRC";
            // 
            // VERSION
            // 
            this.VERSION.DataPropertyName = "VERSION";
            this.VERSION.HeaderText = "版本";
            this.VERSION.Name = "VERSION";
            // 
            // CREATER
            // 
            this.CREATER.DataPropertyName = "CREATER";
            this.CREATER.HeaderText = "CREATER";
            this.CREATER.Name = "CREATER";
            // 
            // MODIFIER
            // 
            this.MODIFIER.DataPropertyName = "MODIFIER";
            this.MODIFIER.HeaderText = "MODIFIER";
            this.MODIFIER.Name = "MODIFIER";
            // 
            // CTREATETIME
            // 
            this.CTREATETIME.DataPropertyName = "CTREATETIME";
            this.CTREATETIME.HeaderText = "CTREATETIME";
            this.CTREATETIME.Name = "CTREATETIME";
            // 
            // MODIFYTIME
            // 
            this.MODIFYTIME.DataPropertyName = "MODIFYTIME";
            this.MODIFYTIME.HeaderText = "MODIFYTIME";
            this.MODIFYTIME.Name = "MODIFYTIME";
            // 
            // MEMO_ZH
            // 
            this.MEMO_ZH.DataPropertyName = "MEMO_ZH";
            this.MEMO_ZH.HeaderText = "MEMO_ZH";
            this.MEMO_ZH.Name = "MEMO_ZH";
            // 
            // MEMO_EN
            // 
            this.MEMO_EN.DataPropertyName = "MEMO_EN";
            this.MEMO_EN.HeaderText = "MEMO_EN";
            this.MEMO_EN.Name = "MEMO_EN";
            // 
            // dGVProduct
            // 
            this.dGVProduct.AllowUserToAddRows = false;
            this.dGVProduct.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dGVProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.PRODUCTID,
            this.PRODUCTNO,
            this.MODELTYPE1,
            this.PRODUCTTYPE,
            this.PRODUCTLEVEL,
            this.VERSION1,
            this.STATUS,
            this.CREATER1,
            this.MODIFIER1,
            this.CREATETIME,
            this.MODIFYTIME1,
            this.MEMO_ZH1,
            this.MEMO_EN1,
            this.MEMO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGVProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProduct.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVProduct.Location = new System.Drawing.Point(3, 17);
            this.dGVProduct.Name = "dGVProduct";
            this.dGVProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVProduct.RowTemplate.Height = 23;
            this.dGVProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProduct.Size = new System.Drawing.Size(726, 256);
            this.dGVProduct.TabIndex = 1;
            // 
            // chk
            // 
            this.chk.DataPropertyName = "chk";
            this.chk.FalseValue = "false";
            this.chk.Frozen = true;
            this.chk.HeaderText = "选择";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.TrueValue = "true";
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.DataPropertyName = "PRODUCTID";
            this.PRODUCTID.Frozen = true;
            this.PRODUCTID.HeaderText = "PRODUCTID";
            this.PRODUCTID.Name = "PRODUCTID";
            this.PRODUCTID.Visible = false;
            // 
            // PRODUCTNO
            // 
            this.PRODUCTNO.DataPropertyName = "PRODUCTNO";
            this.PRODUCTNO.Frozen = true;
            this.PRODUCTNO.HeaderText = "产品NO";
            this.PRODUCTNO.Name = "PRODUCTNO";
            // 
            // MODELTYPE1
            // 
            this.MODELTYPE1.DataPropertyName = "MODELTYPE";
            this.MODELTYPE1.HeaderText = "MODELTYPE";
            this.MODELTYPE1.Name = "MODELTYPE1";
            // 
            // PRODUCTTYPE
            // 
            this.PRODUCTTYPE.DataPropertyName = "PRODUCTTYPE";
            this.PRODUCTTYPE.HeaderText = "PRODUCTTYPE";
            this.PRODUCTTYPE.Name = "PRODUCTTYPE";
            // 
            // PRODUCTLEVEL
            // 
            this.PRODUCTLEVEL.DataPropertyName = "PRODUCTLEVEL";
            this.PRODUCTLEVEL.HeaderText = "PRODUCTLEVEL";
            this.PRODUCTLEVEL.Name = "PRODUCTLEVEL";
            // 
            // VERSION1
            // 
            this.VERSION1.DataPropertyName = "VERSION";
            this.VERSION1.HeaderText = "版本";
            this.VERSION1.Name = "VERSION1";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // CREATER1
            // 
            this.CREATER1.DataPropertyName = "CREATER";
            this.CREATER1.HeaderText = "CREATER";
            this.CREATER1.Name = "CREATER1";
            // 
            // MODIFIER1
            // 
            this.MODIFIER1.DataPropertyName = "MODIFIER";
            this.MODIFIER1.HeaderText = "MODIFIER";
            this.MODIFIER1.Name = "MODIFIER1";
            // 
            // CREATETIME
            // 
            this.CREATETIME.DataPropertyName = "CREATETIME";
            this.CREATETIME.HeaderText = "创建时间";
            this.CREATETIME.Name = "CREATETIME";
            // 
            // MODIFYTIME1
            // 
            this.MODIFYTIME1.DataPropertyName = "MODIFYTIME";
            this.MODIFYTIME1.HeaderText = "修改时间";
            this.MODIFYTIME1.Name = "MODIFYTIME1";
            // 
            // MEMO_ZH1
            // 
            this.MEMO_ZH1.DataPropertyName = "MEMO_ZH";
            this.MEMO_ZH1.HeaderText = "MEMO_ZH";
            this.MEMO_ZH1.Name = "MEMO_ZH1";
            // 
            // MEMO_EN1
            // 
            this.MEMO_EN1.DataPropertyName = "MEMO_EN";
            this.MEMO_EN1.HeaderText = "MEMO_EN";
            this.MEMO_EN1.Name = "MEMO_EN1";
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "MEMO";
            this.MEMO.Name = "MEMO";
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = true;
            this.ucPaging1.Location = new System.Drawing.Point(3, 273);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 20;
            this.ucPaging1.Size = new System.Drawing.Size(726, 37);
            this.ucPaging1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.comboMaterialNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combQueryType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.view;
            this.btnQuery.Location = new System.Drawing.Point(620, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(32, 31);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(418, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(193, 21);
            this.txtValue.TabIndex = 3;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            this.txtValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtValue_MouseDown);
            // 
            // comboMaterialNo
            // 
            this.comboMaterialNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaterialNo.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboMaterialNo.FormattingEnabled = true;
            this.comboMaterialNo.Items.AddRange(new object[] {
            "料号"});
            this.comboMaterialNo.Location = new System.Drawing.Point(290, 15);
            this.comboMaterialNo.Name = "comboMaterialNo";
            this.comboMaterialNo.Size = new System.Drawing.Size(121, 23);
            this.comboMaterialNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "关联类型";
            // 
            // combQueryType
            // 
            this.combQueryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryType.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combQueryType.FormattingEnabled = true;
            this.combQueryType.Items.AddRange(new object[] {
            "产品",
            "物料"});
            this.combQueryType.Location = new System.Drawing.Point(103, 15);
            this.combQueryType.Name = "combQueryType";
            this.combQueryType.Size = new System.Drawing.Size(181, 23);
            this.combQueryType.TabIndex = 0;
            this.combQueryType.SelectedIndexChanged += new System.EventHandler(this.combQueryType_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(610, 367);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(57, 31);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "查看";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(477, 367);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(61, 31);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(544, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(60, 31);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "完成";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(673, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel1);
            this.Name = "ConnectForm";
            this.Text = "关联关系";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource docBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private BaseControl.UcPaging ucPaging1;
        private BaseControl.DataGridViewExt dGVProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combQueryType;
        private BaseControl.DataGridViewExt dgvMaterial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIALID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIALNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIALTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAWMATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIALSRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTREATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFYTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_ZH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_EN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELTYPE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTLEVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERSION1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATER1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFIER1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFYTIME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_ZH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO_EN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboMaterialNo;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnQuery;

    }
}