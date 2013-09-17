using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IMyWorkSpaceService
    {

        //*****************************************************************//
        //*********************       我的工作区操作         ******************//
        //*****************************************************************//
        /// <summary>
        /// 获取结构树的父节点
        /// </summary>
        /// <returns></returns>
        DataTable GetComBoxList();


        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        List<MYWOKSPACE> GetList();

        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        List<MYWOKSPACE> GetList(string p_userId);

        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        List<MYWOKSPACE> GetByParentId(string p_parentId);


         /// <summary>
        /// 级联删除目录结构
        /// </summary>
        /// <param name="p_parentId"></param>
       void DelAssoByID(string p_parentId);

        /// <summary>
        /// 根据主键删除目录结构
        /// </summary>
       /// <param name="c"></param>
        void DelByID(MYWOKSPACE c);

        /// <summary>
        /// 根据主键更新目录结构
        /// </summary>
        /// <param name="c"></param>
        void UpDateByID(MYWOKSPACE c);

        /// <summary>
        /// 保存目录结构
        /// </summary>
        /// <param name="c"></param>
        void Save(MYWOKSPACE c);

        void SaveRecord(MYWORKRECORD c);
        void DeleteRecord(MYWORKRECORD c);
        DataTable GetListFromTableRemove(DataTable p_dt, MYWORKRECORD mwr);
        DataTable GetListFromTableAdd(DataTable p_dt, MYWORKRECORD mwr);
    }
}
