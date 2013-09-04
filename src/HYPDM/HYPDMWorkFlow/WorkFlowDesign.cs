using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAS.Explorer;
using EAS.Modularization;
namespace HYPDMWorkFlow
{
    [Module("{EB7A20E5-0875-4C82-93AE-0A8CA67C137F}", "工作流设计", "工作流设计")]
    public partial class WorkFlowDesign : UserControl
    {
        public WorkFlowDesign()
        {
            InitializeComponent();
        }
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        [ModuleStart]
        public void StartEx()
        {
            initialEvent(false,false,false);
        }
        /// <summary>
        /// </summary>
        /// <param name="pnlTop"></param>
        /// <param name="pnlMain"></param>
        /// <param name="dgVStepInfo"></param>
        private void initialEvent(Boolean pnlTop, Boolean pnlMain, Boolean dgVStepInfo)
        {
            this.pnlTop.Visible = pnlTop;
            
            this.pnlMain.Visible = pnlMain;
            this.dgVStepInfo.Visible = dgVStepInfo;
            //this.pnlTop.Dock = DockStyle.Top;
            //this.pnlMain.Dock = DockStyle.Left;
            //this.dgVStepInfo.Dock = DockStyle.Fill;
        }

        private void btnWorkFlowNew_Click(object sender, EventArgs e)
        {
            initialEvent(true, false, false);
            this.txtWFName.Text = "";
            this.txtWFName.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.txtWFName.Text == "")
            {
                this.txtWFName.Focus();
                this.txtWFName.SelectAll();
              
            }
            else
            {
                Boolean IsExist = false;
                //判定数据库中是否已经存在同名称的工作流
                if (IsExist)
                {
                    MessageBox.Show("已经存在同名称的工作流,请重新命名!","工作流提示助手提醒您:",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    this.txtWFName.Focus();
                    this.txtWFName.SelectAll();
                    return;
                }
                else
                {
                    initialEvent(true, true, false);
                    this.txtDefineUser.Text = LoginInfo.LoginID;
                    this.txtUsers.Focus();
                    this.combCurrentStep.SelectedItem = "拟制";
                    this.combCurrentStep.Enabled = false;
                }

                this.combThroughNext.Items.Remove("拟制");

            }
           
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (this.combCurrentStep.Text == "拟制")
            {
                this.radioBtnYes.Checked = true;
            }
        }

        private void combCurrentStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.combCurrentStep.Text == "拟制")
            {
                this.radioBtnYes.Checked = true;
            }
        }

        private void combCurrentStep_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.combCurrentStep.Text == "拟制")
            {
                this.radioBtnYes.Checked = true;
            }
        }
    }
}
