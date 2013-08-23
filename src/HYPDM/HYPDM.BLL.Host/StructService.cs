using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Access;
using EAS.Data.Linq;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("产品结构关联服务")]
    [ServiceBind(typeof(IStructService))]
    public class StructService : BaseServiceObject, HYPDM.BLL.IStructService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PRODUCT().DbTableName);
        }

        public DataTable GetProductList()
        {
            string sqlText = "Select PRODUCTID,PRODUCTNO,MODELTYPE,PRODUCTTYPE from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL =1";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        public DataTable GetPartsList()
        {
            string sqlText = "Select PRODUCTID,PRODUCTNO,MODELTYPE,PRODUCTTYPE from  PDM_ALL_PRODUCT  WHERE PRODUCTLEVEL =2";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        public  DataTable GetMaterailList()
        {
            string sqlText = "Select MATERIALID,MATERIALNO,MODELTYPE,MATERIALTYPE from  PDM_MATERAIL ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        public DataTable GetStructPartList(string p_objectId)
        {
            string sqlText = "SELECT     A.ASSOBJECTID,A.ASSONUM, A.SORTNUM, A.MEMO,B.PRODUCTNO,B.VERSION,B.MODELTYPE  " +
                             "FROM       PDM_STRUCT A,PDM_ALL_PRODUCT B  "+
                             "Where      A.OBJECTID = '" + p_objectId +"'  "+
                             "AND        A.ASSOBJECTID=B.PRODUCTID ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public DataTable GetStructMaterailList(string p_objectId) {
            string sqlText = "SELECT     A.ASSOBJECTID,A.ASSONUM, A.SORTNUM, A.MEMO,B.MATERIALNO,B.VERSION,B.MODELTYPE  " +
                             "FROM       PDM_STRUCT A,PDM_MATERAIL B  " +
                             "Where      A.OBJECTID = '" + p_objectId + "'  " +
                             "AND        A.ASSOBJECTID=B.MATERIALID ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public  void saveStruct(PDM_STRUCT c)
        {
            string sqlText = "INSERT  PDM_STRUCT (OBJECTID,ASSOBJECTID,ASSONUM,ASSOWEIGHT,SORTNUM,MEMO) VALUES ('" 
                            + c.OBJECTID + "','"
                            + c.ASSOBJECTID + "','"
                            + c.ASSONUM + "','"
                            + c.ASSOWEIGHT + "','"
                            + c.SORTNUM + "','"
                            + c.MEMO + "')  ";
            this.DataAccessor.Execute(sqlText);
        }

        public void delStruct(PDM_STRUCT c)
        {
            string sqlText = "DELETE  FROM  PDM_STRUCT  WHERE  OBJECTID='" + c.OBJECTID
                            + "' AND ASSOBJECTID ='" + c.ASSOBJECTID + "' ";
            this.DataAccessor.Execute(sqlText);
        }

        public DataTable getStruct(PDM_STRUCT c)
        {
            string sqlText = "SELECT * FROM  PDM_STRUCT  WHERE  OBJECTID='" + c.OBJECTID
                            + "' AND ASSOBJECTID ='" + c.ASSOBJECTID + "' ";
            DataTable dt=this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public void editStruct(PDM_STRUCT c)
        {
            string sqlText = "UPDATE  PDM_STRUCT SET  ASSONUM ='" + c.ASSONUM + "',"
                           + "ASSOWEIGHT ='" + c.ASSOWEIGHT + "',"
                           + "SORTNUM ='" + c.SORTNUM + "',"
                           + "MEMO ='" + c.MEMO + "'  "
                           + "WHERE  OBJECTID='" + c.OBJECTID +"'  "
                           + "AND ASSOBJECTID ='" + c.ASSOBJECTID + "'  ";
            this.DataAccessor.Execute(sqlText);
        }
    }
}
