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
    }
}
