using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAS.Explorer;
using EAS.Modularization;
using HYPDM.BLL;
using HYPDM.BaseControl;
namespace HYPDM.WinUI.DrawingDocument
{
    public class DocQuery
    {
        private static DocQuery newInstance;

        public static DocQuery NewInstance
        {
            get
            {

                if (newInstance == null)
                {
                    newInstance = new DocQuery();
                }
                return DocQuery.newInstance;
            }
        }

        /// <summary>
        /// 给定列名，where条件,及表明返回datatable
        /// </summary>
        /// <param name="fields">需要查询出来的字段,sample:fields1,field2,field3</param>
        /// <param name="where">查询条件,sample:  where 1=1 and a1='jjj' order by CreateDate asc</param>
        /// <param name="tableName">查询的表名,sample:DOC_FILE_LIST</param>
        /// <returns></returns>
        public static DataTable getDataTableBySql(String fields, string where, string tableName)
        {
            DataTable tb = null;
            StringBuilder stb = new StringBuilder();
            stb.Append("SELECT " + fields + " FROM " + tableName + " " + where);
            tb = EAS.Services.ServiceContainer.GetService<DocFileListService>().getDataTableBySql(stb.ToString());
            return tb;
        }

        public IList<HYPDM.Entities.PDM_DOCUMENT> GetQueryResult(string queryStr)
        {
            IList<HYPDM.Entities.PDM_DOCUMENT> list = null;
            HYPDM.Entities.PDM_DOCUMENT doc;
            DataTable dtTemp = getDataTableBySql("PDM_DOCUMENT.* ", "WHERE DEL_FLAG='N' AND PDM_Params_DETAIL.MASTER_TABLE_NAME='PDM_DOCUMENT' AND DOCID=PK_VALUE AND " + queryStr, "PDM_DOCUMENT,PDM_Params_DETAIL");

            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                list = new List<HYPDM.Entities.PDM_DOCUMENT>();

            }
            foreach (DataRow dr in dtTemp.Rows)
            {
                doc = new Entities.PDM_DOCUMENT();
                doc.DOCID = dr["DOCID"].ToString();
                doc.DOCNAME = dr["DOCNAME"].ToString();
                doc.DOCNO = dr["DOCNO"].ToString();
                doc.DOCSTATUS = dr["DOCSTATUS"].ToString();
                doc.DOCTYPE = dr["DOCTYPE"].ToString();

                doc.LASTUPDATEDATE = dr["LASTUPDATEDATE"].ToString();
                doc.LASTUPDATEUSER = dr["LASTUPDATEUSER"].ToString();
                doc.REMARK = dr["REMARK"].ToString();
                doc.VERSION = dr["VERSION"].ToString();

                doc.CREATEDATE = dr["CREATEDATE"].ToString();
                doc.CREATEUSER = dr["CREATEUSER"].ToString();
                doc.DEL_FLAG = dr["DEL_FLAG"].ToString();
                doc.DESCRIPTION = dr["DESCRIPTION"].ToString();
               
                list.Add(doc);
            }
            return list;
        }
        public DataTable  GetQueryResultForDataTable(string queryStr)
        {

            DataTable dtTemp = getDataTableBySql("PDM_DRAWING.* ", "WHERE DEL_FLAG='N' AND " + queryStr, " PDM_DRAWING left join PDM_Params_DETAIL" + " ON PDM_Params_DETAIL.MASTER_TABLE_NAME='PDM_DRAWING' AND DOCID=PK_VALUE ");

            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                return null;
            }

            return dtTemp;
        }
    }
}
