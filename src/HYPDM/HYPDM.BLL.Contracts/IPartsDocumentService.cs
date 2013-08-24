using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IPartsDocumentService
    {
        int GetMaxID();

        // 根据半成品ID查询数据
        IList<PDM_PARTS_DOCUMENT> GetPartsDocList(string partsID);

        // 根据文档ID查询数据
        IList<PDM_PARTS_DOCUMENT> GetPartsDocByDocID(string docID);

        // 保存半成品文档关联
        void PartsDocSave(List<PDM_PARTS_DOCUMENT> partsDocList);

        // 删除数据关联
        void DelPartsDoc(List<PDM_PARTS_DOCUMENT> partsDocList);
    }
}
