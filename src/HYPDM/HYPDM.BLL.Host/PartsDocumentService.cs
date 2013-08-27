using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.ORM;
using EAS.Data.Linq;
using EAS.Data.Access;

namespace HYPDM.BLL
{
    [ServiceObject("半成品文档关联服务管理")]
    [ServiceBind(typeof(IPartsDocumentService))]
    public class PartsDocumentService : BaseServiceObject, HYPDM.BLL.IPartsDocumentService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PRODUCT_DOCUMENT().DbTableName);
        }

        public IList<PDM_PARTS_DOCUMENT> GetPartsDocList(string partsID)
        {
            DataEntityQuery<PDM_PARTS_DOCUMENT> query = DataEntityQuery<PDM_PARTS_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.PARTSID == partsID)
                     select item
                );

            return p.ToList();
        }

        public IList<PDM_PARTS_DOCUMENT> GetPartsDocByDocID(string docID)
        {
            DataEntityQuery<PDM_PARTS_DOCUMENT> query = DataEntityQuery<PDM_PARTS_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.DOCID == docID)
                     select item
                );

            return p.ToList();
        }

        #region 保存数据

        public void PartsDocSave(IList<PDM_PARTS_DOCUMENT> partsDocList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), partsDocList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PARTS_DOCUMENT> partsDocList = parameters[0] as List<PDM_PARTS_DOCUMENT>;

            string connString = "Data Source=192.168.0.8;Initial Catalog=drugshop;Integrated Security=False;User ID=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = null;
            conn.Open();

            foreach (PDM_PARTS_DOCUMENT partsDoc in partsDocList)
            {
                string insertSql = "INSERT INTO PDM_PARTS_DOCUMENT VALUES('" + partsDoc.ID + "', '" + partsDoc.PARTSID + "', '" + partsDoc.DOCID + "')";
                cmd = new SqlCommand(insertSql, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        #endregion

        #region 删除数据

        public void DelPartsDoc(IList<PDM_PARTS_DOCUMENT> partsDocList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), partsDocList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PARTS_DOCUMENT> partsDocList = parameters[0] as IList<PDM_PARTS_DOCUMENT>;

            foreach (PDM_PARTS_DOCUMENT partsDoc in partsDocList)
            {
                partsDoc.Delete();
            }
        }
        #endregion
    }
}
