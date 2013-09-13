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
using HYPDM.BLL;
using System.Threading;
namespace HYPDM.WinUI.WorkFlow
{
    [Module("{EB7A20E5-0875-4C82-93AE-0A8CA67C137F}", "工作流设计", "工作流设计")]
    public partial class WorkFlowDesign : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public WorkFlowDesign()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 当前操作的工作流ID
        /// </summary>
        private string currentWFTemplateID = "";
        /// <summary>
        /// 当前节点value，记录下一节点的去向，新增加下一节点的当前节点值
        /// </summary>
        private string currentWFStep = "";
        [ModuleStart]
        public void StartEx()
        {
            initialEvent(false, false); //初始化显示部分控件
            setComboxValue();
            pnlModify.Visible = false;
            pnlBtnTools.Visible = false;
       
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
            this.txtWFName.Enabled = true;
            this.pnlModify.Visible = false;

            this.btnModify.Visible = false;
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

                    this.pnlModify.Visible = false;
                    this.pnlMain.Enabled = true;
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
                        initialEvent(true, true);
                        combCurrentStep.Focus();
                        pnlBtnTools.Visible = true;

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

        private void btnNextStepAdd_Click(object sender, EventArgs e)
        {
            //判定数据库中是否存在此工作流，如果不存在的话，需要首先创建一个初始步骤的节点，否则下一步骤，不能为起始节点了。
            ///1.判定此工作流是否已经为完成状态 
            /////check
            # region 
            if (this.currentWFTemplateID == "")
            {
                MessageBox.Show("没有指定工作流对象!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                WF_TEMPLATES wf = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.currentWFTemplateID);
                if (wf == null)
                {
                    MessageBox.Show("没有查询到当期那工作流信息", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (wf.STATUS == DataType.WFTEMPLATESSTATUS.Complete.ToString())
                {
                    MessageBox.Show("当前工作流状态为:【" + DataType.WFTEMPLATESSTATUS.Complete.ToString() + "】不允许再添加新节点", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            #endregion
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
                WorkFlow.NewInstance.CreateWF(this.currentWFTemplateID, this.gpWFG); //绘制出工作流走向
            }
            catch (Exception ex)
            {


            }
            finally
            {

            }
            if (step.IS_END_STEP == "Y")
            {
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

        /// <summary>
        /// 修改工作流
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.txtWFName.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要修改的工作流名称!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.txtWFName.Focus();
                return;
            }
            else
            {
                DataTable dt = CommonFuns.getDataTableBySql("WFT_ID,WFT_NAME,CREATEUSER", "WHERE WFT_NAME='" + this.txtWFName.Text + "'", "WF_TEMPLATES");
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("你输入的工作流名称不存在,请确认后再输入!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.txtWFName.SelectAll();
                    return;
                }
                else if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("数据异常，该工作流名称不唯一,请确认后再输入!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.txtWFName.SelectAll();
                    return;
                }
                else
                {
                    this.currentWFTemplateID = dt.Rows[0]["WFT_ID"].ToString();
                    WorkFlow.NewInstance.CreateWF(this.currentWFTemplateID, this.gpWFG);
                    this.txtWFName.Enabled = false;
                    this.txtDefineUser.Text = dt.Rows[0]["CREATEUSER"].ToString();
                    this.pnlModify.Visible = false;
                }

            }
            pnlBtnTools.Visible = true;
            //this.pnlMain.Visible = true;
            this.pnlMain.Enabled = false;
            foreach (Control ctl in gpWFG.Controls)
            {
                if (ctl.GetType().Name == "Button")
                {
                    ((Button)ctl).Click += new EventHandler(WorkFlowDesign_Click); //添加代理方法
                }
            }

        }
        private void WorkFlowDesign_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name.ToString());
            string stepID = ((Button)sender).Name.ToString();
            if (stepID == "")
            {
                return;
            }
            WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStepInfoByStepID(stepID);

            this.combCurrentStep.SelectedValue = step.WFT_CURRENT_STEP_ID;

            this.currentWFStep = step.WFT_STEP_ID;
            this.currentWFTemplateID = step.WFT_ID; //可以不要，前面已经赋值
            this.combThroughNext.SelectedValue = step.WFT_NEXT_STEP_ID;
            this.radioBtnYes.Checked = step.IS_START_STEP == "Y" ? true : false;
            if (this.radioBtnYes.Checked == false)
            {
                this.radioBtnNo.Checked = true;
            }
            else
            {
                this.radioBtnNo.Checked = false;
            }

            if (step.IS_ALLOW_DELETE == "Y")
            {
                this.chkDelWF.Checked = true;
            }
            else
            {
                this.chkDelWF.Checked = false;
            }

            if (step.IS_ALLOW_EDIT == "Y")
            {
                this.chkMdyContent.Checked = true;
            }
            else
            {
                this.chkMdyContent.Checked = false;
            }

            if (step.IS_NOTE_STARTUSER == "Y")
            {
                this.chkStartUserNote.Checked = true;
            }
            else
            {
                this.chkStartUserNote.Checked = false;
            }
            this.txtComment.Text = step.WFT_STEP_DESC;


            //    this.pnlModify.Location = new System.Drawing.Point(298, 2);
            this.pnlModify.Visible = true;
            this.pnlMain.Visible = true;
            this.pnlMain.Enabled = false;


        }

        private void btnWorkFlowModify_Click(object sender, EventArgs e)
        {
            initialEvent(true, false);
            this.txtWFName.Enabled = true;
            this.btnModify.Location = new System.Drawing.Point(301, 17);
            this.btnModify.Visible = true;
            this.txtWFName.Focus();
            this.txtDefineUser.Text = "";
            this.txtDefineUser.Text = CommonFuns.NewInstance.LoginInfo.LoginID;
            pnlBtnTools.Visible = false;
        }

        private void btnStepModify_Click(object sender, EventArgs e)
        {
            if (this.btnStepModify.Text == "修改")
            {
                this.pnlMain.Enabled = true;
                this.combCurrentStep.Enabled = false;
                this.combThroughNext.Enabled = false;
                //this.groupBox2.Enabled = false;
                //this.groupBox3.Enabled = false;
                this.btnStepModify.Text = "保存";
            }
            else
            {

                ///修改
                this.btnStepModify.Text = "修改";
            }

        }

        private void btnStepDel_Click(object sender, EventArgs e)
        {
            if (this.currentWFTemplateID == "" || this.combCurrentStep.SelectedIndex == -1 || this.currentWFStep == "")
            {
                return;
            }
            Boolean hasEndStep = false; //是否有终节点
            IList<WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(this.currentWFTemplateID);
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("不存在该工作流信息!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                foreach (WF_TEMPLATES_STEP ss in list)
                {
                    if (ss.IS_END_STEP == "Y")
                    {
                        hasEndStep = true;
                        return;
                    }
                }
            }


            WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStepInfoByStepID(this.currentWFStep);
            if (step == null)
            {
                MessageBox.Show("找不到该节点信息!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            IList<WF_TEMPLATES_STEP> steps = WorkFlow.NewInstance.GetGreaterWFStepListByStepID(this.currentWFStep, this.currentWFTemplateID);
            if (steps != null && steps.Count > 0)
            {
                MessageBox.Show("此节点后面还有节点，请从最后面的节点开始删除!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            if (hasEndStep)
            {
                if (step.IS_END_STEP == "Y")
                {
                    wfModify(step);
                }
                else
                {
                    MessageBox.Show("工作流存在终节点，请从终节点开始删除!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                wfModify(step);
            }

        }
        private void wfModify(WF_TEMPLATES_STEP step)
        {
            //删除
            step.DEL_FLAG = "Y";
            step.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
            step.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                step.Save();
                this.gpWFG.Controls.Clear();
                WorkFlow.NewInstance.CreateWF(this.currentWFTemplateID, this.gpWFG);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                MessageBox.Show("删除成功", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void btnWFHold_Click(object sender, EventArgs e)
        {
            if (this.currentWFTemplateID == "")
            {
                MessageBox.Show("没有指定工作流对象!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                WF_TEMPLATES wf = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.currentWFTemplateID);
                if (wf == null)
                {
                    MessageBox.Show("没有查找到指定的工作流模板信息", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (wf.STATUS == DataType.WFTEMPLATESSTATUS.Hold.ToString())
                {
                    MessageBox.Show("目前状态已经为停用，无需再次停用", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    wf.STATUS = DataType.WFTEMPLATESSTATUS.Hold.ToString();
                    wf.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wf.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    try
                    {
                        wf.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    finally
                    {
                        MessageBox.Show("工作流：" + wf.WFT_NAME + ",已经停用成功.", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.currentWFTemplateID == "")
            {
                MessageBox.Show("没有指定工作流对象!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            //需要加入一些Check进行验证
            //1.是否存在终结点
            //2.是否有起始节点
            //3.是否有重复的步骤节点
            //4.
            //成功后执行如下代码
            
             WF_TEMPLATES_STEP endStep = WorkFlow.NewInstance.GetWFEndStepByWFID(this.currentWFTemplateID);
             
            /// check是否有终节点
             if (endStep == null)
             {
                 MessageBox.Show("没有指定工作流对象【" + this.txtWFName.Text + "】的终节点,无法正式启用!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                 return;
             }
             /// check是否有起始节点
             WF_TEMPLATES_STEP startStep = WorkFlow.NewInstance.GetWFStartStepByWFID(this.currentWFTemplateID);
             if (startStep == null)
             {
                 MessageBox.Show("没有指定工作流对象【"+this.txtWFName.Text+"】的起始节点,无法正式启用!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                 return;
             }
             /// check是否有重复节点
             DataTable dtTemp = CommonFuns.getDataTableBySql("WFT_CURRENT_STEP_ID", "WHERE WFT_ID='" + this.currentWFTemplateID + "' AND DEL_FLAG='N' GROUP BY WFT_CURRENT_STEP_ID  HAVING COUNT(1)>1", "WF_TEMPLATES_STEP");
             if (dtTemp != null && dtTemp.Rows.Count>0)
             {
                 string stepName = WorkFlow.NewInstance.GetWFStep(dtTemp.Rows[0]["WFT_CURRENT_STEP_ID"].ToString()).COMBTEXT;
                 MessageBox.Show("节点【" + stepName + "】，存在重复设定，请核查!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                 return;
             }

            if (true)
            {
                WF_TEMPLATES wf = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.currentWFTemplateID);
                if (wf == null)
                {
                    MessageBox.Show("没有查找到指定的工作流模板信息", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (wf.STATUS == DataType.WFTEMPLATESSTATUS.Complete.ToString())
                {
                    MessageBox.Show("当前工作流已经提交，无需重复提交!", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    wf.STATUS = DataType.WFTEMPLATESSTATUS.Complete.ToString();
                    wf.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wf.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    try
                    {
                        wf.Save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    finally
                    {
                        MessageBox.Show("工作流：" + wf.WFT_NAME + ",已经提交成功.", "工作流提示助手提醒您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
            }


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
