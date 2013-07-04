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
    [Module("A32CED04-0B8A-4C45-B075-D4B1CAF24DAF", "图纸初始化", "图纸管理")]
    public partial class InitGraphForm : UserControl
    {
        public InitGraphForm()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        { }
    }
}
