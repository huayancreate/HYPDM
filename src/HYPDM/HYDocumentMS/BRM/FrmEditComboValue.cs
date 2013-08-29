using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using    HYPDM.Entities;
using EAS.Services;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Data.Linq;
namespace HYDocumentMS.BRM
{
    public partial class FrmEditComboValue : Form
    {
        IComboBoxValueService _comboValue = ServiceContainer.GetService<ComboBoxValueService>();
        public FrmEditComboValue()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        private ComboBoxValue selectedComboBoxItem = null;

        public ComboBoxValue SelectedComboBoxItem
        {
            get { return selectedComboBoxItem; }
            set { selectedComboBoxItem = value; }
        }
        private void FrmEditComboValue_Load(object sender, EventArgs e)
        {
            if (SelectedComboBoxItem == null)
            {
                MessageBox.Show("请选择需要修改的数据项目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
            else
            {
                this.combType.Text = SelectedComboBoxItem.COMBTYPE;
                this.txtText.Text = SelectedComboBoxItem.COMBTEXT.ToString();
                this.txtValue.Text = SelectedComboBoxItem.COMBVALUE.ToString();
                this.txtDesc.Text = SelectedComboBoxItem.COMBDESC.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtValue.Text.ToString() != "")
            {
                if (_comboValue.IsExsitsComboBoxValue(this.txtValue.Text.ToString(), this.combType.Text.ToString(),selectedComboBoxItem.COMBID.ToString()))
                {
                    MessageBox.Show("该value值已经存在请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.txtValue.Focus();
                    return;
                }
                SelectedComboBoxItem.COMBVALUE = this.txtValue.Text.ToString();

            }
            else
            {
                SelectedComboBoxItem.COMBVALUE = SelectedComboBoxItem.COMBID;
            }
            SelectedComboBoxItem.COMBDESC = this.txtDesc.Text.ToString();
            SelectedComboBoxItem.COMBTYPE = this.combType.Text.ToString();
            SelectedComboBoxItem.COMBTEXT = this.txtText.Text.ToString();
            //if (this.txtValue.Text.ToString() == "")
            //{
            //    //cbv.COMBVALUE = Guid.NewGuid().ToString();
            //    SelectedComboBoxItem.COMBVALUE = SelectedComboBoxItem.COMBID;
            //}
            //else
            //{   
            //    SelectedComboBoxItem.COMBVALUE = this.txtValue.Text.ToString();
            //}
            SelectedComboBoxItem.Save();
            DialogResult = DialogResult.OK;
            MessageBox.Show("修改成功!!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
