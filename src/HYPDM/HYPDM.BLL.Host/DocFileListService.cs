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
namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IDocFileListService))]
    public class DocFileListService : BaseServiceObject, IDocFileListService
    {
        /// <summary>
        /// 返回所有文档清单
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetDocFileListForDatatable()
        {
            DataTable dt = null;
            string SQLText = "SELECT * FROM DOC_FILE_LIST ORDER BY CREATEDATE asc ";

            dt = this.DataAccessor.QueryDataTable(SQLText);

          
            return dt;
        }
        /// <summary>
        /// 返回指定删除标识的文档清单
        /// </summary>
        /// <param name="bl">true为没有删除，false标识已经删除</param>
        /// <returns></returns>
        public DataTable GetDocFileListForDatatable(Boolean bl)
        {
            string  delFlag = "N";
            if (bl == false)
            {
                delFlag = "Y";
            }
            else
            {
                delFlag = "N";
            }
            DataTable dt = null;
            string SQLText = "SELECT * FROM DOC_FILE_LIST ORDER BY WHERE DEL_FLAG='"+delFlag.Trim()+"' CREATEDATE asc ";

            dt = this.DataAccessor.QueryDataTable(SQLText);

            return dt;
        }
        public DataTable GetDocFileDir()
        {
            DataTable dt = null;
            string SQLText = "SELECT * FROM DOC_FILE_DIR ";
            dt = this.DataAccessor.QueryDataTable(SQLText);
            return dt;
            
        }

        public DataTable GetDocFileDataTableByDCID(string dcid)
        {
            DataTable dt = null;


            StringBuilder stb = new StringBuilder();
            stb.Append("SELECT DFL_ID,DFL_FILE_NAME,DFL_FILE_EXTEND,DFL_FILE_CHILD_PATH,DFL_VER_LATEST");
            stb.Append(" ,DEL_FLAG ,CREATEDATE,CREATEUSER,LASTUPDATEUSER,LASTUPDATEDATE,DOCID,CHECKINFLG,CHECKOUTFLG,CHECKINDATE,CHECKOUTDATE FROM DOC_FILE_LIST");
            stb.Append(" WHERE  DEL_FLAG='N' AND DOCID='" + dcid.Trim() + "'");
            dt = this.DataAccessor.QueryDataTable(stb.ToString());
            return dt;

                
        }
    }
}
