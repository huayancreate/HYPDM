using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Explorer;
using EAS.Data;
using EAS.Data.ORM;
using EAS.Data.Linq;
namespace HYPDM.BLL
{
    [ServiceObject("文档权限")]
    [ServiceBind(typeof(IFileAuthService))]
    public class FileAuthService : BaseServiceObject, IFileAuthService
    {
        public FILE_AUTH GetFileAuth(string FAU_OBJ_TYPE, string FAU_OBJ_VALUE, string FAU_IS_FOLDER, string DFL_ID)
        {
            // DataTable dt = null;

            DataEntityQuery<FILE_AUTH> query = DataEntityQuery<FILE_AUTH>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     where (item.DEL_FLAG == "N" && item.FAU_OBJ_TYPE == FAU_OBJ_TYPE && item.FAU_OBJ_VALUE==FAU_OBJ_VALUE && item.FAU_IS_FOLDER==FAU_IS_FOLDER && item.DFL_ID==DFL_ID)
                     select item
                );
           IList<FILE_AUTH> list=p.ToList();
           if (list == null ||list.Count==0)
           {
               return null;
           }
           else
           {
               return list[0];
           }
        }
    }
}
