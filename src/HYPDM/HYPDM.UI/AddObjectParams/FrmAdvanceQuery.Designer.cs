namespace HYPDM.WinUI.AddObjectParams
{
    partial class FrmAdvanceQuery
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
            this.splitmain = new System.Windows.Forms.SplitContainer();
            this.pnlQueryAdvanceParams = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExtandAdvanceQuery = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.cbmColName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).BeginInit();
            this.splitmain.Panel1.SuspendLayout();
            this.splitmain.Panel2.SuspendLayout();
            this.splitmain.SuspendLayout();
            this.pnlQueryAdvanceParams.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitmain
            // 
            this.splitmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitmain.Location = new System.Drawing.Point(0, 0);
            this.splitmain.Name = "splitmain";
            this.splitmain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitmain.Panel1
            // 
            this.splitmain.Panel1.Controls.Add(this.pnl);
            this.splitmain.Panel1.Controls.Add(this.panel3);
            // 
            // splitmain.Panel2
            // 
            this.splitmain.Panel2.Controls.Add(this.pnlQueryAdvanceParams);
            this.splitmain.Size = new System.Drawing.Size(836, 475);
            this.splitmain.SplitterDistance = 255;
            this.splitmain.TabIndex = 0;
            // 
            // pnlQueryAdvanceParams
            // 
            this.pnlQueryAdvanceParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQueryAdvanceParams.Controls.Add(this.cbmColName);
            this.pnlQueryAdvanceParams.Controls.Add(this.cmb);
            this.pnlQueryAdvanceParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQueryAdvanceParams.Location = new System.Drawing.Point(0, 0);
            this.pnlQueryAdvanceParams.Name = "pnlQueryAdvanceParams";
            this.pnlQueryAdvanceParams.Size = new System.Drawing.Size(836, 216);
            this.pnlQueryAdvanceParams.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExtandAdvanceQuery);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 26);
            this.panel3.TabIndex = 2;
            // 
            // btnExtandAdvanceQuery
            // 
            this.btnExtandAdvanceQuery.Location = new System.Drawing.Point(3, 1);
            this.btnExtandAdvanceQuery.Name = "btnExtandAdvanceQuery";
            this.btnExtandAdvanceQuery.Size = new System.Drawing.Size(84, 23);
            this.btnExtandAdvanceQuery.TabIndex = 2;
            this.btnExtandAdvanceQuery.Text = "高级查询<<<";
            this.btnExtandAdvanceQuery.UseVisualStyleBackColor = true;
            this.btnExtandAdvanceQuery.Click += new System.EventHandler(this.btnExtandAdvanceQuery_Click);
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(836, 229);
            this.pnl.TabIndex = 3;
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "like",
            "between"});
            this.cmb.Location = new System.Drawing.Point(224, 35);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 20);
            this.cmb.TabIndex = 0;
            // 
            // cbmColName
            // 
            this.cbmColName.FormattingEnabled = true;
            this.cbmColName.Items.AddRange(new object[] {
            "长度",
            "高度",
            "半径"});
            this.cbmColName.Location = new System.Drawing.Point(89, 35);
            this.cbmColName.Name = "cbmColName";
            this.cbmColName.Size = new System.Drawing.Size(121, 20);
            this.cbmColName.TabIndex = 1;
            this.cbmColName.SelectedIndexChanged += new System.EventHandler(this.cbmColName_SelectedIndexChanged);
            // 
            // FrmAdvanceQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 475);
            this.Controls.Add(this.splitmain);
            this.MaximizeBox = false;
            this.Name = "FrmAdvanceQuery";
            this.Text = "查询";
            this.Load += new System.EventHandler(this.FrmAdvanceQuery_Load);
            this.splitmain.Panel1.ResumeLayout(false);
            this.splitmain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitmain)).EndInit();
            this.splitmain.ResumeLayout(false);
            this.pnlQueryAdvanceParams.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitmain;
        private System.Windows.Forms.Panel pnlQueryAdvanceParams;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl;
        public System.Windows.Forms.Button btnExtandAdvanceQuery;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.ComboBox cbmColName;
    }
}