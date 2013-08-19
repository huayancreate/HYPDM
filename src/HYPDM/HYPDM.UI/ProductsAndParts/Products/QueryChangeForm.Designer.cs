namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class QueryChangeForm
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
            this.changeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changePerson = new System.Windows.Forms.TextBox();
            this.changeStatus = new System.Windows.Forms.TextBox();
            this.changeAssoYes = new System.Windows.Forms.CheckBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.changeAssoNo = new System.Windows.Forms.CheckBox();
            this.changeTime = new HYPDM.WinUI.DefineControl.DateTimePickerExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "变更编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "变更时间";
            // 
            // changeNo
            // 
            this.changeNo.Location = new System.Drawing.Point(109, 16);
            this.changeNo.Name = "changeNo";
            this.changeNo.Size = new System.Drawing.Size(157, 21);
            this.changeNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "变更人";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "变更状态";
            // 
            // changePerson
            // 
            this.changePerson.Location = new System.Drawing.Point(109, 70);
            this.changePerson.Name = "changePerson";
            this.changePerson.Size = new System.Drawing.Size(157, 21);
            this.changePerson.TabIndex = 7;
            // 
            // changeStatus
            // 
            this.changeStatus.Location = new System.Drawing.Point(109, 97);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(157, 21);
            this.changeStatus.TabIndex = 8;
            // 
            // changeAssoYes
            // 
            this.changeAssoYes.AutoSize = true;
            this.changeAssoYes.Location = new System.Drawing.Point(109, 124);
            this.changeAssoYes.Name = "changeAssoYes";
            this.changeAssoYes.Size = new System.Drawing.Size(60, 16);
            this.changeAssoYes.TabIndex = 9;
            this.changeAssoYes.Text = "已关联";
            this.changeAssoYes.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(134, 155);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "查询";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(215, 155);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 11;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // changeAssoNo
            // 
            this.changeAssoNo.AutoSize = true;
            this.changeAssoNo.Location = new System.Drawing.Point(186, 124);
            this.changeAssoNo.Name = "changeAssoNo";
            this.changeAssoNo.Size = new System.Drawing.Size(60, 16);
            this.changeAssoNo.TabIndex = 12;
            this.changeAssoNo.Text = "未关联";
            this.changeAssoNo.UseVisualStyleBackColor = true;
            // 
            // changeTime
            // 
            this.changeTime.CustomFormat = " ";
            this.changeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.changeTime.FormatString = "yyyy-MM-dd";
            this.changeTime.Location = new System.Drawing.Point(109, 43);
            this.changeTime.Name = "changeTime";
            this.changeTime.OriginalFormat = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.changeTime.Size = new System.Drawing.Size(157, 21);
            this.changeTime.TabIndex = 13;
            this.changeTime.ValueX = null;
            // 
            // ChangeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 185);
            this.Controls.Add(this.changeTime);
            this.Controls.Add(this.changeAssoNo);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.changeAssoYes);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.changePerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeQueryForm";
            this.Text = "工程变更详细查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox changePerson;
        private System.Windows.Forms.TextBox changeStatus;
        private System.Windows.Forms.CheckBox changeAssoYes;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.CheckBox changeAssoNo;
        private DefineControl.DateTimePickerExt changeTime;
    }
}