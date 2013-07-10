using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYPDM.BLL;
using EAS.Data.ORM;
using HYPDM.WinUI.parts;

namespace HYPDM.WinUI.Parts
{
    [Module("A6F9DA33-FC28-445F-ACC2-F1516BA9F5B8", "产品列表", "产品零部件管理")]
    public partial class ProductListControl : UserControl
    {
        public ProductListControl()
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
            this.InitList();
        }

        private IList<HYPDM.Entities.PDM_PRODUCT> productList;
        private void InitList()
        {
            DateTime d0 = DateTime.Now;
            this.productList = EAS.Services.ServiceContainer.GetService<IProductService>().GetProductList();
            this.InitList(productList);
        }
        /// <summary>
        /// 将指定的数据源中的记录绑定到列表。
        /// </summary>
        internal void InitList(IList<HYPDM.Entities.PDM_PRODUCT> list)
        {
            this.proBindingSource.DataSource = null;
            this.proBindingSource.DataSource = list;
        }


        private void btnProToAdd_Click(object sender, EventArgs e)
        {
            this.ProAdd();
        }

        /// 记录添加。
        /// </summary>
        protected void ProAdd()
        {
            ProductRegForm o = new ProductRegForm();

            o.StartPosition = FormStartPosition.CenterParent;

            if (o.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_PRODUCT pro = o.Product;

                //添加到列表上
                this.productList.Insert(0, pro);

                this.proBindingSource.DataSource = null;
                this.proBindingSource.DataSource = this.productList;
            }
        }

        /// <summary>
        /// 记录属性。
        /// </summary>
        protected void ProProperty()
        {
            int rowIndex = dgvProList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvProList.Rows[rowIndex];

            HYPDM.Entities.PDM_PRODUCT product = row.DataBoundItem as HYPDM.Entities.PDM_PRODUCT;

            if (product == null)
            {
                return;
            }

            ProductRegForm o = new ProductRegForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o.Product = product;

            if (o.ShowDialog() == DialogResult.OK)
            {
                HYPDM.Entities.PDM_PRODUCT pro = o.Product;
                row.Cells["ProName"].Value = pro.PRODUCTNAME.ToString();
                row.Cells["Version"].Value = pro.VERSION;
                row.Cells["ModelNo"].Value = pro.MODELNO;
                row.Cells["ProSize"].Value = pro.SIZE;
                row.Cells["TechName"].Value = pro.TECHNAME;
                row.Cells["TechInstruction"].Value = pro.TECHINSTRUCTION;
                row.Cells["ProStatus"].Value = pro.PRODUCTSTATUS;
                row.Cells["ProNoAttr"].Value = pro.PRODUCTNOATTR;
                row.Cells["Property"].Value = pro.PROPERTY;
                row.Cells["WorkCenter"].Value = pro.WORKCENTER;
                row.Cells["Remark"].Value = pro.REMARK;
            }
        }

        private void btnProProperty_Click(object sender, EventArgs e)
        {
            this.ProProperty();
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            this.ProDelete();
        }

        /// <summary>
        /// 记录删除
        /// </summary>
        protected void ProDelete()
        {
            int rowIndex = dgvProList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgvProList.Rows[rowIndex];

            HYPDM.Entities.PDM_PRODUCT pro = row.DataBoundItem as HYPDM.Entities.PDM_PRODUCT;

            if (pro == null)
            {
                return;
            }

            if (MessageBox.Show("您确认要删除所选择的产品记录么？\n删除文档记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pro.Delete();
                this.dgvProList.Rows.Remove(row);
            }
        }

        private void dgvProList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ProProperty();
        }

        private void dgvProList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgvProList.Rows[e.RowIndex].Selected == false)
                    {
                        dgvProList.ClearSelection();
                        dgvProList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgvProList.SelectedRows.Count == 1)
                    {
                        dgvProList.CurrentCell = dgvProList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cmProduct.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
