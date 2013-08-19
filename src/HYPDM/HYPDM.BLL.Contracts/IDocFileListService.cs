using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace HYPDM.BLL
{
    public interface IDocFileListService
    {
        DataTable GetDocFileListForDatatable();
        DataTable GetDocFileListForDatatable(Boolean bl);
        DataTable GetDocFileDir();
        /// <summary>
        /// 根据文档ID找到关联的文件
        /// </summary>
        /// <param name="dcid"></param>
        /// <returns></returns>
        DataTable GetDocFileDataTableByDCID(string dcid);
    }
}
