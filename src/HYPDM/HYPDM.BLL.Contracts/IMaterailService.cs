using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HYPDM.Entities;
using EAS.Data.ORM;

namespace HYPDM.BLL
{
    public interface IMaterailService
    {
        int GetMaxID();
        /// <summary>
        /// 根据条件分页查询记录
        /// </summary>
        /// <param name="c"></param>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        DataSet GetProductByPage(PDM_MATERAIL c, int currentpage, int pagesize);

        DataTable GetMaterailList();
        IList<PDM_MATERAIL> GetMaterailList2(Condition c);

        /// <summary>
        /// 根据ID获取一条记录
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        PDM_MATERAIL GetById(String p_id);


        DataTable GetMaterailList(PDM_MATERAIL c);
        void DelMaterailList(String p_id);
        void DelMaterailList(String p_id, String p_user);

        /// <summary>
        /// 根据一个材料实体类更新一条记录
        /// </summary>
        /// <param name="c"></param>
        void UpdateByID(PDM_MATERAIL c);

        /// <summary>
        ///  根据编号查询一组数据
        /// </summary>
        /// <param name="p_productNo"></param>
        /// <returns></returns>
        DataTable GetListByNoDetail(string p_productNo);

        /********************************************************/
        /****************      材料关联文档操作       *******************/
        /********************************************************/
        DataTable GetAssoDoc(String p_MaterailId, String p_version);
        void DelAssoDoc(String p_DocId, String p_DocVersion, String p_MaterailId, String p_MaterailVersion);
        DataTable GetDocList(String p_MaterailId, String p_version, int p_type, String p_value);
    }
}
