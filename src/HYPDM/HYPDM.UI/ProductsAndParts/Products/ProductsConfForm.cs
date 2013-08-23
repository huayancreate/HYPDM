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
        public ProductsConfForm(string t, int p_type)
        {
            InitializeComponent();
            this.m_type = p_type;
            this.opStatus = false;
            allinit(t);
        }
        //产品数据
        private int m_type;
        private bool opStatus;
        HYPDM.Entities.PDM_ALL_PRODUCT m_product;
        public HYPDM.Entities.PDM_ALL_PRODUCT Product
        {
            get { return this.m_product; }
            set
            {
                this.m_product = value;
            }
        }

        #region 初始化

        /************************************************************************
         ************************         初始化        *************************
         ************************************************************************/

        private void allinit(string p_id)
        {
            initService();
            this.m_product = m_AllProductService.GetById(p_id);
            initBaseData();
            dgvProduct_Init();
            //dgvProduct_Init(t);
            //dgv_ProRecord_init(t);
            //dgv_Change_init(t);
            list_productTreeStruct_init(m_product);
        }
        //初始化服务类
        private IAllProductService m_AllProductService;
        private void initService()
        {
            m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
        }
        //初始化基础数据
        private void initBaseData()
        {
            this.tb_productNo.Text = this.m_product.PRODUCTNO;
            this.tb_modelType.Text = this.m_product.MODELTYPE;
            this.tb_productType.Text = this.m_product.PRODUCTTYPE;
            this.tb_version.Text = this.m_product.VERSION;
            this.tb_status.Text = this.m_product.STATUS;
            this.tb_creater.Text = this.m_product.CREATER;
            this.tb_modifier.Text = this.m_product.MODIFIER;
            this.tb_createTime.Text = this.m_product.CREATETIME;
            this.tb_modifyTime.Text = this.m_product.MODIFYTIME;
            this.tb_memoZh.Text = this.m_product.MEMO_ZH;
            this.tb_memoEn.Text = this.m_product.MEMO_EN;
            this.rtbMemo.Text = this.m_product.MEMO;
        }

        #endregion

        #region 版本tab页面操作
        /************************************************************************
         *******************         版本tab页面操作        *********************
         ************************************************************************/

        ///
        /// 变量定义*************************************************************
        ///



        ///
        /// 页面控件初始化********************************************************
        ///

        //dgv_Product（产品列表）
        private void dgvProduct_Init()
        {
            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            t_product.PRODUCTNO = this.m_product.PRODUCTNO;
            var list = m_AllProductService.GetProductList(t_product);
            this.dgv_Product.DataSource = list;
        }

        ///
        /// 页面控件操作***********************************************************
        ///
        //toolVersionCompare（比较按钮操作）
        private void toolVersionCompare_Click(object sender, EventArgs e)
        {
            IList<string> _compList = new List<string>();
            for (int i = 0; i < dgv_Product.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_Product.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if (flag)
                {
                    string productId = dgv_Product.Rows[i].Cells[0].Value.ToString().Trim();
                    _compList.Add(productId);
                }
            }
            if (_compList.Count < 2)
            {
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
                // Condition condition = PDM_PRODUCT.Create().CreateCondition();
                //  condition.AddElement("PRODUCTID", this.toolVersionNo.Text, ElementType.Match);
                // var list = _productService.GetProductList(condition);
                //  this.dgv_Product.DataSource = list;
            }
            else
            {
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
            else { ifcheck.Value = true; }
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
        private void dgv_ProRecord_init(HYPDM.Entities.PDM_PRODUCT t)
        {
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
            o._ProductId = this.m_product.PRODUCTID;
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
            o._ProductId = this.m_product.PRODUCTID;
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
            //o.Product = m_product;
            o.ShowDialog();
            this.dgv_Change.DataSource = _pjtChangeService.GetAssoList(this.m_product.PRODUCTID);
        }

        private void toolChangeDel_Click(object sender, EventArgs e)
        {
            int index = dgv_Change.CurrentRow.Index;
            _pjtChangeService.deleteAsso(dgv_Change.Rows[index].Cells[0].Value.ToString(), this.m_product.PRODUCTID);
            _pjtChangeService.updateAsso(0, dgv_Change.Rows[index].Cells[0].Value.ToString());
            this.dgv_Change.DataSource = _pjtChangeService.GetAssoList(this.m_product.PRODUCTID);
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
        IStructService m_StructService = EAS.Services.ServiceContainer.GetService<IStructService>();

        ///
        /// TreeGridView控件操作********************************************************
        ///

        //TreeGridView显示初始化
        private void list_productTreeStruct_init(HYPDM.Entities.PDM_ALL_PRODUCT t)
        {
            TreeListViewItem root = new TreeListViewItem(t.PRODUCTNO, 0);
            root.Expand(); root.SubItems.Add(t.VERSION);
            this.list_productTreeStruct.Items.Add(root);
            treeCreater(root, t.PRODUCTID);
        }
        //构造列表树结构
        private void treeCreater(TreeListViewItem node, string p_objectId)
        {
            DataTable dt_parts = m_StructService.GetStructPartList(p_objectId);
            int len = dt_parts.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                TreeListViewItem item = new TreeListViewItem(dt_parts.Rows[i]["PRODUCTNO"].ToString(), 0);
                node.Items.Add(item);
                item.Expand();
                item.SubItems.Add(dt_parts.Rows[i]["VERSION"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["ASSONUM"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["MODELTYPE"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["SORTNUM"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["MEMO"].ToString());
                item.Tag = dt_parts.Rows[i]["ASSOBJECTID"].ToString();
                treeCreater(item, dt_parts.Rows[i]["ASSOBJECTID"].ToString());
            }

            DataTable dt_Materail = m_StructService.GetStructMaterailList(p_objectId);
            int len2 = dt_Materail.Rows.Count;
            for (int i = 0; i < len2; i++)
            {
                TreeListViewItem item = new TreeListViewItem(dt_Materail.Rows[i]["MATERIALNO"].ToString(), 0);
                node.Items.Add(item);
                item.Expand();
                item.SubItems.Add(dt_Materail.Rows[i]["VERSION"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["ASSONUM"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["MODELTYPE"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["SORTNUM"].ToString());
                item.Tag = dt_Materail.Rows[i]["ASSOBJECTID"].ToString();
                item.SubItems.Add(dt_Materail.Rows[i]["MEMO"].ToString());
            }
        }

        ///
        /// 工具栏工具控件操作***********************************************************
        ///

        //添加产品结构
        private void toolStructAdd_Click(object sender, EventArgs e)
        {
            ProductsStructAddForm o = new ProductsStructAddForm(this.m_product);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init(this.m_product);
        }

        //删除产品结构
        private void toolStructDel_Click(object sender, EventArgs e)
        {
            PDM_STRUCT t_struct = new PDM_STRUCT();
            TreeListViewItem item = this.list_productTreeStruct.Items[0];
            for (int i = 0; i < item.Items.Count; i++)
            {
                if(item.Items[i].CheckStatus==CheckState.Checked){
                    t_struct.OBJECTID = this.m_product.PRODUCTID;
                    t_struct.ASSOBJECTID = item.Items[i].Tag.ToString();
                    m_StructService.delStruct(t_struct);
                } 
            }
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init(this.m_product);
        }

        //修改产品结构
        private void toolStructEdit_Click(object sender, EventArgs e)
        {
            PDM_STRUCT t_struct = new PDM_STRUCT();
            TreeListViewItem item = this.list_productTreeStruct.Items[0];
            int count = 0; int index=0;
            for (int i = 0; i < item.Items.Count; i++)
            {
                if (item.Items[i].CheckStatus == CheckState.Checked)
                {
                    count ++;
                    index = i;
                }
            }
            if (count != 1) {
                MessageBox.Show("只能选择一条记录且子结构无法更改！"); 
                return; 
            }

            t_struct.OBJECTID = this.m_product.PRODUCTID;
            t_struct.ASSOBJECTID = item.Items[index].Tag.ToString();


            StructAddForm o = new StructAddForm(t_struct.OBJECTID, t_struct.ASSOBJECTID);
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK) {
                m_StructService.editStruct(t_struct);
                this.list_productTreeStruct.Items.Clear();
                list_productTreeStruct_init(this.m_product);
            }

        }
        ///
        /// 自定义函数操作***********************************************************
        ///
        #endregion

        #region 基本操作

        /************************************************************************
         *******************     产品基本信息操作     *********************
         ************************************************************************/

        //基本信息修改操作
        private void toolBaseEdit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("您确认要修改此产品信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            t_product.PRODUCTID = this.m_product.PRODUCTID;
            t_product.PRODUCTNO = this.tb_productNo.Text;
            t_product.MODELTYPE = this.tb_modelType.Text;
            t_product.PRODUCTTYPE = this.tb_productType.Text;
            t_product.MEMO_ZH = this.tb_memoZh.Text;
            t_product.MEMO_EN = this.tb_memoEn.Text;
            t_product.MEMO = this.rtbMemo.Text;
            t_product.MODIFYTIME = DateTime.Now.ToString();
            t_product.MODIFIER = CommonVar.userName;
            m_AllProductService.UpdateByID(t_product);

            this.tb_modifyTime.Text = t_product.MODIFYTIME;
            this.tb_modifier.Text = t_product.MODIFIER;
        }

        //基本信息注册（添加）操作
        private void toolBaseReg_Click(object sender, EventArgs e)
        {
            if (this.m_product.PRODUCTNO.Equals(this.tb_productNo.Text.Trim()))
            {
                if (MessageBox.Show("您确认要生成新版本?如果不是请更改编号!", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            if (string.IsNullOrEmpty(this.tb_productNo.Text.Trim()))
            {
                MessageBox.Show("产品编号不能为空"); return;
            }

            HYPDM.Entities.PDM_ALL_PRODUCT temp_product = new HYPDM.Entities.PDM_ALL_PRODUCT();

            temp_product.PRODUCTID = Guid.NewGuid().ToString();
            temp_product.PRODUCTNO = this.tb_productNo.Text;
            temp_product.MODELTYPE = this.tb_modelType.Text;
            temp_product.PRODUCTTYPE = this.tb_productType.Text;
            temp_product.PRODUCTLEVEL = this.m_type;
            temp_product.VERSION = "V" + DateTime.Now.ToString("yyyyMMddHHmm");
            temp_product.STATUS = "已创建";
            temp_product.CREATER = CommonVar.userName;
            //temp_product.MODIFIER = "";
            temp_product.CREATETIME = DateTime.Now.ToString();
            //temp_product.MODIFYTIME ;
            temp_product.MEMO_ZH = this.tb_memoZh.Text;
            temp_product.MEMO_EN = this.tb_memoEn.Text;
            temp_product.MEMO = this.rtbMemo.Text;
            temp_product.Save();
            MessageBox.Show("保存成功");
            this.m_product = temp_product;
            if (this.opStatus)
            {
                this.tabControl.TabPages.Add(tab_ProRecord);
                this.tabControl.TabPages.Add(tab_Change);
                this.tabControl.TabPages.Add(tab_Doc);
                this.tabControl.TabPages.Add(tab_Drawing);
                this.tabControl.TabPages.Add(tab_productStruct);
                this.tabControl.TabPages.Add(tab_TelTask);
                this.tabControl.TabPages.Add(tab_Version);
                this.opStatus = false;
            }
        }

        //清空显示信息
        private void toolBaseClear_Click(object sender, EventArgs e)
        {
            this.tb_productNo.Text = "";
            this.tb_modelType.Text = "";
            this.tb_productType.Text = "";
            this.tb_version.Text = "";
            this.tb_status.Text = "";
            this.tb_creater.Text = "";
            this.tb_modifier.Text = "";
            this.tb_createTime.Text = "";
            this.tb_modifyTime.Text = "";
            this.tb_memoZh.Text = "";
            this.tb_memoEn.Text = "";
            this.rtbMemo.Text = "";
            this.tabControl.TabPages.Remove(tab_ProRecord);
            this.tabControl.TabPages.Remove(tab_Change);
            this.tabControl.TabPages.Remove(tab_Doc);
            this.tabControl.TabPages.Remove(tab_Drawing);
            this.tabControl.TabPages.Remove(tab_productStruct);
            this.tabControl.TabPages.Remove(tab_TelTask);
            this.tabControl.TabPages.Remove(tab_Version);
            this.opStatus = true;
        }
        #endregion


        


    }
}