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
    [ServiceObject("半成品管理服务")]
    [ServiceBind(typeof(IAllPartsService))]
    public class AllPartsService : BaseServiceObject, HYPDM.BLL.IAllPartsService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_ALL_PRODUCT().DbTableName);
        }

        /// <summary>
        /// 获取所有半成品记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetProductList()
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL=2";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 更加对象查询半成品记录
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public DataTable GetProductList(PDM_ALL_PRODUCT c)
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT WHERE PRODUCTLEVEL=2  ";
            if (!string.IsNullOrEmpty(c.PRODUCTNO))
            {
                sqlText += " AND PRODUCTNO LIKE '%" + c.PRODUCTNO + "%' ";
            }
            if (!string.IsNullOrEmpty(c.VERSION))
            {
                sqlText += " AND VERSION LIKE '%" + c.VERSION + "%' ";
            }
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        /// <summary>
        /// 查询符合条件的半成品记录
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IList<PDM_ALL_PRODUCT> GetProductList2(Condition c)
        {
            DataEntityQuery<PDM_ALL_PRODUCT> query = DataEntityQuery<PDM_ALL_PRODUCT>.Create();
            return query.Select(c).ToList();
        }

        /// <summary>
        /// 根据主键查询半成品记录
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public PDM_ALL_PRODUCT GetById(String p_id)
        {
            //PDM_ALL_PRODUCT t_product = new PDM_ALL_PRODUCT();
            //string sqlText = "select *  from  PDM_ALL_PRODUCT where PRODUCTID = '" + p_id + "'";
            //System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            //if (dt.Rows.Count > 0)
            //{
            //    t_product.PRODUCTID = dt.Rows[0]["PRODUCTID"].ToString();
            //    t_product.PRODUCTNO = dt.Rows[0]["PRODUCTNO"].ToString();
            //    t_product.MODELTYPE = dt.Rows[0]["MODELTYPE"].ToString();
            //    t_product.PRODUCTTYPE = dt.Rows[0]["PRODUCTTYPE"].ToString();
            //    t_product.PRODUCTLEVEL = Convert.ToInt16(dt.Rows[0]["PRODUCTLEVEL"].ToString());
            //    t_product.VERSION = dt.Rows[0]["VERSION"].ToString();
            //    t_product.STATUS = dt.Rows[0]["STATUS"].ToString();
            //    t_product.CREATER = dt.Rows[0]["CREATER"].ToString();
            //    t_product.MODIFIER = dt.Rows[0]["MODIFIER"].ToString();
            //    t_product.CREATETIME = dt.Rows[0]["CREATETIME"].ToString();
            //    t_product.MODIFYTIME = dt.Rows[0]["MODIFYTIME"].ToString();
            //    t_product.MEMO_ZH = dt.Rows[0]["MEMO_ZH"].ToString();
            //    t_product.MEMO_EN = dt.Rows[0]["MEMO_EN"].ToString();
            //    t_product.MEMO = dt.Rows[0]["MEMO"].ToString();
            //}
            //return t_product;
            DataEntityQuery<PDM_ALL_PRODUCT> query = DataEntityQuery<PDM_ALL_PRODUCT>.Create();

            var p = (from item in query
                     where item.PRODUCTID == p_id
                     select item
                );
            IList<PDM_ALL_PRODUCT> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return new PDM_ALL_PRODUCT();
            }
            else
            {
                return p.ToList()[0];
            }
            
        }

        /// <summary>
        /// 根据半成品编号获取所有该半成品的版本(模糊查询)
        /// </summary>
        /// <returns></returns>
        public DataTable GetListByNo(string p_productNo)
        {

            string sqlText = "SELECT  PRODUCTID,  PRODUCTNO,VERSION,MODELTYPE,PRODUCTTYPE,STATUS,MEMO_ZH  FROM PDM_ALL_PRODUCT "
                           + "WHERE  PRODUCTLEVEL=2 AND PRODUCTNO LIKE '%" + p_productNo + "%'";
            return this.DataAccessor.QueryDataTable(sqlText);
        }


        /// <summary>
        /// 根据半成品编号获取所有该半成品的版本（精确查询）
        /// </summary>
        /// <param name="p_productNo"></param>
        /// <returns></returns>
        public DataTable GetListByNoDetail(string p_productNo)
        {

            string sqlText = "SELECT  PRODUCTID,  PRODUCTNO,VERSION,MODELTYPE,PRODUCTTYPE,STATUS,MEMO_ZH  FROM PDM_ALL_PRODUCT "
                           + "WHERE  PRODUCTLEVEL=2 AND PRODUCTNO ='" + p_productNo + "'";
            return this.DataAccessor.QueryDataTable(sqlText);
        }


        /// <summary>
        /// 根据主键删除半成品记录
        /// </summary>
        /// <param name="p_id"></param>
        public void DelProductList(String p_id) {
            string sqlText = "delete  from  PDM_ALL_PRODUCT where PRODUCTID = '" + p_id+"'";
            int temp = this.DataAccessor.Execute(sqlText);
        }


        /// <summary>
        /// 根据半成品对象更新记录
        /// </summary>
        /// <param name="c"></param>
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
        
    }
}
