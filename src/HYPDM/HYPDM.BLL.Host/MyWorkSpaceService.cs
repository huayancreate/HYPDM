using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using EAS.Services;
using HYPDM.Entities;
using EAS.Data.Access;
using EAS.Data.Linq;
using EAS.Data.ORM;
namespace HYPDM.BLL
{
    [ServiceObject("我的工作区服务")]
    [ServiceBind(typeof(IMyWorkSpaceService))]
    public class MyWorkSpaceService : BaseServiceObject, HYPDM.BLL.IMyWorkSpaceService
    {

        //*****************************************************************//
        //*********************       我的工作区操作         ******************//
        //*****************************************************************//

        /// <summary>
        /// 获取结构树的父节点
        /// </summary>
        /// <returns></returns>
        public DataTable GetComBoxList() {
            string sqlText = "Select ID,NAME from  MYWOKSPACE WHERE USERID= 'ALL' ";
            System.Data.DataTable dt = this.DataAccessor.QueryDataTable(sqlText);
            return dt;
        }


        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        public List<MYWOKSPACE> GetList()
        {
            DataEntityQuery<MYWOKSPACE> query = DataEntityQuery<MYWOKSPACE>.Create();
            var p = (from item in query
                     where (item.USERID == "ALL")
                     orderby item.SORTNUM
                     select item
               );
            return p.ToList();
        }

        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        public List<MYWOKSPACE> GetList(string p_userId)
        {
            DataEntityQuery<MYWOKSPACE> query = DataEntityQuery<MYWOKSPACE>.Create();
            var p = (from item in query
                     where (item.USERID == p_userId) || (item.USERID == "ALL")
                     orderby item.SORTNUM
                     select item
               );
            return p.ToList();
        }

        /// <summary>
        /// 获取树形目录结构
        /// </summary>
        /// <returns></returns>
        public List<MYWOKSPACE> GetByParentId(string p_parentId)
        {
            DataEntityQuery<MYWOKSPACE> query = DataEntityQuery<MYWOKSPACE>.Create();
            var p = (from item in query
                     where (item.PARENTID == p_parentId)
                     select item
               );
            return p.ToList();
        }


        /// <summary>
        /// 级联删除目录结构
        /// </summary>
        /// <param name="p_id"></param>
        public void DelAssoByID(string p_parentId)
        {
            List<MYWOKSPACE> list = GetByParentId(p_parentId);
            for (int i=0;i<list.Count;i++){
                DelAssoByID(list[i].ID);
                DelByID(list[i]);
            }   
        }
        /// <summary>
        /// 根据主键删除目录结构
        /// </summary>
        /// <param name="p_id"></param>
        public void DelByID(MYWOKSPACE c)
        {            
            c.Delete();
        }

        /// <summary>
        /// 根据主键更新目录结构
        /// </summary>
        /// <param name="c"></param>
        public void UpDateByID(MYWOKSPACE c)
        {
            c.Update();
        }

        /// <summary>
        /// 保存目录结构
        /// </summary>
        /// <param name="c"></param>
        public void Save(MYWOKSPACE c)
        {
            c.Save();
        }
    }
}
