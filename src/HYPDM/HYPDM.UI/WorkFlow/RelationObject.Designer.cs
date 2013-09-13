namespace HYPDM.WinUI.WorkFlow
{
    partial class RelationObject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvExtTemplates = new HYPDM.BaseControl.DataGridViewExt();
            this.WFT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WFT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.dgvExtTemplates);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(0, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(444, 42);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvExtTemplates
            // 
            this.dgvExtTemplates.AllowUserToAddRows = false;
            this.dgvExtTemplates.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvExtTemplates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExtTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WFT_ID,
            this.WFT_NAME});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExtTemplates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExtTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExtTemplates.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExtTemplates.Location = new System.Drawing.Point(0, 0);
            this.dgvExtTemplates.Name = "dgvExtTemplates";
            this.dgvExtTemplates.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExtTemplates.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExtTemplates.RowTemplate.Height = 23;
            this.dgvExtTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtTemplates.Size = new System.Drawing.Size(444, 199);
            this.dgvExtTemplates.TabIndex = 1;
            // 
            // WFT_ID
            // 
            this.WFT_ID.DataPropertyName = "WFT_ID";
            this.WFT_ID.HeaderText = "模板ID";
            this.WFT_ID.Name = "WFT_ID";
            this.WFT_ID.Width = 200;
            // 
            // WFT_NAME
            // 
            this.WFT_NAME.DataPropertyName = "WFT_NAME";
            this.WFT_NAME.HeaderText = "模板名称";
            this.WFT_NAME.Name = "WFT_NAME";
            this.WFT_NAME.Width = 200;
            // 
            // RelationObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 243);
            this.Controls.Add(this.panel1);
            this.Name = "RelationObject";
            this.Text = "对象关联流程模板";
            this.Load += new System.EventHandler(this.RelationObject_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BaseControl.DataGridViewExt dgvExtTemplates;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_NAME;

    }
}