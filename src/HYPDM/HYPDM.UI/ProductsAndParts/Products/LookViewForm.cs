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
    public partial class LookViewForm : Form
    {
        public LookViewForm()
        {
            InitializeComponent();
        }
        private string memo;
        public string Memo {
            get { return this.memo; }
            set { this.memo = value;
                if (value != null) {
                    this.memoBox.Text = value;
                }
            }
        }
    }
}
