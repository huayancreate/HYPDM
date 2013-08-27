namespace HYDocumentMS.FileAuth
{
    partial class FileAuthOper
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileAuthOper));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabAuth = new System.Windows.Forms.TabControl();
            this.tabSigleUser = new System.Windows.Forms.TabPage();
            this.pnlSingle = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVUsers = new HYPDM.BaseControl.DataGridViewExt();
            this.LOGINID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLENAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGANNAME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRoleUsers = new HYPDM.BaseControl.DataGridViewExt();
            this.LOGINID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGANNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvRoles = new HYPDM.BaseControl.DataGridViewExt();
            this.NAME1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGroupAuth = new System.Windows.Forms.Button();
            this.tabDescription = new System.Windows.Forms.TabPage();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabSigleUser.SuspendLayout();
            this.pnlSingle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabGroup.SuspendLayout();
            this.pnlGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUsers)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabDescription.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabAuth);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 541);
            this.panel1.TabIndex = 0;
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.tabSigleUser);
            this.tabAuth.Controls.Add(this.tabGroup);
            this.tabAuth.Controls.Add(this.tabDescription);
            this.tabAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAuth.Location = new System.Drawing.Point(0, 27);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.SelectedIndex = 0;
            this.tabAuth.Size = new System.Drawing.Size(919, 483);
            this.tabAuth.TabIndex = 3;
            // 
            // tabSigleUser
            // 
            this.tabSigleUser.Controls.Add(this.pnlSingle);
            this.tabSigleUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabSigleUser.Location = new System.Drawing.Point(4, 22);
            this.tabSigleUser.Name = "tabSigleUser";
            this.tabSigleUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabSigleUser.Size = new System.Drawing.Size(911, 457);
            this.tabSigleUser.TabIndex = 0;
            this.tabSigleUser.Text = "单用户文档权限设定";
            this.tabSigleUser.UseVisualStyleBackColor = true;
            // 
            // pnlSingle
            // 
            this.pnlSingle.Controls.Add(this.groupBox1);
            this.pnlSingle.Controls.Add(this.panel5);
            this.pnlSingle.Controls.Add(this.panel4);
            this.pnlSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSingle.Location = new System.Drawing.Point(3, 3);
            this.pnlSingle.Name = "pnlSingle";
            this.pnlSingle.Size = new System.Drawing.Size(905, 451);
            this.pnlSingle.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVUsers);
            this.groupBox1.Controls.Add(this.ucPaging1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 371);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户清单";
            // 
            // dGVUsers
            // 
            this.dGVUsers.AllowUserToAddRows = false;
            this.dGVUsers.AllowUserToDeleteRows = false;
            this.dGVUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dGVUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOGINID,
            this.ROLENAME1,
            this.DESCRIPTION2,
            this.ORGANNAME2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUsers.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dGVUsers.Location = new System.Drawing.Point(3, 17);
            this.dGVUsers.Name = "dGVUsers";
            this.dGVUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dGVUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dGVUsers.RowTemplate.Height = 23;
            this.dGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUsers.Size = new System.Drawing.Size(899, 314);
            this.dGVUsers.TabIndex = 1;
            this.dGVUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUsers_CellDoubleClick);
            // 
            // LOGINID
            // 
            this.LOGINID.DataPropertyName = "LOGINID";
            this.LOGINID.HeaderText = "登录账号";
            this.LOGINID.Name = "LOGINID";
            this.LOGINID.ReadOnly = true;
            this.LOGINID.Width = 150;
            // 
            // ROLENAME1
            // 
            this.ROLENAME1.DataPropertyName = "ROLENAME";
            this.ROLENAME1.HeaderText = "群组";
            this.ROLENAME1.Name = "ROLENAME1";
            this.ROLENAME1.ReadOnly = true;
            this.ROLENAME1.Width = 160;
            // 
            // DESCRIPTION2
            // 
            this.DESCRIPTION2.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION2.HeaderText = "描述";
            this.DESCRIPTION2.Name = "DESCRIPTION2";
            this.DESCRIPTION2.ReadOnly = true;
            this.DESCRIPTION2.Width = 180;
            // 
            // ORGANNAME2
            // 
            this.ORGANNAME2.DataPropertyName = "ORGANNAME";
            this.ORGANNAME2.HeaderText = "组织";
            this.ORGANNAME2.Name = "ORGANNAME2";
            this.ORGANNAME2.ReadOnly = true;
            this.ORGANNAME2.Width = 180;
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = false;
            this.ucPaging1.Location = new System.Drawing.Point(3, 331);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 20;
            this.ucPaging1.Size = new System.Drawing.Size(899, 37);
            this.ucPaging1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 31);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btnSet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 49);
            this.panel4.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(3, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(142, 39);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "选定用户的权限设定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tabGroup
            // 
            this.tabGroup.Controls.Add(this.pnlGroup);
            this.tabGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroup.Name = "tabGroup";
            this.tabGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroup.Size = new System.Drawing.Size(911, 457);
            this.tabGroup.TabIndex = 1;
            this.tabGroup.Text = "群组文档权限设定";
            this.tabGroup.UseVisualStyleBackColor = true;
            // 
            // pnlGroup
            // 
            this.pnlGroup.Controls.Add(this.groupBox2);
            this.pnlGroup.Controls.Add(this.panel6);
            this.pnlGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroup.Location = new System.Drawing.Point(3, 3);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(905, 451);
            this.pnlGroup.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 405);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户群组权限设定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRoleUsers);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(295, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 354);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "群组对应用户";
            // 
            // dgvRoleUsers
            // 
            this.dgvRoleUsers.AllowUserToAddRows = false;
            this.dgvRoleUsers.AllowUserToDeleteRows = false;
            this.dgvRoleUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRoleUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoleUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LOGINID1,
            this.ROLENAME,
            this.DESCRIPTION1,
            this.ORGANNAME});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoleUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoleUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoleUsers.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvRoleUsers.Location = new System.Drawing.Point(3, 17);
            this.dgvRoleUsers.Name = "dgvRoleUsers";
            this.dgvRoleUsers.ReadOnly = true;
            this.dgvRoleUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvRoleUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvRoleUsers.RowTemplate.Height = 23;
            this.dgvRoleUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleUsers.Size = new System.Drawing.Size(601, 334);
            this.dgvRoleUsers.TabIndex = 10;
            // 
            // LOGINID1
            // 
            this.LOGINID1.DataPropertyName = "LOGINID";
            this.LOGINID1.HeaderText = "登录账号";
            this.LOGINID1.Name = "LOGINID1";
            this.LOGINID1.ReadOnly = true;
            this.LOGINID1.Width = 150;
            // 
            // ROLENAME
            // 
            this.ROLENAME.DataPropertyName = "ROLENAME";
            this.ROLENAME.HeaderText = "群组名称";
            this.ROLENAME.Name = "ROLENAME";
            this.ROLENAME.ReadOnly = true;
            this.ROLENAME.Width = 150;
            // 
            // DESCRIPTION1
            // 
            this.DESCRIPTION1.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION1.HeaderText = "描述";
            this.DESCRIPTION1.Name = "DESCRIPTION1";
            this.DESCRIPTION1.ReadOnly = true;
            this.DESCRIPTION1.Width = 180;
            // 
            // ORGANNAME
            // 
            this.ORGANNAME.DataPropertyName = "ORGANNAME";
            this.ORGANNAME.HeaderText = "组织名称";
            this.ORGANNAME.Name = "ORGANNAME";
            this.ORGANNAME.ReadOnly = true;
            this.ORGANNAME.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvRoles);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 354);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "群组";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME1,
            this.DESCRIPTION});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvRoles.Location = new System.Drawing.Point(3, 17);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvRoles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvRoles.RowTemplate.Height = 23;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(286, 334);
            this.dgvRoles.TabIndex = 8;
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            this.dgvRoles.SelectionChanged += new System.EventHandler(this.dgvRoles_SelectionChanged);
            // 
            // NAME1
            // 
            this.NAME1.DataPropertyName = "NAME";
            this.NAME1.HeaderText = "群组名称";
            this.NAME1.Name = "NAME1";
            this.NAME1.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "描述";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 200;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 371);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(899, 31);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.btnGroupAuth);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 46);
            this.panel6.TabIndex = 4;
            // 
            // btnGroupAuth
            // 
            this.btnGroupAuth.Location = new System.Drawing.Point(3, 4);
            this.btnGroupAuth.Name = "btnGroupAuth";
            this.btnGroupAuth.Size = new System.Drawing.Size(142, 38);
            this.btnGroupAuth.TabIndex = 3;
            this.btnGroupAuth.Text = "选定群组的权限设定";
            this.btnGroupAuth.UseVisualStyleBackColor = true;
            this.btnGroupAuth.Click += new System.EventHandler(this.btnGroupAuth_Click);
            // 
            // tabDescription
            // 
            this.tabDescription.Controls.Add(this.pnlDescription);
            this.tabDescription.Location = new System.Drawing.Point(4, 22);
            this.tabDescription.Name = "tabDescription";
            this.tabDescription.Size = new System.Drawing.Size(911, 457);
            this.tabDescription.TabIndex = 3;
            this.tabDescription.Text = "说明";
            this.tabDescription.UseVisualStyleBackColor = true;
            // 
            // pnlDescription
            // 
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(0, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(911, 457);
            this.pnlDescription.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 27);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HYDocumentMS.Properties.Resources.banner;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 27);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件权限管理";
            // 
            // FileAuthOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FileAuthOper";
            this.Size = new System.Drawing.Size(923, 541);
            this.Load += new System.EventHandler(this.FileAuthOper_Load);
            this.panel1.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabSigleUser.ResumeLayout(false);
            this.pnlSingle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabGroup.ResumeLayout(false);
            this.pnlGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUsers)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabDescription.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabAuth;
        private System.Windows.Forms.TabPage tabSigleUser;
        private System.Windows.Forms.TabPage tabGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDescription;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Panel pnlSingle;
        private System.Windows.Forms.Panel pnlGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSet;
        private HYPDM.BaseControl.DataGridViewExt dGVUsers;
        private HYPDM.BaseControl.UcPaging ucPaging1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGroupAuth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private HYPDM.BaseControl.DataGridViewExt dgvRoles;
        private System.Windows.Forms.GroupBox groupBox3;
        private HYPDM.BaseControl.DataGridViewExt dgvRoleUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGINID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGANNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGINID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLENAME1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGANNAME2;
    }
}
