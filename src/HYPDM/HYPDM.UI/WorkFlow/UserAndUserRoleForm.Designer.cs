namespace HYPDM.WinUI.WorkFlow
{
    partial class UserAndUserRoleForm
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
            this.pnlNotSelect = new System.Windows.Forms.Panel();
            this.lvNotSelect = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.lvSelected = new System.Windows.Forms.ListView();
            this.colSelectUn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSelectGn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlNotSelect.SuspendLayout();
            this.pnlSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotSelect
            // 
            this.pnlNotSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlNotSelect.Controls.Add(this.lvNotSelect);
            this.pnlNotSelect.Location = new System.Drawing.Point(4, 32);
            this.pnlNotSelect.Name = "pnlNotSelect";
            this.pnlNotSelect.Size = new System.Drawing.Size(205, 360);
            this.pnlNotSelect.TabIndex = 0;
            // 
            // lvNotSelect
            // 
            this.lvNotSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colGroupName});
            this.lvNotSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNotSelect.FullRowSelect = true;
            this.lvNotSelect.GridLines = true;
            this.lvNotSelect.Location = new System.Drawing.Point(0, 0);
            this.lvNotSelect.Name = "lvNotSelect";
            this.lvNotSelect.Size = new System.Drawing.Size(205, 360);
            this.lvNotSelect.TabIndex = 0;
            this.lvNotSelect.UseCompatibleStateImageBehavior = false;
            this.lvNotSelect.View = System.Windows.Forms.View.Details;
            this.lvNotSelect.SelectedIndexChanged += new System.EventHandler(this.lvNotSelecet_SelectedIndexChanged);
            // 
            // colUsername
            // 
            this.colUsername.Text = "用户名";
            this.colUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUsername.Width = 100;
            // 
            // colGroupName
            // 
            this.colGroupName.Text = "类型";
            this.colGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGroupName.Width = 100;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 4);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(163, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(174, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查  询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // pnlSelected
            // 
            this.pnlSelected.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSelected.Controls.Add(this.lvSelected);
            this.pnlSelected.Location = new System.Drawing.Point(292, 32);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(205, 360);
            this.pnlSelected.TabIndex = 4;
            // 
            // lvSelected
            // 
            this.lvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSelectUn,
            this.colSelectGn});
            this.lvSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelected.FullRowSelect = true;
            this.lvSelected.GridLines = true;
            this.lvSelected.Location = new System.Drawing.Point(0, 0);
            this.lvSelected.Name = "lvSelected";
            this.lvSelected.Size = new System.Drawing.Size(205, 360);
            this.lvSelected.TabIndex = 0;
            this.lvSelected.UseCompatibleStateImageBehavior = false;
            this.lvSelected.View = System.Windows.Forms.View.Details;
            this.lvSelected.SelectedIndexChanged += new System.EventHandler(this.lvSelected_SelectedIndexChanged);
            // 
            // colSelectUn
            // 
            this.colSelectUn.Text = "用户名";
            this.colSelectUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSelectUn.Width = 100;
            // 
            // colSelectGn
            // 
            this.colSelectGn.Text = "类型";
            this.colSelectGn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSelectGn.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(212, 108);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(212, 150);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 7;
            this.btnAddAll.Text = "添加所有";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(212, 192);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(75, 23);
            this.btnDelAll.TabIndex = 8;
            this.btnDelAll.Text = "删除所有";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(212, 290);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserAndUserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 394);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlSelected);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.pnlNotSelect);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.Name = "UserAndUserRoleForm";
            this.Text = "签批人员选择";
            this.Load += new System.EventHandler(this.UserAndUserRoleForm_Load);
            this.pnlNotSelect.ResumeLayout(false);
            this.pnlSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotSelect;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lvNotSelect;
        private System.Windows.Forms.ListView lvSelected;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colGroupName;
        private System.Windows.Forms.ColumnHeader colSelectUn;
        private System.Windows.Forms.ColumnHeader colSelectGn;
        private System.Windows.Forms.Button btnCancel;
    }
}