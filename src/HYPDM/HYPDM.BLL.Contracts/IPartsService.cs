using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;

namespace HYPDM.BLL
{
    public interface IPartsService
    {
        int GetMaxID();
        IList<PDM_PARTS> getListByPartsClass(String classfication);
    }
}
