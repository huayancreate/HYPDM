using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Services;
using EAS.Explorer;
using EAS.Data.ORM;
using HYPDM.BLL;
using HYPDM.Entities;
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public enum Enum_AssOpType{SAVE,EDIT,INSERT,REPLACE}

    public partial class StructAddForm : Form
    {
        private PDM_STRUCT m_struct;    //产品
        private string m_assojectId;  //关联对象ID
        private Enum_AssOpType m_assoPType;   //操作类型
        IStructService m_structService = EAS.Services.ServiceContainer.GetService<IStructService>();

        public StructAddForm(PDM_STRUCT p_struct, string p_assobjectId, Enum_AssOpType p_assoPType)
        {
            InitializeComponent();
            m_struct = p_struct;
            m_assojectId = p_assobjectId;
            m_assoPType = p_assoPType;
            initControl();
        }

        #region 初始化操作

        public void initControl()
        {
            if (this.m_assoPType == Enum_AssOpType.EDIT)
            {
                initEdit();
            } 
            else if (this.m_assoPType == Enum_AssOpType.SAVE) 
            {
                initSave();
            }
            else if (this.m_assoPType == Enum_AssOpType.INSERT)
            {
                initInsert();
            }
            else if (this.m_assoPType == Enum_AssOpType.REPLACE)
            {
                initReplace();
            }
        
        }
        //新建一条记录时显示初始化
        private void initSave() {
            this.tb_assoNum.Text = "";
            this.tb_assoWeight.Text = "";
            this.tb_sortNum.Text = m_structService.getCount(m_struct.OBJECTID);//获取产品结构的数量
            this.rtb_memo.Text = "";
        }

        //编辑一条记录时显示初始化
        private void initEdit() {
            DataTable dt = m_structService.getStruct(this.m_struct);

            this.tb_assoNum.Text = dt.Rows[0]["ASSONUM"].ToString();
            this.tb_assoWeight.Text = dt.Rows[0]["ASSOWEIGHT"].ToString();
            this.tb_sortNum.Text = dt.Rows[0]["SORTNUM"].ToString();
            this.rtb_memo.Text = dt.Rows[0]["MEMO"].ToString();
        }

        //替换一条记录时显示初始化
        private void initReplace() {
            PDM_STRUCT p_struct = new PDM_STRUCT();

            p_struct.OBJECTID = m_struct.OBJECTID;
            p_struct.ASSOBJECTID = this.m_assojectId;

            DataTable dt = m_structService.getStruct(p_struct);

            this.tb_assoNum.Text = dt.Rows[0]["ASSONUM"].ToString();
            this.tb_assoWeight.Text = dt.Rows[0]["ASSOWEIGHT"].ToString();
            this.tb_sortNum.Text = dt.Rows[0]["SORTNUM"].ToString();
            this.rtb_memo.Text = dt.Rows[0]["MEMO"].ToString();
        }
        //插入一条记录时显示初始化
        private void initInsert() {
            PDM_STRUCT p_struct = new PDM_STRUCT();

            p_struct.OBJECTID = m_struct.OBJECTID;
            p_struct.ASSOBJECTID = this.m_assojectId;

            DataTable dt = m_structService.getStruct(p_struct);

            this.tb_assoNum.Text = "";
            this.tb_assoWeight.Text = "";
            this.tb_sortNum.Text = (Convert.ToInt16(dt.Rows[0]["SORTNUM"].ToString())+1).ToString() ;
            this.rtb_memo.Text = "";
        
        }
        #endregion

        #region 控件操作
        //保存按钮操作
        private void btn_save_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_STRUCT temp_struct = new HYPDM.Entities.PDM_STRUCT();

            temp_struct.OBJECTID = this.m_struct.OBJECTID;
            temp_struct.ASSOBJECTID = this.m_struct.ASSOBJECTID;
            temp_struct.ASSONUM = this.tb_assoNum.Text;
            temp_struct.ASSOWEIGHT = this.tb_assoWeight.Text;
            temp_struct.SORTNUM = this.tb_sortNum.Text;
            temp_struct.MEMO=this.rtb_memo.Text;
            //temp_struct.Save();//需要表有主键
            if (this.m_assoPType == Enum_AssOpType.SAVE)
            {
                m_structService.saveStruct(temp_struct);
                MessageBox.Show("添加成功");
            }
            else if (this.m_assoPType == Enum_AssOpType.EDIT)
            {
                m_structService.editStruct(temp_struct, this.m_assojectId);
                MessageBox.Show("修改成功");
            }
            else if (this.m_assoPType == Enum_AssOpType.INSERT)
            {
                m_structService.transactionExc(temp_struct.OBJECTID,(Convert.ToInt16(temp_struct.SORTNUM) - 1).ToString());
                m_structService.saveStruct(temp_struct);
                MessageBox.Show("插入成功");
            }
            else if (this.m_assoPType == Enum_AssOpType.REPLACE) {
                m_structService.editStruct(temp_struct,this.m_assojectId);
                MessageBox.Show("替换成功");
            }
            this.DialogResult = DialogResult.OK;
        }


        //取消按钮操作
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region 自定义操作
        //排序序号加1
        private void addSortNum() {
            
        }


        #endregion
    }
}
