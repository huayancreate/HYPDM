namespace HYPDM.WinUI.WorkFlow.Flow
{
    partial class StandardFlow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardFlow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpDetail = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFlowName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsp = new System.Windows.Forms.ToolStrip();
            this.tspDelete = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspStart = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsphandle = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFlow = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpFlowDetail = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspMenuUserOrGroup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpDetail.SuspendLayout();
            this.tsp.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpFlow.SuspendLayout();
            this.cMenu.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gpDetail);
            this.splitContainer1.Panel1.Controls.Add(this.tsp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(949, 459);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpDetail
            // 
            this.gpDetail.Controls.Add(this.btnModify);
            this.gpDetail.Controls.Add(this.btnSubmit);
            this.gpDetail.Controls.Add(this.txtFlowName);
            this.gpDetail.Controls.Add(this.label4);
            this.gpDetail.Controls.Add(this.txtStatus);
            this.gpDetail.Controls.Add(this.label3);
            this.gpDetail.Controls.Add(this.txtUserPM);
            this.gpDetail.Controls.Add(this.label2);
            this.gpDetail.Controls.Add(this.txtSubject);
            this.gpDetail.Controls.Add(this.label1);
            this.gpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDetail.Location = new System.Drawing.Point(0, 25);
            this.gpDetail.Name = "gpDetail";
            this.gpDetail.Size = new System.Drawing.Size(949, 105);
            this.gpDetail.TabIndex = 1;
            this.gpDetail.TabStop = false;
            this.gpDetail.Text = "基本信息";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(846, 24);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(51, 24);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(789, 24);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(51, 24);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFlowName
            // 
            this.txtFlowName.Location = new System.Drawing.Point(555, 66);
            this.txtFlowName.Name = "txtFlowName";
            this.txtFlowName.ReadOnly = true;
            this.txtFlowName.Size = new System.Drawing.Size(227, 21);
            this.txtFlowName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "审批流程";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(318, 67);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(147, 21);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "状态";
            // 
            // txtUserPM
            // 
            this.txtUserPM.Location = new System.Drawing.Point(65, 68);
            this.txtUserPM.Name = "txtUserPM";
            this.txtUserPM.ReadOnly = true;
            this.txtUserPM.Size = new System.Drawing.Size(147, 21);
            this.txtUserPM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "负责人";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(65, 27);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(717, 21);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubject_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主题";
            // 
            // tsp
            // 
            this.tsp.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.banner;
            this.tsp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDelete,
            this.toolStripSeparator2,
            this.tspStart,
            this.toolStripSeparator1,
            this.tsphandle});
            this.tsp.Location = new System.Drawing.Point(0, 0);
            this.tsp.Name = "tsp";
            this.tsp.Size = new System.Drawing.Size(949, 25);
            this.tsp.TabIndex = 0;
            this.tsp.Text = "toolStrip1";
            // 
            // tspDelete
            // 
            this.tspDelete.Enabled = false;
            this.tspDelete.ForeColor = System.Drawing.Color.White;
            this.tspDelete.Name = "tspDelete";
            this.tspDelete.Size = new System.Drawing.Size(32, 22);
            this.tspDelete.Text = "删除";
            this.tspDelete.Click += new System.EventHandler(this.tspDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspStart
            // 
            this.tspStart.ForeColor = System.Drawing.Color.White;
            this.tspStart.Name = "tspStart";
            this.tspStart.Size = new System.Drawing.Size(32, 22);
            this.tspStart.Text = "启动";
            this.tspStart.Click += new System.EventHandler(this.tspStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsphandle
            // 
            this.tsphandle.Enabled = false;
            this.tsphandle.ForeColor = System.Drawing.Color.White;
            this.tsphandle.Name = "tsphandle";
            this.tsphandle.Size = new System.Drawing.Size(56, 22);
            this.tsphandle.Text = "流程处理";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFlow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 325);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFlow
            // 
            this.tpFlow.BackColor = System.Drawing.Color.CadetBlue;
            this.tpFlow.Controls.Add(this.panel1);
            this.tpFlow.Controls.Add(this.gpFlowDetail);
            this.tpFlow.Controls.Add(this.toolStrip1);
            this.tpFlow.Location = new System.Drawing.Point(4, 22);
            this.tpFlow.Name = "tpFlow";
            this.tpFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tpFlow.Size = new System.Drawing.Size(941, 299);
            this.tpFlow.TabIndex = 0;
            this.tpFlow.Text = "审批流程";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 81);
            this.panel1.TabIndex = 2;
            // 
            // gpFlowDetail
            // 
            this.gpFlowDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpFlowDetail.Location = new System.Drawing.Point(3, 28);
            this.gpFlowDetail.Name = "gpFlowDetail";
            this.gpFlowDetail.Size = new System.Drawing.Size(935, 187);
            this.gpFlowDetail.TabIndex = 1;
            this.gpFlowDetail.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(935, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMenuUserOrGroup});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(185, 26);
            this.cMenu.Text = "指定处理人【群组】";
            // 
            // tspMenuUserOrGroup
            // 
            this.tspMenuUserOrGroup.Name = "tspMenuUserOrGroup";
            this.tspMenuUserOrGroup.Size = new System.Drawing.Size(184, 22);
            this.tspMenuUserOrGroup.Text = "指定处理人【群组】";
            this.tspMenuUserOrGroup.Click += new System.EventHandler(this.tspMenuUserOrGroup_Click);
            // 
            // StandardFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 459);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StandardFlow";
            this.Text = "标准审批流程";
            this.Load += new System.EventHandler(this.StandardFlow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpDetail.ResumeLayout(false);
            this.gpDetail.PerformLayout();
            this.tsp.ResumeLayout(false);
            this.tsp.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpFlow.ResumeLayout(false);
            this.tpFlow.PerformLayout();
            this.cMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tsp;
        private System.Windows.Forms.ToolStripLabel tspDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tspStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsphandle;
        private System.Windows.Forms.GroupBox gpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlowName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFlow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpFlowDetail;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem tspMenuUserOrGroup;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnModify;
    }
}