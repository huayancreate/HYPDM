using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.BLL
{
    [ServiceObject("版本管理服务")]
    [ServiceBind(typeof(IVersionService))]
    public class VersionService : BaseServiceObject, IVersionService
    {
    }
}
