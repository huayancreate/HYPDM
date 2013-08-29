using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.Document
{
    public partial class FrmShowSelectedObject : Form
    {
        public FrmShowSelectedObject()
        {
            InitializeComponent();
        }

        private DataTable dtDataList = new DataTable();

        public DataTable DtDataList
        {
            get { return dtDataList; }
            set { dtDataList = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShowSelectedObject_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            if (DtDataList != null)
            {
                this.dataGridViewExt1.DataSource = DtDataList;
            }
        }
    }
}
