using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Access;
using EAS.Data.ORM;

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
    }
}
