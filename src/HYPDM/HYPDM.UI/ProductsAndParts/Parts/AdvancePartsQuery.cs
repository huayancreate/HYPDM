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

namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    public partial class AdvancePartsQuery : AddObjectParams.FrmAdvanceQuery
    {
        IAllPartsService m_partsService = EAS.Services.ServiceContainer.GetService<IAllPartsService>();
        public DataTable m_partsList;

        public AdvancePartsQuery()
        {
            InitializeComponent();
            this.MasterTableName = "PDM_ALL_PRODUCT";
        }

        private void query_Product_Click(object sender, EventArgs e)
        {
            Condition condition = PDM_ALL_PRODUCT.Create().CreateCondition();


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
            if (!string.IsNullOrEmpty(createDate_Product.Text))
            {
                condition.AddElement("MODIFYTIME", createDate_Product.Text);
            }
            condition.AddElement("PRODUCTLEVEL", 2);

            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            t_product.PRODUCTNO = no_Product.Text;
            t_product.VERSION = version_Product.Text;
            t_product.PRODUCTTYPE = type_Product.Text;
            t_product.STATUS = status_Product.Text;

            t_product.MODIFIER = mperson_Product.Text;
            t_product.CREATETIME = createDate_Product.Text;
            t_product.MODIFYTIME = modifyDate_Product.Text;
            t_product.MODELTYPE = model_Product.Text;

            m_partsList = m_partsService.GetProductList(t_product, this.AdvanceQueryString);
            this.DialogResult = DialogResult.OK;
        }
    }
}
