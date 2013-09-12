using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
namespace HYPDM.WorkSpace.WorkManager
{
    public partial class NewNodeAddForm : Form
    {
        IMyWorkSpaceService m_MyWorkSpaceService = EAS.Services.ServiceContainer.GetService<IMyWorkSpaceService>();
        private TreeNode m_node;

        public NewNodeAddForm(MYWOKSPACE p_myworkspace, TreeNode p_node)
        {
            InitializeComponent();
            m_myWorkSapce = p_myworkspace;
            m_node = p_node;
            init();
        }

        public MYWOKSPACE m_myWorkSapce
        {
            get;
            set;
        }

        private void init() {
            tb_struct_Init();
            if (m_myWorkSapce == null)
            {
                this.cmb_module.SelectedIndex = 0;
                this.cmb_query.SelectedIndex = 0;
                this.cmb_image.SelectedIndex = 0;
                this.tb_sortNum.Text = "0";
            }
            else {
                this.tb_name.Text = m_myWorkSapce.NAME;
                this.tb_struct.SelectedValue = m_myWorkSapce.PARENTID;
                this.cmb_module.SelectedIndex = m_myWorkSapce.MODULETYPE;
                if (m_myWorkSapce.ISDELETE == 1) { this.ck_delete.Checked = true; } else { this.ck_delete.Checked = false; }
                this.cmb_query.SelectedIndex = m_myWorkSapce.QUERYTYPE;
                this.cmb_image.SelectedIndex= m_myWorkSapce.IMAGETYPE ;
                this.tb_sortNum.Text = m_myWorkSapce.SORTNUM.ToString() ;
                if (m_myWorkSapce.ISADDCHILD == 1) { this.ck_addchild.Checked = true; } else { this.ck_addchild.Checked = false; }
            }
        }

        private  void tb_struct_Init(){
            DataTable dt = m_MyWorkSpaceService.GetComBoxList();
            DataRow dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "根节点";
            dt.Rows.InsertAt(dr,0);

            this.tb_struct.DataSource = dt;
            this.tb_struct.DisplayMember="NAME";
            this.tb_struct.ValueMember = "ID";
            if (m_node.Tag != null) {
                this.tb_struct.SelectedValue = ((MYWOKSPACE)m_node.Tag).ID;
            }
        }


        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            MYWOKSPACE t_myworkspace = new MYWOKSPACE();
            if (m_myWorkSapce == null)
            {
                t_myworkspace.ID = Guid.NewGuid().ToString();
            }
            else {
                t_myworkspace.ID = this.m_myWorkSapce.ID;
            }
            t_myworkspace.NAME = this.tb_name.Text;
            t_myworkspace.PARENTID = this.tb_struct.SelectedValue.ToString();
            t_myworkspace.MODULETYPE = this.cmb_module.SelectedIndex;
            if( this.ck_delete.Checked){t_myworkspace.ISDELETE=1;}else{t_myworkspace.ISDELETE=0;}
            t_myworkspace.QUERYTYPE = this.cmb_query.SelectedIndex;
            t_myworkspace.IMAGETYPE = this.cmb_image.SelectedIndex;
            t_myworkspace.USERID = "ALL";
            t_myworkspace.SORTNUM = Convert.ToInt16(this.tb_sortNum.Text);
            if (this.ck_addchild.Checked) { t_myworkspace.ISADDCHILD = 1; } else { t_myworkspace.ISADDCHILD = 0; }
            m_myWorkSapce = t_myworkspace;
            this.DialogResult = DialogResult.OK;
        }
    }
}
