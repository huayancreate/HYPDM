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

        // 通过分类查找零部件
        IList<PDM_PARTS> getListByPartsClass(String classfication);

        // 删除零部件列表
        void delParts(IList<PDM_PARTS> partsList);
    }
}
