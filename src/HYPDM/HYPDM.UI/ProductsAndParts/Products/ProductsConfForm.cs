using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class ProductsConfForm : Form
    {
        
        public ProductsConfForm()
        {
            InitializeComponent();
        }
        public ProductsConfForm(HYPDM.Entities.PDM_PRODUCT t)
        {
            InitializeComponent();
            dgvProduct_Init(t);
            dgv_ProRecord_init(t);
            dgv_Change_init(t);
            list_productTreeStruct_init(t);//AddItems(); //this.Load += new System.EventHandler(this.TryTreeListView_Load);
        }
        //产品数据
        HYPDM.Entities.PDM_PRODUCT copy_Product;
        public HYPDM.Entities.PDM_PRODUCT Product
        {
            get { return this.copy_Product; }
            set
            {
                this.copy_Product = value;
                if (value != null) { initShowData(); }
            }
        }

        /************************************************************************
         ************************         初始化        *************************
         ************************************************************************/

        //初始化产品显示数据
        private void initShowData() {
            if (this.copy_Product != null)
            {
                this.no_Product.Text = this.copy_Product.PRODUCTID;
            }
        }
        

        #region 版本tab页面操作
        /************************************************************************
         *******************         版本tab页面操作        *********************
         ************************************************************************/

        ///
        /// 变量定义*************************************************************
        ///
        IProductService _productService = EAS.Services.ServiceContainer.GetService<IProductService>();
        public IList<PDM_PRODUCT> _productList;
        ///
        /// 页面控件初始化********************************************************
        ///
        
        //dgv_Product（产品列表）
        private void dgvProduct_Init(HYPDM.Entities.PDM_PRODUCT t)
        {
            if (t != null)
            {
                Condition condition = PDM_PRODUCT.Create().CreateCondition();
                condition.AddElement("PRODUCTID", t.PRODUCTID, ElementType.MatchPrefix);
                var list = _productService.GetProductList(condition);
                this.dgv_Product.DataSource = list;
            }
        }

        ///
        /// 页面控件操作***********************************************************
        ///
        //toolVersionCompare（比较按钮操作）
        private void toolVersionCompare_Click(object sender, EventArgs e)
        {
            IList<string> _compList=new List<string>();
            for (int i = 0; i < dgv_Product.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_Product.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if(flag){
                   string productId= dgv_Product.Rows[i].Cells[0].Value.ToString().Trim();
                   _compList.Add(productId);
                }
            }
            if (_compList.Count < 2) {
                MessageBox.Show("请选择需要比较的两个产品"); return;
            }
            if (_compList.Count > 2)
            {
                MessageBox.Show("只能选择两个产品"); return;
            }

            ProductsCompForm o = new ProductsCompForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o.compProductIDs = _compList;
            o.ShowDialog();
            
        }
        //toolVersionQuery（查询按钮操作）
        private void toolVersionQuery_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.toolVersionNo.Text))
            {
                Condition condition = PDM_PRODUCT.Create().CreateCondition();
                condition.AddElement("PRODUCTID", this.toolVersionNo.Text, ElementType.Match);
                var list = _productService.GetProductList(condition);
                this.dgv_Product.DataSource = list;
            }
            else {
                MessageBox.Show("请输入产品编号");
            }
               
        }
        // dgv_Product（列表checkbox操作）
        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            DataGridViewCheckBoxCell ifcheck = (DataGridViewCheckBoxCell)dgv_Product.Rows[e.RowIndex].Cells[0];
            Boolean flag = Convert.ToBoolean(ifcheck.Value);
            if (flag)
            { ifcheck.Value = false; }
            else { ifcheck.Value = true ; }
        }
        #endregion


        #region 产品生产记录tab页面操作
        /************************************************************************
        *******************     产品生产记录tab页面操作     *********************
        ************************************************************************/

        ///
        /// 变量定义*************************************************************
        ///
        IProductProRecordService _proRecordService = EAS.Services.ServiceContainer.GetService<IProductProRecordService>();
        public IList<PDM_PRODUCT_PRORECORD> _proRecordList;
        
        ///
        /// 页面控件初始化********************************************************
        ///
        
        //dgv_ProRecord表格数据初始化
        private void dgv_ProRecord_init(HYPDM.Entities.PDM_PRODUCT t) {
            if (t != null)
            {
                Condition condition = PDM_PRODUCT_PRORECORD.Create().CreateCondition();
                condition.AddElement("PRUDUCTID", t.PRODUCTID, ElementType.MatchPrefix);
                var list = _proRecordService.GetProductList(condition);
                _proRecordList = list;
                this.dgv_ProRecord.DataSource = list;
            }
        }

        ///
        /// 页面控件操作***********************************************************
        ///
        //产品生产记录增加按钮操作
        private void toolProRecordAdd_Click(object sender, EventArgs e)
        {
            
            ProductsProRecordAddForm o = new ProductsProRecordAddForm();
            o._ProductId = this.copy_Product.PRODUCTID; 
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK)
            {
                PDM_PRODUCT_PRORECORD record = o.Record;
                this._proRecordList.Insert(0, record);

                this.bs_Data_ProRecord.DataSource = null;
                this.bs_Data_ProRecord.DataSource = _proRecordList;
            }
        }

        //产品生产记录修改按钮操作
        private void toolProRecordEdit_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_ProRecord.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_ProRecord.Rows[rowIndex];

            HYPDM.Entities.PDM_PRODUCT_PRORECORD record = row.DataBoundItem as HYPDM.Entities.PDM_PRODUCT_PRORECORD;

            if (record == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            ProductsProRecordAddForm o = new ProductsProRecordAddForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o._ProductId = this.copy_Product.PRODUCTID; 
            o.Record = record;

            if (o.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("更新记录");
            }
        }
        #endregion


        #region 产品变更记录tab页面操作
        /************************************************************************
       *******************     产品变更记录tab页面操作     *********************
       ************************************************************************/

        ///
        /// 变量定义*************************************************************
        ///
        IPjtChangeService _pjtChangeService = EAS.Services.ServiceContainer.GetService<IPjtChangeService>();
        ///
        /// 页面控件初始化********************************************************
        ///
        //dgv_Change表格数据初始化
        private void dgv_Change_init(HYPDM.Entities.PDM_PRODUCT t)
        {
            if (t != null)
            {
                this.dgv_Change.DataSource = _pjtChangeService.GetAssoList(t.PRODUCTID);
            }
        }

        private void toolChangeAdd_Click(object sender, EventArgs e)
        {
            ProductsAssChangeListForm o = new ProductsAssChangeListForm();
            o.StartPosition = FormStartPosition.CenterParent;
            o.Product = copy_Product;
            o.ShowDialog();
            this.dgv_Change.DataSource = _pjtChangeService.GetAssoList(this.copy_Product.PRODUCTID);
        }

        private void toolChangeDel_Click(object sender, EventArgs e)
        {
            int index= dgv_Change.CurrentRow.Index;
            _pjtChangeService.deleteAsso(dgv_Change.Rows[index].Cells[0].Value.ToString(),this.copy_Product.PRODUCTID);
            _pjtChangeService.updateAsso(0, dgv_Change.Rows[index].Cells[0].Value.ToString());
            this.dgv_Change.DataSource = _pjtChangeService.GetAssoList(this.copy_Product.PRODUCTID);
        }
        ///
        /// 页面控件操作***********************************************************
        ///

        #endregion

        #region 产品结构tab页面操作

        /************************************************************************
       *******************     产品结构tab页面操作     *********************
       ************************************************************************/

        ///
        /// 变量定义*************************************************************
        ///
        IObjectStructService _objectStructService = EAS.Services.ServiceContainer.GetService<IObjectStructService>();
  
        ///
        /// 页面控件初始化********************************************************
        ///
        //TreeGridView显示初始化
        private void list_productTreeStruct_init(HYPDM.Entities.PDM_PRODUCT t)
        { 
            //获取与产品直接关联的零部件和半成品
            
            DataTable dt=_objectStructService.GetList(t.PRODUCTID,t.VERSION);
            TreeListViewItem itemA = new TreeListViewItem(t.PRODUCTID, 0);
            itemA.Expand();
            itemA.SubItems.Add(t.VERSION);
            this.list_productTreeStruct.Items.Add(itemA);

            //=====================
            int len=dt.Rows.Count;
            if (len > 0) {
                for (int i = 0; i < len; i++) {
                            
                    TreeListViewItem item = new TreeListViewItem(dt.Rows[i]["ASSOOBJECTID"].ToString(), 0);
                    itemA.Items.Add(item);
                    item.Expand();
                    item.SubItems.Add(dt.Rows[i]["ASSOOBJECTVERSION"].ToString());
                    item.SubItems.Add(dt.Rows[i]["SORTNUM"].ToString());
                    item.SubItems.Add("dddd"); 
                    item.SubItems.Add(dt.Rows[i]["ASSOOBJECTNUM"].ToString());
                    item.SubItems.Add(dt.Rows[i]["ASSOMEMO"].ToString());
                }
            }
            //获取与半成品想关联的零部件
        }


        ///
        /// 页面控件操作***********************************************************
        ///
        
        private void toolStructAdd_Click(object sender, EventArgs e)
        {
            ProductsStructAddForm o = new ProductsStructAddForm(this.copy_Product);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
        }


        ///
        /// 自定义函数操作***********************************************************
        ///
        #endregion
    }
}
