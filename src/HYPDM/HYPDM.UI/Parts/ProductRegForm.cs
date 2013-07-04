using EAS.Modularization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.parts
{
    [Module("76CDF0E3-F75E-42E5-91D9-00EB9CD55AF2", "创建产品", "零部件及结构管理")]
    public partial class ProductRegForm : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {

        }

        public ProductRegForm()
        {
            InitializeComponent();
        }

    }
}
