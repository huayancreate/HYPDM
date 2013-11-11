namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class ProductsProRecordAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsProRecordAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ProRecordId = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProductNum = new System.Windows.Forms.TextBox();
            this.workShop = new System.Windows.Forms.TextBox();
            this.wsDirector = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产编号";
            // 
            // ProRecordId
            // 
            this.ProRecordId.Location = new System.Drawing.Point(145, 41);
            this.ProRecordId.Name = "ProRecordId";
            this.ProRecordId.Size = new System.Drawing.Size(113, 21);
            this.ProRecordId.TabIndex = 1;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(145, 133);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(113, 21);
            this.startTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "产品编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "开始时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "结束时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "生产数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "生产车间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "车间主任";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(145, 177);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(113, 21);
            this.endTime.TabIndex = 9;
            // 
            // ProductID
            // 
            this.ProductID.Enabled = false;
            this.ProductID.Location = new System.Drawing.Point(145, 85);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(113, 21);
            this.ProductID.TabIndex = 10;
            // 
            // ProductNum
            // 
            this.ProductNum.Location = new System.Drawing.Point(145, 214);
            this.ProductNum.Name = "ProductNum";
            this.ProductNum.Size = new System.Drawing.Size(113, 21);
            this.ProductNum.TabIndex = 11;
            // 
            // workShop
            // 
            this.workShop.Location = new System.Drawing.Point(145, 249);
            this.workShop.Name = "workShop";
            this.workShop.Size = new System.Drawing.Size(113, 21);
            this.workShop.TabIndex = 12;
            // 
            // wsDirector
            // 
            this.wsDirector.Location = new System.Drawing.Point(145, 285);
            this.wsDirector.Name = "wsDirector";
            this.wsDirector.Size = new System.Drawing.Size(113, 21);
            this.wsDirector.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(298, 285);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(394, 285);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "说明";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(331, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(104, 211);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // ProductsProRecordAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 328);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.wsDirector);
            this.Controls.Add(this.workShop);
            this.Controls.Add(this.ProductNum);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.ProRecordId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsProRecordAddForm";
            this.Text = "生产记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProRecordId;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.TextBox ProductNum;
        private System.Windows.Forms.TextBox workShop;
        private System.Windows.Forms.TextBox wsDirector;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}