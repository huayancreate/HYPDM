using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class ProductsStructAddForm : Form
    {
        public ProductsStructAddForm(HYPDM.Entities.PDM_PRODUCT t)
        {
            InitializeComponent();
            this.Text = "产品结构添加--" + t.PRODUCTID;
        }

        //所选择产品对应的数据
        HYPDM.Entities.PDM_PRODUCT copy_Product;
        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.copy_Product; }
            set
            {
                this.copy_Product = value;
            }
        }
    }
}
