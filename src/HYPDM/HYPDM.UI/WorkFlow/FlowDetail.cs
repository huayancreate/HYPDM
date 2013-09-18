using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace HYPDM.WinUI.WorkFlow
{
    public class FlowDetail
    {  
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginD">登录账号</param>
        /// <param name="detailType">1. 本人待办工作流   2. 发出的工作:本人拟制的工作流  3. 完成的工作:本人发起的、不是本人发起的，但是与本人有关的工作流且自己已经完成签批，但是整个工作流不一定完成签批</param>
        /// <returns></returns>
        public static DataTable GetWorkDetail(string loginD, int detailType)
        {


            ///1. 我参与的所有工作流 ,未完成但是已经激活状态的
            ///SELECT * FROM WF_APP WHERE WFA_ID IN 
            ///( SELECT DISTINCT WFA_ID FROM WF_APP_HANDLE WHERE   OBJECTVALUE='PDM')
            ///AND   WF_APP.STATUS NOT IN ('UNActivated','Complete') AND DEL_FLAG='N'



            ///2.所有未完成的工作流 
            ///SELECT * FROM WF_DETAIL  WHERE IS_Through NOT IN ('Y','N') AND
            ///( COMPLEMENTDATE ='' OR COMPLEMENTDATE IS NULL)







            DataTable dtTemp = null;
            //1. 本人待办工作流
            //2. 发出的工作:本人拟制的工作流
            //3. 完成的工作:本人发起的、不是本人发起的，但是与本人有关的工作流且自己已经完成签批，但是整个工作流不一定完成签批
            StringBuilder stbTableNameSQl;
            StringBuilder stbWhereSQl;
            StringBuilder stbFieldsSQl;
            switch (detailType)
            {
                case 1:
                    {
                        stbTableNameSQl = new StringBuilder();
                        stbWhereSQl = new StringBuilder();
                        stbFieldsSQl = new StringBuilder();

                        stbFieldsSQl.Append(" DISTINCT  A.WFA_ID,A.WFT_ID,A.CREATEDATE,A.CREATEUSER,A.DEL_FLAG,A.OBJECTKEY,");
                        stbFieldsSQl.Append(" A.RELATIONOBJECTTYPE,A.START_DATE,A.STATUS,A.SUBJECT");
                        stbFieldsSQl.Append(" ,B.Current_STEP_ID,B.COMPLEMENTDATE,B.IS_Through STEP_THROUGH,B.MSG,");
                        stbFieldsSQl.Append(" B.RECIVEDATE,B.WFT_STEP_ID,'' USER_THROUGH,");
                        stbFieldsSQl.Append(" C.WFT_NAME ");

                        stbTableNameSQl.Append(" WF_APP A,");
                        stbTableNameSQl.Append("( SELECT * FROM WF_DETAIL  WHERE IS_Through NOT IN ('Y','N') AND");
                        stbTableNameSQl.AppendFormat(" (COMPLEMENTDATE ='' OR COMPLEMENTDATE IS NULL)) B ,WF_TEMPLATES C,( SELECT*  FROM WF_APP_HANDLE WHERE OBJECTVALUE='{0}' AND IS_THROUGH NOT IN ('Y','N') ) D",loginD);
                        stbTableNameSQl.Append("   WHERE A.WFA_ID IN ");
                        stbTableNameSQl.AppendFormat("( SELECT DISTINCT WFA_ID FROM WF_APP_HANDLE WHERE OBJECTVALUE='{0}' AND IS_THROUGH NOT IN ('Y','N'))", loginD);
                        stbTableNameSQl.Append(" AND   A.STATUS NOT IN ('UNActivate','Complete') AND A.DEL_FLAG='N'");
                        stbTableNameSQl.Append(" AND A.WFA_ID=B.WFA_ID");
                        stbTableNameSQl.Append(" AND  A.WFT_ID=C.WFT_ID   AND B.Current_STEP_ID=D.Current_STEP_ID");
                        dtTemp = CommonFuns.getDataTableBySql(stbFieldsSQl.ToString(), stbWhereSQl.ToString(), stbTableNameSQl.ToString());
                        break;
                    }
                case 2:
                    {

                        stbTableNameSQl = new StringBuilder();
                        stbWhereSQl = new StringBuilder();
                        stbFieldsSQl = new StringBuilder();

                        stbFieldsSQl.Append("  DISTINCT A.WFA_ID,A.WFT_ID,A.CREATEDATE,A.CREATEUSER,A.DEL_FLAG,A.OBJECTKEY,");
                        stbFieldsSQl.Append(" A.RELATIONOBJECTTYPE,A.START_DATE,A.STATUS,A.SUBJECT");
                        stbFieldsSQl.Append(" ,B.Current_STEP_ID,B.COMPLEMENTDATE,B.IS_Through STEP_THROUGH,B.MSG,");
                        stbFieldsSQl.Append(" B.RECIVEDATE,B.WFT_STEP_ID,A.LASTUPDATEDATE,'' USER_THROUGH");
                        stbFieldsSQl.Append(" ,C.WFT_NAME ");

                        stbTableNameSQl.AppendFormat(" (SELECT * FROM WF_APP WHERE CREATEUSER='{0}' AND DEL_FLAG='N') A ", loginD);
                        stbTableNameSQl.Append(" LEFT JOIN  ");
                        stbTableNameSQl.Append(" WF_TEMPLATES C ON  A.WFT_ID=C.WFT_ID ");
                        stbTableNameSQl.Append(" LEFT JOIN  ");
                        stbTableNameSQl.Append("(SELECT * FROM WF_DETAIL  WHERE IS_Through NOT IN ('Y','N') AND ");
                        stbTableNameSQl.Append("( COMPLEMENTDATE ='' OR COMPLEMENTDATE IS NULL)) B  ");
                        stbTableNameSQl.Append(" ON  A.WFA_ID=B.WFA_ID ");
                        dtTemp = CommonFuns.getDataTableBySql(stbFieldsSQl.ToString(), stbWhereSQl.ToString(), stbTableNameSQl.ToString());
                        break;
                    }
                case 3:
                    {
                        stbTableNameSQl = new StringBuilder();
                        stbWhereSQl = new StringBuilder();
                        stbFieldsSQl = new StringBuilder();
                        stbFieldsSQl.Append("  DISTINCT A.WFA_ID,A.WFT_ID,A.CREATEDATE,A.CREATEUSER,A.DEL_FLAG,A.OBJECTKEY,");
                        stbFieldsSQl.Append(" A.LASTUPDATEDATE,A.RELATIONOBJECTTYPE,A.START_DATE,A.STATUS,A.SUBJECT");
                        stbFieldsSQl.Append(" ,B.Current_STEP_ID,B.COMPLEMENTDATE,B.IS_Through STEP_THROUGH,B.MSG,");
                        stbFieldsSQl.Append(" B.RECIVEDATE,B.WFT_STEP_ID,D.IS_THROUGH USER_THROUGH ,C.WFT_NAME ");


                        stbTableNameSQl.Append(" WF_DETAIL B ,");
                        stbTableNameSQl.AppendFormat("( SELECT * FROM WF_APP_HANDLE WHERE OBJECTVALUE='{0}' AND  IS_THROUGH IN ('Y','N')) D,",loginD);
                        stbTableNameSQl.Append(" WF_APP A ,WF_TEMPLATES C");
                        stbTableNameSQl.Append(" WHERE  B.WFA_ID=D.WFA_ID AND B.Current_STEP_ID=D.Current_STEP_ID");
                        stbTableNameSQl.Append(" AND  A.WFT_ID=C.WFT_ID  AND A.WFA_ID=B.WFA_ID AND A.WFA_ID=D.WFA_ID ");

                        dtTemp = CommonFuns.getDataTableBySql(stbFieldsSQl.ToString(), stbWhereSQl.ToString(), stbTableNameSQl.ToString());
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            //CommonFuns.getDataTableBySql();

            return dtTemp;

        }
    }
}
