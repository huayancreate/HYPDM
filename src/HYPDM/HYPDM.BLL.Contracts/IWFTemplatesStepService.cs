using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  HYPDM.Entities;
using System.Data;
namespace HYPDM.BLL
{
    public  interface IWFTemplatesStepService
    {
        IList<WF_TEMPLATES_STEP> GetWFStepListByWFID(string wftID);
        ComboBoxValue GetWFStep(string stepID);
        WF_TEMPLATES_STEP GetWFStepInfoByStepID(string stepID);
        DataTable GetGreaterWFStepListByStepID(string stepID, string wftID);
        WF_TEMPLATES GetWFTemplatesInfoByWFID(string wftID);
        WF_TEMPLATES_STEP GetWFStartStepByWFID(string wftID);
        WF_TEMPLATES_STEP GetWFEndStepByWFID(string wftID);
        WF_APP GetWFappByWFID(string wfappID);
        /// <summary>
        /// 获取指定工作流实例指定节点的信息
        /// </summary>
        /// <param name="wfappID"></param>
        /// <param name="wftStepID"></param>
        /// <returns></returns>
        IList<WF_APP_HANDLE> GetWFAppStepHandle(string wfappID, string wftStepID);
        /// <summary>
        /// 根据工作流实例APPID与目前工作节点获取WF_APP_HANDLE信息集合
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <returns></returns>
        IList<WF_APP_HANDLE> GetWfAppStepHandleList(string wfaID, string CurrentStepID);
        /// <summary>
        /// 根据工作流实例APPID与目前工作节点、用户ID获取WF_APP_HANDLE信息
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        WF_APP_HANDLE GetWfAppHandleItem(string wfaID, string CurrentStepID, string userID);
        /// <summary>
        /// 获取当前节点信息
        /// </summary>
        /// <param name="wfaID"></param>
        /// <param name="CurrentStepID"></param>
        /// <returns></returns>
        WF_DETAIL GetDetailByWFAppidAndStepID(string wfaID, string CurrentStepID);

        /// <summary>
        /// 获取当前节点实例
        /// </summary>
        /// <param name="wftID"></param>
        /// <param name="CurrentStepID"></param>
        /// <returns></returns>
        WF_TEMPLATES_STEP GetStepInfoByWftIDAndCurrentStepID(string wftID, string CurrentStepID);

        /// <summary>
        /// 获取工作流实例所有经过的节点的处理信息
        /// </summary>
        /// <param name="wfaID"></param>
        /// <returns></returns>
        IList<WF_APP_HANDLE> GetWfAppHandleList(string wfaID);

        /// <summary>
        /// 获取给定object的对象
        /// </summary>
        /// <param name="OBJECTVALUE"></param>
        /// <returns></returns>
        WF_TEMPLATES_OBJECT GetWfTemplatesObject(string OBJECTVALUE);

        /// <summary>
        /// 获取工作流处理清单
        /// </summary>
        /// <param name="wfaID"></param>
        /// <returns></returns>
        IList<WF_DETAIL> GetWfDetailList(string wfaID);
        /// <summary>
        /// 获取所有handle信息
        /// </summary>
        /// <param name="wfaID"></param>
        /// <returns></returns>
        IList<WF_APP_HANDLE> GetAllHandleList(string wfaID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wfappID"></param>
        /// <param name="wftStepID"></param>
        IList<WF_APP_USER> GetWFAppStepUser(string wfappID, string wftStepID);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wfaID"></param>
        /// <returns></returns>
        IList<WF_APP_USER> GetAllUserList(string wfaID);
    }
}
