namespace HYPDM.WinUI.Parts
{
    partial class ProductRegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLastUpdateUser = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtProType = new System.Windows.Forms.TextBox();
            this.txtEngDescription = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegPart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tbcContent = new System.Windows.Forms.TabControl();
            this.tpRemark = new System.Windows.Forms.TabPage();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tpDoc = new System.Windows.Forms.TabPage();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ChkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDocument = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmDocAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmProDocDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.txtCreateDate = new System.Windows.Forms.TextBox();
            this.txtLastUpdateDate = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbcContent.SuspendLayout();
            this.tpRemark.SuspendLayout();
            this.tpDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.cmDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.txtLastUpdateDate);
            this.tabPage1.Controls.Add(this.txtCreateDate);
            this.tabPage1.Controls.Add(this.txtModelNo);
            this.tabPage1.Controls.Add(this.txtLastUpdateUser);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.txtProType);
            this.tabPage1.Controls.Add(this.txtEngDescription);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.txtProductNo);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "产品信息";
            // 
            // txtLastUpdateUser
            // 
            this.txtLastUpdateUser.Enabled = false;
            this.txtLastUpdateUser.Location = new System.Drawing.Point(99, 156);
            this.txtLastUpdateUser.Name = "txtLastUpdateUser";
            this.txtLastUpdateUser.Size = new System.Drawing.Size(135, 21);
            this.txtLastUpdateUser.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(99, 132);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(135, 21);
            this.txtStatus.TabIndex = 20;
            // 
            // txtProType
            // 
            this.txtProType.Location = new System.Drawing.Point(99, 84);
            this.txtProType.Name = "txtProType";
            this.txtProType.Size = new System.Drawing.Size(135, 21);
            this.txtProType.TabIndex = 6;
            // 
            // txtEngDescription
            // 
            this.txtEngDescription.Location = new System.Drawing.Point(99, 60);
            this.txtEngDescription.Name = "txtEngDescription";
            this.txtEngDescription.Size = new System.Drawing.Size(135, 21);
            this.txtEngDescription.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 36);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(135, 21);
            this.txtDescription.TabIndex = 4;
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(99, 12);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.Size = new System.Drawing.Size(135, 21);
            this.txtProductNo.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "修改时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "创建时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "修改者";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "状态";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "产品型号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "产品类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文描述";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegPart,
            this.toolStripButton2,
            this.btnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRegPart
            // 
            this.btnRegPart.Image = ((System.Drawing.Image)(resources.GetObject("btnRegPart.Image")));
            this.btnRegPart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegPart.Name = "btnRegPart";
            this.btnRegPart.Size = new System.Drawing.Size(49, 22);
            this.btnRegPart.Text = "保存";
            this.btnRegPart.Click += new System.EventHandler(this.btnRegPart_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 22);
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbcContent
            // 
            this.tbcContent.Controls.Add(this.tpRemark);
            this.tbcContent.Controls.Add(this.tpDoc);
            this.tbcContent.Location = new System.Drawing.Point(268, 28);
            this.tbcContent.Name = "tbcContent";
            this.tbcContent.SelectedIndex = 0;
            this.tbcContent.Size = new System.Drawing.Size(377, 262);
            this.tbcContent.TabIndex = 2;
            // 
            // tpRemark
            // 
            this.tpRemark.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpRemark.Controls.Add(this.txtRemark);
            this.tpRemark.Location = new System.Drawing.Point(4, 21);
            this.tpRemark.Name = "tpRemark";
            this.tpRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tpRemark.Size = new System.Drawing.Size(369, 397);
            this.tpRemark.TabIndex = 0;
            this.tpRemark.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(6, 12);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(357, 207);
            this.txtRemark.TabIndex = 0;
            // 
            // tpDoc
            // 
            this.tpDoc.Controls.Add(this.dgvDoc);
            this.tpDoc.Controls.Add(this.toolStrip2);
            this.tpDoc.Location = new System.Drawing.Point(4, 21);
            this.tpDoc.Name = "tpDoc";
            this.tpDoc.Size = new System.Drawing.Size(369, 237);
            this.tpDoc.TabIndex = 1;
            this.tpDoc.Text = "文档";
            this.tpDoc.UseVisualStyleBackColor = true;
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            this.dgvDoc.AutoGenerateColumns = false;
            this.dgvDoc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkBox,
            this.DocID,
            this.DocNO,
            this.DocType,
            this.Description,
            this.Status,
            this.LastUpdateUser,
            this.LastUpdateDate});
            this.dgvDoc.DataSource = this.docBindingSource;
            this.dgvDoc.Location = new System.Drawing.Point(3, 27);
            this.dgvDoc.MultiSelect = false;
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
            this.dgvDoc.RowHeadersVisible = false;
            this.dgvDoc.RowTemplate.Height = 23;
            this.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoc.Size = new System.Drawing.Size(363, 342);
            this.dgvDoc.TabIndex = 1;
            this.dgvDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellClick);
            this.dgvDoc.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoc_CellMouseDown);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.btnAddDoc,
            this.btnDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(369, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // btnAddDoc
            // 
            this.btnAddDoc.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDoc.Image")));
            this.btnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDoc.Name = "btnAddDoc";
            this.btnAddDoc.Size = new System.Drawing.Size(49, 22);
            this.btnAddDoc.Text = "新增";
            this.btnAddDoc.Click += new System.EventHandler(this.btnAddDoc_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ChkBox
            // 
            this.ChkBox.HeaderText = "";
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.ReadOnly = true;
            this.ChkBox.Width = 30;
            // 
            // DocID
            // 
            this.DocID.DataPropertyName = "DOCID";
            this.DocID.HeaderText = "DocID";
            this.DocID.Name = "DocID";
            this.DocID.ReadOnly = true;
            this.DocID.Visible = false;
            // 
            // DocNO
            // 
            this.DocNO.DataPropertyName = "DOCNO";
            this.DocNO.HeaderText = "编号";
            this.DocNO.Name = "DocNO";
            this.DocNO.ReadOnly = true;
            this.DocNO.Width = 80;
            // 
            // DocType
            // 
            this.DocType.DataPropertyName = "DOCTYPE";
            this.DocType.HeaderText = "文档分类";
            this.DocType.Name = "DocType";
            this.DocType.ReadOnly = true;
            this.DocType.Width = 80;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "DESCRIPTION";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "DOCSTATUS";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // LastUpdateUser
            // 
            this.LastUpdateUser.DataPropertyName = "LASTUPDATEUSER";
            this.LastUpdateUser.HeaderText = "修改者";
            this.LastUpdateUser.Name = "LastUpdateUser";
            this.LastUpdateUser.ReadOnly = true;
            this.LastUpdateUser.Width = 80;
            // 
            // LastUpdateDate
            // 
            this.LastUpdateDate.DataPropertyName = "CREATEDATE";
            this.LastUpdateDate.HeaderText = "创建时间";
            this.LastUpdateDate.Name = "LastUpdateDate";
            this.LastUpdateDate.ReadOnly = true;
            this.LastUpdateDate.Width = 80;
            // 
            // cmDocument
            // 
            this.cmDocument.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmDocAdd,
            this.cmProDocDelete});
            this.cmDocument.Name = "cmDocument";
            this.cmDocument.Size = new System.Drawing.Size(95, 48);
            // 
            // cmDocAdd
            // 
            this.cmDocAdd.Name = "cmDocAdd";
            this.cmDocAdd.Size = new System.Drawing.Size(94, 22);
            this.cmDocAdd.Text = "新建";
            this.cmDocAdd.Click += new System.EventHandler(this.cmDocAdd_Click);
            // 
            // cmProDocDelete
            // 
            this.cmProDocDelete.Name = "cmProDocDelete";
            this.cmProDocDelete.Size = new System.Drawing.Size(94, 22);
            this.cmProDocDelete.Text = "删除";
            this.cmProDocDelete.Click += new System.EventHandler(this.cmProDocDelete_Click);
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(99, 108);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(135, 21);
            this.txtModelNo.TabIndex = 24;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.Enabled = false;
            this.txtCreateDate.Location = new System.Drawing.Point(99, 180);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Size = new System.Drawing.Size(135, 21);
            this.txtCreateDate.TabIndex = 25;
            // 
            // txtLastUpdateDate
            // 
            this.txtLastUpdateDate.Enabled = false;
            this.txtLastUpdateDate.Location = new System.Drawing.Point(99, 204);
            this.txtLastUpdateDate.Name = "txtLastUpdateDate";
            this.txtLastUpdateDate.Size = new System.Drawing.Size(135, 21);
            this.txtLastUpdateDate.TabIndex = 26;
            // 
            // ProductRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 294);
            this.Controls.Add(this.tbcContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductRegForm";
            this.Text = "产品 注册";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcContent.ResumeLayout(false);
            this.tpRemark.ResumeLayout(false);
            this.tpRemark.PerformLayout();
            this.tpDoc.ResumeLayout(false);
            this.tpDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.cmDocument.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegPart;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProType;
        private System.Windows.Forms.TextBox txtEngDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProductNo;
        private System.Windows.Forms.TextBox txtLastUpdateUser;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TabControl tbcContent;
        private System.Windows.Forms.TabPage tpRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TabPage tpDoc;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btnAddDoc;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.BindingSource docBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateDate;
        private System.Windows.Forms.ContextMenuStrip cmDocument;
        private System.Windows.Forms.ToolStripMenuItem cmDocAdd;
        private System.Windows.Forms.ToolStripMenuItem cmProDocDelete;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.TextBox txtLastUpdateDate;
        private System.Windows.Forms.TextBox txtCreateDate;
    }
}