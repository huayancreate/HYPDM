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
        DataTable  GetProductList();
        DataTable  GetPartsList();
        DataTable  GetMaterailList();
        DataTable  GetStructPartList(string p_objectId);
        DataTable  GetStructMaterailList(string p_objectId);
        void saveStruct(PDM_STRUCT c);
        void delStruct(PDM_STRUCT c);
        void editStruct(PDM_STRUCT c);
        DataTable getStruct(PDM_STRUCT c);
    }
}
