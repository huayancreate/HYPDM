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
        //public ObjectRelation findRelation(String masterObjID, String relationObjID)
        //{
        //    DataEntityQuery<ObjectRelation> query = DataEntityQuery<ObjectRelation>.Create();
        //    var p = (from item in query where item.MASTEROBJECTID == masterObjID && item.RELATIONOBJECTID == relationObjID && item.DEL_FALG == "N" select item);
        //    return p.FirstOrDefault();
        //}
        public ObjectRelation getDocProdObjectRelation(string documentID, string productID)
        {
            ObjectRelation oo = null;
            DataEntityQuery<ObjectRelation> query = DataEntityQuery<ObjectRelation>.Create();

            var p = (from item in query
                     where (item.DEL_FALG == "N" && item.MASTEROBJECTID == documentID && item.MASTEROBJECTTYPE == "Document" && item.RELATIONOBJECTTYPE == "Product" && item.RELATIONOBJECTID==productID)
                     select item
                );
            IList<ObjectRelation> list= p.ToList();
            if (list.Count == 0)
            {
                oo = null;
            }
            else
            {
                oo = list[0];
            }
            return oo;
        }

        public ObjectRelation getObjectRelation(string masterObjectType, string masterObjectId, string relationObjectType, string relationObjectId)
        {
            ObjectRelation oo = null;
            DataEntityQuery<ObjectRelation> query = DataEntityQuery<ObjectRelation>.Create();

            var p = (from item in query
                     where (item.DEL_FALG == "N" && item.MASTEROBJECTID == masterObjectId && item.MASTEROBJECTTYPE == masterObjectType && item.RELATIONOBJECTTYPE == relationObjectType && item.RELATIONOBJECTID == relationObjectId)
                     select item
                );
            IList<ObjectRelation> list = p.ToList();
            if (list.Count == 0)
            {
                oo = null;
            }
            else
            {
                oo = list[0];
            }
            return oo;
        }



        public ObjectRelation getDocMaterialObjectRelation(string documentID, string materialID)
        {
            ObjectRelation oo = null;
            DataEntityQuery<ObjectRelation> query = DataEntityQuery<ObjectRelation>.Create();

            var p = (from item in query
                     where (item.DEL_FALG == "N" && item.MASTEROBJECTID == documentID && item.MASTEROBJECTTYPE == "Document" && item.RELATIONOBJECTTYPE == "Material" && item.RELATIONOBJECTID == materialID)
                     select item
                );
            IList<ObjectRelation> list = p.ToList();
            if (list.Count == 0)
            {
                oo = null;
            }
            else
            {
                oo = list[0];
            }
            return oo;
        }

    }
}
