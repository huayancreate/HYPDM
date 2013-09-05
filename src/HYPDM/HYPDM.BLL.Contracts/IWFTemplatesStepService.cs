using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  HYPDM.Entities;
namespace HYPDM.BLL
{
    public  interface IWFTemplatesStepService
    {
        IList<WF_TEMPLATES_STEP> GetWFStepList(string wftID);
        ComboBoxValue GetWFStep(string stepID);
    }
}
