﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.BLL
{
    /// <summary>
    /// 最大号服务。
    /// </summary>
    public interface IMaxCodeService
    {
        int GetMaxCode(string itemKey);
    }
}
