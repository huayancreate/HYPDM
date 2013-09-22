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
namespace HYPDM.WinUI.ProductsAndParts.Material
{
     [Module("9D1D5A0C-D7CE-471C-923C-A0A5102C9930", "材料", "材料管理")]
    public partial class MaterialsList : UserControl
    {
        public MaterialsList()
        {
            InitializeComponent();
            this.pagination1.LoadData += new HYPDM.WinUI.DefineControl.Pagination.LoadDataDelegate(InitGridList);
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
        private void add_Materail_Click(object sender, EventArgs e)
        {
            addMaterail();
        }

        //配置按钮操作
        private void conf_Materail_Click(object sender, EventArgs e)
        {
            confMaterail();
        }

        //删除按钮操作
        private void edit_Materail_Click(object sender, EventArgs e)
        {
            delMaterail();
        }

        //打印按钮操作
        private void print_Materail_Click(object sender, EventArgs e)
        {
            printMaterail();
        }

        //查询按钮操作
        private void query_Materail_Click(object sender, EventArgs e)
        {
            queryMaterail();
        }

        #endregion

        #region 右键菜单操作
        /************************************************************************
         ***************         ContextMenuStrip菜单操作     *******************
         ************************************************************************/

         //增加菜单操作
        private void add_materail_memu_Click(object sender, EventArgs e)
        {
            addMaterail();
        }
         //配置菜单操作
        private void conf_materail_memu_Click(object sender, EventArgs e)
        {
            confMaterail();
        }

         //删除菜单操作
        private void del_materail_memu_Click(object sender, EventArgs e)
        {
            delMaterail();
        }

        #endregion

        #region 列表操作
        /************************************************************************
        *****************         DataGridView列表的操作     ********************
        *************************************************************************/

        //列表数据初始化
        private IMaterailService m_IMaterailService;
        private void InitList()
        {
            this.m_IMaterailService = EAS.Services.ServiceContainer.GetService<IMaterailService>();
            this.pagination1.QueryCondition = new PDM_MATERAIL();
            InitGridList();
        }
        internal void InitGridList()
        {
            DataSet ds = m_IMaterailService.GetProductByPage((PDM_MATERAIL)this.pagination1.QueryCondition, this.pagination1.CurrentPage, this.pagination1.CurrentRows);
            this.dgv_MaterailList.DataSource = ds.Tables[2];
            this.pagination1.TotalPage = Convert.ToInt16(ds.Tables[1].Rows[0][0].ToString());
            this.pagination1.TotalRows = Convert.ToInt16(ds.Tables[1].Rows[0][1].ToString());
            this.pagination1.changeMemo();
            //this.dgv_MaterailList.DataSource = m_IMaterailService.GetMaterailList();
        }

         //右键操作
        private void dgv_MaterailList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dgv_MaterailList.Rows[e.RowIndex].Selected == false)
                    {
                        dgv_MaterailList.ClearSelection();
                        dgv_MaterailList.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dgv_MaterailList.SelectedRows.Count == 1)
                    {
                        dgv_MaterailList.CurrentCell = dgv_MaterailList.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    this.cms_Memu_Materail.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
        #endregion

        #region 自定义操作
        /************************************************************************
         ********************         自定义函数        *************************
         ************************************************************************/

         //添加一个记录
        private void addMaterail() {
            MaterailAddForm o = new MaterailAddForm();//1 表示产品
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                changePage();
            }
        }
         //配置一个记录
        private void confMaterail() {
            int rowIndex = dgv_MaterailList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_MaterailList.Rows[rowIndex];
            string t_id = row.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            MaterialConfForm o = new MaterialConfForm(t_id, 1);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
            changePage();

        }

         //删除一个记录
        private void delMaterail()
        {
            int rowIndex = this.dgv_MaterailList.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_MaterailList.Rows[rowIndex];
            string t_id = row.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }

            if (MessageBox.Show("您确认要删除所选择的产品记录？\n删除产品记录可能造成历史数据的查询错误。\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.m_IMaterailService.DelMaterailList(t_id);
                changePage();
            }
        }

         //打印记录
        private void printMaterail()
        {
           
        }

         //查询记录
        private void queryMaterail()
        {
            QueryMaterailForm o = new QueryMaterailForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                //this.dgv_MaterailList.DataSource = o._materailList;
                this.pagination1.QueryCondition = o.Mmaterail;
                changePage();
            }
        }

        private void changePage()
        {
            this.pagination1.CurrentPage = 1;
            this.pagination1.CurrentRows = 20;
            InitGridList();
        }
        #endregion

        private void regStardardFlow_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = this.dgv_MaterailList.CurrentRow;

            if (dgv == null)
            {
                return;
            }

            string material_id = dgv.Cells["MATERIALID"].Value.ToString();

            if (string.IsNullOrEmpty(material_id))
            {
                return;
            }
            if (material_id == null)
            {
                MessageBox.Show("请选择一条记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;

            }

            ///objectValue工作流模板
            string objectValue = WorkFlow.WorkFlow.NewInstance.GetWfTemplatesObject(DataType.RelationObjectType.Material.ToString()).WFT_ID;
            HYPDM.WinUI.WorkFlow.Flow.StandardFlow flow = new HYPDM.WinUI.WorkFlow.Flow.StandardFlow(material_id, DataType.RelationObjectType.Material, objectValue);
            flow.ShowDialog();
        }

        

    }
}
