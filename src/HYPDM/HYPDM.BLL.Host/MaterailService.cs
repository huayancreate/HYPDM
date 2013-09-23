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
    [ServiceBind(typeof(IMaterailService))]
    public class MaterailService : BaseServiceObject, HYPDM.BLL.IMaterailService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_ALL_PRODUCT().DbTableName);
        }


        /// <summary>
        /// 根据条件分页查询记录
        /// </summary>
        /// <param name="c"></param>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public  DataSet GetProductByPage(PDM_MATERAIL c, int currentpage, int pagesize) {
            string sqlText = "Select * from  PDM_MATERAIL where 1=1  ";
            if (!string.IsNullOrEmpty(c.MATERIALNO))
            {
                sqlText += " AND MATERIALNO LIKE '%" + c.MATERIALNO + "%' ";
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


        public DataTable GetMaterailList()
        {
            string sqlText = "Select * from  PDM_MATERAIL WHERE DEL_FLAG ='N' ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }
        public IList<PDM_MATERAIL> GetMaterailList2(Condition c)
        {
            DataEntityQuery<PDM_MATERAIL> query = DataEntityQuery<PDM_MATERAIL>.Create();
            return query.Select(c).ToList();
        }

        public DataTable GetMaterailList(PDM_MATERAIL c)
        {
            string sqlText = "Select * from  PDM_MATERAIL where 1=1  ";
            if (!string.IsNullOrEmpty(c.MATERIALNO)) {
                sqlText += " AND MATERIALNO LIKE '%" + c.MATERIALNO + "%' "; 
            }
            if(!string.IsNullOrEmpty(c.VERSION)){
                sqlText += " AND VERSION LIKE '%" + c.VERSION + "%' ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 根据ID获取一条记录
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public PDM_MATERAIL GetById(String p_id)
        {
            //PDM_MATERAIL t_product = new PDM_MATERAIL();
            //string sqlText = "select *  from  PDM_MATERAIL where MATERIALID = '" + p_id + "'";
            //System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            //if(dt.Rows.Count>0){
            //    t_product.MATERIALID = dt.Rows[0]["MATERIALID"].ToString();
            //    t_product.MATERIALNO = dt.Rows[0]["MATERIALNO"].ToString();
            //    t_product.MODELTYPE = dt.Rows[0]["MODELTYPE"].ToString();
            //    t_product.MATERIALTYPE = dt.Rows[0]["MATERIALTYPE"].ToString();
            //    t_product.RAWMATERIAL = dt.Rows[0]["RAWMATERIAL"].ToString();
            //    t_product.MATERIALSRC = dt.Rows[0]["MATERIALSRC"].ToString();
            //    t_product.VERSION = dt.Rows[0]["VERSION"].ToString();
            //    t_product.CREATER = dt.Rows[0]["CREATER"].ToString();
            //    t_product.MODIFIER = dt.Rows[0]["MODIFIER"].ToString();
            //    t_product.CTREATETIME = dt.Rows[0]["CTREATETIME"].ToString();
            //    t_product.MODIFYTIME = dt.Rows[0]["MODIFYTIME"].ToString();
            //    t_product.MEMO_ZH = dt.Rows[0]["MEMO_ZH"].ToString();
            //    t_product.MEMO_EN = dt.Rows[0]["MEMO_EN"].ToString();
            //    t_product.MEMO = dt.Rows[0]["MEMO"].ToString();
            //}

            DataEntityQuery<PDM_MATERAIL> query = DataEntityQuery<PDM_MATERAIL>.Create();

            var p = (from item in query
                     where item.MATERIALID==p_id
                     select item
                );
            IList<PDM_MATERAIL> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return new PDM_MATERAIL();
            }
            else
            {
                return p.ToList()[0];
            }
        }

        public void DelMaterailList(String p_id)
        {
            string sqlText = "delete  from  PDM_MATERAIL where MATERIALID = '" + p_id + "'";
            int temp = this.DataAccessor.Execute(sqlText);
        }


        public void DelMaterailList(String p_id, String p_user)
        {
            string sqlText = " UPDATE  PDM_MATERAIL  SET DEL_FLAG ='Y', "
                                + " MODIFIER ='" + p_user + "', "
                                + " MODIFYTIME ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'  "
                                + " WHERE MATERIALID = '" + p_id + "'";
            int temp = this.DataAccessor.Execute(sqlText);
        }

        /// <summary>
        /// 根据材料实体类更新一条记录
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public void UpdateByID(PDM_MATERAIL c)
        {
            string sqlText = "update  PDM_MATERAIL SET  MATERIALNO ='" + c.MATERIALNO + "',"
                           + "MODELTYPE ='" + c.MODELTYPE + "',"
                           + "MATERIALTYPE ='" + c.MATERIALTYPE + "',"
                           + "MEMO_ZH ='" + c.MEMO_ZH + "',"
                           + "RAWMATERIAL ='" + c.RAWMATERIAL + "',"
                           + "MATERIALSRC ='" + c.MATERIALSRC + "',"
                           + "MEMO_EN ='" + c.MEMO_EN + "',"
                           + "MEMO ='" + c.MEMO + "',"
                           + "MODIFYTIME ='" + c.MODIFYTIME + "',"
                           + "MODIFIER ='" + c.MODIFIER + "'  "
                           + "where MATERIALID = '" + c.MATERIALID + "'";
            int temp = this.DataAccessor.Execute(sqlText);
        }

        /// <summary>
        /// 根据编号查询一组数据
        /// </summary>
        /// <param name="p_productNo"></param>
        /// <returns></returns>
        public DataTable GetListByNoDetail(string p_productNo) {
            string sqlText = "SELECT  MATERIALID,  MATERIALNO,VERSION,MODELTYPE,MATERIALTYPE,MEMO_ZH  FROM PDM_MATERAIL "
                               + "WHERE  MATERIALNO ='" + p_productNo + "'";
            return this.DataAccessor.QueryDataTable(sqlText);
        }

        /********************************************************/
        /****************      材料关联文档操作       *******************/
        /********************************************************/

        public DataTable GetAssoDoc(String p_MaterailId,String p_version) {
            string sqlText = " select b.DOCID, b.DOCNO,b.VERSION,b.DOCSTATUS,b.CREATEUSER "
                                 + " from ObjectRelation a, PDM_DOCUMENT b "
                                 + " where a.MASTEROBJECTID=b.DOCID and a.DEL_FALG='N' and b.DEL_FLAG = 'N' and a.RELATIONOBJECTTYPE='Material' "
                                 + " and a.RELATIONOBJECTID='"+p_MaterailId+"' "
                                 + " and a.RELATIONOBJECTVERSION='" + p_version + "' ";
            return this.DataAccessor.QueryDataTable(sqlText);
        }

        public void DelAssoDoc(String p_DocId,String p_DocVersion,String p_MaterailId,String p_MaterailVersion) {     
            string sqlText = " update ObjectRelation set DEL_FALG ='Y'  "
                                + " where MASTEROBJECTID = '" + p_DocId + "' "
                                + " and MASTEROBJECTVERSION='" + p_DocVersion + "' "
                                + " and RELATIONOBJECTID ='"+p_MaterailId+"' "
                                + " and RELATIONOBJECTVERSION = '" + p_MaterailVersion + "' ";
            this.DataAccessor.Execute(sqlText);
        }

        public DataTable GetDocList(String p_MaterailId,String p_version ,int p_type,String p_value ) {
            string sqlText = " select b.DOCID,b.DOCNO,b.VERSION,b.CREATEUSER,b.DESCRIPTION "
                                + " from PDM_DOCUMENT b  "
                                + " where b.DEL_FLAG = 'N'  "
                                + " and b.DOCID not in("
                                + " select a.MASTEROBJECTID from ObjectRelation a where a.DEL_FALG ='N'   and a.RELATIONOBJECTTYPE='Material'  "
	                            + " and a.RELATIONOBJECTID ='"+p_MaterailId+"'  "
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
