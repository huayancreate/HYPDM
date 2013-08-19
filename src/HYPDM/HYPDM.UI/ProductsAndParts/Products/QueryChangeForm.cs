using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.BLL;
using HYPDM.Entities;
using EAS.Data.ORM;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class QueryChangeForm : Form
    {
        IPjtChangeService _changeService = EAS.Services.ServiceContainer.GetService<IPjtChangeService>();
        public IList<PDM_PJTCHANGE> _changeList;
        public QueryChangeForm()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Condition condition = PDM_PJTCHANGE.Create().CreateCondition();

            if (!string.IsNullOrEmpty(this.changeNo.Text))
            {
                condition.AddElement("PJTCHANGENO", changeNo.Text);
            }
            if (!string.IsNullOrEmpty(changeTime.Text.Trim()))
            {
                condition.AddElement("CHANGETIME", changeTime.Text + " 00:00:00", ElementType.GreaterThanAndEqualTo);
                condition.AddElement("CHANGETIME", changeTime.Text + " 23:59:59", ElementType.LessThanAndEqualTo);
            }
            if (!string.IsNullOrEmpty(changePerson.Text))
            {
                condition.AddElement("CHANGEPERSON", changePerson.Text);
            }
            if (!string.IsNullOrEmpty(changeStatus.Text))
            {
                condition.AddElement("CHANGESTATUS", changeStatus.Text, ElementType.Match);
            }
            if ((changeAssoNo.Checked ^ changeAssoYes.Checked))
            {
                if (changeAssoNo.Checked)
                {
                    condition.AddElement("IFASSO", 0);
                }
                else {
                    condition.AddElement("IFASSO", 1);
                }
            }

            _changeList = _changeService.GetList(condition);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
