namespace HYPDM.WinUI.DrawingDocument
{
    partial class DrawRegForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawRegForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.tpRemark = new System.Windows.Forms.TabPage();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tpParts = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.dGVProduct = new HYPDM.BaseControl.DataGridViewExt();
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
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.dgvMaterial = new HYPDM.BaseControl.DataGridViewExt();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建关联对象ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品零部件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零部件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHalfProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCad = new System.Windows.Forms.TabPage();
            this.tvCad = new AdvancedDataGridView.TreeGridView();
            this.menuCadObject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCadView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadDownLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCadCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCancelCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCadFileDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tspRegPhysicCad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tspCadDownLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tpVersion = new System.Windows.Forms.TabPage();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.tpgExtandsProperties = new System.Windows.Forms.TabPage();
            this.dgvExptendProperties = new HYPDM.BaseControl.DataGridViewExt();
            this.PARAMS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARGET_COLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspExtands = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddProperties = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtUpdateDate = new System.Windows.Forms.TextBox();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.txtDocNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cobDocType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDocAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DFL_FILE_NAME = new AdvancedDataGridView.TreeGridColumn();
            this.FilePathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_CAD_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CadPathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_ID_CAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new AdvancedDataGridView.TreeGridColumn();
            this.Column3 = new AdvancedDataGridView.TreeGridColumn();
            this.Column4 = new AdvancedDataGridView.TreeGridColumn();
            this.Column5 = new AdvancedDataGridView.TreeGridColumn();
            this.Column6 = new AdvancedDataGridView.TreeGridColumn();
            this.imageStrip = new System.Windows.Forms.ImageList(this.components);
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_FILE_NAME1 = new AdvancedDataGridView.TreeGridColumn();
            this.FilePathName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinflg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutflg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbcContent.SuspendLayout();
            this.tpRemark.SuspendLayout();
            this.tpParts.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).BeginInit();
            this.tabMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvCad)).BeginInit();
            this.menuCadObject.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tpVersion.SuspendLayout();
            this.tpgExtandsProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExptendProperties)).BeginInit();
            this.tspExtands.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcContent);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.tsToolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 419);
            this.panel1.TabIndex = 0;
            // 
            // tbcContent
            // 
            this.tbcContent.Controls.Add(this.tpRemark);
            this.tbcContent.Controls.Add(this.tpParts);
            this.tbcContent.Controls.Add(this.tabCad);
            this.tbcContent.Controls.Add(this.tpVersion);
            this.tbcContent.Controls.Add(this.tpgExtandsProperties);
            this.tbcContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbcContent.Location = new System.Drawing.Point(247, 25);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(626, 394);
            this.tbcContent.TabIndex = 7;
            // 
            // tpRemark
            // 
            this.tpRemark.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpRemark.Controls.Add(this.txtRemark);
            this.tpRemark.Location = new System.Drawing.Point(4, 22);
            this.tpRemark.Name = "tpRemark";
            this.tpRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemark.Size = new System.Drawing.Size(618, 368);
            this.tpRemark.TabIndex = 0;
            this.tpRemark.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(3, 3);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(612, 362);
            this.txtRemark.TabIndex = 8;
            // 
            // tpParts
            // 
            this.tpParts.Controls.Add(this.tabControl2);
            this.tpParts.Controls.Add(this.menuStrip1);
            this.tpParts.Location = new System.Drawing.Point(4, 22);
            this.tpParts.Name = "tpParts";
            this.tpParts.Size = new System.Drawing.Size(618, 368);
            this.tpParts.TabIndex = 3;
            this.tpParts.Text = "产品零部件";
            this.tpParts.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabProduct);
            this.tabControl2.Controls.Add(this.tabMaterial);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(618, 343);
            this.tabControl2.TabIndex = 12;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.dGVProduct);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(610, 317);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "产品";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // dGVProduct
            // 
            this.dGVProduct.AllowUserToAddRows = false;
            this.dGVProduct.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dGVProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProduct.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVProduct.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVProduct.Location = new System.Drawing.Point(3, 3);
            this.dGVProduct.Name = "dGVProduct";
            this.dGVProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVProduct.RowTemplate.Height = 23;
            this.dGVProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVProduct.Size = new System.Drawing.Size(604, 311);
            this.dGVProduct.TabIndex = 2;
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
            // tabMaterial
            // 
            this.tabMaterial.Controls.Add(this.dgvMaterial);
            this.tabMaterial.Location = new System.Drawing.Point(4, 22);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaterial.Size = new System.Drawing.Size(610, 317);
            this.tabMaterial.TabIndex = 1;
            this.tabMaterial.Text = "材料";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.AllowUserToAddRows = false;
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvMaterial.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvMaterial.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvMaterial.RowTemplate.Height = 23;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(604, 311);
            this.dgvMaterial.TabIndex = 3;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建关联对象ToolStripMenuItem,
            this.btnAddRelation,
            this.btnDelRelation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建关联对象ToolStripMenuItem
            // 
            this.新建关联对象ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.产品零部件管理ToolStripMenuItem});
            this.新建关联对象ToolStripMenuItem.Name = "新建关联对象ToolStripMenuItem";
            this.新建关联对象ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.新建关联对象ToolStripMenuItem.Text = "新建关联对象";
            this.新建关联对象ToolStripMenuItem.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // 产品零部件管理ToolStripMenuItem
            // 
            this.产品零部件管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.零部件ToolStripMenuItem,
            this.btnProduct});
            this.产品零部件管理ToolStripMenuItem.Name = "产品零部件管理ToolStripMenuItem";
            this.产品零部件管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.产品零部件管理ToolStripMenuItem.Text = "产品零部件管理";
            // 
            // 零部件ToolStripMenuItem
            // 
            this.零部件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHalfProduct,
            this.btnMaterial});
            this.零部件ToolStripMenuItem.Name = "零部件ToolStripMenuItem";
            this.零部件ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.零部件ToolStripMenuItem.Text = "零部件";
            // 
            // btnHalfProduct
            // 
            this.btnHalfProduct.Name = "btnHalfProduct";
            this.btnHalfProduct.Size = new System.Drawing.Size(112, 22);
            this.btnHalfProduct.Tag = "半成品";
            this.btnHalfProduct.Text = "半成品";
            this.btnHalfProduct.Click += new System.EventHandler(this.btnHalfProduct_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(112, 22);
            this.btnMaterial.Tag = "原材料";
            this.btnMaterial.Text = "原材料";
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(112, 22);
            this.btnProduct.Text = "产品";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(68, 21);
            this.btnAddRelation.Text = "新增关联";
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // btnDelRelation
            // 
            this.btnDelRelation.Name = "btnDelRelation";
            this.btnDelRelation.Size = new System.Drawing.Size(68, 21);
            this.btnDelRelation.Text = "删除关联";
            this.btnDelRelation.Click += new System.EventHandler(this.btnDelRelation_Click);
            // 
            // tabCad
            // 
            this.tabCad.Controls.Add(this.tvCad);
            this.tabCad.Controls.Add(this.toolStrip1);
            this.tabCad.Location = new System.Drawing.Point(4, 22);
            this.tabCad.Name = "tabCad";
            this.tabCad.Size = new System.Drawing.Size(618, 368);
            this.tabCad.TabIndex = 4;
            this.tabCad.Text = "图纸";
            this.tabCad.UseVisualStyleBackColor = true;
            // 
            // tvCad
            // 
            this.tvCad.AllowUserToAddRows = false;
            this.tvCad.AllowUserToDeleteRows = false;
            this.tvCad.AllowUserToOrderColumns = true;
            this.tvCad.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tvCad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.tvCad.ColumnHeadersHeight = 20;
            this.tvCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DFL_FILE_NAME1,
            this.FilePathName1,
            this.Colver,
            this.checkinflg,
            this.checkindate,
            this.checkoutflg,
            this.checkoutdate,
            this.DFL_ID});
            this.tvCad.ContextMenuStrip = this.menuCadObject;
            this.tvCad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tvCad.ImageList = null;
            this.tvCad.Location = new System.Drawing.Point(0, 25);
            this.tvCad.Name = "tvCad";
            this.tvCad.RowHeadersVisible = false;
            this.tvCad.RowHeadersWidth = 20;
            this.tvCad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tvCad.Size = new System.Drawing.Size(618, 343);
            this.tvCad.TabIndex = 10;
            // 
            // menuCadObject
            // 
            this.menuCadObject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadView,
            this.menuCadDownLoad,
            this.toolStripSeparator9,
            this.menuCadCheckIn,
            this.menuCadCheckOut,
            this.menuCadCancelCheckOut,
            this.toolStripSeparator10,
            this.menuCadFileDelete});
            this.menuCadObject.Name = "contextMenuStrip1";
            this.menuCadObject.Size = new System.Drawing.Size(125, 148);
            // 
            // menuCadView
            // 
            this.menuCadView.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.menuCadView.Name = "menuCadView";
            this.menuCadView.Size = new System.Drawing.Size(124, 22);
            this.menuCadView.Text = "查看";
            this.menuCadView.Click += new System.EventHandler(this.menuCadView_Click);
            // 
            // menuCadDownLoad
            // 
            this.menuCadDownLoad.Image = global::HYPDM.WinUI.Properties.Resources.download;
            this.menuCadDownLoad.Name = "menuCadDownLoad";
            this.menuCadDownLoad.Size = new System.Drawing.Size(124, 22);
            this.menuCadDownLoad.Text = "文件下载";
            this.menuCadDownLoad.Click += new System.EventHandler(this.menuCadDownLoad_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(121, 6);
            // 
            // menuCadCheckIn
            // 
            this.menuCadCheckIn.Name = "menuCadCheckIn";
            this.menuCadCheckIn.Size = new System.Drawing.Size(124, 22);
            this.menuCadCheckIn.Text = "检入";
            this.menuCadCheckIn.Click += new System.EventHandler(this.menuCadCheckIn_Click);
            // 
            // menuCadCheckOut
            // 
            this.menuCadCheckOut.Name = "menuCadCheckOut";
            this.menuCadCheckOut.Size = new System.Drawing.Size(124, 22);
            this.menuCadCheckOut.Text = "检出";
            this.menuCadCheckOut.Click += new System.EventHandler(this.menuCadCheckOut_Click);
            // 
            // menuCadCancelCheckOut
            // 
            this.menuCadCancelCheckOut.Name = "menuCadCancelCheckOut";
            this.menuCadCancelCheckOut.Size = new System.Drawing.Size(124, 22);
            this.menuCadCancelCheckOut.Text = "取消检出";
            this.menuCadCancelCheckOut.Click += new System.EventHandler(this.menuCadCancelCheckOut_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(121, 6);
            // 
            // menuCadFileDelete
            // 
            this.menuCadFileDelete.Image = global::HYPDM.WinUI.Properties.Resources.delete;
            this.menuCadFileDelete.Name = "menuCadFileDelete";
            this.menuCadFileDelete.Size = new System.Drawing.Size(124, 22);
            this.menuCadFileDelete.Text = "删除文件";
            this.menuCadFileDelete.Click += new System.EventHandler(this.menuCadFileDelete_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tspRegPhysicCad,
            this.toolStripSeparator7,
            this.tspCadDownLoad,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 25);
            this.toolStrip1.TabIndex = 6;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tspRegPhysicCad
            // 
            this.tspRegPhysicCad.Image = ((System.Drawing.Image)(resources.GetObject("tspRegPhysicCad.Image")));
            this.tspRegPhysicCad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspRegPhysicCad.Name = "tspRegPhysicCad";
            this.tspRegPhysicCad.Size = new System.Drawing.Size(76, 22);
            this.tspRegPhysicCad.Text = "文件注册";
            this.tspRegPhysicCad.ToolTipText = "管理文档的物理文件。";
            this.tspRegPhysicCad.Click += new System.EventHandler(this.tspRegPhysicCad_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tspCadDownLoad
            // 
            this.tspCadDownLoad.Image = ((System.Drawing.Image)(resources.GetObject("tspCadDownLoad.Image")));
            this.tspCadDownLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspCadDownLoad.Name = "tspCadDownLoad";
            this.tspCadDownLoad.Size = new System.Drawing.Size(76, 22);
            this.tspCadDownLoad.Text = "文件下载";
            this.tspCadDownLoad.Click += new System.EventHandler(this.tspCadDownLoad_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton3";
            // 
            // tpVersion
            // 
            this.tpVersion.Controls.Add(this.txtVer);
            this.tpVersion.Location = new System.Drawing.Point(4, 22);
            this.tpVersion.Name = "tpVersion";
            this.tpVersion.Size = new System.Drawing.Size(618, 368);
            this.tpVersion.TabIndex = 2;
            this.tpVersion.Text = "版本";
            this.tpVersion.UseVisualStyleBackColor = true;
            // 
            // txtVer
            // 
            this.txtVer.BackColor = System.Drawing.Color.White;
            this.txtVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVer.Location = new System.Drawing.Point(0, 0);
            this.txtVer.Multiline = true;
            this.txtVer.Name = "txtVer";
            this.txtVer.ReadOnly = true;
            this.txtVer.Size = new System.Drawing.Size(618, 368);
            this.txtVer.TabIndex = 0;
            // 
            // tpgExtandsProperties
            // 
            this.tpgExtandsProperties.Controls.Add(this.dgvExptendProperties);
            this.tpgExtandsProperties.Controls.Add(this.tspExtands);
            this.tpgExtandsProperties.Location = new System.Drawing.Point(4, 22);
            this.tpgExtandsProperties.Name = "tpgExtandsProperties";
            this.tpgExtandsProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tpgExtandsProperties.Size = new System.Drawing.Size(618, 368);
            this.tpgExtandsProperties.TabIndex = 5;
            this.tpgExtandsProperties.Text = "扩展属性";
            this.tpgExtandsProperties.UseVisualStyleBackColor = true;
            // 
            // dgvExptendProperties
            // 
            this.dgvExptendProperties.AllowUserToAddRows = false;
            this.dgvExptendProperties.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvExptendProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExptendProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExptendProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMS_NAME,
            this.TARGET_COLNAME,
            this.colValue});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExptendProperties.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvExptendProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExptendProperties.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExptendProperties.Location = new System.Drawing.Point(3, 28);
            this.dgvExptendProperties.Name = "dgvExptendProperties";
            this.dgvExptendProperties.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExptendProperties.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExptendProperties.RowTemplate.Height = 23;
            this.dgvExptendProperties.Size = new System.Drawing.Size(612, 337);
            this.dgvExptendProperties.TabIndex = 24;
            // 
            // PARAMS_NAME
            // 
            this.PARAMS_NAME.DataPropertyName = "PARAMS_NAME";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PARAMS_NAME.DefaultCellStyle = dataGridViewCellStyle8;
            this.PARAMS_NAME.HeaderText = "属性值";
            this.PARAMS_NAME.Name = "PARAMS_NAME";
            this.PARAMS_NAME.Width = 280;
            // 
            // TARGET_COLNAME
            // 
            this.TARGET_COLNAME.DataPropertyName = "TARGET_COLNAME";
            this.TARGET_COLNAME.HeaderText = "TARGET_COLNAME";
            this.TARGET_COLNAME.Name = "TARGET_COLNAME";
            this.TARGET_COLNAME.Visible = false;
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "colValue";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colValue.DefaultCellStyle = dataGridViewCellStyle9;
            this.colValue.HeaderText = "属性值";
            this.colValue.Name = "colValue";
            this.colValue.Width = 280;
            // 
            // tspExtands
            // 
            this.tspExtands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.btnAddProperties});
            this.tspExtands.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tspExtands.Location = new System.Drawing.Point(3, 3);
            this.tspExtands.Name = "tspExtands";
            this.tspExtands.Size = new System.Drawing.Size(612, 25);
            this.tspExtands.TabIndex = 23;
            this.tspExtands.Click += new System.EventHandler(this.btnAddProperties_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddProperties
            // 
            this.btnAddProperties.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.btnAddProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddProperties.Name = "btnAddProperties";
            this.btnAddProperties.Size = new System.Drawing.Size(76, 22);
            this.btnAddProperties.Text = "属性添加";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(247, 394);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.txtCreateUser);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.txtCreateDate);
            this.tabPage1.Controls.Add(this.txtUpdateDate);
            this.tabPage1.Controls.Add(this.txtUpdateUser);
            this.tabPage1.Controls.Add(this.txtDocNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cobDocType);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(239, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(57, 58);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 36);
            this.txtDescription.TabIndex = 18;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.BackColor = System.Drawing.Color.LightCyan;
            this.txtCreateUser.Enabled = false;
            this.txtCreateUser.Location = new System.Drawing.Point(58, 176);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(149, 21);
            this.txtCreateUser.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.LightCyan;
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(57, 99);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(150, 21);
            this.txtStatus.TabIndex = 4;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.BackColor = System.Drawing.Color.LightCyan;
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(58, 203);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(149, 21);
            this.txtCreateDate.TabIndex = 6;
            // 
            // txtUpdateDate
            // 
            this.txtUpdateDate.BackColor = System.Drawing.Color.LightCyan;
            this.txtUpdateDate.Enabled = false;
            this.txtUpdateDate.Location = new System.Drawing.Point(58, 150);
            this.txtUpdateDate.Name = "txtUpdateDate";
            this.txtUpdateDate.Size = new System.Drawing.Size(149, 21);
            this.txtUpdateDate.TabIndex = 7;
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.BackColor = System.Drawing.Color.LightCyan;
            this.txtUpdateUser.Enabled = false;
            this.txtUpdateUser.Location = new System.Drawing.Point(57, 125);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(150, 21);
            this.txtUpdateUser.TabIndex = 5;
            // 
            // txtDocNo
            // 
            this.txtDocNo.Location = new System.Drawing.Point(57, 11);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(150, 21);
            this.txtDocNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(1, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "创建用户";
            // 
            // cobDocType
            // 
            this.cobDocType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobDocType.FormattingEnabled = true;
            this.cobDocType.Location = new System.Drawing.Point(58, 35);
            this.cobDocType.Name = "cobDocType";
            this.cobDocType.Size = new System.Drawing.Size(149, 20);
            this.cobDocType.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(0, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "修改日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(1, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "创建时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(22, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "修改者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "文档分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "编号";
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.btnDocAdd,
            this.toolStripSeparator1});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(887, 25);
            this.tsToolbar.TabIndex = 4;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDocAdd
            // 
            this.btnDocAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDocAdd.Image")));
            this.btnDocAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocAdd.Name = "btnDocAdd";
            this.btnDocAdd.Size = new System.Drawing.Size(76, 22);
            this.btnDocAdd.Text = "记录保存";
            this.btnDocAdd.ToolTipText = "保存或修改一个新的基础数据记录。";
            this.btnDocAdd.Click += new System.EventHandler(this.btnDocAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DFL_FILE_NAME
            // 
            this.DFL_FILE_NAME.DefaultNodeImage = null;
            this.DFL_FILE_NAME.Name = "DFL_FILE_NAME";
            // 
            // FilePathName
            // 
            this.FilePathName.Name = "FilePathName";
            // 
            // Column10
            // 
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.Name = "Column11";
            // 
            // Column9
            // 
            this.Column9.Name = "Column9";
            // 
            // Column12
            // 
            this.Column12.Name = "Column12";
            // 
            // Column23
            // 
            this.Column23.Name = "Column23";
            // 
            // DFL_CAD_NAME
            // 
            this.DFL_CAD_NAME.HeaderText = "文件名称";
            this.DFL_CAD_NAME.Name = "DFL_CAD_NAME";
            this.DFL_CAD_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DFL_CAD_NAME.Width = 230;
            // 
            // CadPathName
            // 
            this.CadPathName.HeaderText = "文件路径";
            this.CadPathName.Name = "CadPathName";
            this.CadPathName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CadPathName.Width = 240;
            // 
            // 版本
            // 
            this.版本.HeaderText = "版本";
            this.版本.Name = "版本";
            this.版本.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "检入标识";
            this.Column17.Name = "Column17";
            this.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "检入日期";
            this.Column18.Name = "Column18";
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "检出标识";
            this.Column19.Name = "Column19";
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "检出日期";
            this.Column20.Name = "Column20";
            this.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DFL_ID_CAD
            // 
            this.DFL_ID_CAD.HeaderText = "DFL_ID";
            this.DFL_ID_CAD.Name = "DFL_ID_CAD";
            this.DFL_ID_CAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DFL_ID_CAD.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DefaultNodeImage = null;
            this.Column2.HeaderText = "文件";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DefaultNodeImage = null;
            this.Column3.HeaderText = "文件名";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DefaultNodeImage = null;
            this.Column4.HeaderText = "描述";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DefaultNodeImage = null;
            this.Column5.HeaderText = "版本";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DefaultNodeImage = null;
            this.Column6.HeaderText = "检入日期";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imageStrip
            // 
            this.imageStrip.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "编号";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "版本";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "描述";
            this.Column13.Name = "Column13";
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "状态";
            this.Column14.Name = "Column14";
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "修改者";
            this.Column15.Name = "Column15";
            this.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "创建时间";
            this.Column16.Name = "Column16";
            this.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DFL_FILE_NAME1
            // 
            this.DFL_FILE_NAME1.DefaultNodeImage = null;
            this.DFL_FILE_NAME1.HeaderText = "文件名称";
            this.DFL_FILE_NAME1.Name = "DFL_FILE_NAME1";
            this.DFL_FILE_NAME1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DFL_FILE_NAME1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DFL_FILE_NAME1.Width = 230;
            // 
            // FilePathName1
            // 
            this.FilePathName1.HeaderText = "文件路径";
            this.FilePathName1.Name = "FilePathName1";
            this.FilePathName1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilePathName1.Width = 240;
            // 
            // Colver
            // 
            this.Colver.HeaderText = "版本";
            this.Colver.Name = "Colver";
            this.Colver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colver.Width = 50;
            // 
            // checkinflg
            // 
            this.checkinflg.HeaderText = "检入标识";
            this.checkinflg.Name = "checkinflg";
            this.checkinflg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkindate
            // 
            this.checkindate.HeaderText = "检入日期";
            this.checkindate.Name = "checkindate";
            this.checkindate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkoutflg
            // 
            this.checkoutflg.HeaderText = "检出标识";
            this.checkoutflg.Name = "checkoutflg";
            this.checkoutflg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkoutdate
            // 
            this.checkoutdate.HeaderText = "检出日期";
            this.checkoutdate.Name = "checkoutdate";
            this.checkoutdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DFL_ID
            // 
            this.DFL_ID.DataPropertyName = "DFL_ID";
            this.DFL_ID.HeaderText = "DFL_ID";
            this.DFL_ID.Name = "DFL_ID";
            this.DFL_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DFL_ID.Visible = false;
            // 
            // DrawRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 419);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图纸 注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocRegForm_FormClosing);
            this.Load += new System.EventHandler(this.DocRegForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcContent.ResumeLayout(false);
            this.tpRemark.ResumeLayout(false);
            this.tpRemark.PerformLayout();
            this.tpParts.ResumeLayout(false);
            this.tpParts.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).EndInit();
            this.tabMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCad.ResumeLayout(false);
            this.tabCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvCad)).EndInit();
            this.menuCadObject.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpVersion.ResumeLayout(false);
            this.tpVersion.PerformLayout();
            this.tpgExtandsProperties.ResumeLayout(false);
            this.tpgExtandsProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExptendProperties)).EndInit();
            this.tspExtands.ResumeLayout(false);
            this.tspExtands.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton btnDocAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private AdvancedDataGridView.TreeGridColumn Column2;
        private AdvancedDataGridView.TreeGridColumn Column3;
        private AdvancedDataGridView.TreeGridColumn Column4;
        private AdvancedDataGridView.TreeGridColumn Column5;
        private AdvancedDataGridView.TreeGridColumn Column6;
        private System.Windows.Forms.ImageList imageStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private AdvancedDataGridView.TreeGridColumn DFL_FILE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
       // private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_CAD_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CadPathName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版本;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID_CAD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCreateDate;
        private System.Windows.Forms.TextBox txtUpdateDate;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.TextBox txtDocNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobDocType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private AdvancedDataGridView.TreeGridView tvFileList;
        private AdvancedDataGridView.TreeGridView tvCad;
        private System.Windows.Forms.ContextMenuStrip menuCadObject;
        private System.Windows.Forms.ToolStripMenuItem menuCadView;
        private System.Windows.Forms.ToolStripMenuItem menuCadDownLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuCadCheckIn;
        private System.Windows.Forms.ToolStripMenuItem menuCadCheckOut;
        private System.Windows.Forms.ToolStripMenuItem menuCadCancelCheckOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuCadFileDelete;
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.TabPage tpRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TabPage tpParts;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabProduct;
        private BaseControl.DataGridViewExt dGVProduct;
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
        private System.Windows.Forms.TabPage tabMaterial;
        private BaseControl.DataGridViewExt dgvMaterial;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建关联对象ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品零部件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零部件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHalfProduct;
        private System.Windows.Forms.ToolStripMenuItem btnMaterial;
        private System.Windows.Forms.ToolStripMenuItem btnProduct;
        private System.Windows.Forms.ToolStripMenuItem btnAddRelation;
        private System.Windows.Forms.ToolStripMenuItem btnDelRelation;
        private System.Windows.Forms.TabPage tabCad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tspRegPhysicCad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tspCadDownLoad;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TabPage tpVersion;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.TabPage tpgExtandsProperties;
        private BaseControl.DataGridViewExt dgvExptendProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARGET_COLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.ToolStrip tspExtands;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnAddProperties;
        private AdvancedDataGridView.TreeGridColumn DFL_FILE_NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePathName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colver;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinflg;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutflg;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFL_ID;
    }
}