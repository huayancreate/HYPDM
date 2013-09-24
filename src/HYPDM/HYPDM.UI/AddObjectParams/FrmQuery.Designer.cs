namespace HYPDM.WinUI.AddObjectParams
{
    partial class FrmQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitmain = new System.Windows.Forms.SplitContainer();
            this.pnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExtandAdvanceQuery = new System.Windows.Forms.Button();
            this.pnlQueryAdvanceParams = new System.Windows.Forms.Panel();
            this.dgvExtandCols = new HYPDM.BaseControl.DataGridViewExt();
            this.PARAMS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARAMS_DATA_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARGET_COLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASTER_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.val1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.Panel1.SuspendLayout();
            this.splitmain.Panel2.SuspendLayout();
            this.splitmain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlQueryAdvanceParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtandCols)).BeginInit();
            this.SuspendLayout();
            // 
            // splitmain
            // 
            this.splitmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitmain.Location = new System.Drawing.Point(0, 0);
            this.splitmain.Name = "splitmain";
            this.splitmain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitmain.Panel1
            // 
            this.splitmain.Panel1.Controls.Add(this.pnl);
            this.splitmain.Panel1.Controls.Add(this.panel3);
            // 
            // splitmain.Panel2
            // 
            this.splitmain.Panel2.Controls.Add(this.pnlQueryAdvanceParams);
            this.splitmain.Size = new System.Drawing.Size(836, 475);
            this.splitmain.SplitterDistance = 206;
            this.splitmain.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(836, 180);
            this.pnl.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExtandAdvanceQuery);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 26);
            this.panel3.TabIndex = 2;
            // 
            // btnExtandAdvanceQuery
            // 
            this.btnExtandAdvanceQuery.Location = new System.Drawing.Point(3, 1);
            this.btnExtandAdvanceQuery.Name = "btnExtandAdvanceQuery";
            this.btnExtandAdvanceQuery.Size = new System.Drawing.Size(84, 23);
            this.btnExtandAdvanceQuery.TabIndex = 2;
            this.btnExtandAdvanceQuery.Text = "高级查询<<<";
            this.btnExtandAdvanceQuery.UseVisualStyleBackColor = true;
            this.btnExtandAdvanceQuery.Click += new System.EventHandler(this.btnExtandAdvanceQuery_Click);
            // 
            // pnlQueryAdvanceParams
            // 
            this.pnlQueryAdvanceParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueryAdvanceParams.Controls.Add(this.dgvExtandCols);
            this.pnlQueryAdvanceParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryAdvanceParams.Location = new System.Drawing.Point(0, 0);
            this.pnlQueryAdvanceParams.Name = "pnlQueryAdvanceParams";
            this.pnlQueryAdvanceParams.Size = new System.Drawing.Size(836, 265);
            this.pnlQueryAdvanceParams.TabIndex = 1;
            // 
            // dgvExtandCols
            // 
            this.dgvExtandCols.AllowUserToAddRows = false;
            this.dgvExtandCols.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvExtandCols.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExtandCols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtandCols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMS_NAME,
            this.PARAMS_DATA_TYPE,
            this.TARGET_COLNAME,
            this.MASTER_TABLE_NAME,
            this.operation,
            this.val1,
            this.val2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExtandCols.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExtandCols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExtandCols.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvExtandCols.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExtandCols.Location = new System.Drawing.Point(0, 0);
            this.dgvExtandCols.Name = "dgvExtandCols";
            this.dgvExtandCols.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExtandCols.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExtandCols.RowTemplate.Height = 23;
            this.dgvExtandCols.Size = new System.Drawing.Size(834, 263);
            this.dgvExtandCols.TabIndex = 6;
            this.dgvExtandCols.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtandCols_CellEndEdit);
            // 
            // PARAMS_NAME
            // 
            this.PARAMS_NAME.DataPropertyName = "PARAMS_NAME";
            this.PARAMS_NAME.HeaderText = "列名";
            this.PARAMS_NAME.Name = "PARAMS_NAME";
            this.PARAMS_NAME.ReadOnly = true;
            // 
            // PARAMS_DATA_TYPE
            // 
            this.PARAMS_DATA_TYPE.DataPropertyName = "PARAMS_DATA_TYPE";
            this.PARAMS_DATA_TYPE.HeaderText = "字段类型";
            this.PARAMS_DATA_TYPE.Name = "PARAMS_DATA_TYPE";
            this.PARAMS_DATA_TYPE.ReadOnly = true;
            // 
            // TARGET_COLNAME
            // 
            this.TARGET_COLNAME.DataPropertyName = "TARGET_COLNAME";
            this.TARGET_COLNAME.HeaderText = "TARGET_COLNAME";
            this.TARGET_COLNAME.Name = "TARGET_COLNAME";
            this.TARGET_COLNAME.Visible = false;
            // 
            // MASTER_TABLE_NAME
            // 
            this.MASTER_TABLE_NAME.DataPropertyName = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.HeaderText = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.Name = "MASTER_TABLE_NAME";
            this.MASTER_TABLE_NAME.Visible = false;
            // 
            // operation
            // 
            this.operation.DataPropertyName = "operation";
            this.operation.HeaderText = "操作符";
            this.operation.Name = "operation";
            this.operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // val1
            // 
            this.val1.DataPropertyName = "val1";
            this.val1.HeaderText = "val1";
            this.val1.Name = "val1";
            // 
            // val2
            // 
            this.val2.DataPropertyName = "val2";
            this.val2.HeaderText = "val2";
            this.val2.Name = "val2";
            // 
            // FrmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 475);
            this.Controls.Add(this.splitmain);
            this.MaximizeBox = false;
            this.Name = "FrmQuery";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.FrmQuery_Load);
            this.splitmain.Panel1.ResumeLayout(false);
            this.splitmain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlQueryAdvanceParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtandCols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnExtandAdvanceQuery;
        public System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.SplitContainer splitmain;
        public System.Windows.Forms.Panel pnlQueryAdvanceParams;
        public System.Windows.Forms.Panel panel3;
        public BaseControl.DataGridViewExt dgvExtandCols;
        public System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_NAME;
        public System.Windows.Forms.DataGridViewTextBoxColumn PARAMS_DATA_TYPE;
        public System.Windows.Forms.DataGridViewTextBoxColumn TARGET_COLNAME;
        public System.Windows.Forms.DataGridViewTextBoxColumn MASTER_TABLE_NAME;
        public System.Windows.Forms.DataGridViewComboBoxColumn operation;
        public System.Windows.Forms.DataGridViewTextBoxColumn val1;
        public System.Windows.Forms.DataGridViewTextBoxColumn val2;
    }
}