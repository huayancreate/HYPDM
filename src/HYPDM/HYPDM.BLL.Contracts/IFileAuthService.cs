using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;
namespace HYPDM.BLL
{
     public interface IFileAuthService
    {
         FILE_AUTH GetFileAuth(string FAU_OBJ_TYPE, string FAU_OBJ_VALUE, string FAU_IS_FOLDER, string DFL_ID);
    }
}
