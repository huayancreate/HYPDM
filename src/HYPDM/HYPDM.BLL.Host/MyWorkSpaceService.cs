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


        public void SaveRecord(MYWORKRECORD c) {
            
            string sqlText = "INSERT MYWORKRECORD (WORD_ID,STEP_ID,WORK_TYPE,USERNAME) VALUES('"
                                +c.WORD_ID+"','"
                                +c.STEP_ID+"',"
                                +c.WORK_TYPE+",'"
                                +c.USERNAME+"') ";

            this.DataAccessor.QueryDataTable(sqlText);
        }

        public void DeleteRecord(MYWORKRECORD c) {
            string sqlText = "DELETE MYWORKRECORD  "
                  + "WHERE  WORD_ID='"+c.WORD_ID+"'  "
                  + "AND  STEP_ID='"+c.STEP_ID+"'  "
                  + "AND  WORK_TYPE="+c.WORK_TYPE+"  "
                  + "AND  USERNAME='"+c.USERNAME+"'  ";
            this.DataAccessor.QueryDataTable(sqlText);
        }

       public  DataTable GetListFromTableRemove(DataTable p_dt,MYWORKRECORD mwr) {
           string sqlText = "Select WORD_ID,STEP_ID from  MYWORKRECORD WHERE USERNAME='"
               + mwr.USERNAME + "' AND WORK_TYPE= " + mwr.WORK_TYPE;
           System.Data.DataTable dtd = this.DataAccessor.QueryDataTable(sqlText);

           //DataTable t_dt = new DataTable();
           DataTable t_dt = p_dt.Clone();
           for (int i = 0; i < p_dt.Rows.Count; i++) {
               bool flag = true;
               for (int j = 0; j < dtd.Rows.Count; j++) {
                   string t1 = p_dt.Rows[i][0].ToString();
                   string t2 = dtd.Rows[j][0].ToString();
                   string t11 = p_dt.Rows[i]["Current_STEP_ID"].ToString();
                   string t21 = dtd.Rows[j][1].ToString();
                   if (t1.Equals(t2) && t11.Equals(t21))
                   {
                       flag = false; break;
                   } 
               }
               if(flag){
                   t_dt.ImportRow(p_dt.Rows[i]);
               }
           }
            return t_dt;
        }

       public DataTable GetListFromTableAdd(DataTable p_dt, MYWORKRECORD mwr)
       {
           string sqlText = "Select WORD_ID,STEP_ID from  MYWORKRECORD WHERE USERNAME='"
               + mwr.USERNAME + "' AND WORK_TYPE= " + mwr.WORK_TYPE;
           System.Data.DataTable dtd = this.DataAccessor.QueryDataTable(sqlText);

           //DataTable t_dt = new DataTable() ;
           DataTable t_dt = p_dt.Clone();

           for (int i = 0; i < p_dt.Rows.Count; i++)
           {
               for (int j = 0; j < dtd.Rows.Count; j++)
               {
                   string t1 = p_dt.Rows[i][0].ToString();
                   string t2 = dtd.Rows[j][0].ToString();
                   string t11 = p_dt.Rows[i]["Current_STEP_ID"].ToString();
                   string t21 = dtd.Rows[j][1].ToString();
                   if (t1.Equals(t2) && t11.Equals(t21))
                   {
                       t_dt.ImportRow(p_dt.Rows[i]);
                       break;
                   }
               }
           }
           return t_dt;
       }
    }
}
