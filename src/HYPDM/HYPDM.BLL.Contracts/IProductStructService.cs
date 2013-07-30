using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;

namespace HYPDM.BLL
{
    public interface IProductStructService
    {
        int GetMaxID();
        void ProStructSave(IList<PDM_PRODUCT_STRUCT> proStructList);
        IList<PDM_PRODUCT_STRUCT> GetProStructList(String productID, String isProduct);
        IList<PDM_PRODUCT_STRUCT> getProStructListByID(String proStructID);
        IList<PDM_PRODUCT_STRUCT> getListByPartsID(String productID, String partsID);
        void delProStruct(IList<PDM_PRODUCT_STRUCT> proStructList);
    }
}
