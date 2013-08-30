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

        public ProductsConfForm(int p_type)
        {
            InitializeComponent();

            this.m_type = p_type;
            this.opStatus = false;
            service_Init();
            toolBaseClear_Click(null,null);
        }

        public ProductsConfForm(string t_productId, int p_type)
        {
            InitializeComponent();

            this.m_type = p_type;
            this.opStatus = false;
            service_Init();
            this.m_product = m_AllProductService.GetById(t_productId);
            allinit();
        }

        #region 属性基本数据
        
        private int m_type;     //类型（半成品，成品）
        private bool opStatus;  //操作状态（产品清空状态，配置状态）

        private IAllProductService m_AllProductService;      //产品服务类
        private IStructService m_StructService;              //结构体服务类
        private IProductProRecordService m_proRecordService; //生产记录服务类

        HYPDM.Entities.PDM_ALL_PRODUCT m_product;       //操作的产品
        public HYPDM.Entities.PDM_ALL_PRODUCT Product
        {
            get { return this.m_product; }
            set
            {
                this.m_product = value;
            }
        }

        #endregion

        #region 公共操作

        /************************************************************************
         ************************         公共操作        ***********************
         ************************************************************************/

        /// <summary>
        /// 初始化界面控件数据
        /// </summary>
        private void allinit()
        {
            baseInfo_Init();
            //tabProRecord_Init();
            //dgv_Change_init(t);
            tabStruct_Init();
            tabVersion_Init();
        }

        /// <summary>
        /// //初始化服务类
        /// </summary>
        private void service_Init()
        {
            m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
            m_StructService = EAS.Services.ServiceContainer.GetService<IStructService>();
            IProductProRecordService _proRecordService = EAS.Services.ServiceContainer.GetService<IProductProRecordService>();
        }

        #endregion

        #region 基本操作

        /************************************************************************
         *******************     产品基本信息操作     *********************
         ************************************************************************/

        /// <summary>
        /// 基本信息--显示初始化
        /// </summary>
        private void baseInfo_Init()
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

        /// <summary>
        /// 基本信息--修改按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseEdit_Click(object sender, EventArgs e)
        {
            //
            if (this.m_product == null) {
                MessageBox.Show("该产品不存在,无法修改！"); return;
            }

            //判断是否需要修改
            if (MessageBox.Show("您确认要修改此产品基本信息?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            //1.更新数据库产品基本信息记录
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


            //2.基本信息改变后更新基本信息显示
            this.tb_modifyTime.Text = t_product.MODIFYTIME;
            this.tb_modifier.Text = t_product.MODIFIER;

            //3.更新（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面列表显示,更新基本属性信息
            this.m_product = m_AllProductService.GetById(t_product.PRODUCTID);
            allinit();
        }

        /// <summary>
        /// 基本信息--新建按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseReg_Click(object sender, EventArgs e)
        {
           
            //1.判断产品编号是否为空
            if (string.IsNullOrEmpty(this.tb_productNo.Text.Trim()))
            {
                MessageBox.Show("产品编号不能为空"); return;
            }

            DataTable dt = m_AllProductService.GetListByNoDetail(this.tb_productNo.Text.Trim());

            //1.判断产品是否存在，如果存在是否生产新版本
            if (dt.Rows.Count>0)
            {
                if (MessageBox.Show("该产品已存在，是否生产新版本?\n如果不是请更改产品编号!", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
            }

            //3.保存新的产品记录
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
            

            //4. 判断显示状态
            if (this.opStatus)
            {
                //a.显示（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面
                this.tabControl.TabPages.Add(tab_ProRecord);
                this.tabControl.TabPages.Add(tab_Change);
                this.tabControl.TabPages.Add(tab_Doc);
                this.tabControl.TabPages.Add(tab_Drawing);
                this.tabControl.TabPages.Add(tab_productStruct);
                this.tabControl.TabPages.Add(tab_TelTask);
                this.tabControl.TabPages.Add(tab_Version);

                //b.改变显示属性（产品清空状态 ，产品配置状态）
                this.opStatus = false;
            }

            //5.更新（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab页面列表显示,更新基本属性信息
            this.m_product = temp_product;
            allinit();
        }

        /// <summary>
        /// 基本信息--清空按钮的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBaseClear_Click(object sender, EventArgs e)
        {
            //if (this.m_product == null)
            //{
            //    return;
            //}
            //1.清空基本信息显示
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

            //2.移除（派生历史记录,ERC,文档,图纸,技术任务单,产品结构,版本）等tab 页面
            this.tabControl.TabPages.Remove(tab_ProRecord);
            this.tabControl.TabPages.Remove(tab_Change);
            this.tabControl.TabPages.Remove(tab_Doc);
            this.tabControl.TabPages.Remove(tab_Drawing);
            this.tabControl.TabPages.Remove(tab_productStruct);
            this.tabControl.TabPages.Remove(tab_TelTask);
            this.tabControl.TabPages.Remove(tab_Version);

            //3.改变显示属性（产品清空状态 ，产品配置状态）
            this.opStatus = true;
        }

        #endregion

        #region 产品生产记录tab页面操作
        /************************************************************************
        *******************     产品生产记录tab页面操作     *********************
        ************************************************************************/

        /// <summary>
        /// 生产记录页面初始化
        /// </summary>
        /// <param name="t"></param>
        private void tabProRecord_Init()
        {
            Condition condition = PDM_PRODUCT_PRORECORD.Create().CreateCondition();
            condition.AddElement("PRUDUCTID", this.m_product.PRODUCTID, ElementType.MatchPrefix);
            this.dgv_ProRecord.DataSource= m_proRecordService.GetProductList(condition);
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
                tabProRecord_Init();
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
        private void dgv_Change_init(HYPDM.Entities.PDM_ALL_PRODUCT t)
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

        /// <summary>
        /// 产品结构页面初始化
        /// </summary>
        private void tabStruct_Init() {

            //1.属性combox控件初始化
            structPro_Init();

            //2.产品结构树初始化
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init();
        }

        /// <summary>
        /// 属性combox控件初始化
        /// </summary>
        private void structPro_Init()
        {
            this.cb_structPro.Items.Add("编号");
            this.cb_structPro.SelectedValue = 1;
            this.cb_structPro.Items.Add("版本");
            this.cb_structPro.SelectedValue = 2;
            this.cb_structPro.Items.Add("描述");
            this.cb_structPro.SelectedValue = 3;
            this.cb_structPro.SelectedIndex = 0;  
        }


        /// <summary>
        /// 初始化树列表根节点
        /// </summary>
        private void list_productTreeStruct_init()
        {
            TreeListViewItem root = new TreeListViewItem(this.m_product.PRODUCTNO, 0);
            root.Expand(); root.SubItems.Add(this.m_product.VERSION);
            this.list_productTreeStruct.Items.Add(root);
            treeCreater(root, this.m_product.PRODUCTID);
        }
        
        /// <summary>
        /// 初始化树列表子节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="p_objectId"></param>
        private void treeCreater(TreeListViewItem node, string p_objectId)
        {
            DataTable dt_parts = m_StructService.GetStructPartList(p_objectId);
            int len = dt_parts.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                TreeListViewItem item = new TreeListViewItem(dt_parts.Rows[i]["PRODUCTNO"].ToString(), 0);
                node.Items.Add(item);
                //item.Expand();
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
                // item.Expand();
                item.SubItems.Add(dt_Materail.Rows[i]["VERSION"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["ASSONUM"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["MODELTYPE"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["SORTNUM"].ToString());
                item.Tag = dt_Materail.Rows[i]["ASSOBJECTID"].ToString();
                item.SubItems.Add(dt_Materail.Rows[i]["MEMO"].ToString());
            }
        }

        /// <summary>
        /// 查询按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_StructSearch_Click(object sender, EventArgs e)
        {
            //1.清空列表显示
            this.list_productTreeStruct.Items.Clear();

            //2.判断查询条件是否为空（为空显示完整的产品结构树，否则显示符合条件的产品结构）
            if (this.tb_structProValue.Text.Trim() == "")
            {
                list_productTreeStruct_init();
            }
            else
            {
                TreeListViewItem root = new TreeListViewItem(this.m_product.PRODUCTNO, 0);
                root.Expand(); root.SubItems.Add(this.m_product.VERSION);
                this.list_productTreeStruct.Items.Add(root);
                string id = treeCreaterSearch(root, this.m_product.PRODUCTID);
                treeCreater(root, id);
            }
        }

        /// <summary>
        /// 构造符合查询条件的产品结构树
        /// </summary>
        /// <param name="node"></param>
        /// <param name="p_objectId"></param>
        /// <returns></returns>
        private string treeCreaterSearch(TreeListViewItem node,string p_objectId)
        {
            DataTable dt_parts = m_StructService.GetStructPartList(p_objectId);
            int len = dt_parts.Rows.Count;
            string strValue = "";
            int value = -1;
            for (int i = 0; i < len; i++)
            {
                if (this.cb_structPro.Text == "编号")
                {
                    value = dt_parts.Rows[i]["PRODUCTNO"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                else if (this.cb_structPro.Text == "版本")
                {
                    value = dt_parts.Rows[i]["VERSION"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                else if (this.cb_structPro.Text == "描述")
                {
                    value = dt_parts.Rows[i]["MEMO"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                if (value >= 0)
                {
                    TreeListViewItem item = new TreeListViewItem(dt_parts.Rows[i]["PRODUCTNO"].ToString(), 0);
                    node.Items.Add(item);
                    item.SubItems.Add(dt_parts.Rows[i]["VERSION"].ToString());
                    item.SubItems.Add(dt_parts.Rows[i]["ASSONUM"].ToString());
                    item.SubItems.Add(dt_parts.Rows[i]["MODELTYPE"].ToString());
                    item.SubItems.Add(dt_parts.Rows[i]["SORTNUM"].ToString());
                    item.SubItems.Add(dt_parts.Rows[i]["MEMO"].ToString());
                    item.Tag = dt_parts.Rows[i]["ASSOBJECTID"].ToString();
                    treeCreater(item, dt_parts.Rows[i]["ASSOBJECTID"].ToString());
                }
                else
                {
                   treeCreaterSearch(node, dt_parts.Rows[i]["ASSOBJECTID"].ToString());
                }
                if (strValue != "") {
                    return strValue;
                }
            }

            DataTable dt_Materail = m_StructService.GetStructMaterailList(p_objectId);
            int len2 = dt_Materail.Rows.Count;
            for (int j = 0; j < len2; j++)
            {
                if (this.cb_structPro.Text == "编号")
                {
                    value = dt_Materail.Rows[j]["MATERIALNO"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                else if (this.cb_structPro.Text == "版本")
                {
                    value = dt_Materail.Rows[j]["VERSION"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                else if (this.cb_structPro.Text == "描述")
                {
                    value = dt_Materail.Rows[j]["MEMO"].ToString().IndexOf(this.tb_structProValue.Text);
                }
                if (value >= 0)
                {
                    TreeListViewItem item = new TreeListViewItem(dt_Materail.Rows[j]["MATERIALNO"].ToString(), 0);
                    node.Items.Add(item);
                    // item.Expand();
                    item.SubItems.Add(dt_Materail.Rows[j]["VERSION"].ToString());
                    item.SubItems.Add(dt_Materail.Rows[j]["ASSONUM"].ToString());
                    item.SubItems.Add(dt_Materail.Rows[j]["MODELTYPE"].ToString());
                    item.SubItems.Add(dt_Materail.Rows[j]["SORTNUM"].ToString());
                    item.Tag = dt_Materail.Rows[j]["ASSOBJECTID"].ToString();
                    item.SubItems.Add(dt_Materail.Rows[j]["MEMO"].ToString());
                }
            }
            return strValue;
        }

        /// <summary>
        /// 添加产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStructAdd_Click(object sender, EventArgs e)
        {
            //1.打开产品添加界面传递（产品对象，关联对象ID,操作类型--保存）参数
            ProductsStructAddForm o = new ProductsStructAddForm(this.m_product,"",Enum_AssOpType.SAVE);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

            //2.清空并重新构造产品结构树
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init();
        }

        /// <summary>
        /// 删除产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStructDel_Click(object sender, EventArgs e)
        {
            //1.判断是否要删除选中的产品结构
            if (MessageBox.Show("您确认要删除所选择的产品结构\n请确认您的操作。", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            //2.找出被选择的产品结构
            PDM_STRUCT t_struct = new PDM_STRUCT();
            TreeListViewItem item = this.list_productTreeStruct.Items[0];
            List<TreeListViewItem> list = new List<TreeListViewItem>();
            for (int i = 0; i < item.Items.Count; i++)
            {
                if(item.Items[i].CheckStatus==CheckState.Checked){
                    list.Add(item.Items[i]);
                } 
            }

            //3.删除被选择的产品结构
            if (list.Count > 0)
            {
                foreach (TreeListViewItem tlvi in list)
                {
                    t_struct.OBJECTID = this.m_product.PRODUCTID;
                    t_struct.ASSOBJECTID = tlvi.Tag.ToString();
                    m_StructService.delStruct(t_struct);
                }
            }
            else {
                MessageBox.Show("最少选择一条记录！");
            }

            //4.清空并重新构造产品结构树
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init();
        }

       /// <summary>
        ///  修改产品结构
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void toolStructEdit_Click(object sender, EventArgs e)
        {
            //1.找出需要修改的产品结构
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

            //2.记录修改界面传递（关联对象，关联对象ID,操作类型--修改）参数
            StructAddForm o = new StructAddForm(t_struct, "", Enum_AssOpType.EDIT);
            o.StartPosition = FormStartPosition.CenterParent;

            //3.判断是否修改如果修改（清空产品结构树，并重新构造树）
            if (o.ShowDialog() == DialogResult.OK)
            {
                this.list_productTreeStruct.Items.Clear();
                list_productTreeStruct_init();
            }

        }

        /// <summary>
        /// 替换产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStructReplace_Click(object sender, EventArgs e)
        {
            //1.查找需要替换的产品结构
            PDM_STRUCT t_struct = new PDM_STRUCT();
            TreeListViewItem item = this.list_productTreeStruct.Items[0];
            int count = 0; int index = 0;
            for (int i = 0; i < item.Items.Count; i++)
            {
                if (item.Items[i].CheckStatus == CheckState.Checked)
                {
                    count++;
                    index = i;
                }
            }
            if (count != 1)
            {
                MessageBox.Show("只能选择一条记录且子结构无法更改！");
                return;
            }
            t_struct.OBJECTID = this.m_product.PRODUCTID;
            t_struct.ASSOBJECTID = item.Items[index].Tag.ToString();

            //2.打开产品添加界面传递（产品对象，关联对象ID,操作类型--替换）参数
            ProductsStructAddForm o = new ProductsStructAddForm(this.m_product, t_struct.ASSOBJECTID, Enum_AssOpType.REPLACE);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

            //3.清空产品结构树，并重新构造树
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init();
            
        }
       
        /// <summary>
        /// 插入产品结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStructInsert_Click(object sender, EventArgs e)
        {

            //1.找到插入的节点的位置
            PDM_STRUCT t_struct = new PDM_STRUCT();
            TreeListViewItem item = this.list_productTreeStruct.Items[0];
            int count = 0; int index = 0;
            for (int i = 0; i < item.Items.Count; i++)
            {
                if (item.Items[i].CheckStatus == CheckState.Checked)
                {
                    count++;
                    index = i;
                }
            }
            if (count != 1)
            {
                MessageBox.Show("只能选择一条记录且子结构无法更改！");
                return;
            }
            t_struct.OBJECTID = this.m_product.PRODUCTID;
            t_struct.ASSOBJECTID = item.Items[index].Tag.ToString();

            //2.打开产品添加界面传递（产品对象，关联对象ID,操作类型--插入）参数
            ProductsStructAddForm o = new ProductsStructAddForm(this.m_product, t_struct.ASSOBJECTID, Enum_AssOpType.INSERT);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

            //3.清空产品结构树，并重新构造树
            this.list_productTreeStruct.Items.Clear();
            list_productTreeStruct_init();
        }
       
        /// <summary>
        /// 保存--查询结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStructSave_Click(object sender, EventArgs e)
        {
            //1.打开Excle程序
            Excel.Application application = new Excel.Application();
            application.Visible = false;
            application.UserControl = false;
            Excel.Workbook workBook = (Excel.Workbook)(application.Workbooks.Add(Type.Missing));
            Excel.Worksheet mySheet = workBook.Sheets[1] as Excel.Worksheet; //第一个sheet页 

            //2.遍历产品结构树
            getchildValue(this.list_productTreeStruct.Items[0], mySheet, 0, 0);

            //3.关闭Excle程序
            workBook.Close(true, Type.Missing, Type.Missing);
            workBook = null;
            application.Quit();
            application = null;
            MessageBox.Show("保存成功");
            
        }
        /// <summary>
        /// 保存--遍历树结构
        /// </summary>
        /// <param name="item_first"></param>
        /// <param name="mySheet"></param>
        /// <param name="p_rowNum"></param>
        /// <param name="p_level"></param>
        /// <returns></returns>
        private int getchildValue(TreeListViewItem item_first, Excel.Worksheet mySheet,int p_rowNum,int p_level)
        {
            int rowNum = p_rowNum + 1;
            string sp = "";
            for (int i = 0; i < item_first.SubItems.Count; i++) {
                if (i == 0)
                {
                    for (int k = 1; k < p_level; k++)
                    {
                        sp += "  ";
                    }
                    mySheet.Cells[rowNum, i + 1] = sp + item_first.SubItems[i].Text;
                }
                else
                {
                    mySheet.Cells[rowNum, i + 1] = item_first.SubItems[i].Text;
                }
            }
            for (int j = 0; j < item_first.Items.Count; j++) {
                rowNum = getchildValue(item_first.Items[j], mySheet, rowNum, p_level+1);
            }
            return rowNum;
        }

        #endregion

        #region 版本tab页面操作
        /************************************************************************
         *******************         版本tab页面操作        *********************
         ************************************************************************/

        /// <summary>
        /// 版本页面初始化
        /// </summary>
        private void tabVersion_Init()
        {
            //1.列表数据初始化
            this.dgv_Product.DataSource = m_AllProductService.GetListByNo(this.m_product.PRODUCTNO);//列表显示初始化
        }


        /// <summary>
        ///  // dgv_Product（列表checkbox选择操作）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //1.获取被点击的checkbox
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            DataGridViewCheckBoxCell ifcheck = (DataGridViewCheckBoxCell)dgv_Product.Rows[e.RowIndex].Cells[0];

            //2.如果checkbox已被选中则取消选中，如果没有选中，则选中
            Boolean flag = Convert.ToBoolean(ifcheck.Value);
            if (flag){ ifcheck.Value = false; } else { ifcheck.Value = true; }
        }

        /// <summary>
        /// toolVersionQuery（查询按钮操作）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolVersionQuery_Click(object sender, EventArgs e)
        {
            //1.判断是否输入编号
            if (!string.IsNullOrEmpty(this.toolVersionNo.Text))
            {
                //2.更新列表显示
                this.dgv_Product.DataSource = m_AllProductService.GetListByNo(this.toolVersionNo.Text);
            }
            else
            {
                MessageBox.Show("请输入产品编号");
            }

        }

       /// <summary>
       /// 比较按钮操作
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void toolVersionCompare_Click(object sender, EventArgs e)
        {
            //1.遍历列表中checkbox选中的记录
            IList<string> _compList = new List<string>();
            for (int i = 0; i < dgv_Product.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_Product.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if (flag)
                {
                    string productId = dgv_Product.Rows[i].Cells[1].Value.ToString().Trim();
                    _compList.Add(productId);
                }
            }

            //2.判断是否只选择2条记录
            if (_compList.Count < 2)
            {
                MessageBox.Show("请选择需要比较的两个产品"); return;
            }
            if (_compList.Count > 2)
            {
                MessageBox.Show("只能选择两个产品"); return;
            }

            //3.打开产品比较页面,且将比较的两个产品ID作为参数传递给比较页面
            ProductsCompForm o = new ProductsCompForm(_compList[0].ToString(), _compList[1].ToString());
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

        }
        

        #endregion


    }
}