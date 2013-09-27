using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using EAS.Data.Linq;
using EAS.Data.Access;
using HYPDM.Entities;
using EAS.Data.ORM;
using System.Data;
using EAS.Explorer;

namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IDRAWINGService))]
    public class DRAWINGService : BaseServiceObject, HYPDM.BLL.IDRAWINGService
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        public  PDM_DRAWING  GetDrawObjectDCID(string objId)
        {
            PDM_DRAWING doc = null;
            DataEntityQuery<PDM_DRAWING> query = DataEntityQuery<PDM_DRAWING>.Create();

            var p = (from item in query
                     where (item.DEL_FLAG == "N") && (item.DOCID == objId)
                     select item);
            IList<PDM_DRAWING> list = p.ToList();
            if (list.Count == 0)
            {

            }
            else
            {
                doc = list[0];
            }
            return doc;
        }

        public void DocDel(IList<PDM_DRAWING> documentList, IList<DOC_FILE_LIST> docFileList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), documentList, docFileList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DRAWING> documentList = parameters[0] as IList<PDM_DRAWING>;
            IList<DOC_FILE_LIST> docFileList = parameters[1] as IList<DOC_FILE_LIST>;

            foreach (PDM_DRAWING document in documentList)
            {

                document.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                document.LASTUPDATEUSER = LoginInfo.LoginID.ToString();
                document.DEL_FLAG = "Y";
                document.Update();
            }

            foreach (DOC_FILE_LIST docfile in docFileList)
            {
                docfile.LASTUPDATEDATE = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                docfile.LASTUPDATEUSER = LoginInfo.LoginID.ToString();
                //docfile.DEL_FLAG = "N";
                docfile.DOCID = "";
                docfile.Update();

            }
        }

        public void DocSave(IList<PDM_DRAWING> documentList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), documentList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DRAWING> documentList = parameters[0] as IList<PDM_DRAWING>;
            // IList<PDM_PHYSICAL_FILE> physicalList = parameters[1] as IList<PDM_PHYSICAL_FILE>;

            foreach (PDM_DRAWING document in documentList)
            {
                document.Save();
            }

            //foreach (PDM_PHYSICAL_FILE physical in physicalList)
            //{
            //    physical.Save();
            //}
        }

    }
}
