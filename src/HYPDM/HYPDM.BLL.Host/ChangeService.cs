using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.BLL
{
    [ServiceObject("变更管理服务")]
    [ServiceBind(typeof(IChangeService))]
    public class ChangeService : BaseServiceObject, IChangeService
    {
    }
}
