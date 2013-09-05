using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HYPDM.Entities;
using EAS.Explorer;
using EAS.Services;
using HYPDM.BLL;
using System.Windows.Forms;
namespace HYPDMWorkFlow
{
    public class WorkFlow
    {
        private static WorkFlow newInstance = null;

        /// <summary>
        /// 
        /// </summary>
        public static WorkFlow NewInstance
        {
            get
            {
                if (newInstance == null)
                {
                    newInstance = new WorkFlow();
                }
                return WorkFlow.newInstance;
            }
            //  set { WorkFlow.newInstance = value; }
        }

        public void CreateWF(string wftID, System.Windows.Forms.Control ctl)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            IList<WF_TEMPLATES_STEP> list = _wfService.GetWFStepList(wftID);
            int x = 41;
            int y = 21;
            if (list == null || list.Count == 0)
            {

            }
            else
            {
                Panel pnl = null;
                foreach (WF_TEMPLATES_STEP step in list)
                {
                    Button btnStep = new Button();
                    btnStep.BackColor = System.Drawing.SystemColors.InactiveBorder;
                    btnStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    btnStep.FlatAppearance.BorderSize = 5;
                    btnStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
                    btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    btnStep.Location = new System.Drawing.Point(x, y);
                    btnStep.Name = step.WFT_STEP_ID;
                    btnStep.Size = new System.Drawing.Size(326, 50);
                    btnStep.TabIndex = 0;
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)"+_wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    else {
                        btnStep.Text = _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                     pnl = new Panel();
                    pnl.BackColor = System.Drawing.Color.Transparent;
                    pnl.BackgroundImage = global::HYPDMWorkFlow.Properties.Resources.line;
                    pnl.Location = new System.Drawing.Point(130+x, y+45);
                    pnl.Name = "pnl";
                    pnl.Size = new System.Drawing.Size(32, 30);
                    pnl.TabIndex = 0;
                    btnStep.UseVisualStyleBackColor = false;
                    ctl.Controls.Add(btnStep);
                    ctl.Controls.Add(pnl);
                    y += 55+22;
                }
                ctl.Controls.Remove(pnl);
            }
            //this.btnTest.BackColor = System.Drawing.SystemColors.InactiveBorder;
            //this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            //this.btnTest.FlatAppearance.BorderSize = 5;
            //this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            //this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            //this.btnTest.Location = new System.Drawing.Point(41, 21);
            //this.btnTest.Name = "btnTest";
            //this.btnTest.Size = new System.Drawing.Size(326, 50);
            //this.btnTest.TabIndex = 0;
            //this.btnTest.Text = "测试";
            //this.btnTest.UseVisualStyleBackColor = false;
        }
    }
}
