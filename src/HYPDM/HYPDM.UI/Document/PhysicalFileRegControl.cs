using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

namespace HYPDM.WinUI.document
{
    [Module("76E0C441-0ECF-4049-AB1F-2B264F21188A", "关联物理文件", "文档管理")]
    public partial class PhysicalFileRegControl : UserControl
    {
        public PhysicalFileRegControl()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }
    }
}
