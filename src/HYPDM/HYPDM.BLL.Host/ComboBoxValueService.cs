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
    [ServiceObject("下拉框值")]
    [ServiceBind(typeof(IComboBoxValueService))]
    public class ComboBoxValueService : BaseServiceObject, IComboBoxValueService
    {
        public ComboBoxValue GetComboBoxItemByComboID(string comboID)
        {

            DataEntityQuery<ComboBoxValue> query = DataEntityQuery<ComboBoxValue>.Create();

            var p = (from item in query
                     where item.COMBID==comboID
                     select item
                );
            return p.ToList()[0];

        }

        public Boolean IsExsitsComboBoxValue(string combovalue, string comboType)
        {

            DataEntityQuery<ComboBoxValue> query = DataEntityQuery<ComboBoxValue>.Create();

            var p = (from item in query
                     where item.COMBVALUE==combovalue && item.COMBTYPE==comboType
                     select item
                );
            IList<ComboBoxValue> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean IsExsitsComboBoxValue(string combovalue, string comboType,string comboID)
        {

            DataEntityQuery<ComboBoxValue> query = DataEntityQuery<ComboBoxValue>.Create();

            var p = (from item in query
                     where item.COMBVALUE == combovalue && item.COMBTYPE == comboType && item.COMBID!=comboID
                     select item
                );
            IList<ComboBoxValue> list = p.ToList();
            if (list == null || list.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
