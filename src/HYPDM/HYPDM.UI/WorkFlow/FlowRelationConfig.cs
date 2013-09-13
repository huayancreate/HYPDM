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
    [Module("{21746628-4DFC-49B3-AEEF-AE50FFD82CDA}", "工作流模板清单", "工作流模板清单")]
    public partial class FlowRelationConfig : UserControl
    {
        public FlowRelationConfig()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {
            iniTreeView(tvFlowList);
            SetRealtionObject();

        }

        private void iniTreeView(TreeView tv)
        {
            TreeNode node = new TreeNode("工作流模板", 0, 0);
            node.Tag = null;
            SetFlowList(tv, node);

        }
        private void SetFlowList(TreeView tv, TreeNode node)
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql("WFT_ID,WFT_NAME,CREATEDATE,CREATEUSER ,LASTUPDATEUSER ,LASTUPDATEDATE,DEL_FLAG,STATUS", "WHERE DEL_FLAG='N' AND STATUS='Complete'", "WF_TEMPLATES");
            foreach (DataRow dr in dtTemp.Rows)
            {
                TreeNode n = new TreeNode(dr["WFT_NAME"].ToString(), 0, 1);
                n.Tag = dr["WFT_ID"].ToString();


                DataTable dt = CommonFuns.getDataTableBySql("WFA_ID,WFT_ID,SUBJECT", " WHERE STATUS<>'UNActivated' AND WFT_ID='" + dr["WFT_ID"].ToString() + "'", "WF_APP");

                foreach (DataRow d in dt.Rows)
                {
                    TreeNode m = new TreeNode(d["SUBJECT"].ToString(), 0, 1);
                    m.Tag = d["WFA_ID"].ToString();
                    n.Nodes.Add(m);
                }

                node.Nodes.Add(n);

            }
            tv.Nodes.Add(node);
            tv.ExpandAll();
        }
        private void SetRealtionObject()
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql(" A.OBJECTVALUE,A.WFT_ID,B.WFT_NAME,A.OBJECTDESC,A.LASTUPDATEUSER,A.LASTUPDATEDATE", "", " WF_TEMPLATES_OBJECT A LEFT JOIN WF_TEMPLATES B ON   A.WFT_ID=B.WFT_ID ");
            this.dgvExtTemplates.DataSource = dtTemp;
        }


        #region

        /// <summary>
        /// 创建流程实例视图
        /// </summary>
        protected void CreateFlowGraphicByWFTID(string flowName, string wftid, Control ctl,string wfappid)
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql("1", "WHERE DEL_FLAG='N' AND STATUS='Complete' AND WFT_ID='" + wftid + "'", "WF_TEMPLATES");
            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不存在或者被删除(或者未提交使用)", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                // this.Close();
                return;
            }
            else
            {
                IList<HYPDM.Entities.WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(wftid);
                CreateWF(list, ctl, flowName, wftid, wfappid);
                //  CreateButtonClickEvent(this.gpFlowDetail);
            }

        }
        private void CreateWF(IList<HYPDM.Entities.WF_TEMPLATES_STEP> list, System.Windows.Forms.Control ctl, string flowName, string wftid, string wfappid)
        {
            int x = 5;
            int y = 18;

            WF_DETAIL wipWFAppDetai = WorkFlow.NewInstance.GetWfAppWipDetailByWfaID(wfappid);

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
                       string strUser = getCurrentStepHandle(wfappid, step.WFT_STEP_ID);
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + "\n" + "发起人:【" + WorkFlow.NewInstance.GetWFappByWFID(wfappid).CREATEUSER + "】";
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
                    }
                    else
                    {
                        btnStep.Text = "当前步骤:" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + strUser;
                    }
                    if (wipWFAppDetai != null && wipWFAppDetai.WFT_STEP_ID == btnStep.Name)
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
        private string getCurrentStepHandle(string wfappID, string wftStepID)
        {
            IList<WF_APP_HANDLE> list = WorkFlow.NewInstance.GetWFAppStepHandle(wfappID, wftStepID);
            StringBuilder stbUser = new StringBuilder();
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
        #endregion
        private void tvFlowList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cleatButton(this.gpDetail);
            if (this.tvFlowList.SelectedNode!=null && this.tvFlowList.SelectedNode.Tag != null)
            {
                if (this.tvFlowList.SelectedNode.Parent.Tag != null) //说明是工作流实例
                {
                    //MessageBox.Show(this.tvFlowList.SelectedNode.Text);
                  //  cleatButton(this.gpDetail);
                    CreateFlowGraphicByWFTID(this.tvFlowList.SelectedNode.Text, this.tvFlowList.SelectedNode.Parent.Tag.ToString(), this.gpDetail, this.tvFlowList.SelectedNode.Tag.ToString());
                }
                else //说明是工作流模板
                {
                   // cleatButton(this.gpDetail);
                    CreateTemplatesGraphic(this.tvFlowList.SelectedNode.Text, this.tvFlowList.SelectedNode.Tag.ToString(), this.gpDetail);  
                }
            }
        }
        private void cleatButton(Control ctl)
        {
            ctl.Controls.Clear();
        }

        /// <summary>
        /// 创建流程模板视图
        /// </summary>
        protected void CreateTemplatesGraphic(string flowName, string wftid, Control ctl)
        {
            DataTable dtTemp = CommonFuns.getDataTableBySql("1", "WHERE DEL_FLAG='N' AND STATUS='Complete' AND WFT_ID='" + wftid + "'", "WF_TEMPLATES");
            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不存在或者被删除(或者未提交使用)", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                // this.Close();
                return;
            }
            else
            {
                IList<HYPDM.Entities.WF_TEMPLATES_STEP> list = WorkFlow.NewInstance.GetWFStepListByWFID(wftid);
                CreateWFTemplates(list, ctl, flowName, wftid);
                //  CreateButtonClickEvent(this.gpFlowDetail);
            }

        }
        private void CreateWFTemplates(IList<HYPDM.Entities.WF_TEMPLATES_STEP> list, System.Windows.Forms.Control ctl, string flowName, string wftid)
        {
            int x = 5;
            int y = 18;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("该工作流【" + flowName + "】不没有设置任何节点", "提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
                  
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT + "\n";
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT ;
                    }
                    else
                    {
                        btnStep.Text = "当前步骤:" + wf.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT ;
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

        private void dgvExtTemplates_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExtTemplates.CurrentRow != null)
            {
                RelationObject frm = new RelationObject();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string tempaltesID = frm.WfTemplates;
                    //保存
                    string objectValue = dgvExtTemplates.CurrentRow.Cells["OBJECTVALUE"].Value.ToString();
                    WF_TEMPLATES_OBJECT wfRealtionObject=WorkFlow.NewInstance.GetWfTemplatesObject(objectValue);
                    if (wfRealtionObject != null)
                    {
                        wfRealtionObject.WFT_ID = tempaltesID;
                        wfRealtionObject.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        wfRealtionObject.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                        try
                        {
                            wfRealtionObject.Update();
                            MessageBox.Show("保存成功", "提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            SetRealtionObject();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("存储异常:" + ex.Message.ToString(), "提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        wfRealtionObject.OBJECTVALUE = objectValue;
                        wfRealtionObject.WFT_ID = tempaltesID;
                        wfRealtionObject.OBJECTDESC = "";
                        wfRealtionObject.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        wfRealtionObject.LASTUPDATEUSER = CommonFuns.NewInstance.LoginInfo.LoginID;
                        try
                        {
                            wfRealtionObject.Save();
                            MessageBox.Show("保存成功", "提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            SetRealtionObject();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("存储异常:"+ex.Message.ToString(), "提示您:", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                }
            }
        }
    }
}
