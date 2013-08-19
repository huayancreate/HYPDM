using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;

namespace HYPDM.BLL
{
    public interface IPjtChangeService
    {
        DataTable GetList();
        DataTable GetList(String p_pjtChangeNo);
        IList<PDM_PJTCHANGE> GetList(Condition c);
        DataTable GetAssoList(String p_productId);
        void updateAsso(int asso,string p_changeNO);
        void insertAsso(string p_changeNo, String p_productId);
        void deleteAsso(string p_changeNo, String p_productId);
    }
}
