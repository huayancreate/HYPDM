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
                   dgv_list_init();

               }else if(t_type.Equals(CommonEnum.workType.CompletWork)){
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE==1)
                   {
                       this.tsb_retrive.Visible = true;
                   }
               }
               else if (t_type.Equals(CommonEnum.workType.SendWork))
               {
                   this.tsl_delete.Visible = true;
                   this.tsb_retrive.Visible = false;
                   if (m_workSpace.ISDELETE == 1)
                   {
                       this.tsb_retrive.Visible = true;
                   }
               }
                  
            }
        }

        private void dgv_list_init() { 
 
        }
    }
}
