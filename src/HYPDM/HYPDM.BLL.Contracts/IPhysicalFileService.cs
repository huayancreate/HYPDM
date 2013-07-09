using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
using System.Data;

namespace HYPDM.BLL
{
    public interface IPhysicalFileService
    {
        int GetMaxID();
        IList<PDM_PHYSICAL_FILE> GetList(string fileId);
        DataTable GetDataTable(string fileId);
        PDM_PHYSICAL_FILE GetPhysicalFile(string id, string fileName);
        PDM_PHYSICAL_FILE GetFileByParent(string parentId);

        IList<PDM_PHYSICAL_FILE> GetFileList(string parentId);
    }
}
