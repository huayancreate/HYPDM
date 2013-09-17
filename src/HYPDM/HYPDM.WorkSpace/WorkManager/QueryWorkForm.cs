using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WorkSpace.WorkManager
{
    public partial class QueryWorkForm : Form
    {
        private  DataGridView m_dgvList;
        private DataTable m_dt;
        public QueryWorkForm(DataGridView p_dgvList,DataTable p_dt)
        {
            InitializeComponent();
            m_dgvList = p_dgvList;
            m_dt = p_dt;
        }

        private void bt_query_Click(object sender, EventArgs e)
        {

            DataTable newDt = m_dt.Clone();

            //string sql = "CREATEDATE >'" +dtp_createTime.Text+"'";
            string sql = "WFT_NAME like '%" + this.tb_modelName.Text + "%'  AND CREATEDATE >'" + dtp_createTime.Text + "'";
            DataRow[] dr = m_dt.Select(sql);

            for (int i = 0; i < dr.Length;i++ )
            {
                newDt.ImportRow(dr[i]);
            }
            m_dgvList.DataSource = newDt;

            this.DialogResult = DialogResult.OK;
        }
    }
}
