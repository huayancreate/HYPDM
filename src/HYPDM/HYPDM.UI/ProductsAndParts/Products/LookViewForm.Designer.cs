namespace HYPDM.WinUI.ProductsAndParts.Products
{
    partial class LookViewForm
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
            this.memoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(13, 13);
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(450, 293);
            this.memoBox.TabIndex = 0;
            this.memoBox.Text = "";
            // 
            // LookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 326);
            this.Controls.Add(this.memoBox);
            this.Name = "LookViewForm";
            this.Text = "LookViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox memoBox;
    }
}