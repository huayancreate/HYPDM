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

        /// <summary>
        /// 根据产品编号获取所有该产品的版本(模糊查询)
        /// </summary>
        /// <returns></returns>
        DataTable GetListByNo(string p_productNo);

        /// <summary>
        /// 根据产品编号获取所有该产品的版本（精确查询）
        /// </summary>
        /// <param name="p_productNo"></param>
        /// <returns></returns>
        DataTable GetListByNoDetail(string p_productNo);

        void DelProductList(String p_id);
        void UpdateByID(PDM_ALL_PRODUCT c);
    }
}
