using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Services;
using EAS.Data.ORM;

namespace HYPDM.WinUI.Parts
{
    public partial class ConnectionFilterForm : Form
    {
        private String productID = ProductRegForm.productID;
        IFilterService _filterService = ServiceContainer.GetService<IFilterService>();
        IList<PDM_FILTER> filterList = new List<PDM_FILTER>();
        PDM_FILTER filter;
        public ConnectionFilterForm()
        {
            InitializeComponent();
            InitialList();
        }

        public HYPDM.Entities.PDM_FILTER Filter
        {
            get { return this.filter; }
            set
            {
                this.filter = value;
                if (value != null)
                    this.InitFilterInfo();
            }
        }

        private void InitFilterInfo()
        {
            if (this.Filter != null)
            {
                if (this.Filter.OWNERSHIP == "PUBLIC")
                {
                    this.radPublic.Checked = true;
                }
                else
                {
                    this.radPrivate.Checked = true;
                }
                if (this.Filter.VIEWER == true)
                {
                    this.chkView.Checked = true;
                }
                this.txtPartsNo.Text = this.Filter.PARTSNO;
                this.txtVersion.Text = this.Filter.VERSION;
                this.cobVersionType.Text = this.Filter.VERSIONTYPE;
                this.dtpFrom.Text = this.Filter.FROMDATE;
                this.dtpTo.Text = this.Filter.TODATE;
                this.txtSortCode.Text = this.Filter.SORTCODE;
                this.txtSpecificationCode.Text = this.Filter.SPECIFICATIONCODE;
                this.txtDescription.Text = this.Filter.DESCRIPTION;
                this.txtQuantity.Text = this.Filter.QUANTITY;
                this.txtSingleNetweight.Text = this.Filter.SINGLENETWEIGHT;
                this.cobSurfaceSolve.Text = this.Filter.SURFACESOLVE;
                this.txtFilterName.Text = this.Filter.FILTERNAME;
            }
        }

        private void InitialList()
        {
            filterList = _filterService.getFilterList(productID);
            this.filterBindingSource.DataSource = null;
            this.filterBindingSource.DataSource = filterList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 过滤器名称不能为空
            if (this.txtFilterName.Text.Trim() == "")
            {
                MessageBox.Show("请输入过滤器名称");
                return;
            }
            PDM_FILTER filter = new PDM_FILTER();
            // 保存新建过滤器时
            if (this.filter == null)
            {
                filter.ID = _filterService.GetMaxID().ToString();
            }
            else 
            {
                filter.ID = this.filter.ID;
            }
            // 所有权
            if (this.radPublic.Checked)
            {
                filter.OWNERSHIP = "PUBLIC";
            }
            else
            {
                filter.OWNERSHIP = "PRIVATE";
            }
            // 视图
            if (this.chkView.Checked)
            {
                filter.VIEWER = true;
            }
            else
            {
                filter.VIEWER = false;
            }
            filter.PARTSNO = this.txtPartsNo.Text;
            filter.VERSION = this.txtVersion.Text;
            filter.VERSIONTYPE = this.cobVersionType.Text;
            filter.FROMDATE = this.dtpFrom.Value.ToString();
            filter.TODATE = this.dtpTo.Value.ToString();
            filter.SORTCODE = this.txtSortCode.Text;
            filter.SPECIFICATIONCODE = this.txtSpecificationCode.Text;
            filter.DESCRIPTION = this.txtDescription.Text;
            filter.QUANTITY = this.txtQuantity.Text;
            filter.SINGLENETWEIGHT = this.txtSingleNetweight.Text;
            filter.SURFACESOLVE = this.cobSurfaceSolve.Text;
            filter.FILTERNAME = this.txtFilterName.Text;
            filter.PRODUCTID = productID;
            filter.Save();
            this.InitialList();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFilterName.Text = "";
        }

        private void dgvFilterList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ViewFilter();
        }

        /// <summary>
        /// 选择一个过滤器
        /// </summary>
        private void ViewFilter()
        {
            int rowIndex = dgvFilterList.CurrentCell.RowIndex;

            if (rowIndex < 0)
            {
                MessageBox.Show("请选择一个过滤器");
                return;
            }

            DataGridViewRow row = dgvFilterList.Rows[rowIndex];

            HYPDM.Entities.PDM_FILTER filter = row.DataBoundItem as HYPDM.Entities.PDM_FILTER;

            if (filter == null)
            {
                return;
            }

            this.Filter = filter;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.ViewFilter();
            this.DialogResult = DialogResult.OK;
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvFilterList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvFilterList.Rows[rowIndex];

            HYPDM.Entities.PDM_FILTER filter = row.DataBoundItem as HYPDM.Entities.PDM_FILTER;

            filter.Delete();
        }

        private void dgvFilterList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    for (int i = 0; i < this.dgvFilterList.RowCount; i++)
                    {
                        dgvFilterList.Rows[i].Cells[0].Value = false;
                    }
                    dgvFilterList.Rows[e.RowIndex].Cells[0].Value = true;
                    //若行已是选中状态就不再进行设置
                    if (dgvFilterList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvFilterList.ClearSelection();
                        dgvFilterList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvFilterList.SelectedRows.Count == 1)
                    {
                        dgvFilterList.CurrentCell = dgvFilterList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmFilter.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void cmSelect_Click(object sender, EventArgs e)
        {
            this.ViewFilter();
            this.DialogResult = DialogResult.OK;
        }

    }
}
