using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.BLL
{
    public class BaseServiceObject : ServiceObject
    {
        public EAS.Data.Access.IDataAccessor DataAccessor
        {
            get
            {
                return EAS.Context.ContextHelper.GetContext().Container.GetComponentInstance("DataAccessor") as EAS.Data.Access.IDataAccessor;
            }
        }
    }
}
