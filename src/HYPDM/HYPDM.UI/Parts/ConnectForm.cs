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
    [Module("D0858289-34AA-4565-9D24-7F1ACE55E910", "关联其他对象", "零部件及结构管理")]
    public partial class ConnectForm : UserControl
    {
        [ModuleStart]
        public void StartEx()
        {
        }

        public ConnectForm()
        {
            InitializeComponent();
        }

    }
}
