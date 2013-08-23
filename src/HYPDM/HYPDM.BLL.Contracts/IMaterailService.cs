using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IMaterailService
    {
        int GetMaxID();
        DataTable GetMaterailList();
        IList<PDM_MATERAIL> GetMaterailList2(Condition c);
        PDM_MATERAIL GetById(String p_id);
        DataTable GetMaterailList(PDM_MATERAIL c);
        void DelMaterailList(String p_id);
        void UpdateByID(PDM_MATERAIL c);
    }
}
