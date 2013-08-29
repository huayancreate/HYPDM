using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("工程变更服务")]
    [ServiceBind(typeof(IPjtChangeService))]
    public class PjtChangeService : BaseServiceObject, HYPDM.BLL.IPjtChangeService
    {
        public DataTable GetList() {
            string sqlText = "Select * from  PDM_PJTCHANGE ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public DataTable GetAssoList(String p_productId)
        {
            string sqlText = "Select A.* from  PDM_PJTCHANGE A,PDM_PRODUCT_CHANGE B where A.PJTCHANGENO=B.PJTCHANGENO and B.PRODUCTNO  = '" + p_productId+"'";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public DataTable GetList(String p_pjtChangeNo)
        {
            string sqlText = "Select A.* from  PDM_PJTCHANGE A where A.PJTCHANGENO like %" + p_pjtChangeNo+"%";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }

        public IList<PDM_PJTCHANGE> GetList(Condition c)
        {
            DataEntityQuery<PDM_PJTCHANGE> query = DataEntityQuery<PDM_PJTCHANGE>.Create();
            return query.Select(c).ToList();
        }

        public void updateAsso(int asso,string p_changeNo) {
            string sqlText = "UPDATE    PDM_PJTCHANGE SET  IFASSO = " + asso + "where PJTCHANGENO = " + p_changeNo;
            this.DataAccessor.Execute(sqlText);
        }

        public void insertAsso(string p_changeNo, String p_productId) {
            deleteAsso(p_changeNo, p_productId);
            string sqlText = "INSERT INTO PDM_PRODUCT_CHANGE  (PRODUCTNO, PJTCHANGENO) VALUES ('" + p_productId + "','" + p_changeNo + "')";
            this.DataAccessor.Execute(sqlText);
        }

        public void deleteAsso(string p_changeNo, String p_productId)
        {
            string sqlText = "DELETE   from PDM_PRODUCT_CHANGE   WHERE  PRODUCTNO = '" + p_productId + "' AND  PJTCHANGENO = '" + p_changeNo + "'";
            this.DataAccessor.Execute(sqlText);
        }
    }
}
