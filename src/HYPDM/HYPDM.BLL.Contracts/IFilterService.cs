using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using System.Data;

namespace HYPDM.BLL
{
    public interface IFilterService
    {
        int GetMaxID();

        void FilterSave(IList<PDM_FILTER> filterList);

        /// <summary>
        /// 获取产品私有过滤器或者公共过滤器
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        IList<PDM_FILTER> getFilterList(String productID ,String isProduct);

        //DataTable GetDataTable(string productID);
    }
}
