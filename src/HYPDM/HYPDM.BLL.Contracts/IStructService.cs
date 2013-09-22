using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IStructService
    {
        int GetMaxID();
        DataTable  GetProductList(PDM_ALL_PRODUCT p);
        DataTable GetPartsList(PDM_ALL_PRODUCT p);
        DataTable  GetMaterailList(PDM_MATERAIL p);
        DataTable  GetStructPartList(string p_objectId);
        DataTable  GetStructMaterailList(string p_objectId);
        string getCount(string p_productId);
        void saveStruct(PDM_STRUCT c);
        void delStruct(PDM_STRUCT c);
        void delStruct(string p_objId, string p_assoId);
        void editStruct(PDM_STRUCT c,string p_assobjId);
        void transactionExc(string p_productId,string p_sortNum);  
        DataTable getStruct(PDM_STRUCT c);
    }
}
