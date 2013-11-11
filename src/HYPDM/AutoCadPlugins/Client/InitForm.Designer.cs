/*
 * 由SharpDevelop创建。
 * 用户： wliu
 * 日期: 2013/10/9
 * 时间: 16:16
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace AutoCadPlugins.Client
{
	partial class InitForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPartFind = new System.Windows.Forms.Button();
			this.btnPartCreate = new System.Windows.Forms.Button();
			this.btnDrawFind = new System.Windows.Forms.Button();
			this.btnDrawCreate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.lstPartsType = new System.Windows.Forms.ListBox();
			this.lstDrawType = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblDrawCode = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnPartFind);
			this.panel2.Controls.Add(this.btnPartCreate);
			this.panel2.Controls.Add(this.btnDrawFind);
			this.panel2.Controls.Add(this.btnDrawCreate);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.lstPartsType);
			this.panel2.Controls.Add(this.lstDrawType);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(365, 261);
			this.panel2.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(250, 17);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(103, 34);
			this.panel4.TabIndex = 19;
			this.panel4.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "label4";
			this.label4.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(197, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 34);
			this.label2.TabIndex = 18;
			this.label2.Text = "主关联零部件：";
			this.label2.Visible = false;
			// 
			// btnPartFind
			// 
			this.btnPartFind.Location = new System.Drawing.Point(278, 223);
			this.btnPartFind.Name = "btnPartFind";
			this.btnPartFind.Size = new System.Drawing.Size(75, 23);
			this.btnPartFind.TabIndex = 17;
			this.btnPartFind.Text = "查找";
			this.btnPartFind.UseVisualStyleBackColor = true;
			this.btnPartFind.Click += new System.EventHandler(this.btnPartFind_Click);
			// 
			// btnPartCreate
			// 
			this.btnPartCreate.Location = new System.Drawing.Point(197, 223);
			this.btnPartCreate.Name = "btnPartCreate";
			this.btnPartCreate.Size = new System.Drawing.Size(75, 23);
			this.btnPartCreate.TabIndex = 16;
			this.btnPartCreate.Text = "新建";
			this.btnPartCreate.UseVisualStyleBackColor = true;
			this.btnPartCreate.Click += new System.EventHandler(this.btnPartCreate_Click);
			// 
			// btnDrawFind
			// 
			this.btnDrawFind.Location = new System.Drawing.Point(102, 223);
			this.btnDrawFind.Name = "btnDrawFind";
			this.btnDrawFind.Size = new System.Drawing.Size(75, 23);
			this.btnDrawFind.TabIndex = 15;
			this.btnDrawFind.Text = "查找";
			this.btnDrawFind.UseVisualStyleBackColor = true;
			this.btnDrawFind.Click += new System.EventHandler(this.btnDrawFind_Click);
			// 
			// btnDrawCreate
			// 
			this.btnDrawCreate.Location = new System.Drawing.Point(21, 223);
			this.btnDrawCreate.Name = "btnDrawCreate";
			this.btnDrawCreate.Size = new System.Drawing.Size(75, 23);
			this.btnDrawCreate.TabIndex = 14;
			this.btnDrawCreate.Text = "新建";
			this.btnDrawCreate.UseVisualStyleBackColor = true;
			this.btnDrawCreate.Click += new System.EventHandler(this.btnDrawCreate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(15, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 66);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "初始化方式";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(79, 39);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(91, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "导入模板";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Visible = false;
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 38);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(72, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "已有图纸";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(6, 14);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "使用模板";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Visible = false;
			// 
			// lstPartsType
			// 
			this.lstPartsType.FormattingEnabled = true;
			this.lstPartsType.ItemHeight = 12;
			this.lstPartsType.Location = new System.Drawing.Point(197, 57);
			this.lstPartsType.Name = "lstPartsType";
			this.lstPartsType.Size = new System.Drawing.Size(156, 160);
			this.lstPartsType.TabIndex = 12;
			this.lstPartsType.SelectedValueChanged += new System.EventHandler(this.lstPartsType_SelectedValueChanged);
			// 
			// lstDrawType
			// 
			this.lstDrawType.DisplayMember = "COMBTEXT";
			this.lstDrawType.ItemHeight = 12;
			this.lstDrawType.Location = new System.Drawing.Point(15, 57);
			this.lstDrawType.Name = "lstDrawType";
			this.lstDrawType.Size = new System.Drawing.Size(176, 88);
			this.lstDrawType.TabIndex = 11;
			this.lstDrawType.ValueMember = "COMBVALUE";
			this.lstDrawType.SelectedValueChanged += new System.EventHandler(this.lstDrawType_SelectedValueChanged);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(79, 17);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(103, 34);
			this.panel1.TabIndex = 10;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.lblDrawCode);
			this.panel3.Location = new System.Drawing.Point(-1, -1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(103, 34);
			this.panel3.TabIndex = 11;
			// 
			// lblDrawCode
			// 
			this.lblDrawCode.AutoSize = true;
			this.lblDrawCode.Location = new System.Drawing.Point(8, 7);
			this.lblDrawCode.Name = "lblDrawCode";
			this.lblDrawCode.Size = new System.Drawing.Size(0, 12);
			this.lblDrawCode.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "图纸编号：";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(198, 267);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "确定";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(279, 267);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// InitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 298);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.panel2);
			this.Name = "InitForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "图纸初始化";
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnPartFind;
		private System.Windows.Forms.Button btnPartCreate;
		private System.Windows.Forms.Button btnDrawFind;
		private System.Windows.Forms.Button btnDrawCreate;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lstPartsType;
		private System.Windows.Forms.ListBox lstDrawType;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDrawCode;
	}
}
