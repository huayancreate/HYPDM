using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.WorkFlow
{
    public partial class RelationObject : Form
    {
        public RelationObject()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        private string wfTemplates = "";

        public string WfTemplates
        {
            get { return wfTemplates; }
            set { wfTemplates = value; }
        }
        private void RelationObject_Load(object sender, EventArgs e)
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql("WFT_ID,WFT_NAME", "WHERE DEL_FLAG='N' AND STATUS='Complete'", "WF_TEMPLATES");
            this.dgvExtTemplates.DataSource = dtTemp;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.dgvExtTemplates.CurrentRow == null)
            {
                MessageBox.Show("请选择工作流模板!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("请确认修改为模板:!" + this.dgvExtTemplates.CurrentRow.Cells["WFT_NAME"].Value.ToString(), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    WfTemplates = this.dgvExtTemplates.CurrentRow.Cells["WFT_ID"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
