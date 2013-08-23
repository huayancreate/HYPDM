using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.ORM;
using EAS.Data.Linq;
using EAS.Data.Access;
using EAS.Data;
namespace HYPDM.BLL
{

    [ServiceObject("文档目录")]
    [ServiceBind(typeof(IDocFileListService))]
    public class DocumentDirService : BaseServiceObject, IDocumentDirService
    {
        /// <summary>
        /// 添加目录
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public bool addDocumentDir(DOC_FILE_DIR dir)
        {
            try
            {
                dir.Save();
                return true;
            }
            catch (Exception)
            {

                //throw new Exception(e.Message.ToString());
                return false;
            }

        }
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_DOCUMENT().DbTableName);
        }
        /// <summary>
        /// 删除目录
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>

        /* public bool deleteDocumentDir(DOC_FILE_DIR dir)
         {
             try
             {
                  dir.Delete();
                  return true;
             }
             catch (Exception)
             {
                 return false;
                
             }
         }*/
        /// <summary>
        /// 根据文件节点id查询相应记录
        /// </summary>
        /// <param name="dfd_id"></param>
        /// <returns></returns>
        public DOC_FILE_DIR findDoc(String dfd_id)
        {
            DataEntityQuery<DOC_FILE_DIR> query = DataEntityQuery<DOC_FILE_DIR>.Create();
            var p = (from item in query where item.DFD_ID == dfd_id select item);
            return p.FirstOrDefault();
        }
        /// <summary>
        /// 逻辑删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public bool deleteDocumentDir(DOC_FILE_DIR dir)
        {
            try
            {
                dir.Update();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 修改文件夹
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public bool updateDocumentDir(DOC_FILE_DIR dir)
        {
            try
            {
                dir.Update();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public int findDocments(String parentID, String docName)
        {
            DataEntityQuery<DOC_FILE_DIR> query = DataEntityQuery<DOC_FILE_DIR>.Create();
            var p = (from item in query where item.DFD_PATH_NAME == docName && item.DFD_PARENT_DIR_ID == parentID select item);
            return p.Count();
        }
        public int findSonDocments(String id)
        {
            DataEntityQuery<DOC_FILE_DIR> query = DataEntityQuery<DOC_FILE_DIR>.Create();
            var p = (from item in query where item.DFD_PARENT_DIR_ID == id select item);
            return p.Count();
        }

    }
}
