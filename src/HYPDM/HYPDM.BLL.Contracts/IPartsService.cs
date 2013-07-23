using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;

namespace HYPDM.BLL
{
    public interface IPartsService
    {
        int GetMaxID();

        // 查找全部零部件
        IList<PDM_PARTS> GetPartsList();

        // 通过分类查找零部件
        IList<PDM_PARTS> GetListByPartsClass(String classfication);

        // 删除零部件列表
        void DelParts(IList<PDM_PARTS> partsList);

        // 根据零部件ID查找零部件
        IList<PDM_PARTS> GetPartsListByID(String partsID);

        // 根据零部件编号条件查询
        IList<PDM_PARTS> GetPartsByPartsNo(String queryCondition);

        // 根据描述查找零部件信息
        IList<PDM_PARTS> GetPartsByDescription(String queryCondition);
    }
}
