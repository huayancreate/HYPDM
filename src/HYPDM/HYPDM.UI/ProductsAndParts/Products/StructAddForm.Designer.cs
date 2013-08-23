namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class StructAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sortNum = new System.Windows.Forms.TextBox();
            this.tb_assoNum = new System.Windows.Forms.TextBox();
            this.tb_assoWeight = new System.Windows.Forms.TextBox();
            this.rtb_memo = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "序号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "重量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "描述";
            // 
            // tb_sortNum
            // 
            this.tb_sortNum.Location = new System.Drawing.Point(49, 29);
            this.tb_sortNum.Name = "tb_sortNum";
            this.tb_sortNum.Size = new System.Drawing.Size(69, 21);
            this.tb_sortNum.TabIndex = 4;
            // 
            // tb_assoNum
            // 
            this.tb_assoNum.Location = new System.Drawing.Point(161, 29);
            this.tb_assoNum.Name = "tb_assoNum";
            this.tb_assoNum.Size = new System.Drawing.Size(73, 21);
            this.tb_assoNum.TabIndex = 5;
            // 
            // tb_assoWeight
            // 
            this.tb_assoWeight.Location = new System.Drawing.Point(275, 29);
            this.tb_assoWeight.Name = "tb_assoWeight";
            this.tb_assoWeight.Size = new System.Drawing.Size(78, 21);
            this.tb_assoWeight.TabIndex = 6;
            // 
            // rtb_memo
            // 
            this.rtb_memo.Location = new System.Drawing.Point(49, 70);
            this.rtb_memo.Name = "rtb_memo";
            this.rtb_memo.Size = new System.Drawing.Size(304, 87);
            this.rtb_memo.TabIndex = 7;
            this.rtb_memo.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(278, 178);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // StructAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 213);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rtb_memo);
            this.Controls.Add(this.tb_assoWeight);
            this.Controls.Add(this.tb_assoNum);
            this.Controls.Add(this.tb_sortNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StructAddForm";
            this.Text = "结构添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sortNum;
        private System.Windows.Forms.TextBox tb_assoNum;
        private System.Windows.Forms.TextBox tb_assoWeight;
        private System.Windows.Forms.RichTextBox rtb_memo;
        private System.Windows.Forms.Button btn_save;
    }
}