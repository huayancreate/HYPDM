using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.DefineControl
{
    public partial class Pagination : UserControl
    {

        public delegate void LoadDataDelegate();
        public event LoadDataDelegate LoadData;

        //private int current_Page;
        //private int current_Rows;
        //private int total_Page;
        //private int total_Rows;
        public Pagination()
        {
            InitializeComponent();
        }

        
        //每页的记录数
        private int  page_Rows;
        public int PageRows
        {
            get { return Convert.ToInt16(this.pageRowsCtrl.Text); }
            set
            {
                this.page_Rows = value;
            }
        }

        //记录的页数
        private int page_Num;
        public int PageNum
        {
            get { return Convert.ToInt16(this.pageRowsCtrl.Text); }
            set
            {
                this.page_Num = value;
                this.pageNumCtrl.Text = page_Num.ToString();
            }
        }

        private void pageRowsCtrl_TextChanged(object sender, EventArgs e)
        {
            if (LoadData != null)
            {
                LoadData();
            }
        }

        private void pageNumCtrl_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        

        
    }
}
