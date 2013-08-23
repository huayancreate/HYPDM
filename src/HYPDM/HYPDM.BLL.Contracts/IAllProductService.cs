using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IAllProductService
    {
        int GetMaxID();
        DataTable  GetProductList();
        IList<PDM_ALL_PRODUCT> GetProductList2(Condition c);
        PDM_ALL_PRODUCT GetById(String p_id);
        DataTable GetProductList(PDM_ALL_PRODUCT c);
        void DelProductList(String p_id);
        void UpdateByID(PDM_ALL_PRODUCT c);
    }
}
