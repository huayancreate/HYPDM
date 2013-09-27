using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using EAS.Data.ORM;
using HYPDM.Entities;
using EAS.Services;
using HYPDM.BLL;
using HYPDM.WinUI.BaseUI;
using EAS.Explorer;
using AdvancedDataGridView;
using System.IO;
using System.Configuration;
using System.Collections;
using EAS.Data.Linq;
using HYDocumentMS;
using HYPDM;
namespace HYPDM.WinUI.WorkFlow
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
            //IList<WF_TEMPLATES_STEP> list = _wfService.GetWFStepListByWFID(wftID);
            IList<WF_TEMPLATES_STEP> list = this.GetWFStepListByWFID(wftID);
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
                    btnStep.Size = new System.Drawing.Size(200, 50);
                    btnStep.TabIndex = 0;
                    if (step.IS_START_STEP == "Y")
                    {
                        btnStep.Text = "(Start)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    else if (step.IS_END_STEP == "Y")
                    {
                        btnStep.Text = "(END)" + _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    else
                    {
                        btnStep.Text = _wfService.GetWFStep(step.WFT_CURRENT_STEP_ID).COMBTEXT;
                    }
                    pnl = new Panel();
                    pnl.BackColor = System.Drawing.Color.Transparent;
                    pnl.BackgroundImage = global::HYPDM.WinUI.Properties.Resources.line;
                    pnl.Location = new System.Drawing.Point(80 + x, y + 45);
                    pnl.Name = "pnl";
                    pnl.Size = new System.Drawing.Size(32, 30);
                    pnl.TabIndex = 0;
                    btnStep.UseVisualStyleBackColor = false;
                    ctl.Controls.Add(btnStep);
                    ctl.Controls.Add(pnl);
                    y += 55 + 22;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stepID"></param>
        /// <returns></returns>
        public WF_TEMPLATES_STEP GetWFStepInfoByStepID(string stepID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            WF_TEMPLATES_STEP step = _wfService.GetWFStepInfoByStepID(stepID);
            return step;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wftID"></param>
        /// <returns></returns>
        public IList<WF_TEMPLATES_STEP> GetWFStepListByWFID(string wftID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            IList<WF_TEMPLATES_STEP> list = _wfService.GetWFStepListByWFID(wftID);
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wftID"></param>
        /// <returns></returns>
        public WF_TEMPLATES_STEP GetWFStartStepByWFID(string wftID)
        {

            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWFStartStepByWFID(wftID);
        }
        public WF_TEMPLATES_STEP GetWFEndStepByWFID(string wftID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWFEndStepByWFID(wftID);
        }
        public IList<WF_TEMPLATES_STEP> GetGreaterWFStepListByStepID(string stepID, string wftID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            DataTable dtTemp = _wfService.GetGreaterWFStepListByStepID(stepID, wftID);
            WF_TEMPLATES_STEP step = null;
            IList<WF_TEMPLATES_STEP> List = new List<WF_TEMPLATES_STEP>();
            foreach (DataRow dr in dtTemp.Rows)
            {
                step = new WF_TEMPLATES_STEP();
                step.WFT_CURRENT_STEP_ID = dr["WFT_CURRENT_STEP_ID"].ToString();
                step.WFT_STEP_ID = dr["WFT_STEP_ID"].ToString();
                step.WFT_ID = dr["WFT_ID"].ToString();
                step.WFT_STEP_DESC = dr["WFT_STEP_DESC"].ToString();
                step.WFT_CURRENT_STEP_USERTYPE = dr["WFT_CURRENT_STEP_USERTYPE"].ToString();
                step.WFT_CURRENT_STEP_USERID = dr["WFT_CURRENT_STEP_USERID"].ToString();
                step.CREATEDATE = dr["CREATEDATE"].ToString();
                step.CREATEUSER = dr["CREATEUSER"].ToString();
                step.LASTUPDATEDATE = dr["LASTUPDATEDATE"].ToString();
                step.LASTUPDATEUSER = dr["LASTUPDATEUSER"].ToString();
                step.IS_ALLOW_DELETE = dr["IS_ALLOW_DELETE"].ToString();
                step.IS_ALLOW_EDIT = dr["IS_ALLOW_EDIT"].ToString();
                step.IS_END_STEP = dr["IS_END_STEP"].ToString();
                step.IS_NOTE_STARTUSER = dr["IS_NOTE_STARTUSER"].ToString();
                step.IS_START_STEP = dr["IS_START_STEP"].ToString();
                List.Add(step);
            }
            return List;
        }
        public WF_TEMPLATES GetWFTemplatesInfoByWFID(string wftID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            WF_TEMPLATES wf = _wfService.GetWFTemplatesInfoByWFID(wftID);
            return wf;
        }

        public WF_APP GetWFappByWFID(string wfappID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWFappByWFID(wfappID);
        }


        public IList<WF_APP_USER> GetWFAppStepUser(string wfappID, string wftStepID)
        {
            DataEntityQuery<WF_APP_USER> query = DataEntityQuery<WF_APP_USER>.Create();
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            IList<WF_APP_USER> list = _wfService.GetWFAppStepUser(wfappID, wftStepID);
            return list;
        }


        public IList<WF_APP_HANDLE> GetWFAppStepHandle(string wfappID, string wftStepID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            IList<WF_APP_HANDLE> list = _wfService.GetWFAppStepHandle(wfappID, wftStepID);
            return list;
        }
        /// <summary>
        /// 获取当前处理人集合
        /// </summary>
        /// <param name="wfaID">WF_APP表主键,工作流实例的主键</param>
        /// <returns></returns>
        public IList<EAS_ACCOUNTS> GETCurrentStepHandleUser(string wfaID)
        {
            IList<EAS_ACCOUNTS> list = null;
            EAS_ACCOUNTS acc = null;
            StringBuilder stb = new StringBuilder();
            stb.Append("WHERE LOGINID IN (");
            stb.Append(" SELECT  OBJECTVALUE");
            stb.Append(" FROM  WF_APP_HANDLE");
            stb.Append(" WHERE WFA_ID='" + wfaID + "'");
            stb.Append(" AND OBJECTTYPE='SingleUser'");
            stb.Append(" AND Current_STEP_ID=");
            stb.Append(" (");
            stb.Append(" SELECT  Current_STEP_ID");
            stb.Append(" FROM WF_DETAIL");
            stb.Append(" WHERE WFA_ID='" + wfaID + "'");
            stb.Append(" AND (COMPLEMENTDATE='' or  COMPLEMENTDATE is null)");
            stb.Append(" AND  IS_Through<>'Y'");
            stb.Append(" )");
            stb.Append(" )");
            DataTable dt = CommonFuns.getDataTableBySql("LOGINID,NAME", stb.ToString(), "EAS_ACCOUNTS");
            if (dt == null && dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                list = new List<EAS_ACCOUNTS>();
                foreach (DataRow dr in dt.Rows)
                {
                    acc = new EAS_ACCOUNTS();
                    acc.LOGINID = dr["LOGINID"].ToString();
                    acc.NAME = dr["NAME"].ToString();
                    list.Add(acc);
                }
                return list;
            }
        }

        /// <summary>
        /// 获取工作流实例的的当前处理节点
        /// </summary>
        /// <param name="wfaID"></param>
        /// <returns></returns>
        public WF_DETAIL GetWfAppWipDetailByWfaID(string wfaID)
        {
            WF_DETAIL detail = null;
            StringBuilder stb = new StringBuilder();
            stb.Append(" WHERE WFA_ID='" + wfaID + "'");
            stb.Append("AND (COMPLEMENTDATE='' or  COMPLEMENTDATE is null)");
            stb.Append("AND  IS_Through<>'Y'");
            DataTable dt = CommonFuns.getDataTableBySql("*", stb.ToString(), "WF_DETAIL");
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                detail = new WF_DETAIL();
                DataRow dr = dt.Rows[0];
                detail.WFA_ID = dt.Rows[0]["WFA_ID"].ToString();
                detail.WFD_ID = dt.Rows[0]["WFD_ID"].ToString();
                detail.WFT_STEP_ID = dt.Rows[0]["WFT_STEP_ID"].ToString();
                detail.RECIVEDATE = dt.Rows[0]["RECIVEDATE"].ToString();
                detail.MSG = dt.Rows[0]["MSG"].ToString();
                detail.IS_Through = dt.Rows[0]["IS_Through"].ToString();
                detail.Current_STEP_ID = dt.Rows[0]["Current_STEP_ID"].ToString();
                return detail;
            }
        }
        /// <summary>
        /// 根据工作流实例主键与节点（工作流节点）获取WF_TEMPLATES_STEP中的主键
        /// </summary>
        /// <param name="wfappID"></param>
        /// <param name="stepID"></param>
        /// <returns></returns>
        public string GetWftStepIDByStepIDAndAppID(string wfappID, string stepID)
        {
            StringBuilder stb = new StringBuilder();
            stb.Append(" WHERE WFT_ID=");
            stb.Append(" (SELECT WFT_ID");
            stb.Append(" FROM  WF_APP");
            stb.Append(" WHERE WFA_ID='" + wfappID + "'");
            stb.Append(" AND DEL_FLAG='N')");
            stb.Append(" AND  WFT_CURRENT_STEP_ID='" + stepID + "'");
            DataTable dt = CommonFuns.getDataTableBySql("WFT_STEP_ID", stb.ToString(), "WF_TEMPLATES_STEP");
            if (dt == null && dt.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return dt.Rows[0]["WFT_STEP_ID"].ToString();
            }
        }

        /// <summary>
        /// 根据工作流实例APPID与目前工作节点获取WF_APP_HANDLE信息集合
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <returns></returns>
        public IList<WF_APP_HANDLE> GetWfAppStepHandleList(string wfaID, string CurrentStepID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();

            return _wfService.GetWfAppStepHandleList(wfaID, CurrentStepID);
        }

        /// <summary>
        /// 根据工作流实例APPID与目前工作节点、用户ID获取WF_APP_HANDLE信息
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public WF_APP_HANDLE GetWfAppHandleItem(string wfaID, string CurrentStepID, string userID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();

            return _wfService.GetWfAppHandleItem(wfaID, CurrentStepID, userID);
        }

        public WF_DETAIL GetDetailByWFAppidAndStepID(string wfaID, string CurrentStepID)
        {

            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();

            return _wfService.GetDetailByWFAppidAndStepID(wfaID, CurrentStepID);
        }

        public WF_TEMPLATES_STEP GetStepInfoByWftIDAndCurrentStepID(string wftID, string CurrentStepID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();

            return _wfService.GetStepInfoByWftIDAndCurrentStepID(wftID, CurrentStepID);
        }

        public IList<WF_APP_HANDLE> GetWfAppHandleList(string wfaID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();

            return _wfService.GetWfAppHandleList(wfaID);
        }
        /// <summary>
        /// 获取工作节点的名称如审批、拟制等信息
        /// </summary>
        /// <param name="wftCurrentStepID"></param>
        /// <returns></returns>
        public ComboBoxValue GetWFStep(string wftCurrentStepID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWFStep(wftCurrentStepID);
        }

        public WF_TEMPLATES_OBJECT GetWfTemplatesObject(string objectValue)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWfTemplatesObject(objectValue);
        }


        public IList<WF_DETAIL> GetWfDetailList(string wfaID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetWfDetailList(wfaID);
        }

        public WF_DETAIL GetWfAppLastDetailByWfaID(string wfaID)
        {
            WF_DETAIL detail = null;
            StringBuilder stb = new StringBuilder();
            stb.Append("   WHERE 1=1 AND WFA_ID='" + wfaID + "'");
            stb.Append(" AND RECIVEDATE IN (SELECT MAX(RECIVEDATE) FROM WF_DETAIL WHERE  WFA_ID='" + wfaID + "') ");
            DataTable dt = CommonFuns.getDataTableBySql("*", stb.ToString(), "WF_DETAIL");
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                detail = new WF_DETAIL();
                DataRow dr = dt.Rows[0];
                detail.WFA_ID = dt.Rows[0]["WFA_ID"].ToString();
                detail.WFD_ID = dt.Rows[0]["WFD_ID"].ToString();
                detail.WFT_STEP_ID = dt.Rows[0]["WFT_STEP_ID"].ToString();
                detail.RECIVEDATE = dt.Rows[0]["RECIVEDATE"].ToString();
                detail.MSG = dt.Rows[0]["MSG"].ToString();
                detail.IS_Through = dt.Rows[0]["IS_Through"].ToString();
                detail.Current_STEP_ID = dt.Rows[0]["Current_STEP_ID"].ToString();
                return detail;
            }
        }
        /// <summary>
        /// 获取设定流程对象的title名称
        /// </summary>
        /// <param name="relationObjectType">RelationObjectType</param>
        /// <returns></returns>
        public static string GetObjectTitle(DataType.RelationObjectType relationObjectType)
        {
            string tableName = DataType.GetTableName(relationObjectType);
            string objectTitle = "";
            switch (relationObjectType)
            {
                case DataType.RelationObjectType.Document:
                    {
                        objectTitle = "【文档编号:" + CommonFuns.getDataTableBySql("DOCNO", "", tableName).Rows[0][0].ToString() + "】";
                        break;
                    }
                case DataType.RelationObjectType.File:
                    {
                        objectTitle = "【文件名称:" + CommonFuns.getDataTableBySql("DFL_FILE_NAME", "", tableName).Rows[0][0].ToString() + "】";
                        break;
                    }
                case DataType.RelationObjectType.Material:
                    {
                        objectTitle = "【物料NO:" + CommonFuns.getDataTableBySql("MATERIALNO", "", tableName).Rows[0][0].ToString() + "】";
                        break;
                    }
                case DataType.RelationObjectType.Product:
                    {
                        objectTitle = "【产品NO:" + CommonFuns.getDataTableBySql("PRODUCTNO", "WHERE PRODUCTLEVEL=1", tableName).Rows[0][0].ToString() + "】"; //PRODUCTLEVEL为1的时候表示是产品
                        break;
                    }
                case DataType.RelationObjectType.SemiProduct:
                    {
                        objectTitle = "【半成品NO:" + CommonFuns.getDataTableBySql("PRODUCTNO", "WHERE PRODUCTLEVEL=2", tableName).Rows[0][0].ToString() + "】"; //PRODUCTLEVEL为2的时候表示是半产品
                        break;
                    }
                case DataType.RelationObjectType.Drawing:
                    {
                        objectTitle = "【图纸NO:" + CommonFuns.getDataTableBySql("DOCNO", "", tableName).Rows[0][0].ToString() + "】";
                        break;
                    }
                default:
                    {
                        tableName = "";
                        break;
                    }
            }
            return objectTitle;
        }
        /// <summary>
        /// 获取form
        /// </summary>
        /// <param name="RelationObjectType"></param>
        /// <param name="objectID"></param>
        /// <returns></returns>
        public static Form GetDetaiFrm(DataType.RelationObjectType RelationObjectType, string objectID)
        {
            Form FrmDetail = null;
            string tableName = DataType.GetTableName(RelationObjectType);
            switch (RelationObjectType)
            {
                case DataType.RelationObjectType.Document:
                    {
                        IDocumentService _docService = ServiceContainer.GetService<DocumentService>();
                        HYPDM.WinUI.Document.DocRegForm frm = new Document.DocRegForm(true);
                        frm.Document = _docService.GetDocListByID(objectID)[0];
                        frm.StartPosition = FormStartPosition.CenterParent;
                        FrmDetail = frm;
                        break;
                    }
                case DataType.RelationObjectType.File:
                    {
                        //tableName = "DOC_FILE_LIST";
                        break;
                    }
                case DataType.RelationObjectType.Material:
                    {
                        //tableName = "PDM_MATERAIL";

                        HYPDM.WinUI.ProductsAndParts.Material.MaterialConfForm frm = new ProductsAndParts.Material.MaterialConfForm(objectID, 1, true);  //2为半成品  1为成品
                        //IDocumentService _docService = ServiceContainer.GetService<DocumentService>();
                        //IAllProductService m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
                        FrmDetail = frm;
                        frm.StartPosition = FormStartPosition.CenterParent;
                        break;
                    }
                case DataType.RelationObjectType.Product:
                    {
                        // tableName = "PDM_ALL_PRODUCT";  //PRODUCTLEVEL为1的时候表示是产品
                        HYPDM.WinUI.ProductsAndParts.Products.ProductsConfForm frm = new ProductsAndParts.Products.ProductsConfForm(objectID, 1, true);  //2为半成品  1为成品
                        //IDocumentService _docService = ServiceContainer.GetService<DocumentService>();
                        //IAllProductService m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();
                        FrmDetail = frm;
                        frm.StartPosition = FormStartPosition.CenterParent;

                        break;
                    }
                case DataType.RelationObjectType.SemiProduct:
                    {
                        //tableName = "PDM_ALL_PRODUCT"; //PRODUCTLEVEL为2的时候表示是半产品
                        HYPDM.WinUI.ProductsAndParts.Products.ProductsConfForm frm = new ProductsAndParts.Products.ProductsConfForm(objectID, 2, true);  //2为半成品  1为成品
                        //IDocumentService _docService = ServiceContainer.GetService<DocumentService>();
                        //IAllProductService m_AllProductService = EAS.Services.ServiceContainer.GetService<IAllProductService>();

                        //frm.Product = m_AllProductService.GetById(objectID);

                        frm.StartPosition = FormStartPosition.CenterParent;
                        FrmDetail = frm;
                        break;
                    }
                case DataType.RelationObjectType.Drawing:
                    {
                        IDRAWINGService _docService = ServiceContainer.GetService<DRAWINGService>();
                        HYPDM.WinUI.DrawingDocument.DrawRegForm frm = new DrawingDocument.DrawRegForm(true);
                        frm.Document = _docService.GetDrawObjectDCID(objectID);
                        frm.StartPosition = FormStartPosition.CenterParent;
                        FrmDetail = frm;
                        break;
                    }
                default:
                    {
                        // tableName = "";
                        break;
                    }
            }
            return FrmDetail;
        }


        public IList<WF_APP_HANDLE> GetAllHandleList(string wfaID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetAllHandleList(wfaID);
        }
        #region
        //public IList<WF_APP_HANDLE> GetAllHandleList(string wfaID)
        //{
        //    IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
        //    return _wfService.GetAllHandleList(wfaID);
        //}

        //public IList<WF_DETAIL> GetWfDetailList(string wfaID)
        //{
        //    IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
        //    return _wfService.GetWfDetailList(wfaID);
        //}

        //public WF_DETAIL GetWfAppLastDetailByWfaID(string wfaID)
        //{
        //    WF_DETAIL detail = null;
        //    StringBuilder stb = new StringBuilder();
        //    stb.Append("   WHERE 1=1 AND WFA_ID='" + wfaID + "'");
        //    stb.Append(" AND RECIVEDATE IN (SELECT MAX(RECIVEDATE) FROM WF_DETAIL WHERE  WFA_ID='"+wfaID+"') ");
        //    DataTable dt = CommonFuns.getDataTableBySql("*", stb.ToString(), "WF_DETAIL");
        //    if (dt == null || dt.Rows.Count == 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        detail = new WF_DETAIL();
        //        DataRow dr = dt.Rows[0];
        //        detail.WFA_ID = dt.Rows[0]["WFA_ID"].ToString();
        //        detail.WFD_ID = dt.Rows[0]["WFD_ID"].ToString();
        //        detail.WFT_STEP_ID = dt.Rows[0]["WFT_STEP_ID"].ToString();
        //        detail.RECIVEDATE = dt.Rows[0]["RECIVEDATE"].ToString();
        //        detail.MSG = dt.Rows[0]["MSG"].ToString();
        //        detail.IS_Through = dt.Rows[0]["IS_Through"].ToString();
        //        detail.Current_STEP_ID = dt.Rows[0]["Current_STEP_ID"].ToString();
        //        return detail;
        //    }
        //}
        #endregion

        //获取对象关联的流程实例
        public DataTable GetObjectWFList(string p_ObjectId, string p_user, string p_ObjectType)
        {
            {
                StringBuilder selectWhere = new StringBuilder();
                String selectColunm = " A.WFA_ID,A.OBJECTKEY,B.WFT_NAME,A.SUBJECT,A.STATUS, A.CREATEUSER,A.WFT_ID ";
                String selectTable = "WF_APP A,WF_TEMPLATES B  ";

                selectWhere.Append("WHERE   A.WFT_ID= B.WFT_ID AND OBJECTKEY='").Append(p_ObjectId)
                     .Append("'  AND RELATIONOBJECTTYPE  ='").Append(p_ObjectType)
                     .Append("'  AND A.CREATEUSER='").Append(p_user).Append("' ");

                DataTable dt = CommonFuns.getDataTableBySql(selectColunm, selectWhere.ToString(), selectTable);
                return dt;
            }
        }
        public IList<WF_APP_USER> GetAllUserList(string wfaID)
        {
            IWFTemplatesStepService _wfService = ServiceContainer.GetService<WFTemplatesStepService>();
            return _wfService.GetAllUserList(wfaID);

        }
        /// <summary>
        /// 获取对象的工作流实例
        /// </summary>
        /// <param name="p_ObjectId">对象主键</param>
        /// <param name="p_ObjectType">对象类型</param>
        /// <returns></returns>
        public DataTable GetObjectWFList(string p_ObjectId, string p_ObjectType)
        {
            StringBuilder selectWhere = new StringBuilder();
            String selectColunm = " A.WFA_ID,A.OBJECTKEY,B.WFT_NAME,A.SUBJECT,A.STATUS, A.CREATEUSER ,A.WFT_ID";
            String selectTable = "WF_APP A,WF_TEMPLATES B  ";

            selectWhere.Append("WHERE   A.WFT_ID= B.WFT_ID AND OBJECTKEY='").Append(p_ObjectId)
                 .Append("'  AND RELATIONOBJECTTYPE  ='").Append(p_ObjectType)
                 .Append("'");
            DataTable dt = CommonFuns.getDataTableBySql(selectColunm, selectWhere.ToString(), selectTable);
            return dt;
        }

        /// <summary>
        /// 重启工作流
        /// </summary>
        /// <param name="dgv">存放数据信息的gridview</param>
        /// <param name="wfaID">工作流实例主键ID</param>
        /// <param name="loginID">登录账号</param>
        public void RestartWorkFlow(DataGridView dgv, string wfaID, string loginID,string wftID)
        {
            if (dgv.RowCount <= 0)
            {
                // MessageBox.Show("请选择一条记录");
                MessageBox.Show("请选择一条记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = dgv.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("请选择一条记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            // string status = dgv.CurrentRow.Cells["STATUS"].Value.ToString();
            //if (!status.Equals(DataType.WFDetailSTATUS.Return.ToString()))
            //{
            //    MessageBox.Show("该流程已经启动", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); return;
            //}
            //WF_APP t_wfapp = EAS.Services.ServiceContainer.GetService<WFTemplatesStepService>().GetWFappByWFID(dgv.CurrentRow.Cells["WFA_ID"].Value.ToString());
            WF_APP t_wfapp = EAS.Services.ServiceContainer.GetService<WFTemplatesStepService>().GetWFappByWFID(wfaID);
            if (wfaID != null)
            {
                if (!t_wfapp.STATUS.Equals(DataType.WFDetailSTATUS.Return.ToString()))
                {
                    MessageBox.Show("该流程状态不为Return,不能重新发起,目前状态为:" + "\n" + t_wfapp.STATUS.ToString(), "确认", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); return;
                }
                if (loginID == t_wfapp.CREATEUSER)
                {
                   // t_wfapp.STATUS = DataType.WFDetailSTATUS.Activated.ToString();
                }
                else
                {
                    MessageBox.Show("工作流只有发起人才可以重新启动!,本工作流的发起人为:" + "\n" + t_wfapp.CREATEUSER, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("获取工作流实例信息失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
               // t_wfapp.Update();
                //t_wfapp.Update();
                HYPDM.WinUI.WorkFlow.Flow.StandardFlow flow = new Flow.StandardFlow(wftID, wfaID);
                // new StandardFlow(this.dgv_ProRecord.CurrentRow.Cells["WFT_ID"].Value.ToString(), dgv_ProRecord.CurrentRow.Cells["WFA_ID"].Value.ToString());
                flow.ShowDialog();
              //  MessageBox.Show("工作流重启成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新状态失败,异常信息:" + "\n" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        /// <summary>
        /// 重启工作流,不需要传gridview控件
        /// </summary>
        /// <param name="wfaID">工作流实例主键ID</param>
        /// <param name="loginID">登录账号</param>
        ///<param name="wftID">工作流模板ID</param>
        public void RestartWorkFlow(string wfaID, string loginID,string wftID)
        {
            WF_APP t_wfapp = EAS.Services.ServiceContainer.GetService<WFTemplatesStepService>().GetWFappByWFID(wfaID);
            if (wfaID != null)
            {
                if (!t_wfapp.STATUS.Equals(DataType.WFDetailSTATUS.Return.ToString()))
                {
                    MessageBox.Show("该流程状态不为Return,不能重新发起,目前状态为:" + "\n" + t_wfapp.STATUS.ToString(), "确认", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); return;
                }
                if (loginID == t_wfapp.CREATEUSER)
                {
                    //t_wfapp.STATUS = DataType.WFDetailSTATUS.Activated.ToString();
                }
                else
                {
                    MessageBox.Show("工作流只有发起人才可以重新启动!,本工作流的发起人为:" + "\n" + t_wfapp.CREATEUSER, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("获取工作流实例信息失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //t_wfapp.Update();
                HYPDM.WinUI.WorkFlow.Flow.StandardFlow flow = new Flow.StandardFlow(wftID, wfaID);
               // new StandardFlow(this.dgv_ProRecord.CurrentRow.Cells["WFT_ID"].Value.ToString(), dgv_ProRecord.CurrentRow.Cells["WFA_ID"].Value.ToString());
                flow.ShowDialog();
                //MessageBox.Show("工作流重启成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新状态失败,异常信息:" + "\n" + ex.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
