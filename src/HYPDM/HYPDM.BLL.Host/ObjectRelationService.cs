using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Explorer;
using EAS.Data.Linq;
using HYPDM.Entities;
namespace HYPDM.BLL
{
    [ServiceObject("关联对象")]
    [ServiceBind(typeof(IObjectRelationService))]
    public class ObjectRelationService : BaseServiceObject, IObjectRelationService
    {
        public ObjectRelation findRelation(String masterObjID, String relationObjID)
        {
            DataEntityQuery<ObjectRelation> query = DataEntityQuery<ObjectRelation>.Create();
            var p = (from item in query where item.MASTEROBJECTID == masterObjID && item.RELATIONOBJECTID == relationObjID && item.DEL_FALG == "N" select item);
            return p.FirstOrDefault();
        }

    }
}
