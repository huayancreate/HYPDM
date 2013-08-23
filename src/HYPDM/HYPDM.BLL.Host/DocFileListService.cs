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
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IDocFileListService))]
    public class DocFileListService : BaseServiceObject, IDocFileListService
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
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
            string delFlag = "N";
            if (bl == false)
            {
                delFlag = "Y";
            }
            else
            {
                delFlag = "N";
            }
            DataTable dt = null;
            string SQLText = "SELECT * FROM DOC_FILE_LIST WHERE DEL_FLAG='" + delFlag.Trim() + "' ORDER BY  CREATEDATE asc ";

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
        public DataTable GetDocFileDir(Boolean bl)
        {

            string delFlag = "";
            if (bl == false)
            {
                delFlag = "Y";
            }
            else
            {
                delFlag = "N";
            }
            DataTable dt = null;
            string SQLText = "SELECT * FROM DOC_FILE_DIR  WHERE DEL_FLAG='"+delFlag+"'";
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
        public Boolean delDocFileByDFLID(string dflID)
        {
            Boolean result = true;
            DOC_FILE_LIST file = new DOC_FILE_LIST();
            DataEntityQuery<DOC_FILE_LIST> query = DataEntityQuery<DOC_FILE_LIST>.Create();

            var p = (from item in query
                     where (item.DFL_ID == dflID) && (item.DEL_FLAG == "N")
                     select item
                );
            file = p.ToList()[0];
            if (file == null)
            {
                result = false;
                throw new Exception("改记录不存在");
            }
            else
            {
                file.DEL_FLAG = "Y";
                file.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                file.LASTUPDATEUSER = LoginInfo.LoginID;
                try
                {
                    file.Update();
                }
                catch (Exception ex)
                {
                    result = false;
                    throw new Exception(ex.Message.ToString());
                }
                finally
                {

                }
            }
            return result;
        }
        public DOC_FILE_LIST GetDocFileEntityByDCID(string dflID)
        {
            DOC_FILE_LIST doc = null;
            DataEntityQuery<DOC_FILE_LIST> query = DataEntityQuery<DOC_FILE_LIST>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N") && (item.DFL_ID == dflID)
                     select item);
            IList<DOC_FILE_LIST> list = p.ToList();
            if (list.Count == 0)
            {

            }
            else
            {
                doc = list[0];
            }
            return doc;
        }

        public DataTable getDataTableBySql(String sql)
        {
            DataTable dt = null;
            dt = this.DataAccessor.QueryDataTable(sql);
            return dt;
        }
    }
}
