namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    partial class PartsConfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsConfForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeListViewItemCollection.TreeListViewItemCollectionComparer treeListViewItemCollectionComparer1 = new System.Windows.Forms.TreeListViewItemCollection.TreeListViewItemCollectionComparer();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_modifyTime = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_createTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_memoEn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_memoZh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_modifier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_creater = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_productType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_modelType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_productNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolBase = new System.Windows.Forms.ToolStrip();
            this.toolBaseReg = new System.Windows.Forms.ToolStripButton();
            this.toolBaseCopy = new System.Windows.Forms.ToolStripButton();
            this.toolBaseEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBaseClear = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Memo = new System.Windows.Forms.TabPage();
            this.rtbMemo = new System.Windows.Forms.RichTextBox();
            this.tab_ProRecord = new System.Windows.Forms.TabPage();
            this.toolProRecord = new System.Windows.Forms.ToolStrip();
            this.toolProRecordEdit = new System.Windows.Forms.ToolStripButton();
            this.toolProRecordAdd = new System.Windows.Forms.ToolStripButton();
            this.dgv_ProRecord = new HYPDM.BaseControl.DataGridViewExt();
            this.checkedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WFA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTKEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WFT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_Data_ProRecord = new System.Windows.Forms.BindingSource(this.components);
            this.tab_Change = new System.Windows.Forms.TabPage();
            this.dgv_Change = new System.Windows.Forms.DataGridView();
            this.toolChange = new System.Windows.Forms.ToolStrip();
            this.toolChangeAdd = new System.Windows.Forms.ToolStripButton();
            this.toolChangeDel = new System.Windows.Forms.ToolStripButton();
            this.tab_Doc = new System.Windows.Forms.TabPage();
            this.ucPageDoc = new HYPDM.BaseControl.UcPaging();
            this.dgv_DocList = new HYPDM.BaseControl.DataGridViewExt();
            this.DOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCVERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCCREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsb_DocAdd = new System.Windows.Forms.ToolStripButton();
            this.tsb_DocDel = new System.Windows.Forms.ToolStripButton();
            this.tsb_DocLook = new System.Windows.Forms.ToolStripButton();
            this.tab_Drawing = new System.Windows.Forms.TabPage();
            this.ucPagingDraw = new HYPDM.BaseControl.UcPaging();
            this.dgv_DrawList = new HYPDM.BaseControl.DataGridViewExt();
            this.DRAWID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRAWNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRAWVERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRAWDOCSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRAWCREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolDrawAdd = new System.Windows.Forms.ToolStripButton();
            this.toolDrawDel = new System.Windows.Forms.ToolStripButton();
            this.toolDrawLook = new System.Windows.Forms.ToolStripButton();
            this.tab_TelTask = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel48 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel49 = new System.Windows.Forms.ToolStripLabel();
            this.tab_productStruct = new System.Windows.Forms.TabPage();
            this.structComb = new System.Windows.Forms.Panel();
            this.list_productTreeStruct = new System.Windows.Forms.TreeListView();
            this.ObjectNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectSort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectMemo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.image_productStruct = new System.Windows.Forms.ImageList(this.components);
            this.toolStruct = new System.Windows.Forms.ToolStrip();
            this.toolStructAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel14 = new System.Windows.Forms.ToolStripLabel();
            this.toolStructDel = new System.Windows.Forms.ToolStripButton();
            this.toolStructEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStructSave = new System.Windows.Forms.ToolStripButton();
            this.toolStructReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStructInsert = new System.Windows.Forms.ToolStripButton();
            this.bt_StructSearch = new System.Windows.Forms.Button();
            this.cb_structPro = new System.Windows.Forms.ComboBox();
            this.tb_structProValue = new System.Windows.Forms.TextBox();
            this.tab_Version = new System.Windows.Forms.TabPage();
            this.toolVersion = new System.Windows.Forms.ToolStrip();
            this.toolVersionCompare = new System.Windows.Forms.ToolStripButton();
            this.toolVersionNo = new System.Windows.Forms.ToolStripTextBox();
            this.toolVersionQuery = new System.Windows.Forms.ToolStripButton();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.checkedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Extpro = new System.Windows.Forms.TabPage();
            this.dgvExptendProperties = new HYPDM.BaseControl.DataGridViewExt();
            this.PARAMS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARGET_COLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolExt_Add = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结构ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品结构ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加下层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM顺序重排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.注册流程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对象比较ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRP集成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工艺权限ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolBase.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_Memo.SuspendLayout();
            this.tab_ProRecord.SuspendLayout();
            this.toolProRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Data_ProRecord)).BeginInit();
            this.tab_Change.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Change)).BeginInit();
            this.toolChange.SuspendLayout();
            this.tab_Doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocList)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.tab_Drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawList)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.tab_TelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.toolStrip6.SuspendLayout();
            this.tab_productStruct.SuspendLayout();
            this.structComb.SuspendLayout();
            this.toolStruct.SuspendLayout();
            this.tab_Version.SuspendLayout();
            this.toolVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.tab_Extpro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExptendProperties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tb_modifyTime);
            this.tabPage1.Controls.Add(this.tb_version);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tb_createTime);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tb_memoEn);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tb_memoZh);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_modifier);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_creater);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_status);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tb_productType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_modelType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_productNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "半成品信息";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "创建者";
            // 
            // tb_modifyTime
            // 
            this.tb_modifyTime.Enabled = false;
            this.tb_modifyTime.Location = new System.Drawing.Point(74, 316);
            this.tb_modifyTime.Name = "tb_modifyTime";
            this.tb_modifyTime.Size = new System.Drawing.Size(147, 21);
            this.tb_modifyTime.TabIndex = 22;
            // 
            // tb_version
            // 
            this.tb_version.Enabled = false;
            this.tb_version.Location = new System.Drawing.Point(74, 73);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(147, 21);
            this.tb_version.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "版本号";
            // 
            // tb_createTime
            // 
            this.tb_createTime.Enabled = false;
            this.tb_createTime.Location = new System.Drawing.Point(74, 289);
            this.tb_createTime.Name = "tb_createTime";
            this.tb_createTime.Size = new System.Drawing.Size(147, 21);
            this.tb_createTime.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "修改日期";
            // 
            // tb_memoEn
            // 
            this.tb_memoEn.Location = new System.Drawing.Point(74, 262);
            this.tb_memoEn.Name = "tb_memoEn";
            this.tb_memoEn.Size = new System.Drawing.Size(147, 21);
            this.tb_memoEn.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "创建时间";
            // 
            // tb_memoZh
            // 
            this.tb_memoZh.Location = new System.Drawing.Point(74, 235);
            this.tb_memoZh.Name = "tb_memoZh";
            this.tb_memoZh.Size = new System.Drawing.Size(147, 21);
            this.tb_memoZh.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "修改者";
            // 
            // tb_modifier
            // 
            this.tb_modifier.Enabled = false;
            this.tb_modifier.Location = new System.Drawing.Point(74, 208);
            this.tb_modifier.Name = "tb_modifier";
            this.tb_modifier.Size = new System.Drawing.Size(147, 21);
            this.tb_modifier.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "状态";
            // 
            // tb_creater
            // 
            this.tb_creater.Enabled = false;
            this.tb_creater.Location = new System.Drawing.Point(74, 181);
            this.tb_creater.Name = "tb_creater";
            this.tb_creater.Size = new System.Drawing.Size(147, 21);
            this.tb_creater.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "产品型号";
            // 
            // tb_status
            // 
            this.tb_status.Enabled = false;
            this.tb_status.Location = new System.Drawing.Point(74, 154);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(147, 21);
            this.tb_status.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "产品类型";
            // 
            // tb_productType
            // 
            this.tb_productType.Location = new System.Drawing.Point(74, 127);
            this.tb_productType.Name = "tb_productType";
            this.tb_productType.Size = new System.Drawing.Size(147, 21);
            this.tb_productType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "英文描述";
            // 
            // tb_modelType
            // 
            this.tb_modelType.Location = new System.Drawing.Point(74, 100);
            this.tb_modelType.Name = "tb_modelType";
            this.tb_modelType.Size = new System.Drawing.Size(147, 21);
            this.tb_modelType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "中文描述";
            // 
            // tb_productNo
            // 
            this.tb_productNo.Location = new System.Drawing.Point(74, 41);
            this.tb_productNo.Name = "tb_productNo";
            this.tb_productNo.Size = new System.Drawing.Size(147, 21);
            this.tb_productNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "编号";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel11});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(287, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel11.Text = "  ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolBase
            // 
            this.toolBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolBaseReg,
            this.toolBaseCopy,
            this.toolBaseEdit,
            this.toolBaseClear});
            this.toolBase.Location = new System.Drawing.Point(0, 0);
            this.toolBase.Name = "toolBase";
            this.toolBase.Size = new System.Drawing.Size(864, 25);
            this.toolBase.TabIndex = 1;
            this.toolBase.Text = "toolStrip1";
            // 
            // toolBaseReg
            // 
            this.toolBaseReg.Image = global::HYPDM.WinUI.Properties.Resources.download;
            this.toolBaseReg.Name = "toolBaseReg";
            this.toolBaseReg.Size = new System.Drawing.Size(52, 22);
            this.toolBaseReg.Text = "新建";
            this.toolBaseReg.ToolTipText = "新版本";
            this.toolBaseReg.Click += new System.EventHandler(this.toolBaseReg_Click);
            // 
            // toolBaseCopy
            // 
            this.toolBaseCopy.Image = global::HYPDM.WinUI.Properties.Resources.pagination_last;
            this.toolBaseCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBaseCopy.Name = "toolBaseCopy";
            this.toolBaseCopy.Size = new System.Drawing.Size(52, 22);
            this.toolBaseCopy.Text = "复制";
            this.toolBaseCopy.Click += new System.EventHandler(this.toolBaseCopy_Click);
            // 
            // toolBaseEdit
            // 
            this.toolBaseEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolBaseEdit.Image")));
            this.toolBaseEdit.Name = "toolBaseEdit";
            this.toolBaseEdit.Size = new System.Drawing.Size(52, 22);
            this.toolBaseEdit.Text = "修改";
            this.toolBaseEdit.ToolTipText = "修改";
            this.toolBaseEdit.Click += new System.EventHandler(this.toolBaseEdit_Click);
            // 
            // toolBaseClear
            // 
            this.toolBaseClear.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.toolBaseClear.Name = "toolBaseClear";
            this.toolBaseClear.Size = new System.Drawing.Size(52, 22);
            this.toolBaseClear.Text = "清空";
            this.toolBaseClear.Click += new System.EventHandler(this.toolBaseClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(316, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Memo);
            this.tabControl.Controls.Add(this.tab_ProRecord);
            this.tabControl.Controls.Add(this.tab_Change);
            this.tabControl.Controls.Add(this.tab_Doc);
            this.tabControl.Controls.Add(this.tab_Drawing);
            this.tabControl.Controls.Add(this.tab_TelTask);
            this.tabControl.Controls.Add(this.tab_productStruct);
            this.tabControl.Controls.Add(this.tab_Version);
            this.tabControl.Controls.Add(this.tab_Extpro);
            this.tabControl.Location = new System.Drawing.Point(1, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(535, 384);
            this.tabControl.TabIndex = 0;
            // 
            // tab_Memo
            // 
            this.tab_Memo.Controls.Add(this.rtbMemo);
            this.tab_Memo.Location = new System.Drawing.Point(4, 22);
            this.tab_Memo.Name = "tab_Memo";
            this.tab_Memo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Memo.Size = new System.Drawing.Size(527, 358);
            this.tab_Memo.TabIndex = 0;
            this.tab_Memo.Text = "备注";
            this.tab_Memo.UseVisualStyleBackColor = true;
            // 
            // rtbMemo
            // 
            this.rtbMemo.Location = new System.Drawing.Point(6, 6);
            this.rtbMemo.Name = "rtbMemo";
            this.rtbMemo.Size = new System.Drawing.Size(515, 349);
            this.rtbMemo.TabIndex = 0;
            this.rtbMemo.Text = "";
            // 
            // tab_ProRecord
            // 
            this.tab_ProRecord.Controls.Add(this.toolProRecord);
            this.tab_ProRecord.Controls.Add(this.dgv_ProRecord);
            this.tab_ProRecord.Location = new System.Drawing.Point(4, 22);
            this.tab_ProRecord.Name = "tab_ProRecord";
            this.tab_ProRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ProRecord.Size = new System.Drawing.Size(527, 358);
            this.tab_ProRecord.TabIndex = 1;
            this.tab_ProRecord.Text = "变更申请";
            this.tab_ProRecord.UseVisualStyleBackColor = true;
            // 
            // toolProRecord
            // 
            this.toolProRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProRecordEdit,
            this.toolProRecordAdd});
            this.toolProRecord.Location = new System.Drawing.Point(3, 3);
            this.toolProRecord.Name = "toolProRecord";
            this.toolProRecord.Size = new System.Drawing.Size(521, 25);
            this.toolProRecord.TabIndex = 1;
            this.toolProRecord.Text = "toolStrip7";
            // 
            // toolProRecordEdit
            // 
            this.toolProRecordEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolProRecordEdit.Image")));
            this.toolProRecordEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProRecordEdit.Name = "toolProRecordEdit";
            this.toolProRecordEdit.Size = new System.Drawing.Size(52, 22);
            this.toolProRecordEdit.Text = "重启";
            this.toolProRecordEdit.Click += new System.EventHandler(this.toolProRecordEdit_Click);
            // 
            // toolProRecordAdd
            // 
            this.toolProRecordAdd.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.toolProRecordAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProRecordAdd.Name = "toolProRecordAdd";
            this.toolProRecordAdd.Size = new System.Drawing.Size(52, 22);
            this.toolProRecordAdd.Text = "添加";
            this.toolProRecordAdd.Visible = false;
            this.toolProRecordAdd.Click += new System.EventHandler(this.toolProRecordAdd_Click);
            // 
            // dgv_ProRecord
            // 
            this.dgv_ProRecord.AllowUserToAddRows = false;
            this.dgv_ProRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProRecord.AutoGenerateColumns = false;
            this.dgv_ProRecord.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_ProRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ProRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedDataGridViewCheckBoxColumn1,
            this.WFA_ID,
            this.OBJECTKEY,
            this.WFT_NAME,
            this.SUBJECT,
            this.STATUS,
            this.CREATEUSER});
            this.dgv_ProRecord.DataSource = this.bs_Data_ProRecord;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProRecord.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProRecord.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_ProRecord.Location = new System.Drawing.Point(3, 31);
            this.dgv_ProRecord.MultiSelect = false;
            this.dgv_ProRecord.Name = "dgv_ProRecord";
            this.dgv_ProRecord.ReadOnly = true;
            this.dgv_ProRecord.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_ProRecord.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_ProRecord.RowTemplate.Height = 23;
            this.dgv_ProRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProRecord.Size = new System.Drawing.Size(521, 325);
            this.dgv_ProRecord.TabIndex = 0;
            this.dgv_ProRecord.DoubleClick += new System.EventHandler(this.dgv_ProRecord_DoubleClick);
            // 
            // checkedDataGridViewCheckBoxColumn1
            // 
            this.checkedDataGridViewCheckBoxColumn1.DataPropertyName = "Checked";
            this.checkedDataGridViewCheckBoxColumn1.HeaderText = "选择";
            this.checkedDataGridViewCheckBoxColumn1.Name = "checkedDataGridViewCheckBoxColumn1";
            this.checkedDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.checkedDataGridViewCheckBoxColumn1.Visible = false;
            this.checkedDataGridViewCheckBoxColumn1.Width = 50;
            // 
            // WFA_ID
            // 
            this.WFA_ID.DataPropertyName = "WFA_ID";
            this.WFA_ID.HeaderText = "流程ID";
            this.WFA_ID.Name = "WFA_ID";
            this.WFA_ID.ReadOnly = true;
            this.WFA_ID.Visible = false;
            // 
            // OBJECTKEY
            // 
            this.OBJECTKEY.DataPropertyName = "OBJECTKEY";
            this.OBJECTKEY.HeaderText = "半成品ID";
            this.OBJECTKEY.Name = "OBJECTKEY";
            this.OBJECTKEY.ReadOnly = true;
            this.OBJECTKEY.Visible = false;
            // 
            // WFT_NAME
            // 
            this.WFT_NAME.DataPropertyName = "WFT_NAME";
            this.WFT_NAME.HeaderText = "模板名称";
            this.WFT_NAME.Name = "WFT_NAME";
            this.WFT_NAME.ReadOnly = true;
            // 
            // SUBJECT
            // 
            this.SUBJECT.DataPropertyName = "SUBJECT";
            this.SUBJECT.HeaderText = "实例名称";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "状态";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // CREATEUSER
            // 
            this.CREATEUSER.DataPropertyName = "CREATEUSER";
            this.CREATEUSER.HeaderText = "创建人";
            this.CREATEUSER.Name = "CREATEUSER";
            this.CREATEUSER.ReadOnly = true;
            // 
            // bs_Data_ProRecord
            // 
            this.bs_Data_ProRecord.DataSource = typeof(HYPDM.Entities.PDM_PRODUCT_PRORECORD);
            // 
            // tab_Change
            // 
            this.tab_Change.Controls.Add(this.dgv_Change);
            this.tab_Change.Controls.Add(this.toolChange);
            this.tab_Change.Location = new System.Drawing.Point(4, 22);
            this.tab_Change.Name = "tab_Change";
            this.tab_Change.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Change.Size = new System.Drawing.Size(527, 358);
            this.tab_Change.TabIndex = 2;
            this.tab_Change.Text = "ECR";
            this.tab_Change.UseVisualStyleBackColor = true;
            // 
            // dgv_Change
            // 
            this.dgv_Change.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Change.Location = new System.Drawing.Point(3, 31);
            this.dgv_Change.Name = "dgv_Change";
            this.dgv_Change.RowTemplate.Height = 23;
            this.dgv_Change.Size = new System.Drawing.Size(524, 325);
            this.dgv_Change.TabIndex = 1;
            // 
            // toolChange
            // 
            this.toolChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolChangeAdd,
            this.toolChangeDel});
            this.toolChange.Location = new System.Drawing.Point(3, 3);
            this.toolChange.Name = "toolChange";
            this.toolChange.Size = new System.Drawing.Size(521, 25);
            this.toolChange.TabIndex = 0;
            this.toolChange.Text = "toolStrip7";
            // 
            // toolChangeAdd
            // 
            this.toolChangeAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolChangeAdd.Image")));
            this.toolChangeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolChangeAdd.Name = "toolChangeAdd";
            this.toolChangeAdd.Size = new System.Drawing.Size(52, 22);
            this.toolChangeAdd.Text = "添加";
            this.toolChangeAdd.Click += new System.EventHandler(this.toolChangeAdd_Click);
            // 
            // toolChangeDel
            // 
            this.toolChangeDel.Image = ((System.Drawing.Image)(resources.GetObject("toolChangeDel.Image")));
            this.toolChangeDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolChangeDel.Name = "toolChangeDel";
            this.toolChangeDel.Size = new System.Drawing.Size(52, 22);
            this.toolChangeDel.Text = "删除";
            this.toolChangeDel.Click += new System.EventHandler(this.toolChangeDel_Click);
            // 
            // tab_Doc
            // 
            this.tab_Doc.Controls.Add(this.ucPageDoc);
            this.tab_Doc.Controls.Add(this.dgv_DocList);
            this.tab_Doc.Controls.Add(this.toolStrip4);
            this.tab_Doc.Location = new System.Drawing.Point(4, 22);
            this.tab_Doc.Name = "tab_Doc";
            this.tab_Doc.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Doc.Size = new System.Drawing.Size(527, 358);
            this.tab_Doc.TabIndex = 3;
            this.tab_Doc.Text = "文档";
            this.tab_Doc.UseVisualStyleBackColor = true;
            // 
            // ucPageDoc
            // 
            this.ucPageDoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPageDoc.ExportIsVisiable = false;
            this.ucPageDoc.Location = new System.Drawing.Point(3, 327);
            this.ucPageDoc.Name = "ucPageDoc";
            this.ucPageDoc.PageSize = 20;
            this.ucPageDoc.Size = new System.Drawing.Size(521, 28);
            this.ucPageDoc.TabIndex = 2;
            // 
            // dgv_DocList
            // 
            this.dgv_DocList.AllowUserToAddRows = false;
            this.dgv_DocList.AllowUserToDeleteRows = false;
            this.dgv_DocList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_DocList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCID,
            this.DOCNO,
            this.DOCVERSION,
            this.DOCSTATUS,
            this.DOCCREATEUSER});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DocList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DocList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DocList.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_DocList.Location = new System.Drawing.Point(3, 28);
            this.dgv_DocList.Name = "dgv_DocList";
            this.dgv_DocList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_DocList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_DocList.RowTemplate.Height = 23;
            this.dgv_DocList.Size = new System.Drawing.Size(521, 327);
            this.dgv_DocList.TabIndex = 1;
            // 
            // DOCID
            // 
            this.DOCID.DataPropertyName = "DOCID";
            this.DOCID.HeaderText = "文档ID";
            this.DOCID.Name = "DOCID";
            this.DOCID.Visible = false;
            // 
            // DOCNO
            // 
            this.DOCNO.DataPropertyName = "DOCNO";
            this.DOCNO.HeaderText = "文档编号";
            this.DOCNO.Name = "DOCNO";
            // 
            // DOCVERSION
            // 
            this.DOCVERSION.DataPropertyName = "VERSION";
            this.DOCVERSION.HeaderText = "文档版本";
            this.DOCVERSION.Name = "DOCVERSION";
            // 
            // DOCSTATUS
            // 
            this.DOCSTATUS.DataPropertyName = "DOCSTATUS";
            this.DOCSTATUS.HeaderText = "文档状态";
            this.DOCSTATUS.Name = "DOCSTATUS";
            // 
            // DOCCREATEUSER
            // 
            this.DOCCREATEUSER.DataPropertyName = "CREATEUSER";
            this.DOCCREATEUSER.HeaderText = "创建人";
            this.DOCCREATEUSER.Name = "DOCCREATEUSER";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_DocAdd,
            this.tsb_DocDel,
            this.tsb_DocLook});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(521, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // tsb_DocAdd
            // 
            this.tsb_DocAdd.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.tsb_DocAdd.Name = "tsb_DocAdd";
            this.tsb_DocAdd.Size = new System.Drawing.Size(52, 22);
            this.tsb_DocAdd.Text = "添加";
            this.tsb_DocAdd.Click += new System.EventHandler(this.tsb_DocAdd_Click);
            // 
            // tsb_DocDel
            // 
            this.tsb_DocDel.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.tsb_DocDel.Name = "tsb_DocDel";
            this.tsb_DocDel.Size = new System.Drawing.Size(52, 22);
            this.tsb_DocDel.Text = "删除";
            this.tsb_DocDel.Click += new System.EventHandler(this.tsb_DocDel_Click);
            // 
            // tsb_DocLook
            // 
            this.tsb_DocLook.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.tsb_DocLook.Name = "tsb_DocLook";
            this.tsb_DocLook.Size = new System.Drawing.Size(52, 22);
            this.tsb_DocLook.Text = "查看";
            this.tsb_DocLook.Click += new System.EventHandler(this.tsb_DocLook_Click);
            // 
            // tab_Drawing
            // 
            this.tab_Drawing.Controls.Add(this.ucPagingDraw);
            this.tab_Drawing.Controls.Add(this.dgv_DrawList);
            this.tab_Drawing.Controls.Add(this.toolStrip5);
            this.tab_Drawing.Location = new System.Drawing.Point(4, 22);
            this.tab_Drawing.Name = "tab_Drawing";
            this.tab_Drawing.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Drawing.Size = new System.Drawing.Size(527, 358);
            this.tab_Drawing.TabIndex = 4;
            this.tab_Drawing.Text = "图纸";
            this.tab_Drawing.UseVisualStyleBackColor = true;
            // 
            // ucPagingDraw
            // 
            this.ucPagingDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPagingDraw.ExportIsVisiable = false;
            this.ucPagingDraw.Location = new System.Drawing.Point(3, 327);
            this.ucPagingDraw.Name = "ucPagingDraw";
            this.ucPagingDraw.PageSize = 20;
            this.ucPagingDraw.Size = new System.Drawing.Size(521, 28);
            this.ucPagingDraw.TabIndex = 2;
            // 
            // dgv_DrawList
            // 
            this.dgv_DrawList.AllowUserToAddRows = false;
            this.dgv_DrawList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DrawList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_DrawList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DrawList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DrawList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DRAWID,
            this.DRAWNO,
            this.DRAWVERSION,
            this.DRAWDOCSTATUS,
            this.DRAWCREATEUSER});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DrawList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DrawList.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_DrawList.Location = new System.Drawing.Point(3, 28);
            this.dgv_DrawList.Name = "dgv_DrawList";
            this.dgv_DrawList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_DrawList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_DrawList.RowTemplate.Height = 23;
            this.dgv_DrawList.Size = new System.Drawing.Size(521, 299);
            this.dgv_DrawList.TabIndex = 1;
            // 
            // DRAWID
            // 
            this.DRAWID.DataPropertyName = "DOCID";
            this.DRAWID.HeaderText = "图纸ID";
            this.DRAWID.Name = "DRAWID";
            this.DRAWID.Visible = false;
            // 
            // DRAWNO
            // 
            this.DRAWNO.DataPropertyName = "DOCNO";
            this.DRAWNO.HeaderText = "图纸编号";
            this.DRAWNO.Name = "DRAWNO";
            // 
            // DRAWVERSION
            // 
            this.DRAWVERSION.DataPropertyName = "VERSION";
            this.DRAWVERSION.HeaderText = "图纸版本";
            this.DRAWVERSION.Name = "DRAWVERSION";
            // 
            // DRAWDOCSTATUS
            // 
            this.DRAWDOCSTATUS.DataPropertyName = "DOCSTATUS";
            this.DRAWDOCSTATUS.HeaderText = "状态";
            this.DRAWDOCSTATUS.Name = "DRAWDOCSTATUS";
            // 
            // DRAWCREATEUSER
            // 
            this.DRAWCREATEUSER.DataPropertyName = "CREATEUSER";
            this.DRAWCREATEUSER.HeaderText = "创建人";
            this.DRAWCREATEUSER.Name = "DRAWCREATEUSER";
            // 
            // toolStrip5
            // 
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDrawAdd,
            this.toolDrawDel,
            this.toolDrawLook});
            this.toolStrip5.Location = new System.Drawing.Point(3, 3);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(521, 25);
            this.toolStrip5.TabIndex = 0;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolDrawAdd
            // 
            this.toolDrawAdd.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.toolDrawAdd.Name = "toolDrawAdd";
            this.toolDrawAdd.Size = new System.Drawing.Size(52, 22);
            this.toolDrawAdd.Text = "添加";
            this.toolDrawAdd.Click += new System.EventHandler(this.toolDrawAdd_Click);
            // 
            // toolDrawDel
            // 
            this.toolDrawDel.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.toolDrawDel.Name = "toolDrawDel";
            this.toolDrawDel.Size = new System.Drawing.Size(52, 22);
            this.toolDrawDel.Text = "删除";
            this.toolDrawDel.Click += new System.EventHandler(this.toolDrawDel_Click);
            // 
            // toolDrawLook
            // 
            this.toolDrawLook.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.toolDrawLook.Name = "toolDrawLook";
            this.toolDrawLook.Size = new System.Drawing.Size(52, 22);
            this.toolDrawLook.Text = "查看";
            this.toolDrawLook.Click += new System.EventHandler(this.toolDrawLook_Click);
            // 
            // tab_TelTask
            // 
            this.tab_TelTask.Controls.Add(this.dataGridView4);
            this.tab_TelTask.Controls.Add(this.toolStrip6);
            this.tab_TelTask.Location = new System.Drawing.Point(4, 22);
            this.tab_TelTask.Name = "tab_TelTask";
            this.tab_TelTask.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TelTask.Size = new System.Drawing.Size(527, 358);
            this.tab_TelTask.TabIndex = 5;
            this.tab_TelTask.Text = "技术任务单";
            this.tab_TelTask.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dataGridView4.Location = new System.Drawing.Point(0, 32);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(524, 324);
            this.dataGridView4.TabIndex = 1;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "编号";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "状态";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "负责人";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "技术内容";
            this.Column18.Name = "Column18";
            // 
            // toolStrip6
            // 
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel48,
            this.toolStripLabel49});
            this.toolStrip6.Location = new System.Drawing.Point(3, 3);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(521, 25);
            this.toolStrip6.TabIndex = 0;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripLabel48
            // 
            this.toolStripLabel48.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.toolStripLabel48.Name = "toolStripLabel48";
            this.toolStripLabel48.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel48.Text = "添加";
            // 
            // toolStripLabel49
            // 
            this.toolStripLabel49.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.toolStripLabel49.Name = "toolStripLabel49";
            this.toolStripLabel49.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel49.Text = "删除";
            // 
            // tab_productStruct
            // 
            this.tab_productStruct.Controls.Add(this.structComb);
            this.tab_productStruct.Location = new System.Drawing.Point(4, 22);
            this.tab_productStruct.Name = "tab_productStruct";
            this.tab_productStruct.Padding = new System.Windows.Forms.Padding(3);
            this.tab_productStruct.Size = new System.Drawing.Size(527, 358);
            this.tab_productStruct.TabIndex = 6;
            this.tab_productStruct.Text = "产品结构";
            this.tab_productStruct.UseVisualStyleBackColor = true;
            // 
            // structComb
            // 
            this.structComb.Controls.Add(this.list_productTreeStruct);
            this.structComb.Controls.Add(this.toolStruct);
            this.structComb.Controls.Add(this.bt_StructSearch);
            this.structComb.Controls.Add(this.cb_structPro);
            this.structComb.Controls.Add(this.tb_structProValue);
            this.structComb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structComb.Location = new System.Drawing.Point(3, 3);
            this.structComb.Name = "structComb";
            this.structComb.Size = new System.Drawing.Size(521, 352);
            this.structComb.TabIndex = 5;
            // 
            // list_productTreeStruct
            // 
            this.list_productTreeStruct.CheckBoxes = System.Windows.Forms.CheckBoxesTypes.Recursive;
            this.list_productTreeStruct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ObjectNo,
            this.ObjectVersion,
            this.ObjectNum,
            this.ObjectModel,
            this.ObjectSort,
            this.ObjectMemo});
            treeListViewItemCollectionComparer1.Column = 0;
            treeListViewItemCollectionComparer1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.list_productTreeStruct.Comparer = treeListViewItemCollectionComparer1;
            this.list_productTreeStruct.GridLines = true;
            this.list_productTreeStruct.Location = new System.Drawing.Point(0, 59);
            this.list_productTreeStruct.MultiSelect = false;
            this.list_productTreeStruct.Name = "list_productTreeStruct";
            this.list_productTreeStruct.Size = new System.Drawing.Size(521, 294);
            this.list_productTreeStruct.SmallImageList = this.image_productStruct;
            this.list_productTreeStruct.Sorting = System.Windows.Forms.SortOrder.None;
            this.list_productTreeStruct.TabIndex = 5;
            this.list_productTreeStruct.UseCompatibleStateImageBehavior = false;
            // 
            // ObjectNo
            // 
            this.ObjectNo.Text = "编号";
            this.ObjectNo.Width = 126;
            // 
            // ObjectVersion
            // 
            this.ObjectVersion.Text = "版本号";
            this.ObjectVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ObjectVersion.Width = 79;
            // 
            // ObjectNum
            // 
            this.ObjectNum.Text = "数量";
            this.ObjectNum.Width = 45;
            // 
            // ObjectModel
            // 
            this.ObjectModel.Text = "规格代号";
            this.ObjectModel.Width = 78;
            // 
            // ObjectSort
            // 
            this.ObjectSort.Text = "顺序";
            this.ObjectSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ObjectSort.Width = 55;
            // 
            // ObjectMemo
            // 
            this.ObjectMemo.Text = "描述";
            this.ObjectMemo.Width = 103;
            // 
            // image_productStruct
            // 
            this.image_productStruct.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_productStruct.ImageStream")));
            this.image_productStruct.TransparentColor = System.Drawing.Color.Transparent;
            this.image_productStruct.Images.SetKeyName(0, "525FLOP1.ICO");
            this.image_productStruct.Images.SetKeyName(1, "CLSDFOLD.ICO");
            this.image_productStruct.Images.SetKeyName(2, "NOTE12.ICO");
            this.image_productStruct.Images.SetKeyName(3, "OPENFOLD.ICO");
            // 
            // toolStruct
            // 
            this.toolStruct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStructAdd,
            this.toolStripLabel14,
            this.toolStructDel,
            this.toolStructEdit,
            this.toolStructSave,
            this.toolStructReplace,
            this.toolStructInsert});
            this.toolStruct.Location = new System.Drawing.Point(0, 0);
            this.toolStruct.Name = "toolStruct";
            this.toolStruct.Size = new System.Drawing.Size(521, 25);
            this.toolStruct.TabIndex = 0;
            this.toolStruct.Text = "toolStrip3";
            // 
            // toolStructAdd
            // 
            this.toolStructAdd.Image = global::HYPDM.WinUI.Properties.Resources.edit_add;
            this.toolStructAdd.Name = "toolStructAdd";
            this.toolStructAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStructAdd.ToolTipText = "添加部件";
            this.toolStructAdd.Click += new System.EventHandler(this.toolStructAdd_Click);
            // 
            // toolStripLabel14
            // 
            this.toolStripLabel14.Name = "toolStripLabel14";
            this.toolStripLabel14.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel14.ToolTipText = " ";
            // 
            // toolStructDel
            // 
            this.toolStructDel.Image = global::HYPDM.WinUI.Properties.Resources.edit_remove;
            this.toolStructDel.Name = "toolStructDel";
            this.toolStructDel.Size = new System.Drawing.Size(23, 22);
            this.toolStructDel.ToolTipText = "删除";
            this.toolStructDel.Click += new System.EventHandler(this.toolStructDel_Click);
            // 
            // toolStructEdit
            // 
            this.toolStructEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStructEdit.Image")));
            this.toolStructEdit.Name = "toolStructEdit";
            this.toolStructEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStructEdit.ToolTipText = "修改";
            this.toolStructEdit.Click += new System.EventHandler(this.toolStructEdit_Click);
            // 
            // toolStructSave
            // 
            this.toolStructSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStructSave.Image")));
            this.toolStructSave.Name = "toolStructSave";
            this.toolStructSave.Size = new System.Drawing.Size(23, 22);
            this.toolStructSave.ToolTipText = "保存查询结果";
            this.toolStructSave.Click += new System.EventHandler(this.toolStructSave_Click);
            // 
            // toolStructReplace
            // 
            this.toolStructReplace.Image = ((System.Drawing.Image)(resources.GetObject("toolStructReplace.Image")));
            this.toolStructReplace.Name = "toolStructReplace";
            this.toolStructReplace.Size = new System.Drawing.Size(23, 22);
            this.toolStructReplace.ToolTipText = "替换结构";
            this.toolStructReplace.Click += new System.EventHandler(this.toolStructReplace_Click);
            // 
            // toolStructInsert
            // 
            this.toolStructInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStructInsert.Image")));
            this.toolStructInsert.Name = "toolStructInsert";
            this.toolStructInsert.Size = new System.Drawing.Size(23, 22);
            this.toolStructInsert.ToolTipText = "插入";
            this.toolStructInsert.Click += new System.EventHandler(this.toolStructInsert_Click);
            // 
            // bt_StructSearch
            // 
            this.bt_StructSearch.Image = global::HYPDM.WinUI.Properties.Resources.search;
            this.bt_StructSearch.Location = new System.Drawing.Point(205, 31);
            this.bt_StructSearch.Name = "bt_StructSearch";
            this.bt_StructSearch.Size = new System.Drawing.Size(25, 22);
            this.bt_StructSearch.TabIndex = 4;
            this.bt_StructSearch.UseVisualStyleBackColor = true;
            this.bt_StructSearch.Click += new System.EventHandler(this.bt_StructSearch_Click);
            // 
            // cb_structPro
            // 
            this.cb_structPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_structPro.FormattingEnabled = true;
            this.cb_structPro.Location = new System.Drawing.Point(12, 31);
            this.cb_structPro.Name = "cb_structPro";
            this.cb_structPro.Size = new System.Drawing.Size(70, 20);
            this.cb_structPro.TabIndex = 2;
            // 
            // tb_structProValue
            // 
            this.tb_structProValue.Location = new System.Drawing.Point(88, 31);
            this.tb_structProValue.Name = "tb_structProValue";
            this.tb_structProValue.Size = new System.Drawing.Size(111, 21);
            this.tb_structProValue.TabIndex = 3;
            // 
            // tab_Version
            // 
            this.tab_Version.Controls.Add(this.toolVersion);
            this.tab_Version.Controls.Add(this.dgv_Product);
            this.tab_Version.Location = new System.Drawing.Point(4, 22);
            this.tab_Version.Name = "tab_Version";
            this.tab_Version.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Version.Size = new System.Drawing.Size(527, 358);
            this.tab_Version.TabIndex = 7;
            this.tab_Version.Text = "版本";
            this.tab_Version.UseVisualStyleBackColor = true;
            // 
            // toolVersion
            // 
            this.toolVersion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolVersionCompare,
            this.toolVersionNo,
            this.toolVersionQuery});
            this.toolVersion.Location = new System.Drawing.Point(3, 3);
            this.toolVersion.Name = "toolVersion";
            this.toolVersion.Size = new System.Drawing.Size(521, 25);
            this.toolVersion.TabIndex = 1;
            this.toolVersion.Text = "toolStrip7";
            // 
            // toolVersionCompare
            // 
            this.toolVersionCompare.Image = ((System.Drawing.Image)(resources.GetObject("toolVersionCompare.Image")));
            this.toolVersionCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolVersionCompare.Name = "toolVersionCompare";
            this.toolVersionCompare.Size = new System.Drawing.Size(52, 22);
            this.toolVersionCompare.Text = "比较";
            this.toolVersionCompare.Click += new System.EventHandler(this.toolVersionCompare_Click);
            // 
            // toolVersionNo
            // 
            this.toolVersionNo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolVersionNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolVersionNo.Name = "toolVersionNo";
            this.toolVersionNo.Size = new System.Drawing.Size(121, 25);
            this.toolVersionNo.ToolTipText = "请输入产品编号";
            // 
            // toolVersionQuery
            // 
            this.toolVersionQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolVersionQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolVersionQuery.Image")));
            this.toolVersionQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolVersionQuery.Name = "toolVersionQuery";
            this.toolVersionQuery.Size = new System.Drawing.Size(52, 22);
            this.toolVersionQuery.Text = "查询";
            this.toolVersionQuery.Click += new System.EventHandler(this.toolVersionQuery_Click);
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedDataGridViewCheckBoxColumn,
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10});
            this.dgv_Product.Location = new System.Drawing.Point(-2, 30);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowTemplate.Height = 23;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(523, 324);
            this.dgv_Product.TabIndex = 0;
            this.dgv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
            // 
            // checkedDataGridViewCheckBoxColumn
            // 
            this.checkedDataGridViewCheckBoxColumn.HeaderText = "";
            this.checkedDataGridViewCheckBoxColumn.Name = "checkedDataGridViewCheckBoxColumn";
            this.checkedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.checkedDataGridViewCheckBoxColumn.Width = 50;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PRODUCTID";
            this.Column11.HeaderText = "主键";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PRODUCTNO";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VERSION";
            this.Column2.HeaderText = "版本";
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
            this.Column4.DataPropertyName = "PRODUCTTYPE";
            this.Column4.HeaderText = "类型";
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
            // Column10
            // 
            this.Column10.DataPropertyName = "MEMO_ZH";
            this.Column10.HeaderText = "中文描述";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // tab_Extpro
            // 
            this.tab_Extpro.Controls.Add(this.dgvExptendProperties);
            this.tab_Extpro.Controls.Add(this.toolStrip1);
            this.tab_Extpro.Location = new System.Drawing.Point(4, 22);
            this.tab_Extpro.Name = "tab_Extpro";
            this.tab_Extpro.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Extpro.Size = new System.Drawing.Size(527, 358);
            this.tab_Extpro.TabIndex = 8;
            this.tab_Extpro.Text = "扩展属性";
            this.tab_Extpro.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExptendProperties.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExptendProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExptendProperties.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExptendProperties.Location = new System.Drawing.Point(3, 28);
            this.dgvExptendProperties.Name = "dgvExptendProperties";
            this.dgvExptendProperties.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExptendProperties.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExptendProperties.RowTemplate.Height = 23;
            this.dgvExptendProperties.Size = new System.Drawing.Size(521, 327);
            this.dgvExptendProperties.TabIndex = 27;
            // 
            // PARAMS_NAME
            // 
            this.PARAMS_NAME.DataPropertyName = "PARAMS_NAME";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PARAMS_NAME.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.colValue.HeaderText = "属性值";
            this.colValue.Name = "colValue";
            this.colValue.Width = 280;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExt_Add});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolExt_Add
            // 
            this.toolExt_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolExt_Add.Image")));
            this.toolExt_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExt_Add.Name = "toolExt_Add";
            this.toolExt_Add.Size = new System.Drawing.Size(76, 22);
            this.toolExt_Add.Text = "添加属性";
            this.toolExt_Add.Click += new System.EventHandler(this.toolExt_Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.结构ToolStripMenuItem,
            this.展开ToolStripMenuItem,
            this.toolStripSeparator1,
            this.打开ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.发送ToolStripMenuItem,
            this.toolStripSeparator2,
            this.注册流程ToolStripMenuItem,
            this.对象比较ToolStripMenuItem,
            this.eRP集成ToolStripMenuItem,
            this.工艺权限ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 236);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.产品1ToolStripMenuItem,
            this.产品2ToolStripMenuItem});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 产品1ToolStripMenuItem
            // 
            this.产品1ToolStripMenuItem.Name = "产品1ToolStripMenuItem";
            this.产品1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.产品1ToolStripMenuItem.Text = "产品1";
            // 
            // 产品2ToolStripMenuItem
            // 
            this.产品2ToolStripMenuItem.Name = "产品2ToolStripMenuItem";
            this.产品2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.产品2ToolStripMenuItem.Text = "产品2";
            // 
            // 结构ToolStripMenuItem
            // 
            this.结构ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.产品结构ToolStripMenuItem,
            this.添加下层ToolStripMenuItem,
            this.删除关联ToolStripMenuItem,
            this.bOM顺序重排ToolStripMenuItem,
            this.替换为ToolStripMenuItem,
            this.插入ToolStripMenuItem});
            this.结构ToolStripMenuItem.Name = "结构ToolStripMenuItem";
            this.结构ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结构ToolStripMenuItem.Text = "结构";
            // 
            // 产品结构ToolStripMenuItem
            // 
            this.产品结构ToolStripMenuItem.Name = "产品结构ToolStripMenuItem";
            this.产品结构ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.产品结构ToolStripMenuItem.Text = "产品结构";
            // 
            // 添加下层ToolStripMenuItem
            // 
            this.添加下层ToolStripMenuItem.Name = "添加下层ToolStripMenuItem";
            this.添加下层ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.添加下层ToolStripMenuItem.Text = "添加下层";
            // 
            // 删除关联ToolStripMenuItem
            // 
            this.删除关联ToolStripMenuItem.Name = "删除关联ToolStripMenuItem";
            this.删除关联ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.删除关联ToolStripMenuItem.Text = "删除关联";
            // 
            // bOM顺序重排ToolStripMenuItem
            // 
            this.bOM顺序重排ToolStripMenuItem.Name = "bOM顺序重排ToolStripMenuItem";
            this.bOM顺序重排ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bOM顺序重排ToolStripMenuItem.Text = "BOM顺序重排";
            // 
            // 替换为ToolStripMenuItem
            // 
            this.替换为ToolStripMenuItem.Name = "替换为ToolStripMenuItem";
            this.替换为ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.替换为ToolStripMenuItem.Text = "替换为...";
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.插入ToolStripMenuItem.Text = "插入...";
            // 
            // 展开ToolStripMenuItem
            // 
            this.展开ToolStripMenuItem.Name = "展开ToolStripMenuItem";
            this.展开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.展开ToolStripMenuItem.Text = "展开";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 发送ToolStripMenuItem
            // 
            this.发送ToolStripMenuItem.Name = "发送ToolStripMenuItem";
            this.发送ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.发送ToolStripMenuItem.Text = "发送";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // 注册流程ToolStripMenuItem
            // 
            this.注册流程ToolStripMenuItem.Name = "注册流程ToolStripMenuItem";
            this.注册流程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注册流程ToolStripMenuItem.Text = "注册流程";
            // 
            // 对象比较ToolStripMenuItem
            // 
            this.对象比较ToolStripMenuItem.Name = "对象比较ToolStripMenuItem";
            this.对象比较ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.对象比较ToolStripMenuItem.Text = "对象比较";
            // 
            // eRP集成ToolStripMenuItem
            // 
            this.eRP集成ToolStripMenuItem.Name = "eRP集成ToolStripMenuItem";
            this.eRP集成ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.eRP集成ToolStripMenuItem.Text = "ERP集成";
            // 
            // 工艺权限ToolStripMenuItem
            // 
            this.工艺权限ToolStripMenuItem.Name = "工艺权限ToolStripMenuItem";
            this.工艺权限ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.工艺权限ToolStripMenuItem.Text = "工艺权限";
            // 
            // PartsConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolBase);
            this.Controls.Add(this.groupBox1);
            this.Name = "PartsConfForm";
            this.Tag = "";
            this.Text = "半成品";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolBase.ResumeLayout(false);
            this.toolBase.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_Memo.ResumeLayout(false);
            this.tab_ProRecord.ResumeLayout(false);
            this.tab_ProRecord.PerformLayout();
            this.toolProRecord.ResumeLayout(false);
            this.toolProRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Data_ProRecord)).EndInit();
            this.tab_Change.ResumeLayout(false);
            this.tab_Change.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Change)).EndInit();
            this.toolChange.ResumeLayout(false);
            this.toolChange.PerformLayout();
            this.tab_Doc.ResumeLayout(false);
            this.tab_Doc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocList)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tab_Drawing.ResumeLayout(false);
            this.tab_Drawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DrawList)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.tab_TelTask.ResumeLayout(false);
            this.tab_TelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.tab_productStruct.ResumeLayout(false);
            this.structComb.ResumeLayout(false);
            this.structComb.PerformLayout();
            this.toolStruct.ResumeLayout(false);
            this.toolStruct.PerformLayout();
            this.tab_Version.ResumeLayout(false);
            this.tab_Version.PerformLayout();
            this.toolVersion.ResumeLayout(false);
            this.toolVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.tab_Extpro.ResumeLayout(false);
            this.tab_Extpro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExptendProperties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_productNo;
        private System.Windows.Forms.TextBox tb_modelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_createTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_memoEn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_memoZh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_modifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_creater;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_productType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Memo;
        private System.Windows.Forms.TabPage tab_ProRecord;
        private System.Windows.Forms.TabPage tab_Change;
        private System.Windows.Forms.TabPage tab_Doc;
        private System.Windows.Forms.TabPage tab_Drawing;
        private System.Windows.Forms.TabPage tab_TelTask;
        private System.Windows.Forms.TabPage tab_productStruct;
        private System.Windows.Forms.ToolStrip toolStruct;
        private System.Windows.Forms.ToolStripLabel toolStripLabel14;
        private System.Windows.Forms.TabPage tab_Version;
        private System.Windows.Forms.Button bt_StructSearch;
        private System.Windows.Forms.TextBox tb_structProValue;
        private System.Windows.Forms.ComboBox cb_structPro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结构ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品结构ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加下层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除关联ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOM顺序重排ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 注册流程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对象比较ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRP集成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工艺权限ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel48;
        private System.Windows.Forms.ToolStripLabel toolStripLabel49;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolVersion;
        private System.Windows.Forms.ToolStripButton toolVersionCompare;
        private System.Windows.Forms.ToolStripButton toolVersionQuery;
        private System.Windows.Forms.ToolStripTextBox toolVersionNo;
        private System.Windows.Forms.RichTextBox rtbMemo;
        private System.Windows.Forms.ToolStrip toolProRecord;
        private System.Windows.Forms.ToolStripButton toolProRecordAdd;
        private System.Windows.Forms.ToolStripButton toolProRecordEdit;
        private System.Windows.Forms.BindingSource bs_Data_ProRecord;
        private System.Windows.Forms.ToolStrip toolChange;
        private System.Windows.Forms.DataGridView dgv_Change;
        private System.Windows.Forms.ToolStripButton toolChangeAdd;
        private System.Windows.Forms.ToolStripButton toolChangeDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeReasionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel structComb;
        private System.Windows.Forms.TreeListView list_productTreeStruct;
        private System.Windows.Forms.ColumnHeader ObjectNo;
        private System.Windows.Forms.ColumnHeader ObjectVersion;
        private System.Windows.Forms.ColumnHeader ObjectNum;
        private System.Windows.Forms.ImageList image_productStruct;
        private System.Windows.Forms.ColumnHeader ObjectSort;
        private System.Windows.Forms.ColumnHeader ObjectModel;
        private System.Windows.Forms.ColumnHeader ObjectMemo;
        private System.Windows.Forms.ToolStripButton toolStructAdd;
        private System.Windows.Forms.TextBox tb_modifyTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton toolBaseEdit;
        private System.Windows.Forms.ToolStripButton toolBaseReg;
        private System.Windows.Forms.ToolStripButton toolBaseClear;
        private System.Windows.Forms.ToolStripButton toolStructDel;
        private System.Windows.Forms.ToolStripButton toolStructEdit;
        private System.Windows.Forms.ToolStripButton toolStructSave;
        private System.Windows.Forms.ToolStripButton toolStructReplace;
        private System.Windows.Forms.ToolStripButton toolStructInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNO_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELTYPE_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODIFYTIME_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS_C;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolStripButton tsb_DocAdd;
        private System.Windows.Forms.ToolStripButton tsb_DocDel;
        private System.Windows.Forms.ToolStripButton tsb_DocLook;
        private System.Windows.Forms.ToolStripButton toolDrawAdd;
        private System.Windows.Forms.ToolStripButton toolDrawDel;
        private System.Windows.Forms.ToolStripButton toolDrawLook;
        private BaseControl.UcPaging ucPageDoc;
        private BaseControl.UcPaging ucPagingDraw;
        private BaseControl.DataGridViewExt dgv_DocList;
        private BaseControl.DataGridViewExt dgv_DrawList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCVERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCCREATEUSER;
        private System.Windows.Forms.ToolStripButton toolBaseCopy;
        private System.Windows.Forms.TabPage tab_Extpro;
        private BaseControl.DataGridViewExt dgvExptendProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARGET_COLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolExt_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAWID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAWNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAWVERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAWDOCSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRAWCREATEUSER;

        private BaseControl.DataGridViewExt dgv_ProRecord;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTKEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
    }
}