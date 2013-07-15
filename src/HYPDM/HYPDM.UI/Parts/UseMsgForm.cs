using EAS.Modularization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.WinUI.BaseUI;

namespace HYPDM.WinUI.Parts
{
    [Module("C282CBE9-C4B6-490B-ADAB-7BDDAA42D4CE", "零部件使用信息", "零部件及结构管理")]
    public partial class UseMsgForm : BaseForm
    {
        [ModuleStart]
        public void StartEx()
        {

        }

        public UseMsgForm()
        {
            InitializeComponent();
        }
    }
}
