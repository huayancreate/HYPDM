using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("对象结构管理服务")]
    [ServiceBind(typeof(IObjectStructService))]
    public class ObjectStructService : BaseServiceObject, HYPDM.BLL.IObjectStructService
    {
        public DataTable GetList(string p_ObjectId, string p_ObjectVer)
        {
            string sqlText = "select * from PDM_OBJECT_STRUCT Where OBJECTID = '" + p_ObjectId + "' And OBJECTVERSION='" + p_ObjectVer + "'";
            DataTable dt=this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }


    }
}
