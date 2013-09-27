using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Drawing
    {
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

        private static Drawing newInstance;

        public static Drawing NewInstance
        {
            get
            {
                if (newInstance == null)
                {
                    newInstance = new Drawing();
                }
                return Drawing.newInstance;
            }
            set { Drawing.newInstance = value; }
        }

        /// <summary>
        /// 获取记录
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        public DataTable GetDrawingListForDatatable(Boolean bl)
        {
            string delFlag = bl == true ? "N" : "Y";
            DataTable dt = null;
            string SQLText = "SELECT  FROM PDM_DRAWING LEFT JOIN ComboBoxValue ON   DOCTYPE=COMBVALUE WHERE DEL_FLAG='" + delFlag + "'" + "ORDER BY CREATEDATE asc ";

            dt = getDataTableBySql("DOCID,DOCNAME ,DEL_FLAG,DOCTYPE,DOCSTATUS ,LASTUPDATEUSER ,COMBTEXT,CREATEDATE ,LASTUPDATEDATE,REMARK,VERSION ,DOCNO ,DESCRIPTION,CREATEUSER","","PDM_DRAWING LEFT JOIN ComboBoxValue ON   DOCTYPE=COMBVALUE WHERE DEL_FLAG='" + delFlag + "'" + "ORDER BY CREATEDATE asc");

            return dt;
        }
    }
}
