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
    public partial class ProductsCompForm : Form
    {
        public ProductsCompForm()
        {
            InitializeComponent();
            this.pagination1.LoadData += new HYPDM.WinUI.DefineControl.Pagination.LoadDataDelegate(LoadData);
        }

        public IList<string> compProductIDs;
        public IList<string> CompProductIDs {
            get { return this.compProductIDs; }
            set
            {
                this.compProductIDs = value;
                if (value != null) { MessageBox.Show(compProductIDs.Count.ToString()); }
                MessageBox.Show(compProductIDs.Count.ToString());
            }
        }
        public void LoadData() {
            MessageBox.Show(this.pagination1.PageRows.ToString());
            MessageBox.Show(this.pagination1.PageNum.ToString());
        }
    }
}
