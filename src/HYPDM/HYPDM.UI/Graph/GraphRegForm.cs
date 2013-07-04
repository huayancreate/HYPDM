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
    [Module("3CB29DCB-E482-4DFD-BA34-D1A57999564A", "创建图纸", "图纸管理")]
    public partial class GraphRegForm : UserControl
    {
        public GraphRegForm()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        { }
    }
}
