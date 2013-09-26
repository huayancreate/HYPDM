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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvExt = new HYPDM.BaseControl.DataGridViewExt();
            this.COMBTYPE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBTEXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspModify = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
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
            // dgvExt
            // 
            this.dgvExt.AllowUserToAddRows = false;
            this.dgvExt.BackgroundColor = System.Drawing.Color.White;
            this.dgvExt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COMBTYPE1,
            this.COMBDESC,
            this.COMBID,
            this.COMBTEXT,
            this.COMBVALUE});
            this.dgvExt.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExt.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExt.Location = new System.Drawing.Point(312, 0);
            this.dgvExt.Name = "dgvExt";
            this.dgvExt.ReadOnly = true;
            this.dgvExt.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExt.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExt.RowTemplate.Height = 23;
            this.dgvExt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExt.Size = new System.Drawing.Size(605, 203);
            this.dgvExt.TabIndex = 3;
            this.dgvExt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExt_CellDoubleClick_1);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(312, 203);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 225);
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
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 132);
            this.panel4.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(249, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 102);
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
            this.label6.Location = new System.Drawing.Point(79, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "即显示在界面上供用户选择的值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(78, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "默认为系统自动生产的主键值";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "数据值";
            this.label4.Visible = false;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(80, 71);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(169, 21);
            this.txtValue.TabIndex = 36;
            this.txtValue.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "显示文本";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(80, 30);
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
            this.panel3.Size = new System.Drawing.Size(312, 93);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(77, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "下拉框值的分类，区别一类数据";
            // 
            // combType
            // 
            this.combType.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(80, 33);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(168, 22);
            this.combType.TabIndex = 29;
            this.combType.SelectedValueChanged += new System.EventHandler(this.combType_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "类型";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(80, 62);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(169, 21);
            this.txtDesc.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(139, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(304, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "【此界面主要为企业运维/开发人员使用】";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(108, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(497, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "3、在右边数据显示的grid中，双击选中的记录，会弹出修改对话框,可以对此信息进行修改。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(108, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "2、右边Grid主要用来显示已有的记录信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(108, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(395, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "1、在左边模块，可以选择已经有的类型添加子项，也可以新增一个大分类";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "本界面主要用与界面功能下拉框值的设定，方便用户添加新的分类信息";
            // 
            // ComboboxValueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ComboboxValueControl";
            this.Size = new System.Drawing.Size(923, 545);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExt)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;

    }
}
