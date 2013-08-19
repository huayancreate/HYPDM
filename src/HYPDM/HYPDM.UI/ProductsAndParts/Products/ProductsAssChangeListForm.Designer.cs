namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class ProductsAssChangeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsAssChangeListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ChangeList = new System.Windows.Forms.DataGridView();
            this.Checkeddd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PJTCHANGENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGEPERSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHANGEREASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFASSO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolQueryNo = new System.Windows.Forms.ToolStripTextBox();
            this.toolDedtailQuery = new System.Windows.Forms.ToolStripButton();
            this.toolQuery = new System.Windows.Forms.ToolStripButton();
            this.toolClose = new System.Windows.Forms.ToolStripButton();
            this.toolSelect = new System.Windows.Forms.ToolStripButton();
            this.toolLookView = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChangeList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ChangeList);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 429);
            this.panel1.TabIndex = 0;
            // 
            // dgv_ChangeList
            // 
            this.dgv_ChangeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChangeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkeddd,
            this.PJTCHANGENO,
            this.CHANGETIME,
            this.CHANGESTATUS,
            this.CHANGEPERSON,
            this.CHANGEREASON,
            this.IFASSO});
            this.dgv_ChangeList.Location = new System.Drawing.Point(0, 28);
            this.dgv_ChangeList.Name = "dgv_ChangeList";
            this.dgv_ChangeList.ReadOnly = true;
            this.dgv_ChangeList.RowTemplate.Height = 23;
            this.dgv_ChangeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChangeList.Size = new System.Drawing.Size(715, 373);
            this.dgv_ChangeList.TabIndex = 2;
            this.dgv_ChangeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChangeList_CellClick);
            // 
            // Checkeddd
            // 
            this.Checkeddd.DataPropertyName = "Checked";
            this.Checkeddd.HeaderText = "选择";
            this.Checkeddd.Name = "Checkeddd";
            this.Checkeddd.ReadOnly = true;
            // 
            // PJTCHANGENO
            // 
            this.PJTCHANGENO.DataPropertyName = "PJTCHANGENO";
            this.PJTCHANGENO.HeaderText = "变更编号";
            this.PJTCHANGENO.Name = "PJTCHANGENO";
            this.PJTCHANGENO.ReadOnly = true;
            // 
            // CHANGETIME
            // 
            this.CHANGETIME.DataPropertyName = "CHANGETIME";
            this.CHANGETIME.HeaderText = "变更时间";
            this.CHANGETIME.Name = "CHANGETIME";
            this.CHANGETIME.ReadOnly = true;
            // 
            // CHANGESTATUS
            // 
            this.CHANGESTATUS.DataPropertyName = "CHANGESTATUS";
            this.CHANGESTATUS.HeaderText = "变更状态";
            this.CHANGESTATUS.Name = "CHANGESTATUS";
            this.CHANGESTATUS.ReadOnly = true;
            // 
            // CHANGEPERSON
            // 
            this.CHANGEPERSON.DataPropertyName = "CHANGEPERSON";
            this.CHANGEPERSON.HeaderText = "申请人";
            this.CHANGEPERSON.Name = "CHANGEPERSON";
            this.CHANGEPERSON.ReadOnly = true;
            // 
            // CHANGEREASON
            // 
            this.CHANGEREASON.DataPropertyName = "CHANGEREASON";
            this.CHANGEREASON.HeaderText = "变更原因";
            this.CHANGEREASON.Name = "CHANGEREASON";
            this.CHANGEREASON.ReadOnly = true;
            // 
            // IFASSO
            // 
            this.IFASSO.DataPropertyName = "IFASSO";
            this.IFASSO.HeaderText = "是否关联";
            this.IFASSO.Name = "IFASSO";
            this.IFASSO.ReadOnly = true;
            this.IFASSO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IFASSO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Location = new System.Drawing.Point(0, 404);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(715, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDedtailQuery,
            this.toolStripLabel1,
            this.toolQueryNo,
            this.toolQuery,
            this.toolClose,
            this.toolSelect,
            this.toolLookView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "编号";
            // 
            // toolQueryNo
            // 
            this.toolQueryNo.BackColor = System.Drawing.Color.OldLace;
            this.toolQueryNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolQueryNo.Name = "toolQueryNo";
            this.toolQueryNo.Size = new System.Drawing.Size(100, 25);
            // 
            // toolDedtailQuery
            // 
            this.toolDedtailQuery.Image = global::HYPDM.WinUI.Properties.Resources.view;
            this.toolDedtailQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDedtailQuery.Name = "toolDedtailQuery";
            this.toolDedtailQuery.Size = new System.Drawing.Size(76, 22);
            this.toolDedtailQuery.Text = "详细查询";
            this.toolDedtailQuery.Click += new System.EventHandler(this.toolDedtailQuery_Click);
            // 
            // toolQuery
            // 
            this.toolQuery.Image = global::HYPDM.WinUI.Properties.Resources.upload;
            this.toolQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQuery.Name = "toolQuery";
            this.toolQuery.Size = new System.Drawing.Size(52, 22);
            this.toolQuery.Text = "查询";
            this.toolQuery.Click += new System.EventHandler(this.toolQuery_Click);
            // 
            // toolClose
            // 
            this.toolClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolClose.Image = ((System.Drawing.Image)(resources.GetObject("toolClose.Image")));
            this.toolClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(52, 22);
            this.toolClose.Text = "关闭";
            this.toolClose.Click += new System.EventHandler(this.toolClose_Click);
            // 
            // toolSelect
            // 
            this.toolSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSelect.Image = ((System.Drawing.Image)(resources.GetObject("toolSelect.Image")));
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Size = new System.Drawing.Size(52, 22);
            this.toolSelect.Text = "选择";
            this.toolSelect.Click += new System.EventHandler(this.toolSelect_Click);
            // 
            // toolLookView
            // 
            this.toolLookView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLookView.Image = ((System.Drawing.Image)(resources.GetObject("toolLookView.Image")));
            this.toolLookView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLookView.Name = "toolLookView";
            this.toolLookView.Size = new System.Drawing.Size(52, 22);
            this.toolLookView.Text = "查看";
            this.toolLookView.Click += new System.EventHandler(this.toolLookView_Click);
            // 
            // ProductsAssChangeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 429);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsAssChangeListForm";
            this.Text = "关联工程变更记录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChangeList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolDedtailQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolQueryNo;
        private System.Windows.Forms.ToolStripButton toolQuery;
        private System.Windows.Forms.ToolStripButton toolClose;
        private System.Windows.Forms.ToolStripButton toolSelect;
        private System.Windows.Forms.ToolStripButton toolLookView;
        private System.Windows.Forms.DataGridView dgv_ChangeList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkeddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJTCHANGENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGESTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGEPERSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHANGEREASON;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IFASSO;

    }
}