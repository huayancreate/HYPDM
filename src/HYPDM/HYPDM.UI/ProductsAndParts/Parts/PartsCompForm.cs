using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.BLL;
using EAS.Data.ORM;
using HYPDM.Entities;
namespace HYPDM.WinUI.ProductsAndParts.Parts
{
    public partial class PartsCompForm : Form
    {
        private PDM_ALL_PRODUCT  m_firstObj;
        private PDM_ALL_PRODUCT m_secondObj;
        private IStructService m_StructService;
        private IAllPartsService m_AllPartsService;
        private void initService()
        {
            
        }
        public PartsCompForm(string p_firstId, string p_secondId)
        {
            InitializeComponent();
            common_Init(p_firstId, p_secondId);
            tree_Init();
        }

        #region  界面初始化
        /// <summary>
        /// 初始化
        /// </summary>
        private void  common_Init(string p_firstId, string p_secondId){
            m_StructService = EAS.Services.ServiceContainer.GetService<IStructService>();
            m_AllPartsService = EAS.Services.ServiceContainer.GetService<IAllPartsService>();
            m_firstObj = m_AllPartsService.GetById(p_firstId);
            m_secondObj = m_AllPartsService.GetById(p_secondId);

            this.tb_firstNo.Text = m_firstObj.PRODUCTNO;
            this.tb_firstMemo.Text = m_firstObj.MEMO_ZH;
            this.tb_firstVersion.Text = m_firstObj.VERSION;

            this.tb_secondNo.Text = m_secondObj.PRODUCTNO;
            this.tb_secondMemo.Text = m_secondObj.MEMO_ZH;
            this.tb_secondVersion.Text = m_secondObj.VERSION;
        }

        /// <summary>
        /// 树结构展示初始化
        /// </summary>
        private void tree_Init() {
            treeRootCreate(this.tlv_treeFirst, m_firstObj.PRODUCTID, m_firstObj.PRODUCTNO);
            treeRootCreate(this.tlv_treeSecond, m_secondObj.PRODUCTID, m_firstObj.PRODUCTNO);
        }
        
        /// <summary>m
        /// 构造树根节点
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="p_productId"></param>
        private void treeRootCreate(TreeListView tree, string p_productId,string name)
        {
            TreeListViewItem root = new TreeListViewItem(name, 0);
            root.Expand();
            tree.Items.Add(root);
            treeChildCreate(root, p_productId);
            // this.list_productTreeStruct;
        }
        
        /// <summary>
        /// /构造树子节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="p_objectId"></param>
        private void treeChildCreate(TreeListViewItem node, string p_objectId)
        {
            DataTable dt_parts = m_StructService.GetStructPartList(p_objectId);
            int len = dt_parts.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                TreeListViewItem item = new TreeListViewItem(dt_parts.Rows[i]["PRODUCTNO"].ToString(), 0);
                node.Items.Add(item);
                //item.Expand();
                item.SubItems.Add(dt_parts.Rows[i]["VERSION"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["SORTNUM"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["MODELTYPE"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["ASSONUM"].ToString());
                item.SubItems.Add(dt_parts.Rows[i]["MEMO"].ToString());
                item.Tag = dt_parts.Rows[i]["ASSOBJECTID"].ToString();
                treeChildCreate(item, dt_parts.Rows[i]["ASSOBJECTID"].ToString());
            }

            DataTable dt_Materail = m_StructService.GetStructMaterailList(p_objectId);
            int len2 = dt_Materail.Rows.Count;
            for (int i = 0; i < len2; i++)
            {
                TreeListViewItem item = new TreeListViewItem(dt_Materail.Rows[i]["MATERIALNO"].ToString(), 0);
                node.Items.Add(item);
                // item.Expand();
                item.SubItems.Add(dt_Materail.Rows[i]["VERSION"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["SORTNUM"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["MODELTYPE"].ToString());
                item.SubItems.Add(dt_Materail.Rows[i]["ASSONUM"].ToString());
                item.Tag = dt_Materail.Rows[i]["ASSOBJECTID"].ToString();
                item.SubItems.Add(dt_Materail.Rows[i]["MEMO"].ToString());
            }
        }
        #endregion

        private void bt_comp_Click(object sender, EventArgs e)
        {
            TreeListViewItemCollection list_first = this.tlv_treeFirst.Items[0].Items;
            TreeListViewItemCollection list_second = this.tlv_treeSecond.Items[0].Items;

            int firstLen = list_first.Count;
            int secondLen = list_second.Count;
            int minLen;
            if (firstLen > secondLen) { minLen = secondLen; } else { minLen = firstLen; }

            for (int i = 0; i < minLen; i++)
            {
                setRowColor(list_first[i], list_second[i]);
            }

            for (int m = minLen; m < firstLen; m++)
            {
                changeColor(list_first[m], Color.Lime);
            }

            for  (int n=minLen;n<secondLen;n++)
            {
                changeColor(list_second[n], Color.Lime);
            }
            //Color.FromArgb(255, 128, 0)
        }


        private void setRowColor(TreeListViewItem item_first, TreeListViewItem item_second)
        {
            bool is_version = false;
            bool is_num = false;
            bool is_No = false;
            Color c = Color.Lime;
            if (item_first.SubItems[0].Text == item_second.SubItems[0].Text)//编号
            {
                is_No = true;
            }
            if (item_first.SubItems[1].Text == item_second.SubItems[1].Text)//版本
            {
                is_version = true;//Color t = Color.FromArgb(255, 128, 0);
            }
            if (item_first.SubItems[5].Text == item_second.SubItems[5].Text)//数量
            {
                is_num = true;// Color t = Color.FromArgb(255, 128, 0);
            }

            if (is_No && is_version && is_num) {//相同
                c = Color.FromArgb(192, 192, 255);
            }
            if (is_No && is_version && !is_num)//版本相同数量不同
            {
                c = Color.FromArgb(255, 128, 0);
            }
            if (is_No && !is_version && is_num)//版本不同数量相同
            {
                c = Color.FromArgb(255, 255, 192);
            }
            if (is_No && !is_version && !is_num)//版本不同数量不同
            {
                c = Color.FromArgb(128, 128, 255);
            }
            if (!is_No)//不相同
            {
                c = Color.Lime;
            }
            changeColor(item_first, c);
            changeColor(item_second, c);
        }

        /// <summary>
        /// 改变行背景色
        /// </summary>
        /// <param name="item"></param>
        /// <param name="c"></param>
        private void changeColor(TreeListViewItem item, Color c)
        {
            for (int j = 0; j < item.SubItems.Count; j++)
            {
                item.SubItems[j].BackColor = c;
            }
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_sortComp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
