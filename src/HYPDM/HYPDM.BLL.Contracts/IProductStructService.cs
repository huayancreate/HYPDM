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
        IList<PDM_PRODUCT_STRUCT> GetProStructList(String productID);
        IList<PDM_PRODUCT_STRUCT> getProStructListByPartsID(String productID, String partsID);
    }
}
