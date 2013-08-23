using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;
namespace HYPDM.BLL
{
    public interface IDocumentService
    {
      //  int GetMaxID();
        IList<PDM_DOCUMENT> GetDocumentListForList();
      //  void DocSave(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList);
        void DocSave(IList<PDM_DOCUMENT> documentList);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentList"></param>
        /// <param name="docFileList"></param>
        void DocDel(IList<PDM_DOCUMENT> documentList, IList<DOC_FILE_LIST> docFileList);
        IList<PDM_DOCUMENT> GetDocList(Condition c);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="docID"></param>
        /// <returns></returns>
        IList<PDM_DOCUMENT> GetDocListByID(String docID);
        DataTable GetDocumentListForDatatable();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bl"></param>
        /// <returns></returns>
        DataTable GetDocumentListForDatatable(Boolean bl);
    }
}
