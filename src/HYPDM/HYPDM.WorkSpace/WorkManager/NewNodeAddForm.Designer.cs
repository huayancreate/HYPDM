namespace HYPDM.WorkSpace.WorkManager
{
    partial class NewNodeAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNodeAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_struct = new System.Windows.Forms.ComboBox();
            this.cmb_module = new System.Windows.Forms.ComboBox();
            this.ck_delete = new System.Windows.Forms.CheckBox();
            this.cmb_query = new System.Windows.Forms.ComboBox();
            this.cmb_image = new System.Windows.Forms.ComboBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sortNum = new System.Windows.Forms.TextBox();
            this.ck_addchild = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "所属结构";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "对应模块";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "查询类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "选项图标";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(81, 14);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(95, 21);
            this.tb_name.TabIndex = 6;
            // 
            // tb_struct
            // 
            this.tb_struct.FormattingEnabled = true;
            this.tb_struct.Location = new System.Drawing.Point(261, 14);
            this.tb_struct.Name = "tb_struct";
            this.tb_struct.Size = new System.Drawing.Size(107, 20);
            this.tb_struct.TabIndex = 7;
            // 
            // cmb_module
            // 
            this.cmb_module.FormattingEnabled = true;
            this.cmb_module.Items.AddRange(new object[] {
            "工作模块",
            "最近工作模块",
            "我的文件夹模块",
            "项目模块"});
            this.cmb_module.Location = new System.Drawing.Point(81, 50);
            this.cmb_module.Name = "cmb_module";
            this.cmb_module.Size = new System.Drawing.Size(95, 20);
            this.cmb_module.TabIndex = 8;
            // 
            // ck_delete
            // 
            this.ck_delete.AutoSize = true;
            this.ck_delete.Location = new System.Drawing.Point(101, 127);
            this.ck_delete.Name = "ck_delete";
            this.ck_delete.Size = new System.Drawing.Size(72, 16);
            this.ck_delete.TabIndex = 9;
            this.ck_delete.Text = "是否删除";
            this.ck_delete.UseVisualStyleBackColor = true;
            // 
            // cmb_query
            // 
            this.cmb_query.FormattingEnabled = true;
            this.cmb_query.Items.AddRange(new object[] {
            "收到的工作",
            "发出的工作",
            "完成的工作",
            "最近的工作"});
            this.cmb_query.Location = new System.Drawing.Point(81, 87);
            this.cmb_query.Name = "cmb_query";
            this.cmb_query.Size = new System.Drawing.Size(95, 20);
            this.cmb_query.TabIndex = 10;
            // 
            // cmb_image
            // 
            this.cmb_image.FormattingEnabled = true;
            this.cmb_image.Items.AddRange(new object[] {
            "图标1",
            "图标2",
            "图标3",
            "图标4",
            "图标5",
            "图标6"});
            this.cmb_image.Location = new System.Drawing.Point(261, 87);
            this.cmb_image.Name = "cmb_image";
            this.cmb_image.Size = new System.Drawing.Size(107, 20);
            this.cmb_image.TabIndex = 11;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(101, 167);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancle
            // 
            this.bt_cancle.Location = new System.Drawing.Point(204, 167);
            this.bt_cancle.Name = "bt_cancle";
            this.bt_cancle.Size = new System.Drawing.Size(75, 23);
            this.bt_cancle.TabIndex = 13;
            this.bt_cancle.Text = "取消";
            this.bt_cancle.UseVisualStyleBackColor = true;
            this.bt_cancle.Click += new System.EventHandler(this.bt_cancle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "序号";
            // 
            // tb_sortNum
            // 
            this.tb_sortNum.Location = new System.Drawing.Point(261, 47);
            this.tb_sortNum.Name = "tb_sortNum";
            this.tb_sortNum.Size = new System.Drawing.Size(107, 21);
            this.tb_sortNum.TabIndex = 15;
            // 
            // ck_addchild
            // 
            this.ck_addchild.AutoSize = true;
            this.ck_addchild.Location = new System.Drawing.Point(207, 127);
            this.ck_addchild.Name = "ck_addchild";
            this.ck_addchild.Size = new System.Drawing.Size(108, 16);
            this.ck_addchild.TabIndex = 16;
            this.ck_addchild.Text = "是否添加子结构";
            this.ck_addchild.UseVisualStyleBackColor = true;
            // 
            // NewNodeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 202);
            this.Controls.Add(this.ck_addchild);
            this.Controls.Add(this.tb_sortNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_cancle);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.cmb_image);
            this.Controls.Add(this.cmb_query);
            this.Controls.Add(this.ck_delete);
            this.Controls.Add(this.cmb_module);
            this.Controls.Add(this.tb_struct);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNodeAddForm";
            this.Text = "工作区结构修改或添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox tb_struct;
        private System.Windows.Forms.ComboBox cmb_module;
        private System.Windows.Forms.CheckBox ck_delete;
        private System.Windows.Forms.ComboBox cmb_query;
        private System.Windows.Forms.ComboBox cmb_image;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sortNum;
        private System.Windows.Forms.CheckBox ck_addchild;
    }
}