using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
namespace HYPDM.BLL
{
   public  interface IObjectRelationService
    {
       //ObjectRelation findRelation(String masterObjID, String relationObjID);
       ObjectRelation getDocProdObjectRelation(string documentID, string productID);
       ObjectRelation getDocMaterialObjectRelation(string documentID, string materialID);
    }
}
