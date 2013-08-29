namespace HYDocumentMS.BRM
{
    partial class ComboboxValueControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspModify = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.combType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgvExt = new HYPDM.BaseControl.DataGridViewExt();
            this.COMBTYPE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBTEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Size = new System.Drawing.Size(923, 545);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "下拉框值设定";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvExt);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 225);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspModify});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // tspModify
            // 
            this.tspModify.Name = "tspModify";
            this.tspModify.Size = new System.Drawing.Size(100, 22);
            this.tspModify.Text = "修改";
            this.tspModify.Click += new System.EventHandler(this.tspModify_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 225);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnSubmit);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtValue);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 142);
            this.panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(138, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(59, 25);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "保存";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(252, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "即显示在界面上供用户选择的值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(252, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "默认为系统自动生产的主键值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "数据值";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(80, 47);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 21);
            this.txtValue.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "显示文本";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(80, 15);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(169, 21);
            this.txtText.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.combType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDesc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 83);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(252, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "下拉框值的分类，区别一类数据";
            // 
            // combType
            // 
            this.combType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(80, 25);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(168, 22);
            this.combType.TabIndex = 29;
            this.combType.SelectedValueChanged += new System.EventHandler(this.combType_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "类型";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(80, 53);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(169, 21);
            this.txtDesc.TabIndex = 24;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(443, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(474, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dgvExt
            // 
            this.dgvExt.AllowUserToAddRows = false;
            this.dgvExt.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COMBTYPE1,
            this.COMBDESC,
            this.COMBID,
            this.COMBTEXT,
            this.COMBVALUE});
            this.dgvExt.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExt.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExt.Location = new System.Drawing.Point(443, 0);
            this.dgvExt.Name = "dgvExt";
            this.dgvExt.ReadOnly = true;
            this.dgvExt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExt.RowTemplate.Height = 23;
            this.dgvExt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExt.Size = new System.Drawing.Size(474, 203);
            this.dgvExt.TabIndex = 3;
            // 
            // COMBTYPE1
            // 
            this.COMBTYPE1.DataPropertyName = "COMBTYPE";
            this.COMBTYPE1.HeaderText = "类型";
            this.COMBTYPE1.Name = "COMBTYPE1";
            this.COMBTYPE1.ReadOnly = true;
            // 
            // COMBDESC
            // 
            this.COMBDESC.DataPropertyName = "COMBDESC";
            this.COMBDESC.HeaderText = "备注";
            this.COMBDESC.Name = "COMBDESC";
            this.COMBDESC.ReadOnly = true;
            this.COMBDESC.Width = 180;
            // 
            // COMBID
            // 
            this.COMBID.DataPropertyName = "COMBID";
            this.COMBID.HeaderText = "COMBID";
            this.COMBID.Name = "COMBID";
            this.COMBID.ReadOnly = true;
            this.COMBID.Visible = false;
            // 
            // COMBTEXT
            // 
            this.COMBTEXT.DataPropertyName = "COMBTEXT";
            this.COMBTEXT.HeaderText = "文本值";
            this.COMBTEXT.Name = "COMBTEXT";
            this.COMBTEXT.ReadOnly = true;
            this.COMBTEXT.Width = 150;
            // 
            // COMBVALUE
            // 
            this.COMBVALUE.DataPropertyName = "COMBVALUE";
            this.COMBVALUE.HeaderText = "Value值";
            this.COMBVALUE.Name = "COMBVALUE";
            this.COMBVALUE.ReadOnly = true;
            this.COMBVALUE.Width = 120;
            // 
            // ComboboxValueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ComboboxValueControl";
            this.Size = new System.Drawing.Size(923, 545);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspModify;
        private HYPDM.BaseControl.DataGridViewExt dgvExt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBTYPE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBTEXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBVALUE;

    }
}
