namespace HYPDM.WinUI.AddObjectParams
{
    partial class FrmAddParms
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlIsHasParams = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewParams = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlAdd);
            this.splitContainer1.Size = new System.Drawing.Size(362, 472);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.pnlIsHasParams);
            this.pnl.Controls.Add(this.panel1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(362, 429);
            this.pnl.TabIndex = 0;
            // 
            // pnlIsHasParams
            // 
            this.pnlIsHasParams.AutoScroll = true;
            this.pnlIsHasParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIsHasParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIsHasParams.Location = new System.Drawing.Point(0, 33);
            this.pnlIsHasParams.Name = "pnlIsHasParams";
            this.pnlIsHasParams.Size = new System.Drawing.Size(360, 394);
            this.pnlIsHasParams.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewParams);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 33);
            this.panel1.TabIndex = 180;
            // 
            // btnAddNewParams
            // 
            this.btnAddNewParams.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNewParams.Location = new System.Drawing.Point(281, 0);
            this.btnAddNewParams.Name = "btnAddNewParams";
            this.btnAddNewParams.Size = new System.Drawing.Size(79, 33);
            this.btnAddNewParams.TabIndex = 199;
            this.btnAddNewParams.Text = "添加新属性";
            this.btnAddNewParams.UseVisualStyleBackColor = true;
            this.btnAddNewParams.Click += new System.EventHandler(this.btnAddNewParams_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnSubmit);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdd.Location = new System.Drawing.Point(0, 6);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(362, 33);
            this.pnlAdd.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(304, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(58, 33);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmAddParms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 472);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAddParms";
            this.Text = "属性添加";
            this.Load += new System.EventHandler(this.FrmAddParms_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlIsHasParams;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewParams;
    }
}