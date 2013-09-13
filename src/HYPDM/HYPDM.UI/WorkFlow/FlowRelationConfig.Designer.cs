namespace HYPDM.WinUI.WorkFlow
{
    partial class FlowRelationConfig
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowRelationConfig));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvFlowList = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gpDetail = new System.Windows.Forms.GroupBox();
            this.gpSetting = new System.Windows.Forms.GroupBox();
            this.dgvExtTemplates = new HYPDM.BaseControl.DataGridViewExt();
            this.OBJECTVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.关联模板名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templatesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTUPDATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTUPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 499);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpDetail);
            this.splitContainer1.Panel2.Controls.Add(this.gpSetting);
            this.splitContainer1.Size = new System.Drawing.Size(948, 497);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvFlowList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 497);
            this.panel2.TabIndex = 0;
            // 
            // tvFlowList
            // 
            this.tvFlowList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFlowList.ImageIndex = 0;
            this.tvFlowList.ImageList = this.imageList1;
            this.tvFlowList.Location = new System.Drawing.Point(0, 0);
            this.tvFlowList.Name = "tvFlowList";
            this.tvFlowList.SelectedImageIndex = 0;
            this.tvFlowList.Size = new System.Drawing.Size(227, 497);
            this.tvFlowList.TabIndex = 0;
            this.tvFlowList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFlowList_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_add.png");
            this.imageList1.Images.SetKeyName(1, "edit_remove.png");
            // 
            // gpDetail
            // 
            this.gpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDetail.Location = new System.Drawing.Point(0, 211);
            this.gpDetail.Name = "gpDetail";
            this.gpDetail.Size = new System.Drawing.Size(717, 286);
            this.gpDetail.TabIndex = 1;
            this.gpDetail.TabStop = false;
            this.gpDetail.Text = "工作流预览区";
            // 
            // gpSetting
            // 
            this.gpSetting.Controls.Add(this.dgvExtTemplates);
            this.gpSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpSetting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpSetting.Location = new System.Drawing.Point(0, 0);
            this.gpSetting.Name = "gpSetting";
            this.gpSetting.Size = new System.Drawing.Size(717, 211);
            this.gpSetting.TabIndex = 0;
            this.gpSetting.TabStop = false;
            this.gpSetting.Text = "模块管理工作流模板";
            // 
            // dgvExtTemplates
            // 
            this.dgvExtTemplates.AllowUserToAddRows = false;
            this.dgvExtTemplates.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvExtTemplates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExtTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OBJECTVALUE,
            this.typeName,
            this.关联模板名称,
            this.templatesID,
            this.LASTUPDATEUSER,
            this.LASTUPDATEDATE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExtTemplates.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExtTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExtTemplates.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvExtTemplates.Location = new System.Drawing.Point(3, 17);
            this.dgvExtTemplates.Name = "dgvExtTemplates";
            this.dgvExtTemplates.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvExtTemplates.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvExtTemplates.RowTemplate.Height = 23;
            this.dgvExtTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtTemplates.Size = new System.Drawing.Size(711, 191);
            this.dgvExtTemplates.TabIndex = 0;
            this.dgvExtTemplates.DoubleClick += new System.EventHandler(this.dgvExtTemplates_DoubleClick);
            // 
            // OBJECTVALUE
            // 
            this.OBJECTVALUE.DataPropertyName = "OBJECTVALUE";
            this.OBJECTVALUE.HeaderText = "type";
            this.OBJECTVALUE.Name = "OBJECTVALUE";
            this.OBJECTVALUE.Visible = false;
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "OBJECTDESC";
            this.typeName.HeaderText = "对象名称";
            this.typeName.Name = "typeName";
            this.typeName.Width = 150;
            // 
            // 关联模板名称
            // 
            this.关联模板名称.DataPropertyName = "WFT_NAME";
            this.关联模板名称.HeaderText = "关联模板名称";
            this.关联模板名称.Name = "关联模板名称";
            this.关联模板名称.Width = 300;
            // 
            // templatesID
            // 
            this.templatesID.DataPropertyName = "WFT_ID";
            this.templatesID.HeaderText = "templatesID";
            this.templatesID.Name = "templatesID";
            this.templatesID.Visible = false;
            // 
            // LASTUPDATEUSER
            // 
            this.LASTUPDATEUSER.DataPropertyName = "LASTUPDATEUSER";
            this.LASTUPDATEUSER.HeaderText = "最后修改用户";
            this.LASTUPDATEUSER.Name = "LASTUPDATEUSER";
            this.LASTUPDATEUSER.Width = 150;
            // 
            // LASTUPDATEDATE
            // 
            this.LASTUPDATEDATE.DataPropertyName = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.HeaderText = "最后修改时间";
            this.LASTUPDATEDATE.Name = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.Width = 150;
            // 
            // FlowRelationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FlowRelationConfig";
            this.Size = new System.Drawing.Size(950, 499);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gpSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtTemplates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvFlowList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gpDetail;
        private System.Windows.Forms.GroupBox gpSetting;
        private BaseControl.DataGridViewExt dgvExtTemplates;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTVALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 关联模板名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn templatesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTUPDATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTUPDATEDATE;
    }
}
