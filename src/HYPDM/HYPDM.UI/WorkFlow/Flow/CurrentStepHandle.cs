using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Modularization;
using EAS.Data.Linq;
using EAS.Data.ORM;
using HYPDM;
namespace HYPDM.WinUI.WorkFlow.Flow
{
    public partial class CurrentStepHandle : Form
    {
        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        private string wfAppID = "12bcb09d-b267-4223-9bd0-e0b831131a08";
        //  private string currentStepID = "6e0136cd-1c2c-444b-ac72-2672962c2226";
        private WF_APP APP = null; //存放当前工作流实例
        private WF_DETAIL wipWFAppDetai; //工作流实例的WIP信息

        //public WF_DETAIL WipWFAppDetai
        //{
        //    get { return wipWFAppDetai; }
        //    set { wipWFAppDetai = value; }
        //}


        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        public string WfAppID
        {
            get { return wfAppID; }
            set { wfAppID = value; }
        }
        public CurrentStepHandle()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void CurrentStepHandle_Load(object sender, EventArgs e)
        {
            APP = WorkFlow.NewInstance.GetWFappByWFID(this.WfAppID);

            ///显示之前签批人员的签批记录
            showOldMsg();





            this.txtSubject.Text = APP.SUBJECT;
            this.txtUserPM.Text = APP.CREATEUSER;
            this.txtHandleUser.Text = CommonFuns.NewInstance.LoginInfo.LoginID;


            try
            {
                wipWFAppDetai = WorkFlow.NewInstance.GetWfAppWipDetailByWfaID(WfAppID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取工作流WIP信息失败" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }






            if (APP.STATUS == HYPDM.DataType.WFDetailSTATUS.Complete.ToString())
            {
                this.txtStatus.Text = "完成";
            }
            else if (APP.STATUS == DataType.WFDetailSTATUS.Activated.ToString())
            {
                this.txtStatus.Text = "激活";
            }
            else if (APP.STATUS == DataType.WFDetailSTATUS.UNActivate.ToString())
            {
                this.txtStatus.Text = "未激活";
            }
            else if (APP.STATUS == DataType.WFDetailSTATUS.Handling.ToString())
            {
                this.txtStatus.Text = "激活";
            }
            //  this.txtStatus.Text = APP.STATUS;
            loadIni();
        }

        StringBuilder stb;
        private void showOldMsg()
        {
            stb = new StringBuilder();
            IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWfAppHandleList(this.wfAppID);

            foreach (WF_APP_HANDLE handle in list)
            {
                string result = handle.IS_THROUGH == "Y" ? "同意" : "不同意";
                stb.Append(handle.LASTUPDATEDATE).Append(" ").Append(handle.OBJECTVALUE).Append(" 【").Append(WorkFlow.NewInstance.GetWFStep(handle.Current_STEP_ID).COMBTEXT).Append("】  ").Append(result) ;
                //WorkFlow.NewInstance.
              //  stb.Append("\n");
                this.listComments.Items.Add(stb.ToString());
                stb = new StringBuilder();
                this.listComments.Items.Add(handle.MSG);
            }

           


        }
        string flowName = ""; //工作流名称
        protected void loadIni()
        {
            DataType.RelationObjectType item = (DataType.RelationObjectType)Enum.Parse(typeof(DataType.RelationObjectType), APP.RELATIONOBJECTTYPE, false);
            string tableName = WorkFlow.GetTableName(item);
            if (tableName == "")
            {
                MessageBox.Show("指定参数错误【RelationObjectType】", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                flowName = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(APP.WFT_ID).WFT_NAME.ToString();
                this.Text = "【" + flowName + "】" + WorkFlow.GetObjectTitle(item);
                this.txtFlowName.Text = flowName;

            }
            CreateFlowGraphicByWFTID();
        }
        /// <summary>
        /// 
        /// </summary>
        protected void CreateFlowGraphicByWFTID()
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql("1", "WHERE DEL_FLAG='N' AND STATUS='Complete' AND WFT_ID='" + APP.WFT_ID + "'", "WF_TEMPLATES");
            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不存在或者被删除(或者未提交使用)", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
            else
            {
                IList<HYPDM.Entities.WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(APP.WFT_ID);
                CreateWF(list, this.gpFlowDetail);
                //  CreateButtonClickEvent(this.gpFlowDetail);
            }

        }
        private void CreateWF(IList<HYPDM.Entities.WF_TEMPLATES_STEP> list, System.Windows.Forms.Control ctl)
        {
            int x = 5;
            int y = 18;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不没有设置任何节点", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                //IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
                WorkFlow wf = WorkFlow.NewInstance;
                Panel pnl = null;  //放箭头
                foreach (WF_TEMPLATES_STEP step in list)
                {
                    Button btnStep = new Button();

                    btnStep.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.banner;
                    btnStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    // btnStep.Location = new System.Drawing.Point(5, 18);
                    btnStep.Location = new System.Drawing.Point(x, y);
                    // btnStep.Name = "btnName";
                    btnStep.Size = new System.Drawing.Size(113, 161);
                    // btnStep.TabIndex = 0;
                    // btnStep.Text = "btnText";
                    btnStep.UseVisualStyleBackColor = true;
                    btnStep.Tag = step; //节点信息放在button的tag中
                    btnStep.BackColor = System.Drawing.SystemColors.InactiveBorder;
                    btnStep.Name = step.WFT_STEP_ID;
                    // btnStep.Size = new System.Drawing.Size(200, 50);
                    // btnStep.TabIndex = 0;
                    string strUser = getCurrentStepHandle(APP.WFA_ID, step.WFT_STEP_ID);
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + "\n" + "发起人:【" + CommonFuns.NewInstance.LoginInfo.LoginID + "】";
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
                    }
                    else
                    {
                        btnStep.Text = "当前步骤:" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
                    }
                    if (wipWFAppDetai.WFT_STEP_ID == btnStep.Name)
                    {
                        btnStep.BackColor = Color.Red;
                    }
                    btnStep.TextAlign = ContentAlignment.MiddleLeft;
                    pnl = new Panel();
                    pnl.BackColor = System.Drawing.Color.Transparent;
                    pnl.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.line2;
                    pnl.Location = new System.Drawing.Point(113 + x, (161 / 2 + 18));
                    pnl.Name = "pnl";
                    pnl.Size = new System.Drawing.Size(32, 30);
                    pnl.TabIndex = 0;
                    btnStep.UseVisualStyleBackColor = false;
                    ctl.Controls.Add(btnStep);
                    ctl.Controls.Add(pnl);
                    x += 113 + 32;
                }
                ctl.Controls.Remove(pnl);
            }
        }

        StringBuilder stbUser = null;//存放当前选中的用户、用户群组

        private string getCurrentStepHandle(string wfappID, string wftStepID)
        {
            IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWFAppStepHandle(wfappID, wftStepID);
            if (list != null && list.Count > 0)
            {
                stbUser = new StringBuilder("\n");
            }
            foreach (WF_APP_HANDLE handle in list)
            {
                if (handle.OBJECTTYPE == DataType.AuthObjectType.SingleUser.ToString())
                {
                    stbUser.Append("用户:【" + handle.OBJECTVALUE + "】" + "\n");
                }
                else
                {
                    stbUser.Append("群组:【" + handle.OBJECTVALUE + "】" + "\n");
                }
            }
            return stbUser.ToString();
        }
        string contentMsg = "";
        Boolean isThrough = false;
        string nowDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string loginID = CommonFuns.NewInstance.LoginInfo.LoginID;
        private void btnHandle_Click(object sender, EventArgs e)
        {
            FlowStepHandleCommon handle = new FlowStepHandleCommon();
            if (handle.ShowDialog() == DialogResult.OK)
            {
                contentMsg = handle.ContentMsg;
                isThrough = handle.ISThrough;
                DataStore();
            }

            this.Close();

        }
        private void DataStore()
        {
            //1.detail中存放两笔资料，一笔当前状态的更新   2  下一节点的记录新增 ，如果当前没有完成整个节点的审批，那么不需要进行此项工作
            //2.往handle中更新当前处理人的处理状态及意见

            ///1  更新表WF_APP_HANDLE:往handle中更新当前处理人的处理状态及意见
            WF_APP_HANDLE item = WorkFlow.NewInstance.GetWfAppHandleItem(APP.WFA_ID, wipWFAppDetai.Current_STEP_ID, loginID);
            if(item.IS_THROUGH!=null && item.IS_THROUGH!="")
            {
                MessageBox.Show("您已经审批过，无需再一次审批!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            item.DEL_FLAG = "N";
            item.LASTUPDATEDATE = nowDate;
            item.LASTUPDATEUSER = loginID;
            item.MSG = contentMsg;

            if (isThrough == true)
            {
                item.IS_THROUGH = "Y";
            }
            else
            {
                item.IS_THROUGH = "N";
            }
            item.Update();


            //2 判定当前节点是否还有人员没有审批完成
            Boolean blAllThrough = true;
            Boolean isUpdateDetail = true;
            IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWfAppStepHandleList(APP.WFA_ID, wipWFAppDetai.Current_STEP_ID);
            foreach (WF_APP_HANDLE handleItem in list)
            {
                if (handleItem.IS_THROUGH == "N")
                {
                    blAllThrough = false;
                    return;
                }
                else if (handleItem.IS_THROUGH == "Y")
                {
                    //  blAllThrough = true;
                }
                else if (handleItem.IS_THROUGH == "")
                {
                    isUpdateDetail = false;
                    // return;
                }
                else if (handleItem.IS_THROUGH == null)
                {
                    isUpdateDetail = false;
                    //return;
                }
            }

            if (isUpdateDetail) //需要更新detail信息，说明此节点的所有用户已经审批完成,而且全部通过审批
            {
                ///A更新当前节点的处理信息
                WF_DETAIL detail = new HYPDM.Entities.WF_DETAIL();

                detail = WorkFlow.NewInstance.GetDetailByWFAppidAndStepID(wipWFAppDetai.WFA_ID, wipWFAppDetai.Current_STEP_ID);

                if (detail == null)
                {
                    MessageBox.Show("获取当前节点信息异常!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                detail.Current_STEP_ID = wipWFAppDetai.Current_STEP_ID;
                detail.MSG = contentMsg; //可加可不加
                detail.IS_Through = "Y";
                detail.COMPLEMENTDATE = nowDate;
                detail.WFA_ID = wipWFAppDetai.WFA_ID;
                detail.Update();

                //判定整个工作流是否已经完成,如果已经完成，更新整个工作流状态为Complete

                WF_APP wfapp = WorkFlow.NewInstance.GetWFappByWFID(wipWFAppDetai.WFA_ID);
                WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFEndStepByWFID(wfapp.WFT_ID); //end step
                if (wipWFAppDetai.WFT_STEP_ID == step.WFT_STEP_ID) //判定是否最终节点
                {
                    ///B将该工作流的状态设为完成Complete
                    wfapp.LASTUPDATEDATE = nowDate;
                    wfapp.LASTUPDATEUSER = loginID;
                    wfapp.STATUS = DataType.WFDetailSTATUS.Complete.ToString();
                    wfapp.Update();
                }
                else
                {
                    //如果不是跟节点，且目前节点已经审批完成，需要添加下节点信息


                    ///新增WF_DETAIL记录，指向下一工作流信息
                    // wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                    WF_DETAIL detailNew = new HYPDM.Entities.WF_DETAIL();
                    detailNew.Current_STEP_ID = WorkFlow.NewInstance.GetStepInfoByWftIDAndCurrentStepID(APP.WFT_ID, detail.Current_STEP_ID).WFT_NEXT_STEP_ID;
                    detailNew.MSG = "";
                    detailNew.IS_Through = "";
                    detailNew.DEL_FLAG = "N";
                    detailNew.COMPLEMENTDATE = "";
                    detailNew.RECIVEDATE = detail.COMPLEMENTDATE;
                    detailNew.WFD_ID = Guid.NewGuid().ToString();
                    detailNew.WFA_ID = detail.WFA_ID;
                    detailNew.WFT_STEP_ID = WorkFlow.NewInstance.GetWftStepIDByStepIDAndAppID(detailNew.WFA_ID, detailNew.Current_STEP_ID);
                    detailNew.Save();
                }
            }
            else
            {
                //还有用户没有审批完成，而且目前此节点完成审批的用户均已经通过审批,此种情况下不需要更新detail及相关信息
            }

            if (!blAllThrough)  //说明有用户选择没有通过的选项
            {
                ///如果有审批人员在此节点审批不通过，则将此工作流实例设为UNActivate(未激活，拟制状态)
                WF_APP wfapp = WorkFlow.NewInstance.GetWFappByWFID(wipWFAppDetai.WFA_ID);
                wfapp.LASTUPDATEDATE = nowDate;
                wfapp.LASTUPDATEUSER = loginID;
                wfapp.STATUS = DataType.WFDetailSTATUS.UNActivate.ToString();
                wfapp.Update();

                /////
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
           // APP.RELATIONOBJECTTYPE

           // WorkFlow.GetTableName((DataType.RelationObjectType)Enum.Parse(typeof(DataType.RelationObjectType), APP.RELATIONOBJECTTYPE, false));
            Form frmDetai = WorkFlow.GetDetaiFrm((DataType.RelationObjectType)Enum.Parse(typeof(DataType.RelationObjectType), APP.RELATIONOBJECTTYPE, false),APP.OBJECTKEY);
            frmDetai.Show();
        }


    }
}
