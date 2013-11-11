using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS.Windows.UI.Controls;
using EAS.Modularization;
using EAS.Explorer.Entities;
using EAS.Explorer;
using HYPDM.WinUI;

namespace HYPDM.Res
{
    [Module("704B3F05-0BBC-413A-B554-53733539FCC9", "启始页", "AgileEAS.NET平台WinForm/Wpf容器起始页模块")]
    partial class Welcome : UserControl
    {
        [ModuleStart]
        public void Start()
        {
        }

        IAccount account = null;
        private PictureBox pictureBox1;
        private Label label1;
        private System.ComponentModel.IContainer components = null;

        public Welcome()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);

            InitializeComponent();
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        protected override void OnResize(EventArgs e)
        {
            //this.lblGuest.Top = (this.Height - this.lblGuest.Height) / 2;
            //this.lblGuest.Left = (this.Width - this.lblGuest.Width) / 2;
            //this.lblGuest.Left = this.lblGuest.Left / 5 * 4;

            base.OnResize(e);
        }

        #region 设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HYPDM.Res.Properties.Resources.华研标志;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1133, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(331, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用HYPDM系统";
            // 
            // Welcome
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1139, 606);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal void InternalSetShell()
        {
            //if (account.OriginalID.Length == 0)
            //{
            //    (EAS.Application.Instance as EAS.Windows.Application).Shell.Text = "卫联医院管理信息系统 帐号名称:[" + account.AccountName + "] 帐号[" + account.LoginID + "]";
            //}
            //else
            //{
            //    (EAS.Application.Instance as EAS.Windows.Application).Shell.Text = "卫联医院管理信息系统 科室：[" + DataConvertHelper.GetDeptName(LoginInfo.Employee.DepartmentID) + "] 帐号名称:[" + account.AccountName + "] 帐号[" + account.LoginID + "]";
            //}
        }

        internal void InternalLoginDepartSelect()
        {
            if (account.OriginalID.Length == 0)
            {
                return;
            }

            //IMultiDepartEmployeeList employeeList = WLPersonnel.DAL.Interface.DALHelper.DALManager.CreateMultiDepartEmployeeList();
            //employeeList.GetMultiDepartEmployeeList(LoginInfo.Employee.EmployeeID);

            //if (employeeList.Rows.Count > 0)
            //{
            //    employeeList.Rows.Clear();
            //    employeeList.GetMultiDepartEmployeeList2(LoginInfo.Employee.EmployeeID);

            //    FormLoginSelect select = new FormLoginSelect(employeeList);
            //    select.ShowDialog(this.ParentForm);
            //}
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    System.Drawing.Graphics g = e.Graphics;

        //    if (this.backImage != null)
        //    {
        //        g.DrawImage(this.backImage, this.Width - this.backImage.Width, this.Height - this.backImage.Height, this.backImage.Width, this.backImage.Height);
        //    }
        //}

        private void pbDrugIn_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(Test));
        }

        private void pbDrugLost_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugLost));
        }

        private void pbDrugBackProviderAdIn_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugBackProvider));
        }

        private void pbDrugStoreQuery_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugStoreQuery));
        }

        private void pbDrugBackCustom_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugBackCustom));
        }

        private void pbDrugChangePriceAdIn_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugChangePrice));
        }

        private void pbDrugStoreOut_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugSale));
        }

        private void pbDrugStoreCount_Click(object sender, EventArgs e)
        {
            //EAS.Application.Instance.StartModule(typeof(DrugStoreCount));
        }
    }
}
