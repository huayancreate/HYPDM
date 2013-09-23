using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HYPDM.BLL;
using EAS.Modularization;
using EAS.Explorer;
namespace HYPDM.WinUI.AddObjectParams
{
    public class ObjectParams
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
    }
}
