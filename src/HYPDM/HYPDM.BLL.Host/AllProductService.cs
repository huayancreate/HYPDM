﻿using System;
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
            string sqlText = "Select * from  PDM_ALL_PRODUCT ";
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
        public IList<PDM_ALL_PRODUCT> GetProductList2(Condition c)
        {
            DataEntityQuery<PDM_ALL_PRODUCT> query = DataEntityQuery<PDM_ALL_PRODUCT>.Create();
            return query.Select(c).ToList();
        }

        public DataTable GetProductList(PDM_ALL_PRODUCT c)
        {
            string sqlText = "Select * from  PDM_ALL_PRODUCT where 1=1  ";
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