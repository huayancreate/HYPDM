namespace HYPDM.WinUI.WorkFlow.Flow
{
    partial class CurrentStepHandle
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
            this.gpDetail = new System.Windows.Forms.GroupBox();
            this.btnHandle = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtHandleUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFlowName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listComments = new System.Windows.Forms.ListBox();
            this.gpFlowDetail = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.gpFlowDetail);
            this.splitContainer1.Size = new System.Drawing.Size(952, 471);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // gpDetail
            // 
            this.gpDetail.Controls.Add(this.btnHandle);
            this.gpDetail.Controls.Add(this.btnDetail);
            this.gpDetail.Controls.Add(this.txtHandleUser);
            this.gpDetail.Controls.Add(this.label5);
            this.gpDetail.Controls.Add(this.txtFlowName);
            this.gpDetail.Controls.Add(this.label4);
            this.gpDetail.Controls.Add(this.txtStatus);
            this.gpDetail.Controls.Add(this.label3);
            this.gpDetail.Controls.Add(this.txtUserPM);
            this.gpDetail.Controls.Add(this.label2);
            this.gpDetail.Controls.Add(this.txtSubject);
            this.gpDetail.Controls.Add(this.label1);
            this.gpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpDetail.Location = new System.Drawing.Point(0, 0);
            this.gpDetail.Name = "gpDetail";
            this.gpDetail.Size = new System.Drawing.Size(952, 105);
            this.gpDetail.TabIndex = 2;
            this.gpDetail.TabStop = false;
            this.gpDetail.Text = "基本信息";
            // 
            // btnHandle
            // 
            this.btnHandle.Location = new System.Drawing.Point(95, 73);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(79, 28);
            this.btnHandle.TabIndex = 15;
            this.btnHandle.Text = "流程处理";
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(12, 74);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(79, 28);
            this.btnDetail.TabIndex = 14;
            this.btnDetail.Text = "详细";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtHandleUser
            // 
            this.txtHandleUser.Location = new System.Drawing.Point(645, 77);
            this.txtHandleUser.Name = "txtHandleUser";
            this.txtHandleUser.ReadOnly = true;
            this.txtHandleUser.Size = new System.Drawing.Size(227, 21);
            this.txtHandleUser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "当前处理人";
            // 
            // txtFlowName
            // 
            this.txtFlowName.Location = new System.Drawing.Point(645, 47);
            this.txtFlowName.Name = "txtFlowName";
            this.txtFlowName.ReadOnly = true;
            this.txtFlowName.Size = new System.Drawing.Size(227, 21);
            this.txtFlowName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "审批流程";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(437, 48);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(147, 21);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "状态";
            // 
            // txtUserPM
            // 
            this.txtUserPM.Location = new System.Drawing.Point(253, 49);
            this.txtUserPM.Name = "txtUserPM";
            this.txtUserPM.ReadOnly = true;
            this.txtUserPM.Size = new System.Drawing.Size(147, 21);
            this.txtUserPM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "发起人";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(112, 17);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(761, 21);
            this.txtSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主题";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.listComments);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // listComments
            // 
            this.listComments.BackColor = System.Drawing.Color.Azure;
            this.listComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listComments.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listComments.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listComments.FormattingEnabled = true;
            this.listComments.Location = new System.Drawing.Point(3, 17);
            this.listComments.Name = "listComments";
            this.listComments.Size = new System.Drawing.Size(946, 131);
            this.listComments.TabIndex = 0;
            // 
            // gpFlowDetail
            // 
            this.gpFlowDetail.BackColor = System.Drawing.Color.CadetBlue;
            this.gpFlowDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpFlowDetail.Location = new System.Drawing.Point(0, 0);
            this.gpFlowDetail.Name = "gpFlowDetail";
            this.gpFlowDetail.Size = new System.Drawing.Size(952, 211);
            this.gpFlowDetail.TabIndex = 2;
            this.gpFlowDetail.TabStop = false;
            // 
            // CurrentStepHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 471);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CurrentStepHandle";
            this.Text = "当前处理人";
            this.Load += new System.EventHandler(this.CurrentStepHandle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpDetail.ResumeLayout(false);
            this.gpDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpDetail;
        private System.Windows.Forms.TextBox txtFlowName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHandleUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpFlowDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.ListBox listComments;
    }
}