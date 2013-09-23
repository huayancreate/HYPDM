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
    public partial class QueryProductsForm : Form
    {
        IAllProductService m_productService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
        public DataTable m_productList;
        public QueryProductsForm()
        {
            InitializeComponent();
            if (query_Product.Image != null)
            {
                query_Product.Image = new Bitmap(query_Product.Image, query_Product.Height/2, query_Product.Height/2);
            }
        }
        private void query_Product_Click(object sender, EventArgs e)
        {
            /*Condition condition = PDM_ALL_PRODUCT.Create().CreateCondition();
            if (!string.IsNullOrEmpty(no_Product.Text))
            {
                condition.AddElement("PRODUCTNO", no_Product.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(version_Product.Text))
            {
                condition.AddElement("VERSION", version_Product.Text);
            }
            if (!string.IsNullOrEmpty(type_Product.Text))
            {
                condition.AddElement("PRODUCTTYPE", type_Product.Text);
            }
            if (!string.IsNullOrEmpty(status_Product.Text))
            {
                condition.AddElement("STATUS", status_Product.Text);
            }
            if (!string.IsNullOrEmpty(mperson_Product.Text))
            {
                condition.AddElement("MODIFIER", mperson_Product.Text, ElementType.Match);
            }
            if (!string.IsNullOrEmpty(modifyDate_Product.Text))
            {
                condition.AddElement("MODIFYTIME", modifyDate_Product.Text);
            }
            condition.AddElement("PRODUCTLEVEL", 1);
          */
            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            t_product.PRODUCTNO = no_Product.Text;
            t_product.VERSION = version_Product.Text;
            m_productList = m_productService.GetProductList(t_product);
            this.DialogResult = DialogResult.OK;
        }
    }
}
