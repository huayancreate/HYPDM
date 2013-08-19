using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Access;
using EAS.Data.Linq;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("产品管理服务")]
    [ServiceBind(typeof(IProductService))]
    public class ProductService : BaseServiceObject, HYPDM.BLL.IProductService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PRODUCT().DbTableName);
        }

        public IList<PDM_PRODUCT> GetProductList()
        {
            DataEntityQuery<PDM_PRODUCT> query = DataEntityQuery<PDM_PRODUCT>.Create();

            var p = (from item in query
                     orderby item.PRODUCTID ascending
                     select item
                );

            return p.ToList();
        }
        public IList<PDM_PRODUCT> GetProductList(Condition c) {
            DataEntityQuery<PDM_PRODUCT> query = DataEntityQuery<PDM_PRODUCT>.Create();
            return query.Select(c).ToList();
        }
    }
}
