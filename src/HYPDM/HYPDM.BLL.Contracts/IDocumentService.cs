using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;
namespace HYPDM.BLL
{
    public interface IDocumentService
    {
        int GetMaxID();
        IList<PDM_DOCUMENT> GetDocumentListForList();
        void DocSave(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList);
        void DocDel(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList);
        IList<PDM_DOCUMENT> GetDocList(Condition c);
        IList<PDM_DOCUMENT> GetDocListByID(String docID);
        DataTable GetDocumentListForDatatable();
    }
}
