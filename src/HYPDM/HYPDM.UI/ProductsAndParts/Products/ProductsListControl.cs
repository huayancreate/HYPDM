﻿using System;
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


        #region 工具栏操作
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
        #endregion 
        
        #region 右键菜单操作
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
        #endregion

        #region 列表操作
        /************************************************************************
        *****************         DataGridView列表的操作     ********************
        *************************************************************************/

        //列表数据初始化
        private IAllProductService m_AllProductService;
        private void InitList()
        {
            this.m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
            this.dgv_ProductList.DataSource = m_AllProductService.GetProductList();
        }
        internal void InitGridList()
        {
            this.dgv_ProductList.DataSource = m_AllProductService.GetProductList();
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
        #endregion

        #region 自定义操作
        /************************************************************************
         ********************         自定义函数        *************************
         ************************************************************************/
        
        //添加一个产品记录
        private void addProduct() {
            ProductsAddForm o = new ProductsAddForm(1);//1 表示产品
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                InitGridList();
               /* PDM_ALL_PRODUCT temp = o.Product;
                DataRow _newRow = m_productList.NewRow();
                _newRow["PRODUCTNO"] = temp.PRODUCTNO;
                _newRow["MODELTYPE"] = temp.MODELTYPE;
                _newRow["PRODUCTTYPE"] = temp.PRODUCTTYPE;
                _newRow["VERSION"] = temp.VERSION;
                _newRow["STATUS"] = temp.STATUS;
                _newRow["CREATER"] = temp.CREATER;
                _newRow["CREATETIME"] = temp.CREATETIME;
                this.m_productList.Rows.Add(_newRow);
                this.dgv_ProductList.DataSource = null;
                this.dgv_ProductList.DataSource = m_productList;*/
            }
        }

        //配置一个产品记录
        private void confProduct()
        {
            int rowIndex = dgv_ProductList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_ProductList.Rows[rowIndex];
            string t_id = row.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            ProductsConfForm o = new ProductsConfForm(t_id,1);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
           // if (o.ShowDialog() == DialogResult.OK)
           // {
            this.InitGridList();
           // }
        }

        //删除一个产品记录
        private void  delProduct()
        {
            int rowIndex = dgv_ProductList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_ProductList.Rows[rowIndex];
            string t_id = row.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }

            if (MessageBox.Show("您确认要删除所选择的产品记录？\n删除产品记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                m_AllProductService.DelProductList(t_id);
                this.InitGridList();
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
                this.dgv_ProductList.DataSource = o._productList;
            }
        }
#endregion
    }
}
