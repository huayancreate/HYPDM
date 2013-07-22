using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Linq;
using EAS.Data.Access;
using EAS.Data.ORM;

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

        public IList<PDM_PARTS> GetPartsList()
        {
            DataEntityQuery<PDM_PARTS> query = DataEntityQuery<PDM_PARTS>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     select item
                );

            return p.ToList();
        }

        public IList<PDM_PARTS> GetListByPartsClass(String classfication)
        {
            DataEntityQuery<PDM_PARTS> query = DataEntityQuery<PDM_PARTS>.Create();

            var p = (from item in query
                     where (item.PARTSCLASSFICATION == classfication)
                     select item
                );

            return p.ToList();
        }

        #region 删除

        public void DelParts(IList<PDM_PARTS> partsList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), partsList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_PARTS> partsList = parameters[0] as IList<PDM_PARTS>;

            foreach (PDM_PARTS parts in partsList)
            {
                parts.Delete();
            }
        }
        #endregion

        public IList<PDM_PARTS> GetPartsListByID(String partsID)
        {
            DataEntityQuery<PDM_PARTS> query = DataEntityQuery<PDM_PARTS>.Create();

            var p = (from item in query
                     where (item.PARTSID == partsID)
                     orderby item.CREATEDATE ascending
                     select item
                );

            return p.ToList();
        }

        public IList<PDM_PARTS> GetPartsByQuery(String queryCondition)
        {
            DataEntityQuery<PDM_PARTS> query = DataEntityQuery<PDM_PARTS>.Create();
            var  p = (from item in query
                      where item.PARTSNO.Contains(queryCondition)
                      orderby item.CREATEDATE ascending
                      select item
                 );

            return p.ToList();
        }
    }
}
