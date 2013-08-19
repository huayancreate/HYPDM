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
    }
}
