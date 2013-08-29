using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

using EAS.Services;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Data.Linq;
namespace HYDocumentMS.BRM
{
    /// <summary>
    /// 
    /// </summary>
    [Module("{BF495E20-CD0B-4CAA-B455-BC8B3C545930}", "下拉框值", "下拉框值管理")]
    public partial class ComboboxValueControl : UserControl
    {
        IFileHelper helper = null;
        IComboBoxValueService _comboValue = ServiceContainer.GetService<ComboBoxValueService>();
        /// <summary>
        ///false为添加状态,true为修改状态
        /// </summary>
        //private Boolean operModifyStatus = false;

        //public Boolean OperModifyStatus
        //{
        //    get { return operModifyStatus; }
        //    set { operModifyStatus = value; }
        //}
        /// <summary>
        /// 
        /// </summary>
        public ComboboxValueControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        [ModuleStart]
        public void StartEx()
        {
            iniEvent();
        }
        DataTable dtTemp = null;
        private void iniEvent()
        {
            this.combType.SelectedValueChanged -= new EventHandler(combType_SelectedValueChanged);
            helper = new FileHelper();
            //  DataTable dt = helper.getDataTableBySql("*", "", "ComboBoxValue");
            this.dgvExt.DataSource = helper.getDataTableBySql("*", "", "ComboBoxValue");
            this.combType.DataSource = helper.getDataTableBySql("distinct COMBTYPE", "", "ComboBoxValue");
            this.combType.DisplayMember = "COMBTYPE";
            this.combType.ValueMember = "COMBTYPE";
            this.combType.SelectedIndex = -1;
            //  MessageBox.Show(this.combType.SelectedIndex.ToString());
            //if (this.combType.SelectedText.ToString() != null && this.combType.SelectedText.ToString() != "")
            //{
            //    dtTemp = new DataTable();
            //    helper = new FileHelper();
            //    // MessageBox.Show(this.combType.SelectedText.ToString());
            //    dtTemp = helper.getDataTableBySql("*", "WHERE COMBTYPE='" + this.combType.SelectedValue.ToString() + "'", "ComboBoxValue");
            //    DataRow dr = dtTemp.Rows[0];
            //    this.txtDesc.Text = dr["COMBDESC"].ToString();
            //}
            this.combType.SelectedValueChanged += new EventHandler(combType_SelectedValueChanged);

        }

        private void combType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (this.combType.SelectedIndex == -1)
            if (this.combType.Text == "")
            {
                MessageBox.Show("请选择或者输入需要添加的类型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                if (this.txtText.Text.ToString() == null || this.txtText.Text.ToString() == "")
                {
                    MessageBox.Show("文本值不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.txtText.Focus();
                    return;
                }

                if (this.txtValue.Text.ToString() != "")
                {
                    if (_comboValue.IsExsitsComboBoxValue(this.txtValue.Text.ToString(), this.combType.Text.ToString()))
                    {
                        MessageBox.Show("该value值已经存在请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.txtValue.Focus();
                        return;
                    }

                }


                ComboBoxValue cbv = new ComboBoxValue();
                string msg;
                //if (!this.OperModifyStatus)
                //{

                cbv.COMBID = Guid.NewGuid().ToString();
                msg = "添加成功";

                //}
                //else
                //{
                //    //cbv.COMBID = this.dgvExt.CurrentRow.Cells["COMBID"].Value.ToString();
                //   cbv= _comboValue.GetComboBoxItemByComboID(this.dgvExt.CurrentRow.Cells["COMBID"].Value.ToString());

                //    msg = "修改成功";
                //}
                cbv.COMBDESC = this.txtDesc.Text.ToString();
                cbv.COMBTYPE = this.combType.Text.ToString();
                cbv.COMBTEXT = this.txtText.Text.ToString();
                if (this.txtValue.Text.ToString() == "")
                {
                    //cbv.COMBVALUE = Guid.NewGuid().ToString();
                    cbv.COMBVALUE = cbv.COMBID;
                }
                else
                {
                    cbv.COMBVALUE = this.txtValue.Text.ToString();
                }
                cbv.Save();
                MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                // this.OperModifyStatus = false;
                iniEvent();
            }
        }

        private void combType_SelectedValueChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(this.combType.SelectedIndex.ToString());
            if (this.combType.SelectedIndex > -1)
            {
                dtTemp = new DataTable();
                helper = new FileHelper();
                //MessageBox.Show(this.combType.SelectedItem.ToString().ToString());
                //MessageBox.Show(this.combType.Text.ToString());
                //MessageBox.Show(this.combType.DisplayMember.ToString());
                dtTemp = helper.getDataTableBySql("*", "WHERE COMBTYPE='" + this.combType.SelectedValue.ToString() + "'", "ComboBoxValue");
                DataRow dr = dtTemp.Rows[0];
                this.txtDesc.Text = dr["COMBDESC"].ToString();
                //this.OperModifyStatus = false;
            }
        }

        private void tspModify_Click(object sender, EventArgs e)
        {
            //if (this.dgvExt.CurrentRow == null)
            //{
            //    MessageBox.Show("请选择需要修改的记录!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    return;
            //}
            //else
            //{  
            //   //// this.OperModifyStatus = true;
            //   // DataGridViewRow dr = this.dgvExt.CurrentRow;
            //   // this.combType.SelectedValue = dr.Cells["COMBTYPE"].Value.ToString();
            //   // this.txtText.Text = dr.Cells["COMBTEXT"].Value.ToString();
            //   // this.txtValue.Text = dr.Cells["COMBVALUE"].Value.ToString();
            //   // this.txtDesc.Text = dr.Cells["COMBDESC"].Value.ToString();
            //}
        }

        private void dgvExt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvExt.CurrentRow == null)
            {
                MessageBox.Show("请选择需要修改的记录!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                FrmEditComboValue frmedit = new FrmEditComboValue();
                frmedit.SelectedComboBoxItem = _comboValue.GetComboBoxItemByComboID(this.dgvExt.CurrentRow.Cells["COMBID"].Value.ToString());
                frmedit.ShowDialog();
                if (frmedit.DialogResult == DialogResult.OK)
                {
                    this.dgvExt.DataSource = helper.getDataTableBySql("*", "", "ComboBoxValue");
                }
            }
        }
    }
}
