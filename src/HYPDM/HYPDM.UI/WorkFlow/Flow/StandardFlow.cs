using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using EAS.Explorer;
using EAS.Modularization;
using EAS.Data.Linq;
using EAS.Data.ORM;
namespace HYPDM.WinUI.WorkFlow.Flow
{
    public partial class StandardFlow : Form
    {

        /// <summary>
        /// 对象主键
        /// </summary>
        private string objectKey = "";
        /// <summary>
        /// 关联类型
        /// </summary>
        private DataType.RelationObjectType relationObjectType;

        ///// <summary>
        ///// 当前存储的WF_APP
        ///// </summary>
        //private WF_APP wfApp;

        //public WF_APP WfApp
        //{
        //    get { return wfApp; }
        //    set { wfApp = value; }
        //}
        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        private string wfAppID = "";

        /// <summary>
        /// 工作流实例的主键
        /// </summary>
        public string WfAppID
        {
            get { return wfAppID; }
            set { wfAppID = value; }
        }
        /// <summary>
        /// 工作流模板主键
        /// </summary>
        private string wfTemplatesID = "";
        /// <summary>
        /// 工作流模板主键
        /// </summary>
        public string WfTemplatesID
        {
            get { return wfTemplatesID; }
            set { wfTemplatesID = value; }
        }

        /// <summary>
        /// 对象主键
        /// </summary>
        public string ObjectKey
        {
            get { return objectKey; }
            set { objectKey = value; }
        }
        /// <summary>
        /// 关联类型
        /// </summary>
        public DataType.RelationObjectType RelationObjectType
        {
            get { return relationObjectType; }
            set { relationObjectType = value; }
        }

        /// <summary>
        /// 标识是否为重启状态
        /// </summary>
        private Boolean isRestart = false;

        public Boolean IsRestart
        {
            get { return isRestart; }
            set { isRestart = value; }
        }

        /// <summary>
        /// 重启工作流的时候需要
        /// </summary>
        public StandardFlow(string templatesID, string wflowappID)
        {

            InitializeComponent();
            isRestart = true;
            this.WfTemplatesID = templatesID;
            this.WfAppID = wflowappID;
            this.CenterToParent();
            reloadFlow();
        }

        private void reloadFlow()
        {
            this.txtSubject.Enabled = true;
            this.tsphandle.Enabled = false;
            this.tspStart.Enabled = true;
            this.btnModify.Enabled = true;
            this.btnSubmit.Enabled = false;

            WF_APP app = WorkFlow.NewInstance.GetWFappByWFID(this.WfAppID);
            this.txtSubject.Text = app.SUBJECT;
            this.txtStatus.Text = app.STATUS;
            this.txtFlowName.Text = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.WfTemplatesID).WFT_NAME.ToString();


            CreateFlowGraphicByWFTID();

        }

        /// <summary>
        /// 传参构造方法,创建工作流实例的时候使用
        /// </summary>
        /// <param name="objectKey">对象主键</param>
        /// <param name="relationObjectType">关联类型</param>
        /// <param name="wfTemplates">工作流模板ID</param>
        public StandardFlow(string objectKey, DataType.RelationObjectType relationObjectType, string wfTemplates)
        {
            InitializeComponent();
            this.CenterToParent();

            this.ObjectKey = objectKey;
            this.RelationObjectType = relationObjectType;
            this.WfTemplatesID = wfTemplates;




            this.gpFlowDetail.Visible = false;
            if (this.ObjectKey == "")
            {
                MessageBox.Show("没有指定对象主键【ObjectKey】", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            this.txtUserPM.Text = CommonFuns.NewInstance.LoginInfo.LoginID;
            this.txtStatus.Text = "未激活";
            this.txtSubject.SelectAll();
            loadIni();
            // CreateFlowGraphicByWFTID();//绘流程图
            // loadIni();

        }

        private void StandardFlow_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        string flowName = ""; //工作流名称
        protected void loadIni()
        {
            string tableName = DataType.GetTableName(this.RelationObjectType);
            if (tableName == "")
            {
                MessageBox.Show("指定参数错误【RelationObjectType】", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                flowName = WorkFlow.NewInstance.GetWFTemplatesInfoByWFID(this.WfTemplatesID).WFT_NAME.ToString();
                this.Text = "【" + flowName + "】" + WorkFlow.GetObjectTitle(this.RelationObjectType);
                this.txtFlowName.Text = flowName;
            }
            CreateFlowGraphicByWFTID();
        }

        protected void CreateFlowGraphicByWFTID()
        {

            DataTable dtTemp = CommonFuns.getDataTableBySql("1", "WHERE DEL_FLAG='N' AND STATUS='Complete' AND WFT_ID='" + this.WfTemplatesID + "'", "WF_TEMPLATES");


            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不存在或者被删除(或者未提交使用)", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                this.Close();
                return;
            }
            else
            {
                IList<HYPDM.Entities.WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(this.WfTemplatesID);
                CreateWF(list, this.gpFlowDetail);
                CreateButtonClickEvent(this.gpFlowDetail);
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
                IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
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
                    // btnStep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                    // btnStep.FlatAppearance.BorderSize = 5;
                    // btnStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
                    //  btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    //  btnStep.Location = new System.Drawing.Point(x, y);
                    btnStep.Name = step.WFT_STEP_ID;
                    // btnStep.Size = new System.Drawing.Size(200, 50);
                    // btnStep.TabIndex = 0;
                    string strUser = getCurrentStepHandle(WfAppID, step.WFT_STEP_ID);
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + "\n" + "发起人:【" + CommonFuns.NewInstance.LoginInfo.LoginID + "】";
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
                    }
                    else
                    {
                        btnStep.Text = "当前步骤:" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
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
            stbUser = new StringBuilder();
            //if (APP.STATUS == DataType.WFDetailSTATUS.Return.ToString())
            //{
            //    stbUser = new StringBuilder();
            //}
            //else
            //{
            IList<WF_APP_USER> list = WorkFlow.NewInstance.GetWFAppStepUser(wfappID, wftStepID);
            if (list != null && list.Count > 0)
            {
                stbUser = new StringBuilder("\n");
            }
            foreach (WF_APP_USER handle in list)
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
            //}
            return stbUser.ToString();
        }
        private void CreateButtonClickEvent(System.Windows.Forms.Control controls)
        {
            foreach (Control ctl in controls.Controls)
            {
                if (ctl.GetType().Name == "Button")
                {
                    if (((WF_TEMPLATES_STEP)((Button)ctl).Tag).IS_START_STEP != "Y")
                    {
                        ((Button)ctl).Click += new EventHandler(StandardFlow_Click);
                    }

                    // ((Button)ctl).DoubleClick += new EventHandler(StandardFlow_DoubleClick);
                }
            }
        }
        //private void StandardFlow_DoubleClick(Object sender, EventArgs e)
        //{
        //    string stepID = ((Button)sender).Name.ToString();
        //    if (stepID == "")
        //    {
        //        return;
        //    }
        //    cMenu.Tag = stepID;
        //    foreach (Control ctl in this.gpFlowDetail.Controls)
        //    {
        //        if (ctl.GetType().Name == "Button")
        //        {
        //            ((Button)ctl).BackColor = System.Drawing.SystemColors.InactiveBorder;
        //            ((Button)ctl).ContextMenuStrip = null;
        //        }
        //    }
        //    ((Button)sender).ContextMenuStrip = cMenu;
        //    ((Button)sender).BackColor = System.Drawing.Color.Red;
        //    //stepID
        //    //show出用户、群组设定界面
        //    UserAndUserRoleForm frm = new UserAndUserRoleForm();
        //    frm.ShowDialog();
        //}
        //  
        private void StandardFlow_Click(Object sender, EventArgs e)
        {
            WF_TEMPLATES_STEP step = (WF_TEMPLATES_STEP)((Button)sender).Tag;
            string stepID = ((Button)sender).Name.ToString();
            if (stepID == "")
            {
                return;
            }
            //  cMenu.Tag = stepID;
            cMenu.Tag = sender;
            // MessageBox.Show(cMenu.Tag.ToString());
            foreach (Control ctl in this.gpFlowDetail.Controls)
            {
                if (ctl.GetType().Name == "Button")
                {
                    ((Button)ctl).BackColor = System.Drawing.SystemColors.InactiveBorder;
                    ((Button)ctl).ContextMenuStrip = null;
                }
            }
            ((Button)sender).ContextMenuStrip = cMenu;
            ((Button)sender).BackColor = System.Drawing.Color.Red;

            //UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //frm.ShowDialog();
            // WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStepInfoByStepID(stepID);
            //stepID

            selUser(((Button)sender).Name.ToString());
            ((Button)sender).Text = "当前步骤:" + WorkFlow.NewInstance.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
            //_wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
            //if (stbUser != null)
            //{

            //}
            //else
            //{
            //    stbUser = new StringBuilder();
            //}
            string strUser = getCurrentStepHandle(WfAppID, step.WFT_STEP_ID);
            ((Button)sender).Text += strUser.ToString();

        }

        private void tspMenuUserOrGroup_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cMenu.Tag.ToString());
            //// //show出用户、群组设定界面
            //UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //frm.ShowDialog();
            Button Clickbtn = (Button)cMenu.Tag;
            selUser(Clickbtn.Name.ToString());
            //if (stbUser != null && stbUser.ToString() == "")
            //{
            //    Clickbtn.Text += "\n" + stbUser.ToString();
            //}
            if (stbUser != null)
            {

            }
            else
            {
                stbUser = new StringBuilder();
            }
            Clickbtn.Text += "\n" + stbUser.ToString();
        }
        private List<DataType.UserOrGroupSelected> selectedUserOrGroupList = new List<DataType.UserOrGroupSelected>();
        /// <summary>
        /// 弹出选择用户登录的弹出框
        /// </summary>
        private void selUser(string wftStepID)
        {
            List<DataType.UserOrGroupSelected> oldSelectedUserList = new List<DataType.UserOrGroupSelected>();
            // WfAppID
            //判定当前节点已经设定的签批用户

            IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWFAppStepHandle(this.WfAppID, wftStepID);
            if (list == null)
            {

            }
            else
            {
                DataType.UserOrGroupSelected item;
                foreach (WF_APP_HANDLE han in list)
                {
                    item = new DataType.UserOrGroupSelected();
                    item.Value = han.OBJECTVALUE;
                    item.ObjectType = DataType.AuthObjectType.SingleUser;
                    oldSelectedUserList.Add(item);
                }

            }

            stbUser = new StringBuilder();
            UserAndUserRoleForm frm = new UserAndUserRoleForm();
            //DialogResult dialogResult = frm.ShowDialog();
            frm.OldSelectedUserList = oldSelectedUserList;
            if (frm.ShowDialog() == DialogResult.OK)
            {

                //先删除，如果有的话,最终签批用后以本次的为准
                //  IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWFAppStepHandle(this.WfAppID, wftStepID);

                foreach (WF_APP_HANDLE l in list)
                {
                    l.Delete();
                }

                selectedUserOrGroupList = frm.SelectedUserOrGroupList;
                if (selectedUserOrGroupList == null || selectedUserOrGroupList.Count == 0)
                {
                    stbUser = new StringBuilder("");
                    return;
                }
                else
                {
                    stbUser = new StringBuilder("\n");
                    foreach (DataType.UserOrGroupSelected sel in selectedUserOrGroupList)
                    {

                        //添加
                        //防呆  判定改用户是否已经存在了，存在了就不需要再一次更新


                        WF_APP_HANDLE wfah = new HYPDM.Entities.WF_APP_HANDLE();
                        wfah.WFAH_ID = Guid.NewGuid().ToString();
                        wfah.LASTUPDATEDATE = "";
                        wfah.LASTUPDATEUSER = "";
                        wfah.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        wfah.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                        wfah.DEL_FLAG = "N";
                        wfah.WFA_ID = this.wfAppID;
                        wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                        wfah.OBJECTTYPE = sel.ObjectType.ToString();
                        wfah.OBJECTVALUE = sel.Value.ToString();
                        wfah.WFT_STEP_ID = wftStepID;
                        wfah.IS_THROUGH = "";

                        WF_APP_USER wfuser = new WF_APP_USER();
                        wfuser.WFAU_ID = Guid.NewGuid().ToString();
                        wfuser.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        wfuser.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                        wfuser.DEL_FLAG = "N";
                        wfuser.WFA_ID = this.wfAppID;
                        wfuser.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                        wfuser.OBJECTTYPE = sel.ObjectType.ToString();
                        wfuser.OBJECTVALUE = sel.Value.ToString();
                        wfuser.WFT_STEP_ID = wftStepID;

                        try
                        {
                            wfah.Save();
                            wfuser.Save();
                            if (wfah.OBJECTTYPE == DataType.AuthObjectType.SingleUser.ToString())
                            {
                                stbUser.Append("用户:【" + wfah.OBJECTVALUE + "】" + "\n");
                            }
                            else
                            {
                                stbUser.Append("群组:【" + wfah.OBJECTVALUE + "】" + "\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("处理人设定信息存储异常:" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    // stbUser.Remove(stbUser.Length-1, 1);


                }
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtSubject.Text == "")
            {
                this.txtSubject.Focus();
                return;
            }
            else
            {
                WF_APP wf = new WF_APP();
                wf.WFA_ID = Guid.NewGuid().ToString();
                wf.WFT_ID = this.WfTemplatesID;
                wf.SUBJECT = this.txtSubject.Text.ToString();
                wf.STATUS = DataType.WFDetailSTATUS.UNActivate.ToString();
                wf.START_DATE = "";
                wf.RELATIONOBJECTTYPE = this.RelationObjectType.ToString();
                wf.OBJECTKEY = this.ObjectKey;
                wf.LASTUPDATEDATE = "";
                wf.LASTUPDATEUSER = "";
                wf.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                wf.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                wf.DEL_FLAG = "N";


                try
                {
                    wf.Save();
                    this.gpFlowDetail.Visible = true;
                    WfAppID = wf.WFA_ID;
                    this.txtSubject.ReadOnly = true;
                    this.btnSubmit.Enabled = false;
                    ///新增拟制人员(发起人)的WF_APP_HANDLE表信息
                    WF_APP_HANDLE wfah = new HYPDM.Entities.WF_APP_HANDLE();

                    wfah.WFAH_ID = Guid.NewGuid().ToString();
                    wfah.LASTUPDATEDATE = "";
                    wfah.LASTUPDATEUSER = "";
                    wfah.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    wfah.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wfah.DEL_FLAG = "N";
                    wfah.IS_THROUGH = "";
                    wfah.MSG = "";
                    wfah.OBJECTTYPE = DataType.AuthObjectType.SingleUser.ToString();
                    wfah.OBJECTVALUE = CommonFuns.NewInstance.LoginInfo.LoginID;
                    wfah.WFA_ID = this.wfAppID;
                    wfah.WFT_STEP_ID = WorkFlow.NewInstance.GetWFStartStepByWFID(this.WfTemplatesID).WFT_STEP_ID;
                    wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wfah.WFT_STEP_ID).WFT_CURRENT_STEP_ID;


                    WF_APP_USER user = new HYPDM.Entities.WF_APP_USER();

                    user.WFAU_ID = Guid.NewGuid().ToString();
                    user.CREATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    user.CREATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                    user.DEL_FLAG = "N";
                    user.OBJECTTYPE = DataType.AuthObjectType.SingleUser.ToString();
                    user.OBJECTVALUE = CommonFuns.NewInstance.LoginInfo.LoginID;
                    user.WFA_ID = this.wfAppID;
                    user.WFT_STEP_ID = WorkFlow.NewInstance.GetWFStartStepByWFID(this.WfTemplatesID).WFT_STEP_ID;
                    user.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wfah.WFT_STEP_ID).WFT_CURRENT_STEP_ID;

                    // wfah.WFT_STEP_ID = wftStepID;
                    user.Save();
                    wfah.Save();
                    this.tspDelete.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("创建新流程信息存储异常:" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }

        private void tspStart_Click(object sender, EventArgs e)
        {
            ///判定每个节点是否选择了签批用户
            ///步骤:1.找到该工作流实例对应工作模板中的所有节点，在handle表中判定是否有对应签批用户信息，有的话进行下一步check，否则提示直接返回

            StringBuilder stbMain = new StringBuilder();
            stbMain.Append(" ComboBoxValue  WHERE COMBVALUE IN( ");
            stbMain.Append(" SELECT WFT_CURRENT_STEP_ID  FROM WF_TEMPLATES_STEP ");
            stbMain.AppendFormat(" WHERE  WFT_ID='{0}' ", this.WfTemplatesID);
            stbMain.Append(" AND DEL_FLAG='N' AND  WFT_CURRENT_STEP_ID NOT  IN  (SELECT Current_STEP_ID  FROM WF_APP_HANDLE ");
            stbMain.AppendFormat(" WHERE  WFA_ID='{0}'))", this.WfAppID);

            DataTable dt = CommonFuns.getDataTableBySql(" COMBID,COMBTEXT", "", stbMain.ToString());

            if (dt == null || dt.Rows.Count == 0)
            {
                //说明每个节点都设定了签批人员
            }
            else
            {
                StringBuilder stb = new StringBuilder("以下步骤:");
                foreach (DataRow dr in dt.Rows)
                {
                    stb.Append("【" + dr["COMBTEXT"].ToString() + "】");
                }
                stb.Append(",没有设定签批人员，请设定完毕后再进行工作流的启用动作!");
                MessageBox.Show(stb.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            string contentMsg;
            string nowDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string loginID = CommonFuns.NewInstance.LoginInfo.LoginID;
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            WF_APP app = WorkFlow.NewInstance.GetWFappByWFID(this.WfAppID);
            FlowStepHandle flowstep = new FlowStepHandle();
            if (flowstep.ShowDialog() == DialogResult.OK)
            {
                contentMsg = flowstep.ContentMsg;
                if (app == null)
                {
                    MessageBox.Show("获取流程实例异常", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                else
                {
                    if (app.STATUS == DataType.WFDetailSTATUS.Activated.ToString())
                    {
                        MessageBox.Show("当前工作流已经启用，无需再一次启用!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    else
                    {
                        app.LASTUPDATEUSER = loginID;
                        app.LASTUPDATEDATE = nowDate;
                        app.START_DATE = nowDate;
                        app.STATUS = DataType.WFDetailSTATUS.Activated.ToString();
                        try
                        {
                            app.Update();

                            this.txtStatus.Text = "已激活";

                            ///新增拟制节点完成信息
                            WF_DETAIL detail = new HYPDM.Entities.WF_DETAIL();
                            WF_TEMPLATES_STEP step = WorkFlow.NewInstance.GetWFStartStepByWFID(app.WFT_ID);
                            detail.Current_STEP_ID = step.WFT_CURRENT_STEP_ID;
                            // detail.CURRENT_STEP_NAME = _wfService.GetWFStep(WorkFlow.NewInstance.GetWFStepInfoByStepID(detail.CURRENT_STEP_ID).WFT_CURRENT_STEP_ID).COMBTEXT;

                            detail.MSG = contentMsg;
                            detail.DEL_FLAG = "N";
                            detail.IS_Through = "Y";
                            detail.COMPLEMENTDATE = nowDate;
                            detail.RECIVEDATE = nowDate;
                            detail.WFD_ID = Guid.NewGuid().ToString();
                            detail.WFA_ID = app.WFA_ID;
                            detail.WFT_STEP_ID = step.WFT_STEP_ID;
                            try
                            {
                                detail.Save();

                                ///新增WF_DETAIL记录，指向下一工作流信息
                                // wfah.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                                WF_DETAIL detailNew = new HYPDM.Entities.WF_DETAIL();
                                detailNew.Current_STEP_ID = WorkFlow.NewInstance.GetWFStartStepByWFID(app.WFT_ID).WFT_NEXT_STEP_ID;
                                //_wfService.GetWFStep(detailNew.Current_STEP_ID).COMBTEXT;
                                // WorkFlow.NewInstance.GetWFStepInfoByStepID(detail.Current_STEP_ID).WFT_NEXT_STEP_ID;
                                // detailNew.CURRENT_STEP_NAME = _wfService.GetWFStep(detailNew.CURRENT_STEP_ID).COMBTEXT;
                                detailNew.MSG = "";
                                //  detailNew.Current_STEP_ID = WorkFlow.NewInstance.GetWFStepInfoByStepID(wftStepID).WFT_CURRENT_STEP_ID;
                                detailNew.IS_Through = "";
                                detailNew.DEL_FLAG = "N";
                                detailNew.COMPLEMENTDATE = "";
                                detailNew.RECIVEDATE = detail.COMPLEMENTDATE;
                                detailNew.WFD_ID = Guid.NewGuid().ToString();
                                detailNew.WFA_ID = detail.WFA_ID;
                                detailNew.WFT_STEP_ID = WorkFlow.NewInstance.GetWftStepIDByStepIDAndAppID(detailNew.WFA_ID, detailNew.Current_STEP_ID);
                                detailNew.Save();


                                ///更新表WF_APP_HANDLE
                                WF_APP_HANDLE item = WorkFlow.NewInstance.GetWfAppHandleItem(detail.WFA_ID, detail.Current_STEP_ID, loginID);
                                item.DEL_FLAG = "N";
                                item.LASTUPDATEDATE = nowDate;
                                item.LASTUPDATEUSER = loginID;
                                item.IS_THROUGH = "Y";
                                item.MSG = contentMsg;
                                item.Update();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("信息存储异常,错误信息如下:" + "\n" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                                return;
                            }

                            MessageBox.Show("当前工作流启用成功!", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.tspStart.Enabled = false;
                            this.btnModify.Enabled = false;
                            this.btnSubmit.Enabled = false;
                            this.gpFlowDetail.Enabled = false;
                            this.tspDelete.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("当前工作流启用失败,错误信息如下:" + "\n" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                }
            }
        }


        private void tspDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("主题为【" + this.txtSubject.Text + "】" + "\n" + "的工作流实例即将被删除!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                WF_APP app = WorkFlow.NewInstance.GetWFappByWFID(this.wfAppID);
                app.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                app.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                app.DEL_FLAG = "Y";
                app.Update();
                this.txtSubject.ReadOnly = false;
                this.txtSubject.Text = "";
                this.btnSubmit.Enabled = true;
                this.txtSubject.Focus();
                this.gpDetail.Controls.Clear();
            }


            // this.WfAppID
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            WF_APP app = WorkFlow.NewInstance.GetWFappByWFID(this.WfAppID);
            app.SUBJECT = this.txtSubject.Text.ToString();
            app.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            app.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
            try
            {
                app.Save();
                MessageBox.Show("更新工作流成功", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新工作流失败,错误信息如下:" + "\n" + ex.Message.ToString(), "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

        }

    }
}
