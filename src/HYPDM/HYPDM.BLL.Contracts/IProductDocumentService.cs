using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IProductDocumentService
    {
        int GetMaxID();
        // 根据产品号获取关联的文档
        IList<PDM_PRODUCT_DOCUMENT> GetProDocList(String productID);

        void ProDocSave(List<PDM_PRODUCT_DOCUMENT> proDocList);

        // 根据文档ID查询数据
        IList<PDM_PRODUCT_DOCUMENT> getProDocByID(String proDocID);

        // 删除数据关系
        void delProDoc(IList<PDM_PRODUCT_DOCUMENT> proDocList);

        // 根据产品ID查询数据
        IList<PDM_PRODUCT_DOCUMENT> getProDocByProID(String proID);
    }
}
