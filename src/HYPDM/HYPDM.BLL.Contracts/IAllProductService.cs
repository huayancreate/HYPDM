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

        //*****************************************************************//
        //*********************       成品操作         ********************//
        //*****************************************************************//
        int GetMaxID();
        /// <summary>
        /// 分页查询记录
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        DataSet GetProductByPage(int currentpage, int pagesize);

        /// <summary>
        /// 根据条件分页查询记录
        /// </summary>
        /// <param name="c"></param>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        DataSet GetProductByPage(PDM_ALL_PRODUCT c, int currentpage, int pagesize);

        DataTable  GetProductList();
        IList<PDM_ALL_PRODUCT> GetProductList2(Condition c);
        PDM_ALL_PRODUCT GetById(String p_id);

        DataTable GetProductList(PDM_ALL_PRODUCT c);
        DataTable GetProductList(PDM_ALL_PRODUCT c, String p_partSql);
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
        void DelProductList(String p_id, String p_user);

        void UpdateByID(PDM_ALL_PRODUCT c);

        /********************************************************/
        /****************      材料关联文档操作       *******************/
        /********************************************************/
        DataTable GetAssoDoc(String p_ProductId, String p_version);
        DataTable GetDocList(String p_ProductId, String p_version, int p_type, String p_value);
        void DelAssoDoc(String p_DocId, String p_DocVersion, String p_ProductId, String p_MaterailVersion);

        /********************************************************/
        /****************     复制产品结构操作       *******************/
        /********************************************************/
        void CopyAllAsso(PDM_ALL_PRODUCT p_OldProduct, PDM_ALL_PRODUCT p_NewProduct);
    }
}
