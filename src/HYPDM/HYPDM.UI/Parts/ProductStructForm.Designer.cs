namespace HYPDM.WinUI.Parts
{
    partial class ProductStructForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("半成品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("原材料");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("工艺装备");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("零部件", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
          //  this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.dgvSearchResult = new HYPDM.BaseControl.DataGridViewExt();
            this.ChkParts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PartsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SpecificationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsClassfication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvContent = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 397);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSearchResult);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(188, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 389);
            this.panel3.TabIndex = 2;
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.AutoGenerateColumns = false;
            this.dgvSearchResult.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkParts,
            this.PartsID,
            this.PartsNo,
            this.Version,
            this.Equip,
            this.SpecificationCode,
            this.Description,
            this.PartsType,
            this.PartsClassfication,
            this.Status,
            this.LastUpdateUser,
            this.CreateDate,
            this.LastUpdateDate});
            this.dgvSearchResult.DataSource = this.partsBindingSource;
            this.dgvSearchResult.Location = new System.Drawing.Point(9, 70);
            this.dgvSearchResult.MultiSelect = false;
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            this.dgvSearchResult.RowHeadersVisible = false;
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.Size = new System.Drawing.Size(527, 308);
            this.dgvSearchResult.TabIndex = 12;
            this.dgvSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellClick);
            // 
            // ChkParts
            // 
            this.ChkParts.HeaderText = "";
            this.ChkParts.Name = "ChkParts";
            this.ChkParts.ReadOnly = true;
            this.ChkParts.Width = 30;
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
            this.PartsNo.Width = 80;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "VERSION";
            this.Version.HeaderText = "版本";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // Equip
            // 
            this.Equip.HeaderText = "装配";
            this.Equip.Name = "Equip";
            this.Equip.ReadOnly = true;
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
            this.Description.Width = 80;
            // 
            // PartsType
            // 
            this.PartsType.DataPropertyName = "PARTSTYPE";
            this.PartsType.HeaderText = "零部件类型";
            this.PartsType.Name = "PartsType";
            this.PartsType.ReadOnly = true;
            this.PartsType.Width = 80;
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
            this.LastUpdateUser.Width = 80;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CREATEDATE";
            this.CreateDate.HeaderText = "创建时间";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 80;
            // 
            // LastUpdateDate
            // 
            this.LastUpdateDate.DataPropertyName = "LASTUPDATEDATE";
            this.LastUpdateDate.HeaderText = "修改日期";
            this.LastUpdateDate.Name = "LastUpdateDate";
            this.LastUpdateDate.ReadOnly = true;
            this.LastUpdateDate.Width = 80;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(9, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 34);
            this.panel4.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(497, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(467, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询结果(1 - 1)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 23);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 21);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 20);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 23);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvContent);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 389);
            this.panel2.TabIndex = 1;
            // 
            // tvContent
            // 
            this.tvContent.Location = new System.Drawing.Point(3, 3);
            this.tvContent.Name = "tvContent";
            treeNode1.Name = "semiPro";
            treeNode1.Text = "半成品";
            treeNode2.Name = "material";
            treeNode2.Text = "原材料";
            treeNode3.Name = "techEquip";
            treeNode3.Text = "工艺装备";
            treeNode4.Name = "parts";
            treeNode4.Text = "零部件";
            this.tvContent.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvContent.Size = new System.Drawing.Size(167, 375);
            this.tvContent.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 397);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(578, 404);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(497, 404);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "查看";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ProductStructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.panel1);
            this.Name = "ProductStructForm";
            this.Text = "ProductStructForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView tvContent;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Equip;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecificationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartsClassfication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateDate;

    }
}