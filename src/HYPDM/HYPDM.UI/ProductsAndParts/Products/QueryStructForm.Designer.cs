namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class QueryStructForm
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
            this.tb_No = new System.Windows.Forms.TextBox();
            this.tb_Version = new System.Windows.Forms.TextBox();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.bt_Query = new System.Windows.Forms.Button();
            this.bt_Cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "版本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "型号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "描述";
            // 
            // tb_No
            // 
            this.tb_No.Location = new System.Drawing.Point(67, 28);
            this.tb_No.Name = "tb_No";
            this.tb_No.Size = new System.Drawing.Size(100, 21);
            this.tb_No.TabIndex = 4;
            // 
            // tb_Version
            // 
            this.tb_Version.Location = new System.Drawing.Point(67, 65);
            this.tb_Version.Name = "tb_Version";
            this.tb_Version.Size = new System.Drawing.Size(100, 21);
            this.tb_Version.TabIndex = 5;
            // 
            // tb_Memo
            // 
            this.tb_Memo.Location = new System.Drawing.Point(217, 65);
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(100, 21);
            this.tb_Memo.TabIndex = 6;
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(217, 28);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(100, 21);
            this.tb_Model.TabIndex = 6;
            // 
            // bt_Query
            // 
            this.bt_Query.Location = new System.Drawing.Point(46, 119);
            this.bt_Query.Name = "bt_Query";
            this.bt_Query.Size = new System.Drawing.Size(75, 23);
            this.bt_Query.TabIndex = 7;
            this.bt_Query.Text = "查询";
            this.bt_Query.UseVisualStyleBackColor = true;
            this.bt_Query.Click += new System.EventHandler(this.bt_Query_Click);
            // 
            // bt_Cancle
            // 
            this.bt_Cancle.Location = new System.Drawing.Point(199, 119);
            this.bt_Cancle.Name = "bt_Cancle";
            this.bt_Cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancle.TabIndex = 8;
            this.bt_Cancle.Text = "取消";
            this.bt_Cancle.UseVisualStyleBackColor = true;
            // 
            // QueryStructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 157);
            this.Controls.Add(this.bt_Cancle);
            this.Controls.Add(this.bt_Query);
            this.Controls.Add(this.tb_Model);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.tb_Version);
            this.Controls.Add(this.tb_No);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryStructForm";
            this.Text = "详细查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_No;
        private System.Windows.Forms.TextBox tb_Version;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.Button bt_Query;
        private System.Windows.Forms.Button bt_Cancle;
    }
}