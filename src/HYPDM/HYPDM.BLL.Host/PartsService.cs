using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Linq;
using EAS.Data.Access;

namespace HYPDM.BLL
{
    [ServiceObject("产品管理服务")]
    [ServiceBind(typeof(IPartsService))]
    public class PartsService : BaseServiceObject, HYPDM.BLL.IPartsService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PARTS().DbTableName);
        }

        public IList<PDM_PARTS> getListByPartsClass(String classfication)
        {
            DataEntityQuery<PDM_PARTS> query = DataEntityQuery<PDM_PARTS>.Create();

            var p = (from item in query
                     where (item.PARTSCLASSFICATION == classfication)
                     select item
                );

            return p.ToList();
        }

        #region 删除

        public void delProDoc(IList<PDM_PARTS> proDocList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), proDocList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PARTS> partsList = parameters[0] as IList<PDM_PARTS>;

            foreach (PDM_PARTS parts in partsList)
            {
                
            }
        }
        #endregion
    }
}
