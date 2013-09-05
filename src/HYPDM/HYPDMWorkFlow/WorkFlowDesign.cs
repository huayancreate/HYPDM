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
using HYPDM.Entities;
using EAS.Data.Linq;
using EAS.Data.ORM;
namespace HYPDMWorkFlow
{
    [Module("{EB7A20E5-0875-4C82-93AE-0A8CA67C137F}", "工作流设计", "工作流设计")]
    public partial class WorkFlowDesign : UserControl
    {
        public WorkFlowDesign()
        {
            InitializeComponent();
        }
        private string currentWFTemplateID = "";
        private string currentWFStep = "";
        [ModuleStart]
        public void StartEx()
        {
            initialEvent(false, false); //初始化显示部分控件
            setComboxValue();

        }

        private void setComboxValue()
        {
            CommonFuns.SetComboBoxValue(this.combCurrentStep, "WorkFlowStep", -1);
            CommonFuns.SetComboBoxValue(this.combThroughNext, "WorkFlowStep", -1);
        }
        /// <summary>
        /// </summary>
        /// <param name="pnlTop"></param>
        /// <param name="pnlMain"></param>
        /// <param name="dgVStepInfo"></param>
        private void initialEvent(Boolean pnlTop, Boolean pnlMain)
        {
            this.pnlTop.Visible = pnlTop;

            this.pnlMain.Visible = pnlMain;
           
            //this.pnlTop.Dock = DockStyle.Top;
            //this.pnlMain.Dock = DockStyle.Left;
            //this.dgVStepInfo.Dock = DockStyle.Fill;
        }

        private void btnWorkFlowNew_Click(object sender, EventArgs e)
        {
            initialEvent(true, false);
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

                //判定数据库中是否已经存在同名称的工作流
                if (IsWFTemplateExist())
                {
                    MessageBox.Show("已经存在同名称的工作流,请重新命名!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.txtWFName.Focus();
                    this.txtWFName.SelectAll();
                    return;
                }
                else
                {

                    this.txtDefineUser.Text = CommonFuns.NewInstance.LoginInfo.LoginID;
                    this.txtUsers.Focus();
                    this.radioBtnYes.Checked = true;  //第一次创建的第一个步骤默认为起始节点
              
                    //保存
                    WF_TEMPLATES tempate = new WF_TEMPLATES();
                    tempate.WFT_ID = Guid.NewGuid().ToString();
                    tempate.WFT_NAME = this.txtWFName.Text.ToString();
                    tempate.DEL_FLAG = "N";
                    tempate.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    tempate.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    try
                    {
                        tempate.Save();
                        currentWFTemplateID = tempate.WFT_ID;
                        ///
                        this.txtWFName.Enabled = false;
                        this.btnNextStep.Enabled = true;
                        this.btnSave.Enabled = true;
                        initialEvent(true, true);
                        combCurrentStep.Focus();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message.ToString());
                    }
                    finally
                    {

                    }


                }
                //this.combThroughNext.Items.Remove(this.combCurrentStep.SelectedItem);

                // RefreshNextStepNode();

            }

        }


        private void RefreshNextStepNode()
        {   
           
            this.combThroughNext.DataSource = CommonFuns.getDataTableBySql("COMBTEXT,COMBVALUE", "WHERE  COMBTYPE ='WorkFlowStep' AND  COMBID  NOT IN (SELECT WFT_CURRENT_STEP_ID FROM WF_TEMPLATES_STEP WHERE DEL_FLAG='N' AND WFT_ID IN (SELECT  WFT_ID FROM WF_TEMPLATES WHERE WFT_NAME='" + this.txtWFName.Text.ToString() + "' AND DEL_FLAG='N'))", "ComboBoxValue");
            combThroughNext.DisplayMember = "COMBTEXT";
            combThroughNext.ValueMember = "COMBVALUE";
            combThroughNext.SelectedIndex = -1;

            this.combCurrentStep.DataSource = CommonFuns.getDataTableBySql("COMBTEXT,COMBVALUE", "WHERE  COMBTYPE ='WorkFlowStep' AND  COMBID  NOT IN (SELECT WFT_CURRENT_STEP_ID FROM WF_TEMPLATES_STEP WHERE DEL_FLAG='N' AND WFT_ID IN (SELECT  WFT_ID FROM WF_TEMPLATES WHERE WFT_NAME='" + this.txtWFName.Text.ToString() + "' AND DEL_FLAG='N'))", "ComboBoxValue");
            combCurrentStep.DisplayMember = "COMBTEXT";
            combCurrentStep.ValueMember = "COMBVALUE";
            combCurrentStep.SelectedValue = currentWFStep;

        }



        private void combCurrentStep_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.combCurrentStep.SelectedValue == "928ff93c-35df-4126-9f75-d81b119cd160")  //拟制
            //{
            //    this.radioBtnYes.Checked = true;
            //}
            //else
            //{
            //    this.radioBtnNo.Checked = true;
            //}
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            //判定数据库中是否存在此工作流，如果不存在的话，需要首先创建一个初始步骤的节点，否则下一步骤，不能为起始节点了。

            if (this.combCurrentStep.SelectedIndex == -1 || this.combThroughNext.SelectedIndex == -1)
            {
                MessageBox.Show("当前步骤与下一步流向不能为空", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.combThroughNext.Focus();
                return;
            }
            if (this.combCurrentStep.SelectedValue.ToString() == this.combThroughNext.SelectedValue.ToString())
            {

                MessageBox.Show("当前步骤与下一步流向不能相同!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.combThroughNext.Focus();
                return;
            }
            //判定是否为第一个节点
            if (IsWFFirstStep())
            {

                if (this.radioBtnYes.Checked == false)
                {
                    if (MessageBox.Show("工作流的第一个步骤需要设置为起始步骤,是否自动设为起始步骤?", "工作流提示助手提醒您:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        this.radioBtnYes.Checked = true;
                    }
                }
                else
                {
                    if (this.radioEndY.Checked == true && this.radioBtnYes.Checked == true)
                    {
                        if (MessageBox.Show("同时设置该节点为起始节点与最后节点?", "工作流提示助手提醒您:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }

            }
            else
            {     
                if (this.radioBtnYes.Checked == true)
                {
                    MessageBox.Show("已经存在起始节点!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //保存节点
            WF_TEMPLATES_STEP step = new WF_TEMPLATES_STEP();
            step.IS_END_STEP = radioEndY.Checked == true ? "Y" : "N";

            if (step.IS_END_STEP == "Y")
            {
                if (MessageBox.Show("该步骤为此工作流的最后一步，请确认后提交?", "工作流提示助手提醒您:", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                {
                    return;
                }
            }


            step.WFT_STEP_ID = Guid.NewGuid().ToString();
            step.WFT_ID = this.currentWFTemplateID;
            step.WFT_STEP_DESC = this.txtComment.Text.ToString().Trim();
            step.WFT_CURRENT_STEP_ID = this.combCurrentStep.SelectedValue.ToString();
            step.WFT_NEXT_STEP_ID = this.combThroughNext.SelectedValue.ToString();
            step.WFT_CURRENT_STEP_USERTYPE = "";
            step.WFT_CURRENT_STEP_USERID = "";
            step.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            step.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
            step.DEL_FLAG = "N";
            step.IS_ALLOW_DELETE = this.chkDelWF.Checked == true ? "Y" : "N";
            step.IS_ALLOW_EDIT = this.chkMdyContent.Checked == true ? "Y" : "N";
            step.IS_NOTE_STARTUSER = this.chkStartUserNote.Checked == true ? "Y" : "N";
            step.IS_START_STEP = radioBtnYes.Checked == true ? "Y" : "N";
           
            try
            {
                currentWFStep = this.combThroughNext.SelectedValue.ToString();  //记录下一节点的去向
                this.combCurrentStep.Enabled = false;
                step.Save();
                RefreshNextStepNode();
                this.gpWFG.Controls.Clear();
              //  this.combThroughNext.Items.Remove(this.combCurrentStep.SelectedItem);
                WorkFlow.NewInstance.CreateWF(this.currentWFTemplateID, this.gpWFG);
            }
            catch (Exception ex)
            {
               

            }
            finally
            {
 
            }
            if (step.IS_END_STEP == "Y")
            {
                this.btnNextStep.Enabled = false;
                this.btnSave.Enabled = false;
                this.txtWFName.Enabled = true;
            }


        }



        /// <summary>
        /// 判定是否有同名称的工作流
        /// </summary>
        /// <returns></returns>
        private Boolean IsWFTemplateExist()
        {
            DataTable dt = null;
            Boolean blResult = false;
            dt = CommonFuns.getDataTableBySql("WFT_ID,WFT_NAME", "WHERE DEL_FLAG='N' AND WFT_NAME='" + this.txtWFName.Text.ToString().Trim() + "'", "WF_TEMPLATES");
            if (dt == null || dt.Rows.Count == 0)
            {
                blResult = false;
            }
            else
            {
                blResult = true;
            }
            return blResult;
        }
        /// <summary>
        /// 判定是否是第一个需要保存的节点
        /// </summary>
        /// <returns></returns>
        private Boolean IsWFFirstStep()
        {
            DataTable dt = null;
            Boolean blResult = false;
            dt = CommonFuns.getDataTableBySql("WFT_CURRENT_STEP_ID", "WHERE DEL_FLAG='N' AND WFT_ID IN (SELECT  WFT_ID FROM WF_TEMPLATES WHERE WFT_ID='" + this.currentWFTemplateID + "' AND DEL_FLAG='N')", "WF_TEMPLATES_STEP");
            if (dt == null || dt.Rows.Count == 0)
            {
                blResult = true;
            }
            else
            {
                blResult = false;
            }
            return blResult;
        }

        //private void CreateWF(string wftID)
        //{
        //    //this.btnTest.BackColor = System.Drawing.SystemColors.InactiveBorder;
        //    //this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        //    //this.btnTest.FlatAppearance.BorderSize = 5;
        //    //this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
        //    //this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        //    //this.btnTest.Location = new System.Drawing.Point(41, 21);
        //    //this.btnTest.Name = "btnTest";
        //    //this.btnTest.Size = new System.Drawing.Size(326, 50);
        //    //this.btnTest.TabIndex = 0;
        //    //this.btnTest.Text = "测试";
        //    //this.btnTest.UseVisualStyleBackColor = false;
        //}
    }
}
