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
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.tabGroup = new System.Windows.Forms.TabPage();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExt3 = new HYPDM.BaseControl.DataGridViewExt();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExt2 = new HYPDM.BaseControl.DataGridViewExt();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGroupAuth = new System.Windows.Forms.Button();
            this.tabGroupToGroup = new System.Windows.Forms.TabPage();
            this.pnlGroupGroup = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExt3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExt2)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabGroupToGroup.SuspendLayout();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.tabSigleUser);
            this.tabAuth.Controls.Add(this.tabGroup);
            this.tabAuth.Controls.Add(this.tabGroupToGroup);
            this.tabAuth.Controls.Add(this.tabDescription);
            this.tabAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAuth.Location = new System.Drawing.Point(0, 27);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.SelectedIndex = 0;
            this.tabAuth.Size = new System.Drawing.Size(919, 483);
            this.tabAuth.TabIndex = 3;
            this.tabAuth.SelectedIndexChanged += new System.EventHandler(this.tabAuth_SelectedIndexChanged);
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
            this.tabSigleUser.Text = "单用户权限设定";
            this.tabSigleUser.UseVisualStyleBackColor = true;
            this.tabSigleUser.Click += new System.EventHandler(this.tabSigleUser_Click);
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
            this.pnlSingle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSingle_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVUsers);
            this.groupBox1.Controls.Add(this.ucPaging1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户清单";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dGVUsers
            // 
            this.dGVUsers.AllowUserToAddRows = false;
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
            this.dGVUsers.Size = new System.Drawing.Size(899, 297);
            this.dGVUsers.TabIndex = 1;
            this.dGVUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExt1_CellContentClick);
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = false;
            this.ucPaging1.Location = new System.Drawing.Point(3, 314);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 20;
            this.ucPaging1.Size = new System.Drawing.Size(899, 37);
            this.ucPaging1.TabIndex = 0;
            this.ucPaging1.Load += new System.EventHandler(this.ucPaging1_Load);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(905, 31);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 66);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(21, 17);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(142, 31);
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
            this.tabGroup.Text = "群组权限设定";
            this.tabGroup.UseVisualStyleBackColor = true;
            this.tabGroup.Click += new System.EventHandler(this.tabGroup_Click);
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
            this.pnlGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGroup_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 385);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户群组权限设定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewExt3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(250, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(652, 334);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "群组对应用户";
            // 
            // dataGridViewExt3
            // 
            this.dataGridViewExt3.AllowUserToAddRows = false;
            this.dataGridViewExt3.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewExt3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewExt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExt3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewExt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExt3.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewExt3.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewExt3.Name = "dataGridViewExt3";
            this.dataGridViewExt3.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dataGridViewExt3.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridViewExt3.RowTemplate.Height = 23;
            this.dataGridViewExt3.Size = new System.Drawing.Size(646, 314);
            this.dataGridViewExt3.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewExt2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 334);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "群组";
            // 
            // dataGridViewExt2
            // 
            this.dataGridViewExt2.AllowUserToAddRows = false;
            this.dataGridViewExt2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewExt2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewExt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExt2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewExt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExt2.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewExt2.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewExt2.Name = "dataGridViewExt2";
            this.dataGridViewExt2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dataGridViewExt2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridViewExt2.RowTemplate.Height = 23;
            this.dataGridViewExt2.Size = new System.Drawing.Size(241, 314);
            this.dataGridViewExt2.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 351);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(899, 31);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGroupAuth);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(905, 66);
            this.panel6.TabIndex = 4;
            // 
            // btnGroupAuth
            // 
            this.btnGroupAuth.Location = new System.Drawing.Point(21, 17);
            this.btnGroupAuth.Name = "btnGroupAuth";
            this.btnGroupAuth.Size = new System.Drawing.Size(142, 31);
            this.btnGroupAuth.TabIndex = 3;
            this.btnGroupAuth.Text = "选定群组的权限设定";
            this.btnGroupAuth.UseVisualStyleBackColor = true;
            // 
            // tabGroupToGroup
            // 
            this.tabGroupToGroup.Controls.Add(this.pnlGroupGroup);
            this.tabGroupToGroup.Location = new System.Drawing.Point(4, 22);
            this.tabGroupToGroup.Name = "tabGroupToGroup";
            this.tabGroupToGroup.Size = new System.Drawing.Size(911, 457);
            this.tabGroupToGroup.TabIndex = 2;
            this.tabGroupToGroup.Text = "群组归属群组设定";
            this.tabGroupToGroup.UseVisualStyleBackColor = true;
            this.tabGroupToGroup.Click += new System.EventHandler(this.tabGroupToGroup_Click);
            // 
            // pnlGroupGroup
            // 
            this.pnlGroupGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroupGroup.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupGroup.Name = "pnlGroupGroup";
            this.pnlGroupGroup.Size = new System.Drawing.Size(911, 457);
            this.pnlGroupGroup.TabIndex = 1;
            this.pnlGroupGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGroupGroup_Paint);
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
            this.tabDescription.Click += new System.EventHandler(this.tabDescription_Click);
            // 
            // pnlDescription
            // 
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(0, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(911, 457);
            this.pnlDescription.TabIndex = 0;
            this.pnlDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDescription_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 27);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FileAuthOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FileAuthOper";
            this.Size = new System.Drawing.Size(923, 541);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExt3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExt2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabGroupToGroup.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabGroupToGroup;
        private System.Windows.Forms.TabPage tabDescription;
        private System.Windows.Forms.Panel pnlGroupGroup;
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
        private HYPDM.BaseControl.DataGridViewExt dataGridViewExt2;
        private System.Windows.Forms.GroupBox groupBox3;
        private HYPDM.BaseControl.DataGridViewExt dataGridViewExt3;
    }
}
