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
        private String order;
        private String quantity;
        private String remark;

        public string Order
        {
            get { return order; }
            set { order = value;
            if (order != null)
                this.txtOrder.Text = Order;
            }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value;
            if (quantity != null)
                this.txtQuantity.Text = Quantity;
            }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value;
            if (remark != null)
                this.txtRemark.Text = Remark;
            }
        }

        public UseMsgForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {

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
            this.DialogResult = DialogResult.OK;
        }
    }
}
