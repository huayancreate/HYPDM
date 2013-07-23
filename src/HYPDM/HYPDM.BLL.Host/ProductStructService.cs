using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Access;
using EAS.Data.ORM;
using EAS.Data.Linq;

namespace HYPDM.BLL
{
    [ServiceObject("产品管理服务")]
    [ServiceBind(typeof(IProductStructService))]
    public class ProductStructService : BaseServiceObject, HYPDM.BLL.IProductStructService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PRODUCT_STRUCT().DbTableName);
        }

        public void ProStructSave(IList<PDM_PRODUCT_STRUCT> proStructList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), proStructList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PRODUCT_STRUCT> proStructList = parameters[0] as List<PDM_PRODUCT_STRUCT>;

            foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
            {
                proStruct.Save();
            }
        }

        /// <summary>
        /// 根据产品ID获取产品结构
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public IList<PDM_PRODUCT_STRUCT> GetProStructList(String productID)
        {
            DataEntityQuery<PDM_PRODUCT_STRUCT> query = DataEntityQuery<PDM_PRODUCT_STRUCT>.Create();

            var p = (from item in query
                     where (item.PRODUCTID == productID)
                     select item
                );

            return p.ToList();
        }

        public IList<PDM_PRODUCT_STRUCT> getProStructListByID(String proStructID)
        {
            DataEntityQuery<PDM_PRODUCT_STRUCT> query = DataEntityQuery<PDM_PRODUCT_STRUCT>.Create();

            var p = (from item in query
                     where (item.ID == proStructID)
                     select item
                );

            return p.ToList();
        }

        public IList<PDM_PRODUCT_STRUCT> getListByPartsID(String productID, String partsID)
        {
            DataEntityQuery<PDM_PRODUCT_STRUCT> query = DataEntityQuery<PDM_PRODUCT_STRUCT>.Create();

            var p = (from item in query
                     where (item.PRODUCTID == productID) && (item.PARTSID == partsID)
                     select item
                );

            return p.ToList();
        }

        #region 删除

        public void delProStruct(IList<PDM_PRODUCT_STRUCT> proStructList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), proStructList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PRODUCT_STRUCT> proStructList = parameters[0] as IList<PDM_PRODUCT_STRUCT>;

            foreach (PDM_PRODUCT_STRUCT proStruct in proStructList)
            {
                proStruct.Delete();
            }
        }
        #endregion
    }
}
