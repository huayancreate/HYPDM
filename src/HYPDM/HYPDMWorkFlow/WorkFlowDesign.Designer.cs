namespace HYPDMWorkFlow
{
    partial class WorkFlowDesign
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDefineUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWFName = new System.Windows.Forms.TextBox();
            this.lblWFName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgVStepInfo = new HYPDM.BaseControl.DataGridViewExt();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWorkFlowModify = new System.Windows.Forms.Button();
            this.btnWorkFlowNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkStartUserNote = new System.Windows.Forms.CheckBox();
            this.chkDelWF = new System.Windows.Forms.CheckBox();
            this.chkMdyContent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.combThroughNext = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.btnUserSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combCurrentStep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVStepInfo)).BeginInit();
            this.pnlParameter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.pnlParameter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 534);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(130, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(920, 534);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnCreate);
            this.pnlTop.Controls.Add(this.txtDefineUser);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtWFName);
            this.pnlTop.Controls.Add(this.lblWFName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 70);
            this.pnlTop.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(301, 17);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "创建工作流";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDefineUser
            // 
            this.txtDefineUser.Location = new System.Drawing.Point(452, 19);
            this.txtDefineUser.Name = "txtDefineUser";
            this.txtDefineUser.ReadOnly = true;
            this.txtDefineUser.Size = new System.Drawing.Size(185, 21);
            this.txtDefineUser.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "定义人:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "步骤定义:";
            // 
            // txtWFName
            // 
            this.txtWFName.Location = new System.Drawing.Point(78, 20);
            this.txtWFName.Name = "txtWFName";
            this.txtWFName.Size = new System.Drawing.Size(213, 21);
            this.txtWFName.TabIndex = 1;
            // 
            // lblWFName
            // 
            this.lblWFName.AutoSize = true;
            this.lblWFName.Location = new System.Drawing.Point(7, 24);
            this.lblWFName.Name = "lblWFName";
            this.lblWFName.Size = new System.Drawing.Size(71, 12);
            this.lblWFName.TabIndex = 0;
            this.lblWFName.Text = "工作流名称:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgVStepInfo);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(920, 450);
            this.splitContainer2.SplitterDistance = 496;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(483, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 450);
            this.panel3.TabIndex = 7;
            // 
            // dgVStepInfo
            // 
            this.dgVStepInfo.AllowUserToAddRows = false;
            this.dgVStepInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgVStepInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgVStepInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVStepInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVStepInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgVStepInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVStepInfo.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgVStepInfo.Location = new System.Drawing.Point(0, 0);
            this.dgVStepInfo.Name = "dgVStepInfo";
            this.dgVStepInfo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgVStepInfo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgVStepInfo.RowTemplate.Height = 23;
            this.dgVStepInfo.Size = new System.Drawing.Size(410, 450);
            this.dgVStepInfo.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "当前节点";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "下一节点";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "备注";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "当前处理人";
            this.Column5.Name = "Column5";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(410, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 0;
            // 
            // pnlParameter
            // 
            this.pnlParameter.BackColor = System.Drawing.Color.White;
            this.pnlParameter.Controls.Add(this.button1);
            this.pnlParameter.Controls.Add(this.btnWorkFlowModify);
            this.pnlParameter.Controls.Add(this.btnWorkFlowNew);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlParameter.Location = new System.Drawing.Point(0, 0);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(130, 534);
            this.pnlParameter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "参数设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnWorkFlowModify
            // 
            this.btnWorkFlowModify.Location = new System.Drawing.Point(9, 83);
            this.btnWorkFlowModify.Name = "btnWorkFlowModify";
            this.btnWorkFlowModify.Size = new System.Drawing.Size(113, 47);
            this.btnWorkFlowModify.TabIndex = 1;
            this.btnWorkFlowModify.Text = "工作流修改";
            this.btnWorkFlowModify.UseVisualStyleBackColor = true;
            // 
            // btnWorkFlowNew
            // 
            this.btnWorkFlowNew.Location = new System.Drawing.Point(9, 13);
            this.btnWorkFlowNew.Name = "btnWorkFlowNew";
            this.btnWorkFlowNew.Size = new System.Drawing.Size(113, 47);
            this.btnWorkFlowNew.TabIndex = 0;
            this.btnWorkFlowNew.Text = "新建工作流";
            this.btnWorkFlowNew.UseVisualStyleBackColor = true;
            this.btnWorkFlowNew.Click += new System.EventHandler(this.btnWorkFlowNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnNextStep);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtComment);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.chkStartUserNote);
            this.pnlMain.Controls.Add(this.chkDelWF);
            this.pnlMain.Controls.Add(this.chkMdyContent);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.radioBtnNo);
            this.pnlMain.Controls.Add(this.radioBtnYes);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.combThroughNext);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtUsers);
            this.pnlMain.Controls.Add(this.btnUserSelect);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.combCurrentStep);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 17);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(477, 430);
            this.pnlMain.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(230, 385);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(88, 38);
            this.btnNextStep.TabIndex = 18;
            this.btnNextStep.Text = "继续添加节点";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "备注:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(121, 307);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(364, 48);
            this.txtComment.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // chkStartUserNote
            // 
            this.chkStartUserNote.AutoSize = true;
            this.chkStartUserNote.Location = new System.Drawing.Point(122, 285);
            this.chkStartUserNote.Name = "chkStartUserNote";
            this.chkStartUserNote.Size = new System.Drawing.Size(84, 16);
            this.chkStartUserNote.TabIndex = 14;
            this.chkStartUserNote.Text = "通知拟制人";
            this.chkStartUserNote.UseVisualStyleBackColor = true;
            // 
            // chkDelWF
            // 
            this.chkDelWF.AutoSize = true;
            this.chkDelWF.Location = new System.Drawing.Point(123, 259);
            this.chkDelWF.Name = "chkDelWF";
            this.chkDelWF.Size = new System.Drawing.Size(84, 16);
            this.chkDelWF.TabIndex = 13;
            this.chkDelWF.Text = "可删除流程";
            this.chkDelWF.UseVisualStyleBackColor = true;
            // 
            // chkMdyContent
            // 
            this.chkMdyContent.AutoSize = true;
            this.chkMdyContent.Location = new System.Drawing.Point(123, 231);
            this.chkMdyContent.Name = "chkMdyContent";
            this.chkMdyContent.Size = new System.Drawing.Size(84, 16);
            this.chkMdyContent.TabIndex = 12;
            this.chkMdyContent.Text = "可修改内容";
            this.chkMdyContent.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "当前步骤属性:";
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Enabled = false;
            this.radioBtnNo.Location = new System.Drawing.Point(184, 180);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(35, 16);
            this.radioBtnNo.TabIndex = 10;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "否";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Enabled = false;
            this.radioBtnYes.Location = new System.Drawing.Point(121, 179);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(35, 16);
            this.radioBtnYes.TabIndex = 9;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "是";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "设为起始步骤:";
            // 
            // combThroughNext
            // 
            this.combThroughNext.FormattingEnabled = true;
            this.combThroughNext.Items.AddRange(new object[] {
            "拟制",
            "审核",
            "审批",
            "会签",
            "批准"});
            this.combThroughNext.Location = new System.Drawing.Point(121, 132);
            this.combThroughNext.Name = "combThroughNext";
            this.combThroughNext.Size = new System.Drawing.Size(364, 20);
            this.combThroughNext.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "通过时流向:";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(121, 63);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(364, 48);
            this.txtUsers.TabIndex = 5;
            // 
            // btnUserSelect
            // 
            this.btnUserSelect.Location = new System.Drawing.Point(78, 63);
            this.btnUserSelect.Name = "btnUserSelect";
            this.btnUserSelect.Size = new System.Drawing.Size(38, 23);
            this.btnUserSelect.TabIndex = 4;
            this.btnUserSelect.Text = "选择";
            this.btnUserSelect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "当前处理人:";
            // 
            // combCurrentStep
            // 
            this.combCurrentStep.FormattingEnabled = true;
            this.combCurrentStep.Items.AddRange(new object[] {
            "拟制",
            "审核",
            "审批",
            "会签",
            "批准"});
            this.combCurrentStep.Location = new System.Drawing.Point(121, 23);
            this.combCurrentStep.Name = "combCurrentStep";
            this.combCurrentStep.Size = new System.Drawing.Size(364, 20);
            this.combCurrentStep.TabIndex = 2;
            this.combCurrentStep.SelectedIndexChanged += new System.EventHandler(this.combCurrentStep_SelectedIndexChanged);
            this.combCurrentStep.SelectedValueChanged += new System.EventHandler(this.combCurrentStep_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前步骤名称:";
            // 
            // WorkFlowDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WorkFlowDesign";
            this.Size = new System.Drawing.Size(1050, 534);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVStepInfo)).EndInit();
            this.pnlParameter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlParameter;
        private System.Windows.Forms.Button btnWorkFlowNew;
        private System.Windows.Forms.Button btnWorkFlowModify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDefineUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWFName;
        private System.Windows.Forms.Label lblWFName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private HYPDM.BaseControl.DataGridViewExt dgVStepInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkStartUserNote;
        private System.Windows.Forms.CheckBox chkDelWF;
        private System.Windows.Forms.CheckBox chkMdyContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combThroughNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Button btnUserSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combCurrentStep;
        private System.Windows.Forms.Label label2;
    }
}

