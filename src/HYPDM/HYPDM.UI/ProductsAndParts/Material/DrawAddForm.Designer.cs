namespace HYPDM.WinUI.ProductsAndParts.Material
{
     public partial class DrawAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocAddForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            this.dgv_DocList = new HYPDM.BaseControl.DataGridViewExt();
            this.tsb_type = new System.Windows.Forms.ToolStripComboBox();
            this.tsb_value = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_select = new System.Windows.Forms.ToolStripButton();
            this.DOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCVERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCCREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_type,
            this.tsb_value,
            this.tsb_query,
            this.tsb_select});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = false;
            this.ucPaging1.Location = new System.Drawing.Point(0, 378);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 20;
            this.ucPaging1.Size = new System.Drawing.Size(614, 26);
            this.ucPaging1.TabIndex = 1;
            // 
            // dgv_DocList
            // 
            this.dgv_DocList.AllowUserToAddRows = false;
            this.dgv_DocList.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_DocList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_DocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DocList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCID,
            this.DOCNO,
            this.DOCVERSION,
            this.DOCCREATEUSER,
            this.Column5});
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
            this.dgv_DocList.Location = new System.Drawing.Point(0, 25);
            this.dgv_DocList.Name = "dgv_DocList";
            this.dgv_DocList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_DocList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_DocList.RowTemplate.Height = 23;
            this.dgv_DocList.Size = new System.Drawing.Size(614, 353);
            this.dgv_DocList.TabIndex = 2;
            // 
            // tsb_type
            // 
            this.tsb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsb_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tsb_type.Items.AddRange(new object[] {
            "编号",
            "说明"});
            this.tsb_type.Name = "tsb_type";
            this.tsb_type.Size = new System.Drawing.Size(75, 25);
            // 
            // tsb_value
            // 
            this.tsb_value.Name = "tsb_value";
            this.tsb_value.Size = new System.Drawing.Size(100, 25);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_select
            // 
            this.tsb_select.Image = ((System.Drawing.Image)(resources.GetObject("tsb_select.Image")));
            this.tsb_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_select.Name = "tsb_select";
            this.tsb_select.Size = new System.Drawing.Size(52, 22);
            this.tsb_select.Text = "选择";
            this.tsb_select.Click += new System.EventHandler(this.tsb_select_Click);
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
            this.DOCNO.Width = 120;
            // 
            // DOCVERSION
            // 
            this.DOCVERSION.DataPropertyName = "VERSION";
            this.DOCVERSION.HeaderText = "文档版本";
            this.DOCVERSION.Name = "DOCVERSION";
            this.DOCVERSION.Width = 150;
            // 
            // DOCCREATEUSER
            // 
            this.DOCCREATEUSER.DataPropertyName = "CREATEUSER";
            this.DOCCREATEUSER.HeaderText = "创建人";
            this.DOCCREATEUSER.Name = "DOCCREATEUSER";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DESCRIPTION";
            this.Column5.HeaderText = "描述";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // DocAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 404);
            this.Controls.Add(this.dgv_DocList);
            this.Controls.Add(this.ucPaging1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DocAddForm";
            this.Text = "添加文档";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DocList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private BaseControl.UcPaging ucPaging1;
        private System.Windows.Forms.ToolStripComboBox tsb_type;
        private BaseControl.DataGridViewExt dgv_DocList;
        private System.Windows.Forms.ToolStripTextBox tsb_value;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCVERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCCREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}