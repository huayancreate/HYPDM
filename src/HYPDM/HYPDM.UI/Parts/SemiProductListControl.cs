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
using EAS.Data.ORM;

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
            this.PartsAdd();
        }

        private void PartsAdd()
        {
            SemiProductRegForm o = new SemiProductRegForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                PDM_PARTS parts = o.Parts;
                this.partsList.Insert(0, parts);

                this.partsBindingSource.DataSource = null;
                this.partsBindingSource.DataSource = partsList;
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            this.PartsDelete();
        }

        /// <summary>
        /// 记录删除
        /// </summary>
        protected void PartsDelete()
        {
            int rowIndex = dgvPartsList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvPartsList.Rows[rowIndex];

            HYPDM.Entities.PDM_PARTS parts = row.DataBoundItem as HYPDM.Entities.PDM_PARTS;

            if (parts == null)
            {
                return;
            }

            if (MessageBox.Show("您确认要删除所选择的半成品记录么？\n删除半成品记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                parts.Delete();
                //IProductDocumentService _proDocService = ServiceContainer.GetService<IProductDocumentService>();
                //IList<PDM_PRODUCT_DOCUMENT> proDocList;
                //proDocList = _proDocService.getProdocByProID(pro.PRODUCTID);
                //_proDocService.delProDoc(proDocList);
                this.dgvPartsList.Rows.Remove(row);
            }
        }

        // 记录添加
        private void cmRecordAdd_Click(object sender, EventArgs e)
        {
            this.PartsAdd();
        }

        // 记录属性
        private void cmRecordProperty_Click(object sender, EventArgs e)
        {
            this.PartsProperty();
        }

        // 记录删除
        private void cmRecordDelete_Click(object sender, EventArgs e)
        {
            this.PartsDelete();
        }

        private void btnProProperty_Click(object sender, EventArgs e)
        {
            this.PartsProperty();
        }

        /// <summary>
        /// 记录属性。
        /// </summary>
        protected void PartsProperty()
        {
            int rowIndex = dgvPartsList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvPartsList.Rows[rowIndex];

            HYPDM.Entities.PDM_PARTS parts = row.DataBoundItem as HYPDM.Entities.PDM_PARTS;

            if (parts == null)
            {
                return;
            }

            SemiProductRegForm o = new SemiProductRegForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o.Parts = parts;

            if (o.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_PARTS par = o.Parts;
                row.Cells["PartsNo"].Value = par.PARTSNO;
                row.Cells["Version"].Value = par.VERSION;
                row.Cells["Description"].Value = par.DESCRIPTION;
                row.Cells["PartsType"].Value = par.PARTSTYPE;
                row.Cells["PartsClassfication"].Value = par.PARTSCLASSFICATION;
                row.Cells["Status"].Value = par.STATUS;
                row.Cells["LastUpdateUser"].Value = par.LASTUPDATEUSER;
            }
        }

        private void dgvPartsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.PartsProperty();
        }

        private void dgvPartsList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvPartsList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvPartsList.ClearSelection();
                        dgvPartsList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvPartsList.SelectedRows.Count == 1)
                    {
                        dgvPartsList.CurrentCell = dgvPartsList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmSemiPro.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
