using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
namespace HYPDM.WorkSpace.WorkManager
{
    public partial class WorkManager : UserControl
    {
        private MYWOKSPACE m_workSpace;
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
                   dgv_list_init(1);

               }else if(t_type.Equals(CommonEnum.workType.CompletWork)){
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE==1)
                   {
                       this.tsb_retrive.Visible = true;
                   } 
                   dgv_list_init(3);
               }
               else if (t_type.Equals(CommonEnum.workType.SendWork))
               {
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE == 1)
                   {
                       this.tsb_retrive.Visible = true;
                   }
                   dgv_list_init(2);
               }
                  
            }
        }

        private void dgv_list_init(int p_type) {
            this.dgv_list.DataSource = HYPDM.WinUI.WorkFlow.FlowDetail.GetWorkDetail(HYPDM.WinUI.WorkFlow.CommonFuns.NewInstance.LoginInfo.LoginID,p_type);
        }

        private void dgv_list_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = this.dgv_list.CurrentCell.RowIndex;
         
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dgv_list.Rows[rowIndex];
            string t_id = row.Cells[0].Value.ToString();

            if (string.IsNullOrEmpty(t_id))
            {
                return;
            }
            if (t_id == null)
            {
                MessageBox.Show("请选择一条记录"); return;
            }

            HYPDM.WinUI.WorkFlow.Flow.CurrentStepHandle o = new HYPDM.WinUI.WorkFlow.Flow.CurrentStepHandle();
            o.WfAppID=t_id;
            o.StartPosition = FormStartPosition.CenterParent;
            o.ShowDialog();
        }
    }
}
