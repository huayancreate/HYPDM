using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using EAS.Data.ORM;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class ProductsAssChangeListForm : Form
    {
        IPjtChangeService _pjtChangeService = EAS.Services.ServiceContainer.GetService<IPjtChangeService>();
        public ProductsAssChangeListForm()
        {
            InitializeComponent();
            dgv_ChangeList_Init();
        }

        //产品数据
        HYPDM.Entities.PDM_PRODUCT copy_Product;
        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.copy_Product; }
            set
            {
                this.copy_Product = value;
            }
        }

        //dgv_ChangeList列表初始化
        private void  dgv_ChangeList_Init(){
            this.dgv_ChangeList.DataSource = _pjtChangeService.GetList();
        }

        /*************************************************************
         **************      界面控件操作      ***********************
         ************************************************************/

        //详细查询界面
        private void toolDedtailQuery_Click(object sender, EventArgs e)
        {
            QueryChangeForm o = new QueryChangeForm();
            o.StartPosition=FormStartPosition.CenterParent;

            if(o.ShowDialog() == DialogResult.OK){
                //this.dgv_ChangeList.DataSource = null; 
                this.dgv_ChangeList.DataSource = o._changeList;
            }
        }
        //根据变更编号查询
        private void toolQuery_Click(object sender, EventArgs e)
        {
            Condition condition = PDM_PJTCHANGE.Create().CreateCondition();  
            if (!string.IsNullOrEmpty(this.toolQueryNo.Text))
            {
                condition.AddElement("PJTCHANGENO", this.toolQueryNo.Text, ElementType.Match);  
            }
            //this.dgv_ChangeList.DataSource = null;
            this.dgv_ChangeList.DataSource = _pjtChangeService.GetList(condition);
        }

        private void toolSelect_Click(object sender, EventArgs e)
        {
            //更新关联状态
            for (int i = 0; i < dgv_ChangeList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_ChangeList.Rows[i].Cells["Checkeddd"];
                if (Convert.ToBoolean(checkcell.Value)) { 
                   _pjtChangeService.updateAsso(1,dgv_ChangeList.Rows[i].Cells[1].Value.ToString());
                   _pjtChangeService.insertAsso(dgv_ChangeList.Rows[i].Cells[1].Value.ToString(),this.copy_Product.PRODUCTID);
                   DataGridViewCheckBoxCell ifcheck = (DataGridViewCheckBoxCell)dgv_ChangeList.Rows[i].Cells["IFASSO"];
                   ifcheck.Value = true;
                }
            }
            //
           
            //插入数据
        }

        private void dgv_ChangeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            for (int i = 0; i < dgv_ChangeList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_ChangeList.Rows[i].Cells[0];
                checkcell.Value = false;
            }
            DataGridViewCheckBoxCell ifcheck = (DataGridViewCheckBoxCell)dgv_ChangeList.Rows[e.RowIndex].Cells[0];
            ifcheck.Value = true;
        }

        private void toolLookView_Click(object sender, EventArgs e)
        {
            LookViewForm o = new LookViewForm();
            o.Text = "工程变更描述";
            int index = dgv_ChangeList.CurrentRow.Index;
            o.Memo = dgv_ChangeList.Rows[index].Cells["CHANGEREASON"].Value.ToString();
            o.ShowDialog();
        }

        private void toolClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
