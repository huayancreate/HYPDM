namespace HYPDM.WorkSpace.WorkManager
{
    partial class WorkManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkManager));
            this.dgv_list = new HYPDM.BaseControl.DataGridViewExt();
            this.WFA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WFT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECTKEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTUPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RELATIONOBJECTTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.START_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Current_STEP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STEP_THROUGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIVEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WFT_STEP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USER_THROUGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WFT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsl_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsb_retrive = new System.Windows.Forms.ToolStripButton();
            this.ucPaging1 = new HYPDM.BaseControl.UcPaging();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WFA_ID,
            this.WFT_ID,
            this.CREATEDATE,
            this.CREATEUSER,
            this.DEL_FLAG,
            this.OBJECTKEY,
            this.LASTUPDATEDATE,
            this.RELATIONOBJECTTYPE,
            this.START_DATE,
            this.STATUS,
            this.SUBJECT,
            this.Current_STEP_ID,
            this.COMPLEMENTDATE,
            this.STEP_THROUGH,
            this.MSG,
            this.RECIVEDATE,
            this.WFT_STEP_ID,
            this.USER_THROUGH,
            this.WFT_NAME});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_list.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_list.Location = new System.Drawing.Point(0, 28);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgv_list.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgv_list.RowTemplate.Height = 23;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_list.Size = new System.Drawing.Size(803, 387);
            this.dgv_list.TabIndex = 4;
            this.dgv_list.DoubleClick += new System.EventHandler(this.dgv_list_DoubleClick);
            // 
            // WFA_ID
            // 
            this.WFA_ID.DataPropertyName = "WFA_ID";
            this.WFA_ID.HeaderText = "流程实例主键";
            this.WFA_ID.Name = "WFA_ID";
            this.WFA_ID.ReadOnly = true;
            this.WFA_ID.Visible = false;
            // 
            // WFT_ID
            // 
            this.WFT_ID.DataPropertyName = "WFT_ID";
            this.WFT_ID.HeaderText = "流程模板";
            this.WFT_ID.Name = "WFT_ID";
            this.WFT_ID.ReadOnly = true;
            this.WFT_ID.Visible = false;
            // 
            // CREATEDATE
            // 
            this.CREATEDATE.DataPropertyName = "CREATEDATE";
            this.CREATEDATE.HeaderText = "创建时间";
            this.CREATEDATE.Name = "CREATEDATE";
            this.CREATEDATE.ReadOnly = true;
            // 
            // CREATEUSER
            // 
            this.CREATEUSER.DataPropertyName = "CREATEUSER";
            this.CREATEUSER.HeaderText = "创建人";
            this.CREATEUSER.Name = "CREATEUSER";
            this.CREATEUSER.ReadOnly = true;
            // 
            // DEL_FLAG
            // 
            this.DEL_FLAG.DataPropertyName = "DEL_FLAG";
            this.DEL_FLAG.HeaderText = "实例删除标识";
            this.DEL_FLAG.Name = "DEL_FLAG";
            this.DEL_FLAG.ReadOnly = true;
            this.DEL_FLAG.Visible = false;
            // 
            // OBJECTKEY
            // 
            this.OBJECTKEY.DataPropertyName = "OBJECTKEY";
            this.OBJECTKEY.HeaderText = "关联对象ID";
            this.OBJECTKEY.Name = "OBJECTKEY";
            this.OBJECTKEY.ReadOnly = true;
            this.OBJECTKEY.Visible = false;
            // 
            // LASTUPDATEDATE
            // 
            this.LASTUPDATEDATE.DataPropertyName = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.HeaderText = "修改时间";
            this.LASTUPDATEDATE.Name = "LASTUPDATEDATE";
            this.LASTUPDATEDATE.ReadOnly = true;
            // 
            // RELATIONOBJECTTYPE
            // 
            this.RELATIONOBJECTTYPE.DataPropertyName = "RELATIONOBJECTTYPE";
            this.RELATIONOBJECTTYPE.HeaderText = "对象类型";
            this.RELATIONOBJECTTYPE.Name = "RELATIONOBJECTTYPE";
            this.RELATIONOBJECTTYPE.ReadOnly = true;
            // 
            // START_DATE
            // 
            this.START_DATE.DataPropertyName = "START_DATE";
            this.START_DATE.HeaderText = "流程启动时间";
            this.START_DATE.Name = "START_DATE";
            this.START_DATE.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "流程状态";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // SUBJECT
            // 
            this.SUBJECT.DataPropertyName = "SUBJECT";
            this.SUBJECT.HeaderText = "实例主题";
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.ReadOnly = true;
            // 
            // Current_STEP_ID
            // 
            this.Current_STEP_ID.DataPropertyName = "Current_STEP_ID";
            this.Current_STEP_ID.HeaderText = "当前节点";
            this.Current_STEP_ID.Name = "Current_STEP_ID";
            this.Current_STEP_ID.ReadOnly = true;
            this.Current_STEP_ID.Visible = false;
            // 
            // COMPLEMENTDATE
            // 
            this.COMPLEMENTDATE.DataPropertyName = "COMPLEMENTDATE";
            this.COMPLEMENTDATE.HeaderText = "完成时间";
            this.COMPLEMENTDATE.Name = "COMPLEMENTDATE";
            this.COMPLEMENTDATE.ReadOnly = true;
            // 
            // STEP_THROUGH
            // 
            this.STEP_THROUGH.DataPropertyName = "STEP_THROUGH";
            this.STEP_THROUGH.HeaderText = "节点是否通过";
            this.STEP_THROUGH.Name = "STEP_THROUGH";
            this.STEP_THROUGH.ReadOnly = true;
            // 
            // MSG
            // 
            this.MSG.DataPropertyName = "MSG";
            this.MSG.HeaderText = "意见";
            this.MSG.Name = "MSG";
            this.MSG.ReadOnly = true;
            // 
            // RECIVEDATE
            // 
            this.RECIVEDATE.DataPropertyName = "RECIVEDATE";
            this.RECIVEDATE.HeaderText = "收到时间";
            this.RECIVEDATE.Name = "RECIVEDATE";
            this.RECIVEDATE.ReadOnly = true;
            // 
            // WFT_STEP_ID
            // 
            this.WFT_STEP_ID.DataPropertyName = "WFT_STEP_ID";
            this.WFT_STEP_ID.HeaderText = "模板步骤";
            this.WFT_STEP_ID.Name = "WFT_STEP_ID";
            this.WFT_STEP_ID.ReadOnly = true;
            this.WFT_STEP_ID.Visible = false;
            // 
            // USER_THROUGH
            // 
            this.USER_THROUGH.DataPropertyName = "USER_THROUGH";
            this.USER_THROUGH.HeaderText = "当前节点是否通过";
            this.USER_THROUGH.Name = "USER_THROUGH";
            this.USER_THROUGH.ReadOnly = true;
            // 
            // WFT_NAME
            // 
            this.WFT_NAME.DataPropertyName = "WFT_NAME";
            this.WFT_NAME.HeaderText = "流程名称";
            this.WFT_NAME.Name = "WFT_NAME";
            this.WFT_NAME.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_delete,
            this.toolStripButton1,
            this.tsb_retrive});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(803, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsl_delete
            // 
            this.tsl_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsl_delete.Image")));
            this.tsl_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsl_delete.Name = "tsl_delete";
            this.tsl_delete.Size = new System.Drawing.Size(52, 22);
            this.tsl_delete.Text = "删除";
            this.tsl_delete.Click += new System.EventHandler(this.tsl_delete_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsb_retrive
            // 
            this.tsb_retrive.Image = ((System.Drawing.Image)(resources.GetObject("tsb_retrive.Image")));
            this.tsb_retrive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_retrive.Name = "tsb_retrive";
            this.tsb_retrive.Size = new System.Drawing.Size(52, 22);
            this.tsb_retrive.Text = "回退";
            this.tsb_retrive.Click += new System.EventHandler(this.tsb_retrive_Click);
            // 
            // ucPaging1
            // 
            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPaging1.ExportIsVisiable = true;
            this.ucPaging1.Location = new System.Drawing.Point(0, 412);
            this.ucPaging1.Name = "ucPaging1";
            this.ucPaging1.PageSize = 20;
            this.ucPaging1.Size = new System.Drawing.Size(803, 29);
            this.ucPaging1.TabIndex = 5;
            // 
            // WorkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPaging1);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.toolStrip2);
            this.Name = "WorkManager";
            this.Size = new System.Drawing.Size(803, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsl_delete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsb_retrive;
        private BaseControl.UcPaging ucPaging1;
        private BaseControl.DataGridViewExt dgv_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECTKEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTUPDATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RELATIONOBJECTTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn START_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Current_STEP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STEP_THROUGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIVEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_STEP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_THROUGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn WFT_NAME;
    }
}
