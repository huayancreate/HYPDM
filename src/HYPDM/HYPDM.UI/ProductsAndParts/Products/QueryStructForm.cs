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
        enum selectType { Matieral, Parts, Product };
        private selectType s_type;
        public QueryStructForm(int t)
        {
            InitializeComponent();
            s_type = (selectType)t;
        }
        private  PDM_MATERAIL p_materail;
        public PDM_MATERAIL Materails
        {
             get { return this.p_materail; }
            set { this.p_materail = value; }
        }
        private  PDM_ALL_PRODUCT p_products;
        public PDM_ALL_PRODUCT Products
        {
            get { return this.p_products; }
            set { this.p_products = value; }
        }
        private PDM_ALL_PRODUCT p_parts;
        public PDM_ALL_PRODUCT Parts
        {
            get { return this.p_parts; }
            set { this.p_parts = value; }
        }

        private void bt_Query_Click(object sender, EventArgs e)
        {
            if (s_type == selectType.Matieral) {
                this.p_materail = new PDM_MATERAIL();
                p_materail.MATERIALNO = this.tb_No.Text;
                p_materail.MODELTYPE = this.tb_Model.Text;
                p_materail.VERSION = this.tb_Version.Text;
                p_materail.MEMO = this.tb_Memo.Text;
            }
            else if (s_type == selectType.Parts)
            {
                this.p_parts = new PDM_ALL_PRODUCT();
                p_parts.PRODUCTNO = this.tb_No.Text;
                p_parts.MODELTYPE = this.tb_Model.Text;
                p_parts.VERSION = this.tb_Version.Text;
                p_parts.MEMO = this.tb_Memo.Text;
            }
            else if (s_type == selectType.Product)
            {
                this.p_products = new PDM_ALL_PRODUCT();
                p_products.PRODUCTNO = this.tb_No.Text;
                p_products.MODELTYPE = this.tb_Model.Text;
                p_products.VERSION = this.tb_Version.Text;
                p_products.MEMO = this.tb_Memo.Text;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void bt_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
