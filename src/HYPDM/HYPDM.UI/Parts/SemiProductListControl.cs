using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;

namespace HYPDM.WinUI.Parts
{
    [Module("F8925C0D-72A0-4E8C-988D-E9DD72BA714C", "半成品", "半成品管理")]
    public partial class PartsListControl : UserControl
    {
        private IList<HYPDM.Entities.PDM_PARTS> partsList;
        public PartsListControl()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            DateTime t = DateTime.Now;
            this.partsList = ServiceContainer.GetService<IPartsService>().getListByPartsClass("0");
            this.partsBindingSource.DataSource = null;
            this.partsBindingSource.DataSource = partsList;
        }

        private void btnProToAdd_Click(object sender, EventArgs e)
        {
            SemiProductRegForm o = new SemiProductRegForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if(o.ShowDialog() == DialogResult.OK)
            {
                PDM_PARTS parts = o.Parts;
                this.partsList.Insert(0,parts);

                this.partsBindingSource.DataSource = null;
                this.partsBindingSource.DataSource = partsList;
            }
        }
    }
}
