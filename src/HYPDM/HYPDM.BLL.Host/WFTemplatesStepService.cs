using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;
using EAS.Explorer;

namespace HYPDM.BLL
{  
     [ServiceObject("工作流")]
    [ServiceBind(typeof(IWFTemplatesStepService))]
    public class WFTemplatesStepService: BaseServiceObject, IWFTemplatesStepService
    {
         public IList<WF_TEMPLATES_STEP> GetWFStepList(string wftID)
         {

             DataEntityQuery<WF_TEMPLATES_STEP> query = DataEntityQuery<WF_TEMPLATES_STEP>.Create();

             var p = (from item in query
                      orderby item.CREATEDATE ascending
                      where (item.DEL_FLAG == "N" && item.WFT_ID==wftID)
                      select item
                 );
             return p.ToList();
         }
         public ComboBoxValue GetWFStep(string stepID)
         {

             DataEntityQuery<ComboBoxValue> query = DataEntityQuery<ComboBoxValue>.Create();

             var p = (from item in query

                      where (item.COMBID == stepID)
                      select item
                 );
             IList<ComboBoxValue> list = p.ToList();
             if (list == null || list.Count == 0)
             {
                 return null;
             }
             else
             {
                 return p.ToList()[0];
             }
         }
    }
}
