namespace HYPDM.WinUI.WorkFlow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBtnTools = new System.Windows.Forms.Panel();
            this.btnWFHold = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNextStepAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDefineUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWFName = new System.Windows.Forms.TextBox();
            this.lblWFName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioEndN = new System.Windows.Forms.RadioButton();
            this.radioEndY = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkStartUserNote = new System.Windows.Forms.CheckBox();
            this.chkDelWF = new System.Windows.Forms.CheckBox();
            this.chkMdyContent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combThroughNext = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.btnUserSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combCurrentStep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.btnStepModify = new System.Windows.Forms.Button();
            this.btnStepDel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpWFG = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.btnWorkFlowModify = new System.Windows.Forms.Button();
            this.btnWorkFlowNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBtnTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.pnlParameter.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.pnlTop.Controls.Add(this.pnlBtnTools);
            this.pnlTop.Controls.Add(this.btnModify);
            this.pnlTop.Controls.Add(this.btnCreate);
            this.pnlTop.Controls.Add(this.txtDefineUser);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtWFName);
            this.pnlTop.Controls.Add(this.lblWFName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(920, 80);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlBtnTools
            // 
            this.pnlBtnTools.Controls.Add(this.btnWFHold);
            this.pnlBtnTools.Controls.Add(this.btnSubmit);
            this.pnlBtnTools.Controls.Add(this.btnNextStepAdd);
            this.pnlBtnTools.Location = new System.Drawing.Point(475, 41);
            this.pnlBtnTools.Name = "pnlBtnTools";
            this.pnlBtnTools.Size = new System.Drawing.Size(412, 36);
            this.pnlBtnTools.TabIndex = 10;
            // 
            // btnWFHold
            // 
            this.btnWFHold.Location = new System.Drawing.Point(278, 7);
            this.btnWFHold.Name = "btnWFHold";
            this.btnWFHold.Size = new System.Drawing.Size(130, 27);
            this.btnWFHold.TabIndex = 12;
            this.btnWFHold.Text = "停用工作流";
            this.btnWFHold.UseVisualStyleBackColor = true;
            this.btnWFHold.Click += new System.EventHandler(this.btnWFHold_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(142, 7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 27);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "启用工作流";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNextStepAdd
            // 
            this.btnNextStepAdd.Location = new System.Drawing.Point(6, 7);
            this.btnNextStepAdd.Name = "btnNextStepAdd";
            this.btnNextStepAdd.Size = new System.Drawing.Size(130, 27);
            this.btnNextStepAdd.TabIndex = 10;
            this.btnNextStepAdd.Text = "添加下一节点";
            this.btnNextStepAdd.UseVisualStyleBackColor = true;
            this.btnNextStepAdd.Click += new System.EventHandler(this.btnNextStepAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(301, 46);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "工作流修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(301, 17);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "工作流创建";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDefineUser
            // 
            this.txtDefineUser.Location = new System.Drawing.Point(547, 3);
            this.txtDefineUser.Name = "txtDefineUser";
            this.txtDefineUser.ReadOnly = true;
            this.txtDefineUser.Size = new System.Drawing.Size(185, 21);
            this.txtDefineUser.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "定义人:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
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
            this.splitContainer2.Panel2.Controls.Add(this.gpWFG);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(920, 450);
            this.splitContainer2.SplitterDistance = 496;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.pnlMain);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 450);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作流设计";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox3);
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtComment);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.chkStartUserNote);
            this.pnlMain.Controls.Add(this.chkDelWF);
            this.pnlMain.Controls.Add(this.chkMdyContent);
            this.pnlMain.Controls.Add(this.label6);
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
            this.pnlMain.Size = new System.Drawing.Size(477, 380);
            this.pnlMain.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioEndN);
            this.groupBox3.Controls.Add(this.radioEndY);
            this.groupBox3.Location = new System.Drawing.Point(4, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 44);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "是否为终结点";
            // 
            // radioEndN
            // 
            this.radioEndN.AutoSize = true;
            this.radioEndN.Checked = true;
            this.radioEndN.Location = new System.Drawing.Point(187, 15);
            this.radioEndN.Name = "radioEndN";
            this.radioEndN.Size = new System.Drawing.Size(35, 16);
            this.radioEndN.TabIndex = 24;
            this.radioEndN.TabStop = true;
            this.radioEndN.Text = "否";
            this.radioEndN.UseVisualStyleBackColor = true;
            // 
            // radioEndY
            // 
            this.radioEndY.AutoSize = true;
            this.radioEndY.Location = new System.Drawing.Point(124, 14);
            this.radioEndY.Name = "radioEndY";
            this.radioEndY.Size = new System.Drawing.Size(35, 16);
            this.radioEndY.TabIndex = 23;
            this.radioEndY.Text = "是";
            this.radioEndY.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnNo);
            this.groupBox2.Controls.Add(this.radioBtnYes);
            this.groupBox2.Location = new System.Drawing.Point(4, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 44);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置为起始步骤";
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Checked = true;
            this.radioBtnNo.Location = new System.Drawing.Point(187, 20);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(35, 16);
            this.radioBtnNo.TabIndex = 12;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "否";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(124, 19);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(35, 16);
            this.radioBtnYes.TabIndex = 11;
            this.radioBtnYes.Text = "是";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "备注:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(111, 314);
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
            this.chkStartUserNote.Location = new System.Drawing.Point(114, 292);
            this.chkStartUserNote.Name = "chkStartUserNote";
            this.chkStartUserNote.Size = new System.Drawing.Size(84, 16);
            this.chkStartUserNote.TabIndex = 14;
            this.chkStartUserNote.Text = "通知拟制人";
            this.chkStartUserNote.UseVisualStyleBackColor = true;
            // 
            // chkDelWF
            // 
            this.chkDelWF.AutoSize = true;
            this.chkDelWF.Location = new System.Drawing.Point(115, 266);
            this.chkDelWF.Name = "chkDelWF";
            this.chkDelWF.Size = new System.Drawing.Size(84, 16);
            this.chkDelWF.TabIndex = 13;
            this.chkDelWF.Text = "可删除流程";
            this.chkDelWF.UseVisualStyleBackColor = true;
            // 
            // chkMdyContent
            // 
            this.chkMdyContent.AutoSize = true;
            this.chkMdyContent.Location = new System.Drawing.Point(115, 238);
            this.chkMdyContent.Name = "chkMdyContent";
            this.chkMdyContent.Size = new System.Drawing.Size(84, 16);
            this.chkMdyContent.TabIndex = 12;
            this.chkMdyContent.Text = "可修改内容";
            this.chkMdyContent.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "当前步骤属性:";
            // 
            // combThroughNext
            // 
            this.combThroughNext.FormattingEnabled = true;
            this.combThroughNext.Location = new System.Drawing.Point(121, 115);
            this.combThroughNext.Name = "combThroughNext";
            this.combThroughNext.Size = new System.Drawing.Size(364, 20);
            this.combThroughNext.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "通过时流向:";
            // 
            // txtUsers
            // 
            this.txtUsers.Location = new System.Drawing.Point(121, 53);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(364, 48);
            this.txtUsers.TabIndex = 5;
            // 
            // btnUserSelect
            // 
            this.btnUserSelect.Location = new System.Drawing.Point(78, 53);
            this.btnUserSelect.Name = "btnUserSelect";
            this.btnUserSelect.Size = new System.Drawing.Size(38, 23);
            this.btnUserSelect.TabIndex = 4;
            this.btnUserSelect.Text = "选择";
            this.btnUserSelect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "当前处理人:";
            // 
            // combCurrentStep
            // 
            this.combCurrentStep.FormattingEnabled = true;
            this.combCurrentStep.Location = new System.Drawing.Point(121, 23);
            this.combCurrentStep.Name = "combCurrentStep";
            this.combCurrentStep.Size = new System.Drawing.Size(364, 20);
            this.combCurrentStep.TabIndex = 2;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlModify);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 50);
            this.panel4.TabIndex = 10;
            // 
            // pnlModify
            // 
            this.pnlModify.Controls.Add(this.btnStepModify);
            this.pnlModify.Controls.Add(this.btnStepDel);
            this.pnlModify.Location = new System.Drawing.Point(299, 2);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(173, 46);
            this.pnlModify.TabIndex = 30;
            // 
            // btnStepModify
            // 
            this.btnStepModify.Location = new System.Drawing.Point(88, 4);
            this.btnStepModify.Name = "btnStepModify";
            this.btnStepModify.Size = new System.Drawing.Size(79, 38);
            this.btnStepModify.TabIndex = 23;
            this.btnStepModify.Text = "修改";
            this.btnStepModify.UseVisualStyleBackColor = true;
            this.btnStepModify.Click += new System.EventHandler(this.btnStepModify_Click);
            // 
            // btnStepDel
            // 
            this.btnStepDel.Location = new System.Drawing.Point(5, 4);
            this.btnStepDel.Name = "btnStepDel";
            this.btnStepDel.Size = new System.Drawing.Size(79, 38);
            this.btnStepDel.TabIndex = 22;
            this.btnStepDel.Text = "删除";
            this.btnStepDel.UseVisualStyleBackColor = true;
            this.btnStepDel.Click += new System.EventHandler(this.btnStepDel_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(483, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 450);
            this.panel3.TabIndex = 7;
            // 
            // gpWFG
            // 
            this.gpWFG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpWFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpWFG.Location = new System.Drawing.Point(0, 0);
            this.gpWFG.Name = "gpWFG";
            this.gpWFG.Size = new System.Drawing.Size(410, 450);
            this.gpWFG.TabIndex = 1;
            this.gpWFG.TabStop = false;
            this.gpWFG.Text = "工作流走向";
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
            this.pnlParameter.Controls.Add(this.btnWorkFlowModify);
            this.pnlParameter.Controls.Add(this.btnWorkFlowNew);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlParameter.Location = new System.Drawing.Point(0, 0);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(130, 534);
            this.pnlParameter.TabIndex = 0;
            // 
            // btnWorkFlowModify
            // 
            this.btnWorkFlowModify.Location = new System.Drawing.Point(9, 83);
            this.btnWorkFlowModify.Name = "btnWorkFlowModify";
            this.btnWorkFlowModify.Size = new System.Drawing.Size(113, 47);
            this.btnWorkFlowModify.TabIndex = 1;
            this.btnWorkFlowModify.Text = "工作流修改";
            this.btnWorkFlowModify.UseVisualStyleBackColor = true;
            this.btnWorkFlowModify.Click += new System.EventHandler(this.btnWorkFlowModify_Click);
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
            this.pnlBtnTools.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlModify.ResumeLayout(false);
            this.pnlParameter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlParameter;
        private System.Windows.Forms.Button btnWorkFlowNew;
        private System.Windows.Forms.Button btnWorkFlowModify;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDefineUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWFName;
        private System.Windows.Forms.Label lblWFName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpWFG;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioEndN;
        private System.Windows.Forms.RadioButton radioEndY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkStartUserNote;
        private System.Windows.Forms.CheckBox chkDelWF;
        private System.Windows.Forms.CheckBox chkMdyContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combThroughNext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.Button btnUserSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combCurrentStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.Button btnStepModify;
        private System.Windows.Forms.Button btnStepDel;
        private System.Windows.Forms.Panel pnlBtnTools;
        private System.Windows.Forms.Button btnWFHold;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNextStepAdd;
    }
}

