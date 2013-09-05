using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Windows.UI.Controls;
using EAS.Data.ORM;
using EAS.Explorer.Entities;
using EAS.Objects;
using EAS.Explorer;
using HYPDM.BLL;
using HYPDM.Entities;
namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    public partial class PartsStructAddForm : Form
    {
        /*************************************************************
        ************************     初始化   ************************
        **************************************************************/
        enum selectType {Matieral,Parts,Product};
        IStructService m_structService = EAS.Services.ServiceContainer.GetService<IStructService>();
        //所选择产品对应的数据
        HYPDM.Entities.PDM_ALL_PRODUCT copy_Product;
        public HYPDM.Entities.PDM_ALL_PRODUCT Product
        {
            get { return this.copy_Product; }
            set
            {
                this.copy_Product = value;
            }
        }

        private string  m_assoID;
        private Enum_AssOpType m_assoType;
        //结构体初始化
        public PartsStructAddForm(HYPDM.Entities.PDM_ALL_PRODUCT t, String p_assoID, Enum_AssOpType p_assoType)
        {
            InitializeComponent();
            this.Text = "结构添加--" + t.PRODUCTNO;
            this.copy_Product = t;
            m_assoID = p_assoID;
            m_assoType = p_assoType;
            tv_struct_init();
            toolProComb_init(selectType.Matieral);
            toolVersionComb_init();

            this.dgvgridInit();
           
        }

        #region 树控件的操作
        
        //树控件初始化
        private void tv_struct_init()
        {
            this.tv_struct.Nodes.Clear();
            TreeNode root = new TreeNode("产品及零部件", 0, 1);
            TreeNode node1 = new TreeNode("零部件", 1, 2); node1.Tag = selectType.Matieral;this.tv_struct.SelectedNode = node1;
            TreeNode node2 = new TreeNode("半成品", 1, 2); node2.Tag = selectType.Parts;
            TreeNode node3 = new TreeNode("产品", 1, 2); node3.Tag = selectType.Product;

            root.Nodes.Add(node1); root.Nodes.Add(node2); root.Nodes.Add(node3);
            this.tv_struct.Nodes.Add(root);
            root.Expand();
        }

        //树控件节点单机操作
        private void tv_struct_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tv_struct.SelectedNode.Tag == null) { return; }
            else
            {
               this.dgvViewShow((selectType)this.tv_struct.SelectedNode.Tag);
            }
        }

        #endregion

        #region 工具栏操作
        //属性列表控件出事化
        private void toolProComb_init(selectType type)
        {
            this.toolProComb.Items.Add("编号");
            this.toolProComb.Items.Add("型号");
            this.toolProComb.Items.Add("版本");
            this.toolProComb.Items.Add("描述");
            this.toolProComb.SelectedIndex = 0;
        }
        //版本列表初始化
        private void toolVersionComb_init()
        {
            this.toolVersionComb.Items.Add("所有版本");
            this.toolVersionComb.Items.Add("v1.0");
            this.toolVersionComb.Items.Add("v1.1");
            this.toolVersionComb.Items.Add("v1.2");
            this.toolVersionComb.Items.Add("v1.3");
            this.toolVersionComb.Items.Add("v1.4");
        }

        ///
        ///控件初始化
        ///
        /*
        ITreeDataService _treeDataService = EAS.Services.ServiceContainer.GetService<ITreeDataService>();
        //树控件初始化
        private void tv_struct_init(){
            DataTable dt_root = _treeDataService.GetRootList("产品及零部件");
            if (dt_root.Rows.Count <= 0)
            {
                return;
            }
            this.tv_struct.Nodes.Clear();
            for (int i = 0; i < dt_root.Rows.Count; i++)
            {
                TreeNode root = new TreeNode(dt_root.Rows[0]["NAME"].ToString(), 0, 1);
                this.tv_struct_init_child(root, dt_root.Rows[0]["ID"].ToString());
                this.tv_struct.Nodes.Add(root);
                root.Expand();
                //this.tv_struct.SelectedNode = root;
           }
        }

        /// <summary>
        /// 树控件初始化。
        /// </summary>
        private void tv_struct_init_child(TreeNode node, string parentId)
        {
            DataTable dt_group = _treeDataService.GetGroupList(parentId);
            DataTable dt_module = _treeDataService.GetModelList((parentId));

            foreach (DataRow var in dt_group.Rows) //下级组
            {
                TreeNode subNode = new TreeNode(var["Name"].ToString(), 0, 1);
                this.tv_struct_init_child(subNode, var["ID"].ToString());
                node.Nodes.Add(subNode);
               
            }

            //功能模块
            foreach (DataRow var in dt_module.Rows) 
            {
                //Dictionary<string, int> gms = new Dictionary<string, int>();
                TreeNode itemNode = null;
                itemNode = new TreeNode(var["Name"].ToString(), 2, 2);
                itemNode.Tag = var["GUID"].ToString();
                node.Nodes.Add(itemNode);
                //this.tv_struct.SelectedNode = itemNode;
            }
        }
         * */
        

        //详细查询（按钮toolDetailQuery操作）
        private void toolDetailQuery_Click(object sender, EventArgs e)
        {
            selectType s_type=0;
            if (this.dgv_MaterialList.Visible)
            {
                s_type = selectType.Matieral;
            }
            else if (this.dgv_PartsList.Visible)
            {
                s_type = selectType.Parts;
            }
            else if (this.dgv_productList.Visible)
            {
                s_type = selectType.Product;
            }
            QueryStructForm o = new QueryStructForm(Convert.ToInt16(s_type));
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog()==DialogResult.OK) {
                if (this.dgv_MaterialList.Visible)
                {
                    this.dgv_MaterialList.DataSource = m_structService.GetMaterailList(o.Materails);
                }
                else if (this.dgv_PartsList.Visible)
                {
                    this.dgv_PartsList.DataSource = m_structService.GetPartsList(o.Parts);
                }
                else if (this.dgv_productList.Visible)
                {
                    this.dgv_productList.DataSource = m_structService.GetProductList(o.Products);
                }
            }
        }
       
        //简单查询按钮操作
        private void toolQuery_Click(object sender, EventArgs e)
        {
           
            if (this.toolProValue.Text.Equals("请输入属性值"))
            {
                MessageBox.Show("请输入属性值");
                return;
            }

            if (this.dgv_MaterialList.Visible) 
            {
                PDM_MATERAIL p_materail = new PDM_MATERAIL();
                if (this.toolProComb.Text == "编号")
                {
                    p_materail.MATERIALNO = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("型号"))
                {
                    p_materail.MODELTYPE = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text == "版本")
                {
                    p_materail.VERSION = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("描述"))
                {
                    p_materail.MEMO = this.toolProValue.Text;
                }
                this.dgv_MaterialList.DataSource=m_structService.GetMaterailList(p_materail);

            }else if(this.dgv_PartsList.Visible)
            {
                PDM_ALL_PRODUCT p_parts = new PDM_ALL_PRODUCT();
                if (this.toolProComb.Text == "编号")
                {
                    p_parts.PRODUCTNO = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("型号"))
                {
                    p_parts.MODELTYPE = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text == "版本")
                {
                    p_parts.VERSION = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("描述"))
                {
                    p_parts.MEMO = this.toolProValue.Text;
                }
                this.dgv_PartsList.DataSource=m_structService.GetPartsList(p_parts);
            }
            else if (this.dgv_productList.Visible)
            {
                PDM_ALL_PRODUCT p_products = new PDM_ALL_PRODUCT();
                if (this.toolProComb.Text == "编号")
                {
                    p_products.PRODUCTNO = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("型号"))
                {
                    p_products.MODELTYPE = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text == "版本")
                {
                    p_products.VERSION = this.toolProValue.Text;
                }
                else if (this.toolProComb.Text.ToString().Equals("描述"))
                {
                    p_products.MEMO = this.toolProValue.Text;
                }
                this.dgv_productList.DataSource= m_structService.GetProductList(p_products);
            }
            
        }
        #endregion


        #region 数据列表初始化

        /************************************************************************
         ************************         列表操作        ***********************
         ************************************************************************/

        
        //列表初始化
        private void dgvgridInit() {
           this.dgv_MaterialList.Dock = DockStyle.Fill;
           this.dgv_productList.Dock = DockStyle.Fill;
           this.dgv_PartsList.Dock = DockStyle.Fill;
           this.dgvProductListInit();
           this.dgvPartsListInit();
           this.dgvMaterailListInit();
           dgvViewShow(selectType.Matieral);
        }
        
        //数据列表显示操作
        private void dgvViewShow(selectType p_type) {
            if (p_type == selectType.Matieral) {
                this.dgv_MaterialList.Visible = true;              
                this.dgv_PartsList.Visible = false;               
                this.dgv_productList.Visible = false;
            }
            else if (p_type == selectType.Parts)
            {
                this.dgv_MaterialList.Visible = false;
                this.dgv_PartsList.Visible = true;
                this.dgv_productList.Visible = false;
            }
            else if (p_type == selectType.Product) {
                this.dgv_MaterialList.Visible = false;
                this.dgv_PartsList.Visible = false;
                this.dgv_productList.Visible = true;
            }
        }
       
        //产品列表数据初始化
        private void dgvProductListInit() {
            HYPDM.Entities.PDM_ALL_PRODUCT t = new PDM_ALL_PRODUCT();
            this.dgv_productList.DataSource = m_structService.GetProductList(t);
        }
        //产品列表数据选择
         private void dgv_productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex != 0 || e.RowIndex == -1) return;
            for (int i = 0; i < dgv_productList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_productList.Rows[i].Cells[0];
                if(e.RowIndex==i){
                    checkcell.Value = !Convert.ToBoolean(checkcell.Value);
                }else{
                    checkcell.Value=false;
                }
            }
        }
       
        //半成品列表数据初始化
        private void dgvPartsListInit()
         {
             HYPDM.Entities.PDM_ALL_PRODUCT t = new PDM_ALL_PRODUCT();
            this.dgv_PartsList.DataSource = m_structService.GetPartsList(t);
        }

        //半成品列表数据选择
        private void dgv_PartsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1) return;

            for (int i = 0; i < dgv_PartsList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)this.dgv_PartsList.Rows[i].Cells[0];
                if (e.RowIndex == i){
                    checkcell.Value = !Convert.ToBoolean(checkcell.Value);
                }else{
                    checkcell.Value = false;
                }
            }
        }
        //材料列表数据初始化
        private void dgvMaterailListInit()
        {
            HYPDM.Entities.PDM_MATERAIL t = new PDM_MATERAIL();
            this.dgv_MaterialList.DataSource = m_structService.GetMaterailList(t);
        }

        //材料列表数据选择
        private void dgv_MaterialList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1) return;

            for (int i = 0; i < dgv_MaterialList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_MaterialList.Rows[i].Cells[0];
                if (e.RowIndex == i)
                {
                    checkcell.Value = !Convert.ToBoolean(checkcell.Value);
                }
                else
                {
                    checkcell.Value = false;
                }
            }
        }
        #endregion

        #region 按钮操作
        private void toolSelect_Click(object sender, EventArgs e)
        {
           TreeNode node =  this.tv_struct.SelectedNode ;
            selectStruct((selectType)node.Tag);
        }

        #endregion

        #region 自定义操作
        //选择操作
        private void selectStruct(selectType p_type)
        {
            if (p_type == selectType.Matieral)
            {
                selectMaterail();
            }
            else if (p_type == selectType.Parts)
            {
                selectParts();
            }
            else if (p_type == selectType.Product)
            {
                selectProduct();
            }
        }
        //选择材料
        private void selectMaterail() {

            string t_materailId=null;
            for (int i = 0; i < dgv_MaterialList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_MaterialList.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if (flag)
                {
                    t_materailId = dgv_MaterialList.Rows[i].Cells["MATERIALID"].Value.ToString().Trim();
                }
            }
            if (t_materailId == null) { MessageBox.Show("请选择一个材料"); return; }

            if (filterSelect(t_materailId) == -1)
            {
                MessageBox.Show("已经在产品结构中"); return;
            }


            HYPDM.Entities.PDM_STRUCT temp_struct = new HYPDM.Entities.PDM_STRUCT();
            temp_struct.OBJECTID = this.copy_Product.PRODUCTID;
            temp_struct.ASSOBJECTID = t_materailId;

            StructAddForm o = new StructAddForm(temp_struct, m_assoID, this.m_assoType);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
        
        }
        //选择半成品
        private void selectParts()
        {

            string t_partsId = null;
            string t_partsNo = "";
            for (int i = 0; i < this.dgv_PartsList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_PartsList.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if (flag)
                {
                    t_partsId = dgv_PartsList.Rows[i].Cells["PRODUCTID_P"].Value.ToString().Trim();
                    t_partsNo = dgv_PartsList.Rows[i].Cells["PRODUCTNO_P"].Value.ToString().Trim();
                }
            }
            if (t_partsId == null) { MessageBox.Show("请选择一个半成品"); return; }
            if (this.copy_Product.PRODUCTID == t_partsId)
            {
                MessageBox.Show("半成品不能与自己关联"); return;
            }

            if (filterSelect(t_partsId) == -1)
            {
                MessageBox.Show("已经在半成品结构中"); return;
            }
            if (filterCycle(t_partsId))
            {
                MessageBox.Show(t_partsNo + "结构中包含:" + this.copy_Product.PRODUCTNO + ",不能添加。\n否则产品结构形成循环！"); return;
            }

            HYPDM.Entities.PDM_STRUCT temp_struct = new HYPDM.Entities.PDM_STRUCT();
            temp_struct.OBJECTID = this.copy_Product.PRODUCTID;
            temp_struct.ASSOBJECTID = t_partsId;

            StructAddForm o = new StructAddForm(temp_struct, m_assoID, this.m_assoType);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

        }
        //选择产品
        private void selectProduct()
        {

            string t_productId = null;
            string t_productNo = "";//产品编号
            for (int i = 0; i < this.dgv_productList.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell checkcell = (DataGridViewCheckBoxCell)dgv_productList.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkcell.Value);
                if (flag)
                {
                    t_productId = dgv_productList.Rows[i].Cells["PRODUCTID"].Value.ToString().Trim();
                    t_productNo = dgv_productList.Rows[i].Cells["PRODUCTNO"].Value.ToString().Trim();
                }
            }
            if (t_productId == null) { MessageBox.Show("请选择一个产品"); return; }

            if (this.copy_Product.PRODUCTID == t_productId)
            {
                MessageBox.Show("产品不能与自己关联"); return; 
            }

            if (filterSelect(t_productId)==-1)
            {
                MessageBox.Show("该产品已经在产品结构中"); return;
            }

            if (filterCycle(t_productId))
            {
                MessageBox.Show(t_productNo+"结构中包含:"+this.copy_Product.PRODUCTNO+",不能添加。\n否则产品结构形成循环！"); return;
            }

            HYPDM.Entities.PDM_STRUCT temp_struct = new HYPDM.Entities.PDM_STRUCT();
            temp_struct.OBJECTID = this.copy_Product.PRODUCTID;
            temp_struct.ASSOBJECTID = t_productId;

            StructAddForm o = new StructAddForm(temp_struct, m_assoID, this.m_assoType);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();

        }
        //判断部件是否包含在产品结构中
        private int filterSelect(string p_assoId) {
            PDM_STRUCT t_struct = new PDM_STRUCT();
            t_struct.OBJECTID = this.copy_Product.PRODUCTID;
            t_struct.ASSOBJECTID = p_assoId;

            DataTable dt = m_structService.getStruct(t_struct);
            if (dt.Rows.Count > 0)
            {
                return -1;
            }
            return 0;
        
        }

        //产品1包含产品2，产品2就不能包含产品1
        //查看产品结构是否构成循环

        private bool filterCycle(string p_assoId) {
            
            DataTable dt_parts = m_structService.GetStructPartList(p_assoId);
            bool contain = false;
            for (int i = 0; i < dt_parts.Rows.Count; i++)
            {
                string new_objectId = dt_parts.Rows[i]["ASSOBJECTID"].ToString();
                if (new_objectId == this.copy_Product.PRODUCTID)
                {
                    return true;
                }
                contain = filterCycle(new_objectId);
                if (contain) {
                    return true;
                }
            }
            return contain;
        }

        #endregion
    }

}
