using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

namespace HYPDM.WinUI.graph
{
    [Module("0E489B9B-0838-453C-9E11-9012681F73FB", "关联零部件", "图纸管理")]
    public partial class PartsRegForm : UserControl
    {
        public PartsRegForm()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        { }
    }
}
