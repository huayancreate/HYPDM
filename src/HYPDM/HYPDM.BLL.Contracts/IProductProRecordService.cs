using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;
namespace HYPDM.BLL
{
    public interface IProductProRecordService
    {
        IList<PDM_PRODUCT_PRORECORD> GetProductList();
        IList<PDM_PRODUCT_PRORECORD> GetProductList(Condition c);
    }
}
