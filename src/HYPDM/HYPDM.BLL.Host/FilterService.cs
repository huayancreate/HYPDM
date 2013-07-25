using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.ORM;
using EAS.Data.Access;
using EAS.Data.Linq;

namespace HYPDM.BLL
{
    [ServiceObject("连接过滤器")]
    [ServiceBind(typeof(IFilterService))]
    public class FilterService : BaseServiceObject, HYPDM.BLL.IFilterService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_FILTER().DbTableName);
        }

        #region 保存

        public void FilterSave(IList<PDM_FILTER> filterList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), filterList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_FILTER> filterList = parameters[0] as IList<PDM_FILTER>;

            foreach (PDM_FILTER filter in filterList)
            {
                filter.Save();
            }

        }
        #endregion

        /// <summary>
        /// 获取产品私有过滤器或者公共过滤器
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public IList<PDM_FILTER> getFilterList(String productID)
        {
            DataEntityQuery<PDM_FILTER> query = DataEntityQuery<PDM_FILTER>.Create();

            var p = (from item in query
                     where ((item.OWNERSHIP == "PUBLIC") || (item.PRODUCTID == productID))
                     select item
                );

            return p.ToList();
        }
    }
}
