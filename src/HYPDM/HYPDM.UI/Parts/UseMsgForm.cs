using EAS.Modularization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;

namespace HYPDM.WinUI.Parts
{
    public partial class UseMsgForm : BaseForm
    {
        public static String order = "";
        public static String quantity = "";
        public static String remark = "";

        public string Order
        {
            get { return order; }
            set { order = value; }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public UseMsgForm()
        {
            InitializeComponent();
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("请输入数量");
                return;
            }
            Order = this.txtOrder.Text;
            Quantity = this.txtQuantity.Text;
            Remark = this.txtRemark.Text;
        }
    }
}
