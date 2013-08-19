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
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    [Module("BC7555A2-2FBE-43BE-9D4A-894ED11D9890", "产品", "产品管理")]
    public partial class ProductsListControl : UserControl
    {
        public IList<PDM_PRODUCT> _productList;
        public ProductsListControl()
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

       

        /************************************************************************
         ***************     ToolStrip 工具栏中的按钮操作     *******************
         ************************************************************************/

        //添加按钮操作 
        private void add_Product_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        //配置按钮操作
        private void conf_Product_Click(object sender, EventArgs e)
        {
            confProduct();
        }

        //删除按钮操作
        private void del_Product_Click(object sender, EventArgs e)
        {
            delProduct();
        }

        //打印按钮操作
        private void print_Product_Click(object sender, EventArgs e)
        {
            printProduct();
        }

        //查询按钮操作
        private void query_Product_Click(object sender, EventArgs e)
        {
            queryProduct();
        }

        /************************************************************************
         ***************         ContextMenuStrip菜单操作     *******************
         ************************************************************************/

        //添加菜单操作
        private void add_Product_Menu_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        //删除菜单操作
        private void del_Memu_Product_Click(object sender, EventArgs e)
        {
            delProduct();
        }

        //配置菜单操作
        private void conf_Menu_Product_Click(object sender, EventArgs e)
        {
            confProduct();
        }

        /************************************************************************
        *****************         DataGridView列表的操作     ********************
        *************************************************************************/

        //列表数据初始化
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
            this.bs_Data_Product.DataSource = null;
            this.bs_Data_Product.DataSource = list;
        }

        //DataGridView单选控制
        private void dgv_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
              for (int i = 0; i < dgv_ProductList.Rows.Count; i++)
              {
                  DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_ProductList.Rows[i].Cells[0];
                  checkcell.Value = false;
              }
              DataGridViewCheckBoxCell ifcheck = (DataGridViewCheckBoxCell)dgv_ProductList.Rows[e.RowIndex].Cells[0];
              ifcheck.Value = true;
        }
        
        //鼠标右键单击操作 
        private void dgv_ProductList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgv_ProductList.Rows[e.RowIndex].Selected == false)
                    {
                        dgv_ProductList.ClearSelection();
                        dgv_ProductList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgv_ProductList.SelectedRows.Count == 1)
                    {
                        dgv_ProductList.CurrentCell = dgv_ProductList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    cm_Memu_Product.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        //鼠标左键双击操作
        private void dgv_ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            confProduct();
        }


        /************************************************************************
         ********************         自定义函数        *************************
         ************************************************************************/
        
        //添加一个产品记录
        private void addProduct() {
            ProductsAddForm o = new ProductsAddForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                PDM_PRODUCT parts = o.Product;
                this.productList.Insert(0, parts);

                this.bs_Data_Product.DataSource = null;
                this.bs_Data_Product.DataSource = productList;
            }
        }

        //配置一个产品记录
        private void confProduct()
        {
            int rowIndex = dgv_ProductList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_ProductList.Rows[rowIndex];

            HYPDM.Entities.PDM_PRODUCT product = row.DataBoundItem as HYPDM.Entities.PDM_PRODUCT;

            if (product == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            ProductsConfForm o = new ProductsConfForm(product);
            o.StartPosition = FormStartPosition.CenterParent;
            o.Product = product;

            if (o.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("更新记录"); 
            }
        }

        //删除一个产品记录
        private void  delProduct()
        {
            int rowIndex = dgv_ProductList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_ProductList.Rows[rowIndex];

            HYPDM.Entities.PDM_PRODUCT t_product = row.DataBoundItem as HYPDM.Entities.PDM_PRODUCT;

            if (t_product == null)
            {
                return;
            }

            if (MessageBox.Show("您确认要删除所选择的产品记录？\n删除产品记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                t_product.Delete();
                this.dgv_ProductList.Rows.Remove(row);
            }
        }

        //打印一个产品记录
        private void printProduct()
        {
            ProductsConfForm o = new ProductsConfForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                // PDM_PARTS parts = o.Parts;
                // this.partsList.Insert(0, parts);

                // this.partsBindingSource.DataSource = null;
                // this.partsBindingSource.DataSource = partsList;
            }
        }

        //查询一个产品记录
        private void queryProduct()
        {
            ProductsQueryForm o = new ProductsQueryForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                _productList =o._productList;
                this.dgv_ProductList.DataSource = _productList;
            }
        }
    }
}
