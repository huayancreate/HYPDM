using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IProductService
    {
        int GetMaxID();
        IList<PDM_PRODUCT> GetProductList();
    }
}
