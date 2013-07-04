using EAS.Data;
using EAS.Data.Access;
using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM.BLL
{
    /// <summary>
    /// 最大号服务。
    /// </summary>
    [ServiceObject("最大号服务", "读取数据记录的最大号")]
    [ServiceBind(typeof(IMaxCodeService))]
    public class MaxCodeService : DataService, IMaxCodeService
    {
        #region IMaxCodeService 成员

        public int GetMaxCode(string itemKey)
        {
            if (itemKey.Contains("dbo"))
            {
                itemKey = itemKey.Remove(0, 4);
            }
            ParameterCollection pc = new ParameterCollection();
            pc.Add("ITEMKEY", itemKey);
            try
            {
                return (int)this.DataAccessor.Query("exec PDM_GETIDENTITYVALUE @itemkey=?", pc);
            }
            catch
            {
                throw new System.Exception("读取最大ID时发生错误，错误可能是由于在最大号存储表中没有指定的ItemKey:" + itemKey + "，请参考错误信息修改此问题");
            }
        }

        #endregion
    }
}
