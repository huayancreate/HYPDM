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
    [Module("2A728C57-1DB0-47D5-BAB9-61B949312EE7", "零部件信息", "零部件及结构管理")]
    public partial class PartsInfoForm : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {

        }

        public PartsInfoForm()
        {
            InitializeComponent();
        }

    }
}
