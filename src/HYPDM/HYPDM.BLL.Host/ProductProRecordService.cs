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
    [ServiceObject("产品生产记录管理服务")]
    [ServiceBind(typeof(IProductProRecordService))]
    public class ProductProRecordService : BaseServiceObject, HYPDM.BLL.IProductProRecordService
    {
        public IList<PDM_PRODUCT_PRORECORD> GetProductList()
        {
            DataEntityQuery<PDM_PRODUCT_PRORECORD> query = DataEntityQuery<PDM_PRODUCT_PRORECORD>.Create();

            var p = (from item in query
                     orderby item.PRORECORDID ascending
                     select item
                );

            return p.ToList();
        }
        public IList<PDM_PRODUCT_PRORECORD> GetProductList(Condition c)
        {
            DataEntityQuery<PDM_PRODUCT_PRORECORD> query = DataEntityQuery<PDM_PRODUCT_PRORECORD>.Create();
            return query.Select(c).ToList();
        }
    }
}
