namespace HYPDM.WinUI.SysConfig
{
    partial class FrmAddNewProperties
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTxtValue = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.RadioButton();
            this.btnNumberValue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParamsColName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTxtValue);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnDateTime);
            this.panel1.Controls.Add(this.btnNumberValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtParamsColName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 119);
            this.panel1.TabIndex = 0;
            // 
            // btnTxtValue
            // 
            this.btnTxtValue.AutoSize = true;
            this.btnTxtValue.Checked = true;
            this.btnTxtValue.Location = new System.Drawing.Point(117, 43);
            this.btnTxtValue.Name = "btnTxtValue";
            this.btnTxtValue.Size = new System.Drawing.Size(47, 16);
            this.btnTxtValue.TabIndex = 7;
            this.btnTxtValue.TabStop = true;
            this.btnTxtValue.Text = "文本";
            this.btnTxtValue.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(264, 77);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(58, 33);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.AutoSize = true;
            this.btnDateTime.Location = new System.Drawing.Point(264, 44);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(47, 16);
            this.btnDateTime.TabIndex = 5;
            this.btnDateTime.Text = "日期";
            this.btnDateTime.UseVisualStyleBackColor = true;
            // 
            // btnNumberValue
            // 
            this.btnNumberValue.AutoSize = true;
            this.btnNumberValue.Location = new System.Drawing.Point(186, 44);
            this.btnNumberValue.Name = "btnNumberValue";
            this.btnNumberValue.Size = new System.Drawing.Size(47, 16);
            this.btnNumberValue.TabIndex = 4;
            this.btnNumberValue.Text = "数值";
            this.btnNumberValue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "属性名称:";
            // 
            // txtParamsColName
            // 
            this.txtParamsColName.Location = new System.Drawing.Point(87, 14);
            this.txtParamsColName.Name = "txtParamsColName";
            this.txtParamsColName.Size = new System.Drawing.Size(235, 21);
            this.txtParamsColName.TabIndex = 0;
            // 
            // FrmAddNewParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 119);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmAddNewParams";
            this.Text = "添加新属性";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParamsColName;
        private System.Windows.Forms.RadioButton btnNumberValue;
        private System.Windows.Forms.RadioButton btnDateTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton btnTxtValue;
    }
}