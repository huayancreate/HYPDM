using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.BLL;
using HYPDM.Entities;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class QueryStructForm : Form
    {
        public QueryStructForm()
        {
            InitializeComponent();
        }

        public DataTable dt;
        private  PDM_PRODUCT product;
        public PDM_PRODUCT Product {
            get { return this.product; }
            set { this.product = value; }
        }

        private void bt_Query_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> condition = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(this.tb_No.Text)) {
                condition.Add("tb_No", this.tb_No.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_Version.Text))
            {
                condition.Add("tb_Version", this.tb_Version.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_Model.Text))
            {
                condition.Add("tb_Model", this.tb_Model.Text);
            }
            if (!string.IsNullOrEmpty(this.tb_Memo.Text))
            {
                condition.Add("tb_Memo", this.tb_Memo.Text);
            }
        }

    }
}
