using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
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
        /// <summary>
        /// 根据文件id主键删除数据(逻辑删除)
        /// </summary>
        /// <param name="dflID"></param>
        /// <returns></returns>
        Boolean delDocFileByDFLID(string dflID);
        /// <summary>
        /// 根据docid获取实体对象
        /// </summary>
        /// <param name="dflID">文档清单表的主键</param>
        /// <returns></returns>
        DOC_FILE_LIST GetDocFileEntityByDCID(string dflID);
        /// <summary>
        /// 返回文件目录清单
        /// </summary>
        /// <param name="bl">true标识只返回未删除的目录，false标识只返回已经删除的目录</param>
        /// <returns>datatable</returns>
        DataTable GetDocFileDir(Boolean bl);
        /// <summary>
        /// 给定标准的SQL语句,查询返回datatable集合
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns>DataTable</returns>
        DataTable getDataTableBySql(String sql);
    }
}
