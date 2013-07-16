using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.ORM;
using EAS.Data.Linq;
using EAS.Data.Access;

namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IProductDocumentService))]
    public class ProductDocumentService : BaseServiceObject, HYPDM.BLL.IProductDocumentService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PRODUCT_DOCUMENT().DbTableName);
        }

        public IList<PDM_PRODUCT_DOCUMENT> GetProDocList(String productID)
        {
            DataEntityQuery<PDM_PRODUCT_DOCUMENT> query = DataEntityQuery<PDM_PRODUCT_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.PRODUCTID == productID)
                     select item
                );

            return p.ToList();
        }

        #region 保存

        public void ProDocSave(List<PDM_PRODUCT_DOCUMENT> proDocList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), proDocList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PRODUCT_DOCUMENT> proDocList = parameters[0] as List<PDM_PRODUCT_DOCUMENT>;

            foreach (PDM_PRODUCT_DOCUMENT proDoc in proDocList)
            {
                proDoc.Save();
            }
        }
        #endregion

        public IList<PDM_PRODUCT_DOCUMENT> getProdocByDocID(String docID)
        {
                        DataEntityQuery<PDM_PRODUCT_DOCUMENT> query = DataEntityQuery<PDM_PRODUCT_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.DOCUMENTID == docID)
                     select item
                );

            return p.ToList();
        }

        #region 删除

        public void delProDoc(IList<PDM_PRODUCT_DOCUMENT> proDocList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), proDocList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PRODUCT_DOCUMENT> proDocList = parameters[0] as IList<PDM_PRODUCT_DOCUMENT>;

            foreach (PDM_PRODUCT_DOCUMENT proDoc in proDocList)
            {
                proDoc.Delete();
            }
        }
        #endregion

        public IList<PDM_PRODUCT_DOCUMENT> getProdocByProID(String proID)
        {
            DataEntityQuery<PDM_PRODUCT_DOCUMENT> query = DataEntityQuery<PDM_PRODUCT_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.PRODUCTID == proID)
                     select item
                );

            return p.ToList();
        }
    }
}
