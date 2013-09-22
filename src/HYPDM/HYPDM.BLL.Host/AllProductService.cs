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
    [ServiceObject("产品管理服务")]
    [ServiceBind(typeof(IAllProductService))]
    public class AllProductService : BaseServiceObject, HYPDM.BLL.IAllProductService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_ALL_PRODUCT().DbTableName);
        }

        public DataTable GetProductList()
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL=1  AND DEL_FLAG = 'N' ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);

            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 dt.Rows[i]["CREATETIME"] = (Convert.ToDateTime(dt.Rows[i]["CREATETIME"])).ToString("yyyy-MM-dd hh:mm:ss");
                 if (Convert.ToInt16(dt.Rows[i]["PRODUCTLEVEL"]) == 1)
                 {
                     dt.Rows[i]["PRODUCTLEVEL"] = "成品";
                 }
                 else {
                     dt.Rows[i]["PRODUCTLEVEL"] = "半成品";
                 }
             }*/
            return dt;
        }

        /// <summary>
        /// 调用存储过程，用于分页查询.
        /// </summary>
        /// <param name="p_productId"></param>
        /// <param name="p_sortNum"></param>
        public DataSet GetProductByPage(int currentpage, int pagesize)
        {
            ParameterCollection pc = new ParameterCollection();
            pc.Add("sqlstr", "select * from PDM_ALL_PRODUCT  WHERE PRODUCTLEVEL=1   AND DEL_FLAG = 'N' ");
            pc.Add("currentpage", currentpage);
            pc.Add("pagesize", pagesize);
            DataSet ds = this.DataAccessor.QueryDataSet("SqlPager", CommandType.StoredProcedure, pc);
            return ds;
        }

        /// <summary>
        /// 调用存储过程，用于插入产品结构时排序的序号加1.
        /// </summary>
        /// <param name="p_productId"></param>
        /// <param name="p_sortNum"></param>
        public DataSet GetProductByPage(PDM_ALL_PRODUCT c,int currentpage, int pagesize)
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL=1   AND DEL_FLAG = 'N' ";
            if (!string.IsNullOrEmpty(c.PRODUCTNO))
            {
                sqlText += " AND PRODUCTNO LIKE '%" + c.PRODUCTNO + "%' ";
            }
            if (!string.IsNullOrEmpty(c.VERSION))
            {
                sqlText += " AND VERSION LIKE '%" + c.VERSION + "%' ";
            }

            ParameterCollection pc = new ParameterCollection();
            pc.Add("sqlstr", sqlText);
            pc.Add("currentpage", currentpage);
            pc.Add("pagesize", pagesize);
            DataSet ds = this.DataAccessor.QueryDataSet("SqlPager", CommandType.StoredProcedure, pc);
            return ds;
        }


        public IList<PDM_ALL_PRODUCT> GetProductList2(Condition c)
        {
            DataEntityQuery<PDM_ALL_PRODUCT> query = DataEntityQuery<PDM_ALL_PRODUCT>.Create();
            return query.Select(c).ToList();
        }

        public DataTable GetProductList(PDM_ALL_PRODUCT c)
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL=1   AND DEL_FLAG = 'N' ";
            if (!string.IsNullOrEmpty(c.PRODUCTNO)) {
                sqlText += " AND PRODUCTNO LIKE '%"+ c.PRODUCTNO+"%' "; 
            }
            if(!string.IsNullOrEmpty(c.VERSION)){
                sqlText += " AND VERSION LIKE '%" + c.VERSION + "%' ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }


        public PDM_ALL_PRODUCT GetById(String p_id)
        {
            PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            string sqlText = "select *  from  PDM_ALL_PRODUCT where PRODUCTID = '" + p_id + "'";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            if(dt.Rows.Count>0){
                t_product.PRODUCTID = dt.Rows[0]["PRODUCTID"].ToString();
                t_product.PRODUCTNO = dt.Rows[0]["PRODUCTNO"].ToString();
                t_product.MODELTYPE = dt.Rows[0]["MODELTYPE"].ToString();
                t_product.PRODUCTTYPE = dt.Rows[0]["PRODUCTTYPE"].ToString();
                t_product.PRODUCTLEVEL = Convert.ToInt16(dt.Rows[0]["PRODUCTLEVEL"].ToString());
                t_product.VERSION = dt.Rows[0]["VERSION"].ToString();
                t_product.STATUS = dt.Rows[0]["STATUS"].ToString();
                t_product.CREATER = dt.Rows[0]["CREATER"].ToString();
                t_product.MODIFIER = dt.Rows[0]["MODIFIER"].ToString();
                t_product.CREATETIME = dt.Rows[0]["CREATETIME"].ToString();
                t_product.MODIFYTIME = dt.Rows[0]["MODIFYTIME"].ToString();
                t_product.MEMO_ZH = dt.Rows[0]["MEMO_ZH"].ToString();
                t_product.MEMO_EN = dt.Rows[0]["MEMO_EN"].ToString();
                t_product.MEMO = dt.Rows[0]["MEMO"].ToString();
            }
            return t_product;
        }

        public void DelProductList(String p_id) {
            string sqlText = "delete  from  PDM_ALL_PRODUCT where PRODUCTID = '" + p_id+"'";
            int temp = this.DataAccessor.Execute(sqlText);
        }

        /// <summary>
        /// 根据主键删除半成品记录
        /// </summary>
        /// <param name="p_id"></param>
        public void DelProductList(String p_id, String p_user)
        {
            string sqlText = " UPDATE  PDM_ALL_PRODUCT  SET DEL_FLAG ='Y', "
                                + " MODIFIER ='" + p_user + "', "
                                + " MODIFYTIME ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'  "
                                + " WHERE PRODUCTLEVEL = 1 AND PRODUCTID = '" + p_id + "'";
            int temp = this.DataAccessor.Execute(sqlText);
        }


        public void UpdateByID(PDM_ALL_PRODUCT c){
            string sqlText = "update  PDM_ALL_PRODUCT SET  PRODUCTNO ='" +c.PRODUCTNO+"',"
                           + "MODELTYPE ='" + c.MODELTYPE + "',"
                           + "PRODUCTTYPE ='" + c.PRODUCTTYPE + "',"
                           + "MEMO_ZH ='" + c.MEMO_ZH + "',"
                           + "MEMO_EN ='" + c.MEMO_EN + "',"
                           + "MEMO ='" + c.MEMO + "',"
                           + "MODIFYTIME ='" + c.MODIFYTIME + "',"
                           + "MODIFIER ='" + c.MODIFIER + "'  "
                           + "where PRODUCTID = '" + c.PRODUCTID + "'";
            int temp = this.DataAccessor.Execute(sqlText);
        }

        /// <summary>
        /// 根据产品编号获取所有该产品的版本（模糊查询)
        /// </summary>
        /// <returns></returns>
        public DataTable GetListByNo(string p_productNo) {

            string sqlText = "SELECT  PRODUCTID,  PRODUCTNO,VERSION,MODELTYPE,PRODUCTTYPE,STATUS,MEMO_ZH  FROM PDM_ALL_PRODUCT "
                           + "WHERE  PRODUCTLEVEL=1  AND DEL_FLAG = 'N'  AND PRODUCTNO LIKE '%" + p_productNo + "%'";
            return  this.DataAccessor.QueryDataTable(sqlText);
        }

        /// <summary>
        /// 根据产品编号获取所有该产品的版本（精确查询）
        /// </summary>
        /// <returns></returns>
        public DataTable GetListByNoDetail(string p_productNo)
        {

            string sqlText = "SELECT  PRODUCTID,  PRODUCTNO,VERSION,MODELTYPE,PRODUCTTYPE,STATUS,MEMO_ZH  FROM PDM_ALL_PRODUCT "
                           + "WHERE  PRODUCTLEVEL=1   AND DEL_FLAG = 'N'  AND PRODUCTNO ='" + p_productNo + "'";
            return this.DataAccessor.QueryDataTable(sqlText);
        }


        /********************************************************/
        /****************      材料关联文档操作       *******************/
        /********************************************************/

        public DataTable GetAssoDoc(String p_ProductId, String p_version)
        {
            string sqlText = " select b.DOCID, b.DOCNO,b.VERSION,b.DOCSTATUS,b.CREATEUSER "
                                 + " from ObjectRelation a, PDM_DOCUMENT b "
                                 + " where a.MASTEROBJECTID=b.DOCID and a.DEL_FALG='N' and b.DEL_FLAG = 'N' and a.RELATIONOBJECTTYPE='Product' "
                                 + " and a.RELATIONOBJECTID='" + p_ProductId + "' "
                                 + " and a.RELATIONOBJECTVERSION='" + p_version + "' ";
            return this.DataAccessor.QueryDataTable(sqlText);
        }

        public void DelAssoDoc(String p_DocId, String p_DocVersion, String p_ProductId, String p_MaterailVersion)
        {
            string sqlText = " update ObjectRelation set DEL_FALG ='Y'  "
                                + " where MASTEROBJECTID = '" + p_DocId + "' "
                                + " and MASTEROBJECTVERSION='" + p_DocVersion + "' "
                                + " and RELATIONOBJECTID ='" + p_ProductId + "' "
                                + " and RELATIONOBJECTVERSION = '" + p_MaterailVersion + "' ";
            this.DataAccessor.Execute(sqlText);
        }

        public DataTable GetDocList(String p_ProductId, String p_version, int p_type, String p_value)
        {
            string sqlText = " select b.DOCID,b.DOCNO,b.VERSION,b.CREATEUSER,b.DESCRIPTION "
                                + " from PDM_DOCUMENT b  "
                                + " where b.DEL_FLAG = 'N'  "
                                + " and b.DOCID not in("
                                + " select a.MASTEROBJECTID from ObjectRelation a where a.DEL_FALG ='N'   and a.RELATIONOBJECTTYPE='Product'  "
                                + " and a.RELATIONOBJECTID ='" + p_ProductId + "'  "
                                + " and a.RELATIONOBJECTVERSION ='" + p_version + "'  "
                                 + " )  ";
            if (p_type == 1)
            {
                sqlText += " and  b.DOCNO LIKE '%" + p_value + "%'  ";
            }
            if (p_type == 2)
            {
                sqlText += "  and b.DESCRIPTION LIKE '%" + p_value + "%'";
            }
            return this.DataAccessor.QueryDataTable(sqlText);
        }
    }
}
