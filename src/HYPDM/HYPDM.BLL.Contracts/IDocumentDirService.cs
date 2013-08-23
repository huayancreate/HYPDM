using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;

namespace HYPDM.BLL
{
    public interface IDocumentDirService
    {
        /// <summary>
        /// 添加文件夹
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        bool addDocumentDir(DOC_FILE_DIR dir);
        /// <summary>
        /// 生成将要创建文件夹的ID
        /// </summary>
        /// <returns></returns>
        int GetMaxID();
        /// <summary>
        /// 根据文件夹节点id查询相应记录
        /// </summary>
        /// <param name="dfd_id"></param>
        /// <returns></returns>
        DOC_FILE_DIR findDoc(String dfd_id);
        /// <summary>
        /// 逻辑删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        bool deleteDocumentDir(DOC_FILE_DIR dir);
        /// <summary>
        /// 修改文件夹
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        bool updateDocumentDir(DOC_FILE_DIR dir);
        /// <summary>
        /// 判断所添加的文件夹名是否与兄弟文件夹名相同
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="docName"></param>
        /// <returns></returns>
        int findDocments(String parentID, String docName);
        /// <summary>
        /// 判断要删除的文件是否有子文件夹
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int findSonDocments(String id);
    }

}
