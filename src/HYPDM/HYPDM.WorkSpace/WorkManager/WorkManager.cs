using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Data.ORM;
namespace HYPDM.WorkSpace.WorkManager
{
    public partial class WorkManager : UserControl
    {
        private IMyWorkSpaceService m_MyWorkSpaceService = EAS.Services.ServiceContainer.GetService<IMyWorkSpaceService>();
        private MYWOKSPACE m_workSpace;
        private DataTable m_dt;
        public WorkManager(MYWOKSPACE p_workSpace)
        {
            InitializeComponent();
            m_workSpace = p_workSpace;
            init();
        }

        private void init() {
            if (m_workSpace == null)
            {
                this.tsl_delete.Visible = false;
            }
            else { 
               CommonEnum.workType t_type=(CommonEnum.workType)m_workSpace.QUERYTYPE;
               if (t_type.Equals(CommonEnum.workType.ReciveWork))
               {
                   this.tsl_delete.Visible = false;
                   this.tsb_retrive.Visible = false;
                   dgv_list_init(1,false);

               }else if(t_type.Equals(CommonEnum.workType.CompletWork)){
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE == 1)
                   {
                       this.tsl_delete.Visible = false;
                       this.tsb_retrive.Visible = true;
                       dgv_list_init(3, true);
                   }
                   else
                   {
                       dgv_list_init(3, false);
                   }
               }
               else if (t_type.Equals(CommonEnum.workType.SendWork))
               {
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE == 1)
                   {
                       this.tsl_delete.Visible = false;
                       this.tsb_retrive.Visible = true;
                       dgv_list_init(2, true);
                   }
                   else
                   {
                       dgv_list_init(2, false);
                   }
               }
                  
            }
        }

        private void dgv_list_init(int p_type,bool p_isDelete) {
            m_dt = HYPDM.WinUI.WorkFlow.FlowDetail.GetWorkDetail(HYPDM.WinUI.WorkFlow.CommonFuns.NewInstance.LoginInfo.LoginID, p_type);
            
            
            MYWORKRECORD mwr=new MYWORKRECORD();

            mwr.USERNAME=HYPDM.WinUI.WorkFlow.CommonFuns.NewInstance.LoginInfo.LoginID;
            mwr.WORK_TYPE = m_workSpace.QUERYTYPE;

            if (p_isDelete)
            {
                m_dt = m_MyWorkSpaceService.GetListFromTableAdd(m_dt, mwr);
            }
            else
            {
                m_dt = m_MyWorkSpaceService.GetListFromTableRemove(m_dt, mwr);
            }

            this.dgv_list.DataSource = m_dt;
            this.ucPaging1.SourceDataGridView = this.dgv_list;
        }

        private void dgv_list_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgv_list.RowCount <= 0) return;
            int rowIndex = this.dgv_list.CurrentCell.RowIndex;
         
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_list.Rows[rowIndex];
            string t_id = row.Cells["WFA_ID"].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            HYPDM.WinUI.WorkFlow.Flow.CurrentStepHandle o = new HYPDM.WinUI.WorkFlow.Flow.CurrentStepHandle(t_id);
           // o.WfAppID=t_id;
           // o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
            init();
        }

        private void tsl_delete_Click(object sender, EventArgs e)
        {

            if (this.dgv_list.RowCount <= 0) return;
            int rowIndex = this.dgv_list.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_list.Rows[rowIndex];
            string t_id = row.Cells["WFA_ID"].Value.ToString();
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            MYWORKRECORD mwr = new MYWORKRECORD();
            mwr.WORD_ID = row.Cells["WFA_ID"].Value.ToString();
            mwr.STEP_ID = row.Cells["Current_STEP_ID"].Value.ToString();
            mwr.USERNAME = HYPDM.WinUI.WorkFlow.CommonFuns.NewInstance.LoginInfo.LoginID;
            mwr.WORK_TYPE = m_workSpace.QUERYTYPE;
            m_MyWorkSpaceService.SaveRecord(mwr);
            init();
        }

        private void tsb_retrive_Click(object sender, EventArgs e)
        {
            if (this.dgv_list.RowCount <= 0) return;
            
            int rowIndex = this.dgv_list.CurrentCell.RowIndex;

            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_list.Rows[rowIndex];
            string t_id = row.Cells["WFA_ID"].Value.ToString();
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            MYWORKRECORD mwr = new MYWORKRECORD();
            mwr.WORD_ID = row.Cells["WFA_ID"].Value.ToString();
            mwr.STEP_ID = row.Cells["Current_STEP_ID"].Value.ToString();
            mwr.USERNAME = HYPDM.WinUI.WorkFlow.CommonFuns.NewInstance.LoginInfo.LoginID;
            mwr.WORK_TYPE = m_workSpace.QUERYTYPE;
            m_MyWorkSpaceService.DeleteRecord(mwr);
            init();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            QueryWorkForm o = new QueryWorkForm(this.dgv_list, m_dt);
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
            this.ucPaging1.SourceDataGridView = this.dgv_list;
        }
    }
}