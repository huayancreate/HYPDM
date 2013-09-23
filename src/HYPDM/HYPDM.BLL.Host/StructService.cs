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
            return new MaxCodeService().GetMaxCode(new PDM_ALL_PRODUCT().DbTableName);
        }
        /// <summary>
        /// 获取符合条件的产品的列表
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataTable GetProductList(PDM_ALL_PRODUCT p)
        {
            string sqlText = "Select PRODUCTID,PRODUCTNO,MODELTYPE,PRODUCTTYPE from  PDM_ALL_PRODUCT WHERE  DEL_FLAG='N' AND PRODUCTLEVEL =1 ";
            if (!string.IsNullOrEmpty(p.PRODUCTNO)) {
                sqlText += "AND PRODUCTNO like '%" + p.PRODUCTNO + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MODELTYPE))
            {
                sqlText += "AND MODELTYPE  like '%" + p.MODELTYPE + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.VERSION))
            {
                sqlText += "AND VERSION like '%" + p.VERSION + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MEMO))
            {
                sqlText += "AND MEMO like '%" + p.MEMO + "%'  ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 获取符合条件的产成品的列表
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataTable GetPartsList(PDM_ALL_PRODUCT p)
        {
            string sqlText = "Select PRODUCTID,PRODUCTNO,MODELTYPE,PRODUCTTYPE from  PDM_ALL_PRODUCT  WHERE  DEL_FLAG='N'  AND  PRODUCTLEVEL =2  ";
            if (!string.IsNullOrEmpty(p.PRODUCTNO))
            {
                sqlText += "AND PRODUCTNO like '%" + p.PRODUCTNO + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MODELTYPE))
            {
                sqlText += "AND MODELTYPE like '%" + p.MODELTYPE + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.VERSION))
            {
                sqlText += "AND VERSION like '%" + p.VERSION + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MEMO))
            {
                sqlText += "AND MEMO like '%" + p.MEMO + "%'  ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 获取符合条件的材料的列表
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataTable GetMaterailList(PDM_MATERAIL p)
        {
            string sqlText = "Select MATERIALID,MATERIALNO,MODELTYPE,MATERIALTYPE from  PDM_MATERAIL WHERE  DEL_FLAG='N' ";

            if (!string.IsNullOrEmpty(p.MATERIALNO))
            {
                sqlText += "AND MATERIALNO like '%" + p.MATERIALNO + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MODELTYPE))
            {
                sqlText += "AND MODELTYPE like '%" + p.MODELTYPE + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.VERSION))
            {
                sqlText += "AND VERSION  like '%" + p.VERSION + "%'  ";
            }
            if (!string.IsNullOrEmpty(p.MEMO))
            {
                sqlText += "AND MEMO like '%" + p.MEMO + "%'  ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        /// <summary>
        /// 获取产品结构树的数据
        /// </summary>
        /// <param name="p_objectId"></param>
        /// <returns></returns>
        public DataTable GetStructPartList(string p_objectId)
        {
            string sqlText = "SELECT     A.ASSOBJECTID,A.ASSONUM, A.SORTNUM, A.MEMO,B.PRODUCTNO,B.VERSION,B.MODELTYPE  " +
                             "FROM       PDM_STRUCT A,PDM_ALL_PRODUCT B  "+
                             "Where       A.DEL_FLAG='N' AND A.OBJECTID = '" + p_objectId + "'  " +
                             "AND        A.ASSOBJECTID=B.PRODUCTID ORDER BY Convert (int,A.SORTNUM) ASC";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        /// <summary>
        /// 获取产品机构树中材料的数据
        /// </summary>
        /// <param name="p_objectId"></param>
        /// <returns></returns>
        public DataTable GetStructMaterailList(string p_objectId) {
            string sqlText = "SELECT     A.ASSOBJECTID,A.ASSONUM, A.SORTNUM, A.MEMO,B.MATERIALNO,B.VERSION,B.MODELTYPE  " +
                             "FROM       PDM_STRUCT A,PDM_MATERAIL B  " +
                             "Where     A.DEL_FLAG='N' AND    A.OBJECTID = '" + p_objectId + "'  " +
                             "AND        A.ASSOBJECTID=B.MATERIALID  ORDER BY Convert (int,A.SORTNUM) ASC";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 保存产品结构的一条记录
        /// </summary>
        /// <param name="c"></param>
        public  void saveStruct(PDM_STRUCT c)
        {
            string sqlText = "INSERT  PDM_STRUCT (OBJECTID,ASSOBJECTID,ASSONUM,ASSOWEIGHT,SORTNUM,MEMO,DEL_FLAG) VALUES ('" 
                            + c.OBJECTID + "','"
                            + c.ASSOBJECTID + "','"
                            + c.ASSONUM + "','"
                            + c.ASSOWEIGHT + "','"
                            + c.SORTNUM + "','"
                            + c.MEMO + "','N')  ";
            this.DataAccessor.Execute(sqlText);
        }
        /// <summary>
        /// 删除产品结构的一条记录
        /// </summary>
        /// <param name="c"></param>
        public void delStruct(PDM_STRUCT c)
        {
            string sqlText = "DELETE  FROM  PDM_STRUCT  WHERE  OBJECTID='" + c.OBJECTID
                            + "' AND ASSOBJECTID ='" + c.ASSOBJECTID + "' ";
            this.DataAccessor.Execute(sqlText);
        }
        public void delStruct(string p_objId,string p_assoId)
        {
            string sqlText = "UPDATE PDM_STRUCT SET DEL_FLAG='Y'  WHERE  OBJECTID='" + p_objId
                            + "' AND ASSOBJECTID ='" + p_assoId + "' ";
            this.DataAccessor.Execute(sqlText);
        }
        /// <summary>
        /// 获取一条记录（产品，半成品，材料）之间的关联关系
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public DataTable getStruct(PDM_STRUCT c)
        {
            string sqlText = "SELECT * FROM  PDM_STRUCT  WHERE  DEL_FLAG='N' AND  OBJECTID='" + c.OBJECTID
                            + "' AND ASSOBJECTID ='" + c.ASSOBJECTID + "' ";
            DataTable dt=this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        /// <summary>
        /// 编辑产品结构的一条记录
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p_assobjId"></param>
        public void editStruct(PDM_STRUCT c,string p_assobjId)
        {
            string m_assobjId = "";
            if (p_assobjId == "")
            {
                m_assobjId = c.ASSOBJECTID;
            }
            else {
                m_assobjId = p_assobjId;
            }
            string sqlText = "UPDATE  PDM_STRUCT SET  ASSOBJECTID ='" + c.ASSOBJECTID + "',"
                           + "ASSONUM ='" + c.ASSONUM + "',"
                           + "ASSOWEIGHT ='" + c.ASSOWEIGHT + "',"
                           + "SORTNUM ='" + c.SORTNUM + "',"
                           + "MEMO ='" + c.MEMO + "'  "
                           + "WHERE  OBJECTID='" + c.OBJECTID +"'  "
                           + "AND ASSOBJECTID ='" + m_assobjId + "'  ";
            this.DataAccessor.Execute(sqlText);
        }

       /// <summary>
       ///获取结构的数量，用于增加时排序
       /// </summary>
       /// <param name="p_productId"></param>
       /// <returns></returns>
        public string  getCount(string p_productId) {
            string sqlText = " Select Count(*)+1 as MAXSORTNUM from PDM_STRUCT where DEL_FLAG='N' AND  OBJECTID='" + p_productId + "'";
            DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
           return  dt.Rows[0]["MAXSORTNUM"].ToString();
        }
        /// <summary>
        /// 调用存储过程，用于插入产品结构时排序的序号加1.
        /// </summary>
        /// <param name="p_productId"></param>
        /// <param name="p_sortNum"></param>
        public  void transactionExc(string p_productId, string p_sortNum) {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ObjectID", p_productId);
            pc.Add("SortNum", p_sortNum);
            try
            {
                this.DataAccessor.Query("exec StructAddSortNum @ObjectID=?,@SortNum=?", pc);
            }
            catch
            {
                throw new System.Exception("读取最大ID时发生错误，错误可能是由于在最大号存储表中没有指定的ItemKey:" + p_productId + "，请参考错误信息修改此问题");
            }
        }
    }
}
