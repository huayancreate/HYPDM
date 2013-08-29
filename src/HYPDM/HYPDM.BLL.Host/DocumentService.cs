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
    [ServiceBind(typeof(IDocumentService))]
    public class DocumentService : BaseServiceObject, HYPDM.BLL.IDocumentService
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        //public int GetMaxID()
        //{
        //    return new MaxCodeService().GetMaxCode(new PDM_DOCUMENT().DbTableName);
        //}

        public IList<PDM_DOCUMENT> GetDocumentListForList()
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();

            var p = (from item in query
                     orderby item.CREATEDATE ascending
                     select item
                );
            return p.ToList();
        }


        public DataTable  GetDocumentListForDatatable()
        {
            DataTable dt = null;
            string SQLText = "SELECT DOCID,DOCNAME ,DOCTYPE,DOCSTATUS ,LASTUPDATEUSER ,COMBTEXT,CREATEDATE ,LASTUPDATEDATE,REMARK,VERSION ,DOCNO ,DESCRIPTION,CREATEUSER FROM PDM_DOCUMENT LEFT JOIN ComboBoxValue ON   DOCTYPE=COMBVALUE ORDER BY CREATEDATE asc ";

            dt = this.DataAccessor.QueryDataSet(SQLText).Tables[0];

            return dt;
        }

        public DataTable GetDocumentListForDatatable(Boolean bl)
        {
            string delFlag = bl == true ? "N" : "Y";
            DataTable dt = null;
            string SQLText = "SELECT DOCID,DOCNAME ,DEL_FLAG,DOCTYPE,DOCSTATUS ,LASTUPDATEUSER ,COMBTEXT,CREATEDATE ,LASTUPDATEDATE,REMARK,VERSION ,DOCNO ,DESCRIPTION,CREATEUSER FROM PDM_DOCUMENT LEFT JOIN ComboBoxValue ON   DOCTYPE=COMBVALUE WHERE DEL_FLAG='" + delFlag + "'" + "ORDER BY CREATEDATE asc ";

            dt = this.DataAccessor.QueryDataSet(SQLText).Tables[0];

            return dt;
        }







        #region 保存

        //public void DocSave(IList<PDM_DOCUMENT> documentList, IList<PDM_PHYSICAL_FILE> physicalList)
        //{
        //    this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), documentList, physicalList);
        //}

        //public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        //{
        //    IList<PDM_DOCUMENT> documentList = parameters[0] as IList<PDM_DOCUMENT>;
        //    IList<PDM_PHYSICAL_FILE> physicalList = parameters[1] as IList<PDM_PHYSICAL_FILE>;

        //    foreach (PDM_DOCUMENT document in documentList)
        //    {
        //        document.Save();
        //    }

        //    foreach (PDM_PHYSICAL_FILE physical in physicalList)
        //    {
        //        physical.Save();
        //    }
        //}
        public void DocSave(IList<PDM_DOCUMENT> documentList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(this.IniternalSave), documentList);
        }

        public void IniternalSave(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DOCUMENT> documentList = parameters[0] as IList<PDM_DOCUMENT>;
           // IList<PDM_PHYSICAL_FILE> physicalList = parameters[1] as IList<PDM_PHYSICAL_FILE>;

            foreach (PDM_DOCUMENT document in documentList)
            {
                document.Save();
            }

            //foreach (PDM_PHYSICAL_FILE physical in physicalList)
            //{
            //    physical.Save();
            //}
        }
        #endregion

        #region 

        public void DocDel(IList<PDM_DOCUMENT> documentList, IList<DOC_FILE_LIST> docFileList)
        {
            this.DataAccessor.TransactionExecute(new TransactionHandler2(IniternalDel), documentList, docFileList);
        }

        public void IniternalDel(IDataAccessor accessor, params object[] parameters)
        {
            IList<PDM_DOCUMENT> documentList = parameters[0] as IList<PDM_DOCUMENT>;
            IList<DOC_FILE_LIST> docFileList = parameters[1] as IList<DOC_FILE_LIST>;

            foreach (PDM_DOCUMENT document in documentList)
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
        #endregion

        public IList<PDM_DOCUMENT> GetDocList(Condition c)
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();
            return query.Select(c).ToList();
        }

        public IList<PDM_DOCUMENT> GetDocListByID(String docID)
        {
            DataEntityQuery<PDM_DOCUMENT> query = DataEntityQuery<PDM_DOCUMENT>.Create();

            var p = (from item in query
                     where (item.DOCID == docID)
                     orderby item.CREATEDATE ascending
                     select item
                );

            return p.ToList();
        }

    }
}
