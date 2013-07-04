using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYPDM.WinUI.BaseUI;

namespace HYPDM.WinUI.Document
{
    public partial class PhysicalFileRegForm : BaseForm
    {
        public PhysicalFileRegForm()
        {
            InitializeComponent();
        }

        private void btnRegDoc_Click(object sender, EventArgs e)
        {
            openFileDlg.ShowDialog();
        }
    }
}
