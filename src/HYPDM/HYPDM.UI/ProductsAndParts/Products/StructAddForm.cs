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
namespace HYPDM.WinUI.ProductsAndParts.Products
{
    public partial class StructAddForm : Form
    {
        private string m_objectId;
        private string m_assojectId;
        IStructService m_structService = EAS.Services.ServiceContainer.GetService<IStructService>();
        public StructAddForm(string p_objectId,string p_assobjectId)
        {
            InitializeComponent();
            m_objectId = p_objectId;
            m_assojectId = p_assobjectId;
            initControl();
        }

        public bool m_opStatus;
        public bool OpStatus
        {
            get { return this.m_opStatus; }
            set { this.m_opStatus = value; initControl(); }
        }

        public void initControl()
        {
            HYPDM.Entities.PDM_STRUCT p_struct = new Entities.PDM_STRUCT();
            p_struct.OBJECTID = m_objectId;
            p_struct.ASSOBJECTID = m_assojectId;
            DataTable dt= m_structService.getStruct(p_struct);

            if (dt.Rows.Count>0) {
                this.tb_assoNum.Text = dt.Rows[0]["ASSONUM"].ToString();
                this.tb_assoWeight.Text = dt.Rows[0]["ASSOWEIGHT"].ToString();
                this.tb_sortNum.Text = dt.Rows[0]["SORTNUM"].ToString();
                this.rtb_memo.Text = dt.Rows[0]["MEMO"].ToString();
                this.m_opStatus = false;
            }else{
                this.tb_assoNum.Text="";
                this.tb_assoWeight.Text="";
                this.tb_sortNum.Text="";
                this.rtb_memo.Text="";
                this.m_opStatus = true;
            }
        
        }
        //保存按钮操作
        private void btn_save_Click(object sender, EventArgs e)
        {
            HYPDM.Entities.PDM_STRUCT temp_struct = new HYPDM.Entities.PDM_STRUCT();

            temp_struct.OBJECTID = this.m_objectId;
            temp_struct.ASSOBJECTID = this.m_assojectId;
            temp_struct.ASSONUM = this.tb_assoNum.Text;
            temp_struct.ASSOWEIGHT = this.tb_assoWeight.Text;
            temp_struct.SORTNUM = this.tb_sortNum.Text;
            temp_struct.MEMO=this.rtb_memo.Text;
            //temp_struct.Save();//需要表有主键
            if (this.m_opStatus)
            {
                m_structService.saveStruct(temp_struct);
                MessageBox.Show("添加成功");
            }
            else {
                m_structService.editStruct(temp_struct);
                MessageBox.Show("修改成功");
            }
            this.DialogResult = DialogResult.OK;
        }
        
    }
}
