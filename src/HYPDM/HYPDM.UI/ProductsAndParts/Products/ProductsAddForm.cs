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
        public ProductsAddForm()
        {
            InitializeComponent();
        }

        HYPDM.Entities.PDM_PRODUCT copy_Product;
        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.copy_Product; }
            set
            {
                this.copy_Product = value;
            }
        }
        //保存按钮操作
        private void save_Product_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_PRODUCT temp_Product = new HYPDM.Entities.PDM_PRODUCT();
           // temp_Product=this.Product;
            temp_Product.PRODUCTID=no_Product.Text;
            temp_Product.VERSION= version_Product.Text;
            temp_Product.PRODUCTTYPE=type_Product.Text;
            temp_Product.PRODUCTSTATUS=status_Product.Text;
            temp_Product.LASTUPDATEUSER= mperson_Product.Text;
            temp_Product.LASTUPDATEDATE=creatDate_Product.Text;
            temp_Product.LASTUPDATEDATE=modifyDate_Product.Text;
            temp_Product.REMARK= zhMemo_Product.Text;
            temp_Product.ENGDESCRIPTION = enMemo_Product.Text;
            temp_Product.Save();
            MessageBox.Show("保存成功");
            this.Product = temp_Product;
            this.DialogResult = DialogResult.OK;
        }
    }
}
