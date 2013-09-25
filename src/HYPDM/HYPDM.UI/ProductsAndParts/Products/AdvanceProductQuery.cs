using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using HYPDM.WinUI.Util;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class AdvanceProductQuery : AddObjectParams.FrmAdvanceQuery
    {
        IAllProductService m_productService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
        public DataTable m_productList;
        public AdvanceProductQuery()
        {
            InitializeComponent();
            this.MasterTableName = "PDM_ALL_PRODUCT";
        }

        private void query_Product_Click(object sender, EventArgs e)
        {
            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            t_product.PRODUCTNO = no_Product.Text;
            t_product.VERSION = version_Product.Text;
            t_product.PRODUCTTYPE = type_Product.Text;
            t_product.STATUS = status_Product.Text;

            t_product.MODIFIER = mperson_Product.Text;
            t_product.CREATETIME = createDate_Product.Text;
            t_product.MODIFYTIME = modifyDate_Product.Text;
            t_product.MODELTYPE = model_Product.Text;
            m_productList = m_productService.GetProductList(t_product,this.AdvanceQueryString);
            this.DialogResult = DialogResult.OK;
        }
    }
}
