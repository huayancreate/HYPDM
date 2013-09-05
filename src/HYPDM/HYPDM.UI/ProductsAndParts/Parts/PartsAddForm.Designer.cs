namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    partial class PartsAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsAddForm));
            this.tb_productNO = new System.Windows.Forms.TextBox();
            this.tb_productType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_modeType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.save_Product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_memoZH = new System.Windows.Forms.TextBox();
            this.tb_memoEN = new System.Windows.Forms.TextBox();
            this.rtb_memo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_productNO
            // 
            this.tb_productNO.Location = new System.Drawing.Point(75, 19);
            this.tb_productNO.Name = "tb_productNO";
            this.tb_productNO.Size = new System.Drawing.Size(158, 21);
            this.tb_productNO.TabIndex = 1;
            // 
            // tb_productType
            // 
            this.tb_productType.Location = new System.Drawing.Point(74, 110);
            this.tb_productType.Name = "tb_productType";
            this.tb_productType.Size = new System.Drawing.Size(159, 21);
            this.tb_productType.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "半成品类型";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "中文描述";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "英文描述";
            // 
            // tb_modeType
            // 
            this.tb_modeType.Location = new System.Drawing.Point(75, 65);
            this.tb_modeType.Name = "tb_modeType";
            this.tb_modeType.Size = new System.Drawing.Size(158, 21);
            this.tb_modeType.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "半成品型号";
            // 
            // save_Product
            // 
            this.save_Product.Image = ((System.Drawing.Image)(resources.GetObject("save_Product.Image")));
            this.save_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_Product.Location = new System.Drawing.Point(421, 246);
            this.save_Product.Name = "save_Product";
            this.save_Product.Size = new System.Drawing.Size(56, 26);
            this.save_Product.TabIndex = 28;
            this.save_Product.Text = "保存";
            this.save_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_Product.UseVisualStyleBackColor = true;
            this.save_Product.Click += new System.EventHandler(this.save_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "半成品编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(236, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(236, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "注意（*）标记为必填项目";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "备注";
            // 
            // tb_memoZH
            // 
            this.tb_memoZH.Location = new System.Drawing.Point(74, 159);
            this.tb_memoZH.Name = "tb_memoZH";
            this.tb_memoZH.Size = new System.Drawing.Size(159, 21);
            this.tb_memoZH.TabIndex = 39;
            // 
            // tb_memoEN
            // 
            this.tb_memoEN.Location = new System.Drawing.Point(74, 205);
            this.tb_memoEN.Name = "tb_memoEN";
            this.tb_memoEN.Size = new System.Drawing.Size(159, 21);
            this.tb_memoEN.TabIndex = 40;
            // 
            // rtb_memo
            // 
            this.rtb_memo.Location = new System.Drawing.Point(304, 22);
            this.rtb_memo.Name = "rtb_memo";
            this.rtb_memo.Size = new System.Drawing.Size(173, 204);
            this.rtb_memo.TabIndex = 41;
            this.rtb_memo.Text = "";
            // 
            // PartsAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 290);
            this.Controls.Add(this.rtb_memo);
            this.Controls.Add(this.tb_memoEN);
            this.Controls.Add(this.tb_memoZH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save_Product);
            this.Controls.Add(this.tb_modeType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_productType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_productNO);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsAddForm";
            this.Text = "添加半成品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_productNO;
        private System.Windows.Forms.TextBox tb_productType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_modeType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button save_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_memoZH;
        private System.Windows.Forms.TextBox tb_memoEN;
        private System.Windows.Forms.RichTextBox rtb_memo;
    }
}