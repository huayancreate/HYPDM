using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IDocumentService))]
    public class DocumentService : BaseServiceObject, HYPDM.BLL.IDocumentService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_DOCUMENT().DbTableName);
        }

        public IList<PDM_DOCUMENT> GetDocumentList()
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     select item
                );

            return p.ToList();
        }
    }
}
