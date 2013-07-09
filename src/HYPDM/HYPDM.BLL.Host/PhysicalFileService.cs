using EAS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using EAS.Data.Linq;
using System.Data;

namespace HYPDM.BLL
{
    [ServiceObject("文档管理服务")]
    [ServiceBind(typeof(IPhysicalFileService))]
    public class PhysicalFileService : BaseServiceObject, IPhysicalFileService
    {
        public int GetMaxID()
        {
            return new MaxCodeService().GetMaxCode(new PDM_PHYSICAL_FILE().DbTableName);
        }

        public IList<PDM_PHYSICAL_FILE> GetList(string fileId)
        {
            DataEntityQuery<PDM_PHYSICAL_FILE> query = DataEntityQuery<PDM_PHYSICAL_FILE>.Create();
            var p = (from item in query
                     where (fileId == string.Empty || (item.FILEID == fileId))
                     select item);

            IList<PDM_PHYSICAL_FILE> list = new List<PDM_PHYSICAL_FILE>();
            return p.ToList();
        }

        public DataTable GetDataTable(string fileId)
        {
            var str = "SELECT * FROM PDM_PHYSICAL_FILE WHERE FILEID=" + fileId;
            DataTable dt = this.DataAccessor.QueryDataTable(str);
            return dt;
        }

        public PDM_PHYSICAL_FILE GetPhysicalFile(string id, string fileName)
        {
            DataEntityQuery<PDM_PHYSICAL_FILE> query = DataEntityQuery<PDM_PHYSICAL_FILE>.Create();
            var p = (from item in query
                     where
                         (fileName == string.Empty || (item.FILENAME == fileName))
                         && (id == string.Empty || (item.PHYSICALID == id))
                     select item);
            return p.FirstOrDefault();
        }

        public PDM_PHYSICAL_FILE GetFileByParent(string parentId)
        {
            DataEntityQuery<PDM_PHYSICAL_FILE> query = DataEntityQuery<PDM_PHYSICAL_FILE>.Create();
            var p = (from item in query
                     where (parentId == string.Empty || (item.PARENT == parentId))
                     select item);
            return p.FirstOrDefault();
        }

        public IList<PDM_PHYSICAL_FILE> GetFileList(string parentId)
        {
            DataEntityQuery<PDM_PHYSICAL_FILE> query = DataEntityQuery<PDM_PHYSICAL_FILE>.Create();
            var p = (from item in query
                     where (parentId == string.Empty || (item.PARENT == parentId))
                     select item);

            IList<PDM_PHYSICAL_FILE> list = new List<PDM_PHYSICAL_FILE>();
            return p.ToList();
        }
    }
}
