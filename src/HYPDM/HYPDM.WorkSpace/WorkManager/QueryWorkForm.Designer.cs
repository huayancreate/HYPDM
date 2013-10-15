namespace HYPDM.WorkSpace.WorkManager
{
    partial class QueryWorkForm
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
            this.tb_modelName = new System.Windows.Forms.TextBox();
            this.bt_query = new System.Windows.Forms.Button();
            this.dtp_createTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模板名称";
            // 
            // tb_modelName
            // 
            this.tb_modelName.Location = new System.Drawing.Point(73, 18);
            this.tb_modelName.Name = "tb_modelName";
            this.tb_modelName.Size = new System.Drawing.Size(177, 21);
            this.tb_modelName.TabIndex = 1;
            // 
            // bt_query
            // 
            this.bt_query.Location = new System.Drawing.Point(184, 87);
            this.bt_query.Name = "bt_query";
            this.bt_query.Size = new System.Drawing.Size(66, 23);
            this.bt_query.TabIndex = 2;
            this.bt_query.Text = "查询";
            this.bt_query.UseVisualStyleBackColor = true;
            this.bt_query.Click += new System.EventHandler(this.bt_query_Click);
            // 
            // dtp_createTime
            // 
            this.dtp_createTime.CustomFormat = "yyyy-MM-dd HH:mm:dd";
            this.dtp_createTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_createTime.Location = new System.Drawing.Point(73, 55);
            this.dtp_createTime.Name = "dtp_createTime";
            this.dtp_createTime.Size = new System.Drawing.Size(177, 21);
            this.dtp_createTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "起始日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "支持模糊查询";
            // 
            // QueryWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 119);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_createTime);
            this.Controls.Add(this.bt_query);
            this.Controls.Add(this.tb_modelName);
            this.Controls.Add(this.label1);
            this.Name = "QueryWorkForm";
            this.Text = "查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_modelName;
        private System.Windows.Forms.Button bt_query;
        private System.Windows.Forms.DateTimePicker dtp_createTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}