using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;
using EAS.Explorer;

namespace HYPDM.BLL
{
    [ServiceObject("工作流")]
    [ServiceBind(typeof(IWFTemplatesStepService))]
    public class WFTemplatesStepService : BaseServiceObject, IWFTemplatesStepService
    {
        public IList<WF_TEMPLATES_STEP> GetWFStepListByWFID(string wftID)
        {

            DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFT_ID == wftID)
                     select item
                );
            return p.ToList();
        }
        public WF_TEMPLATES_STEP GetWFStepInfoByStepID(string stepID)
        {

            DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFT_STEP_ID == stepID)
                     select item
                );
            IList<WF_TEMPLATES_STEP> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }
        public ComboBoxValue GetWFStep(string stepID)
        {

            DataEntityQuery<ComboBoxValue> query = DataEntityQuery<ComboBoxValue>.Create();

            var p = (from item in query

                     where (item.COMBID == stepID)
                     select item
                );
            IList<ComboBoxValue> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }


        public DataTable GetGreaterWFStepListByStepID(string stepID, string wftID)
        {

            StringBuilder stb = new StringBuilder();
            stb.Append("SELECT * FROM WF_TEMPLATES_STEP");
            stb.Append("  WHERE  DEL_FLAG='N' AND WFT_ID='").Append(wftID).Append("'");
            stb.Append(" AND  CREATEDATE>(SELECT  CREATEDATE   FROM WF_TEMPLATES_STEP WHERE WFT_STEP_ID='").Append(stepID).Append("')");
            DataTable dtTemp = null;
            dtTemp = this.DataAccessor.QueryDataTable(stb.ToString());
            return dtTemp;
        }

        public WF_TEMPLATES GetWFTemplatesInfoByWFID(string wftID)
        {

            DataEntityQuery<WF_TEMPLATES> query = DataEntityQuery<WF_TEMPLATES>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFT_ID == wftID)
                     select item
                );
            IList<WF_TEMPLATES> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }
        public WF_TEMPLATES_STEP GetWFStartStepByWFID(string wftID)
        {
            DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFT_ID == wftID && item.IS_START_STEP == "Y")
                     select item
                );
            IList<WF_TEMPLATES_STEP> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }

        public WF_TEMPLATES_STEP GetWFEndStepByWFID(string wftID)
        {
            DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFT_ID == wftID && item.IS_END_STEP == "Y")
                     select item
                );
            IList<WF_TEMPLATES_STEP> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }

        public WF_APP GetWFappByWFID(string wfappID)
        {

            DataEntityQuery<WF_APP> query = DataEntityQuery<WF_APP>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfappID)
                     select item
                );
            IList<WF_APP> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }
        public IList<WF_APP_HANDLE> GetWFAppStepHandle(string wfappID, string wftStepID)
        {
            DataEntityQuery<WF_APP_HANDLE> query = DataEntityQuery<WF_APP_HANDLE>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfappID && item.WFT_STEP_ID == wftStepID)
                     select item
                );
            return p.ToList();
        }
        public IList<WF_APP_USER> GetWFAppStepUser(string wfappID, string wftStepID)
        {
            DataEntityQuery<WF_APP_USER> query = DataEntityQuery<WF_APP_USER>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfappID && item.WFT_STEP_ID == wftStepID)
                     select item
                );
            return p.ToList();
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
            DataEntityQuery<WF_APP_HANDLE> query = DataEntityQuery<WF_APP_HANDLE>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfaID && item.Current_STEP_ID == CurrentStepID
                     && item.OBJECTTYPE == "SingleUser" && item.OBJECTVALUE == userID)
                     select item
                );
            IList<WF_APP_HANDLE> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
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
            DataEntityQuery<WF_APP_HANDLE> query = DataEntityQuery<WF_APP_HANDLE>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfaID && item.Current_STEP_ID == CurrentStepID
                     && item.OBJECTTYPE == "SingleUser")
                     select item
                );
            return p.ToList();
        }

        /// <summary>
        /// 获取detail信息,当前节点
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <returns></returns>
        public WF_DETAIL GetDetailByWFAppidAndStepID(string wfaID, string CurrentStepID)
        {
            DataEntityQuery<WF_DETAIL> query = DataEntityQuery<WF_DETAIL>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfaID && item.Current_STEP_ID == CurrentStepID)
                     select item
                );
            IList<WF_DETAIL> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }

        public WF_TEMPLATES_STEP GetStepInfoByWftIDAndCurrentStepID(string wftID, string CurrentStepID)
        {
            DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFT_ID == wftID && item.WFT_CURRENT_STEP_ID == CurrentStepID)
                     select item
                );
            IList<WF_TEMPLATES_STEP> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }


        public IList<WF_APP_HANDLE> GetWfAppHandleList(string wfaID)
        {
            DataEntityQuery<WF_APP_HANDLE> query = DataEntityQuery<WF_APP_HANDLE>.Create();
            var p = (from item in query
                     orderby item.COMPLEMENTDATE descending
                     where (item.WFA_ID == wfaID && (item.IS_THROUGH == "Y" || item.IS_THROUGH == "N") && item.OBJECTTYPE == "SingleUser")
                     select item
                       );
            return p.ToList();
        }
        public IList<WF_APP_HANDLE> GetAllHandleList(string wfaID)
        {
            DataEntityQuery<WF_APP_HANDLE> query = DataEntityQuery<WF_APP_HANDLE>.Create();
            var p = (from item in query
                     orderby item.LASTUPDATEDATE descending
                     where (item.WFA_ID == wfaID && item.DEL_FLAG=="N")
                     select item
                    );
            return p.ToList();
        }


        public IList<WF_APP_USER> GetAllUserList(string wfaID)
        {
            DataEntityQuery<WF_APP_USER> query = DataEntityQuery<WF_APP_USER>.Create();
            var p = (from item in query
                     where (item.WFA_ID == wfaID && item.DEL_FLAG == "N")
                     select item
                    );
            return p.ToList();
        }
        public WF_TEMPLATES_OBJECT GetWfTemplatesObject(string OBJECTVALUE)
        {
            DataEntityQuery<WF_TEMPLATES_OBJECT> query = DataEntityQuery<WF_TEMPLATES_OBJECT>.Create();
            var p = (from item in query
                     where (item.OBJECTVALUE == OBJECTVALUE)
                     select item);
            IList<WF_TEMPLATES_OBJECT> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return null;
            }
            else
            {
                return p.ToList()[0];
            }
        }

        public IList<WF_DETAIL> GetWfDetailList(string wfaID)
        {
            DataEntityQuery<WF_DETAIL> query = DataEntityQuery<WF_DETAIL>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N" && item.WFA_ID == wfaID)
                     select item
                );
            return p.ToList();
        }
    }
}

