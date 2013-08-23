using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Services;
using EAS.Explorer;
using EAS.Data.ORM;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class ProductsAddForm : BaseForm
    {
        private int m_type;
        public ProductsAddForm(int p_type)
        {
            InitializeComponent();
            this.m_type = p_type;
        }

        HYPDM.Entities.PDM_ALL_PRODUCT m_product;
        public HYPDM.Entities.PDM_ALL_PRODUCT Product
        {
            get { return this.m_product; }
            set
            {
                this.m_product = value;
            }
        }
        //保存按钮操作
        private void save_Product_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb_productNO.Text.Trim())) {
                MessageBox.Show("产品编号不能为空"); return;
            }

            HYPDM.Entities.PDM_ALL_PRODUCT temp_product = new HYPDM.Entities.PDM_ALL_PRODUCT();

            temp_product.PRODUCTID = Guid.NewGuid().ToString();
            temp_product.PRODUCTNO = this.tb_productNO.Text;
            temp_product.MODELTYPE = this.tb_modeType.Text;
            temp_product.PRODUCTTYPE = this.tb_productType.Text;
            temp_product.PRODUCTLEVEL = this.m_type;
            temp_product.VERSION = "V"+DateTime.Now.ToString("yyyyMMddHHmm");
            temp_product.STATUS = "已创建";
            temp_product.CREATER = CommonVar.userName;
            //temp_product.MODIFIER = "";
            temp_product.CREATETIME = DateTime.Now.ToString();
            //temp_product.MODIFYTIME ;
            temp_product.MEMO_ZH = this.tb_memoZH.Text;
            temp_product.MEMO_EN = this.tb_memoEN.Text;
            temp_product.MEMO = this.rtb_memo.Text;
            temp_product.Save();
            MessageBox.Show("保存成功");
            this.Product = temp_product;
            this.DialogResult = DialogResult.OK;
        }
    }
}
