using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
namespace HYPDM.BLL
{   
    /// <summary>
    /// 
    /// </summary>
   public interface IComboBoxValueService
    {
       ComboBoxValue GetComboBoxItemByComboID(string comboID);
       Boolean IsExsitsComboBoxValue(string combovalue, string comboType);
       Boolean IsExsitsComboBoxValue(string combovalue, string comboType, string comboID);
    }
}
