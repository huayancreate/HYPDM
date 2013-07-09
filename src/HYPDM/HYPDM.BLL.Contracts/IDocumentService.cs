using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IDocumentService
    {
        int GetMaxID();
        IList<PDM_DOCUMENT> GetDocumentList();
        void DocSave(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList);
        void DocDel(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList);
    }
}
