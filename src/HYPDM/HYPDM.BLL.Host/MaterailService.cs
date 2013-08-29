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

        public DataTable GetMaterailList()
        {
            string sqlText = "Select * from  PDM_MATERAIL ";
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
    }
}
