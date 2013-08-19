using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IObjectStructService
    {
        //增加一条记录
      //  void Add();
        //根据编号和版本删除一条记录
       // void Delete(string p_ObjectId, string p_ObjectVer);
        //获取记录
      //  DataTable GetList();
        //根据编号和版本获取记录
        DataTable GetList(string p_ObjectId,string p_ObjectVer);
    }
}
