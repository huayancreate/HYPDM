namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    partial class PartsTypeForm
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
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkStandard = new System.Windows.Forms.CheckBox();
            this.chkUniversal = new System.Windows.Forms.CheckBox();
            this.chkWelding = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(12, 12);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(60, 16);
            this.chkNormal.TabIndex = 0;
            this.chkNormal.Text = "普通件";
            this.chkNormal.UseVisualStyleBackColor = true;
            // 
            // chkStandard
            // 
            this.chkStandard.AutoSize = true;
            this.chkStandard.Location = new System.Drawing.Point(12, 47);
            this.chkStandard.Name = "chkStandard";
            this.chkStandard.Size = new System.Drawing.Size(60, 16);
            this.chkStandard.TabIndex = 1;
            this.chkStandard.Text = "标准件";
            this.chkStandard.UseVisualStyleBackColor = true;
            // 
            // chkUniversal
            // 
            this.chkUniversal.AutoSize = true;
            this.chkUniversal.Location = new System.Drawing.Point(12, 82);
            this.chkUniversal.Name = "chkUniversal";
            this.chkUniversal.Size = new System.Drawing.Size(60, 16);
            this.chkUniversal.TabIndex = 2;
            this.chkUniversal.Text = "通用件";
            this.chkUniversal.UseVisualStyleBackColor = true;
            // 
            // chkWelding
            // 
            this.chkWelding.AutoSize = true;
            this.chkWelding.Location = new System.Drawing.Point(12, 117);
            this.chkWelding.Name = "chkWelding";
            this.chkWelding.Size = new System.Drawing.Size(60, 16);
            this.chkWelding.TabIndex = 3;
            this.chkWelding.Text = "焊接件";
            this.chkWelding.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(31, 177);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PartsTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.chkWelding);
            this.Controls.Add(this.chkUniversal);
            this.Controls.Add(this.chkStandard);
            this.Controls.Add(this.chkNormal);
            this.Name = "PartsTypeForm";
            this.Text = "BOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkStandard;
        private System.Windows.Forms.CheckBox chkUniversal;
        private System.Windows.Forms.CheckBox chkWelding;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}