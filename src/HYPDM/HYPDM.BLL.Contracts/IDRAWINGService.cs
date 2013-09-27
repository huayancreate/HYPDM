using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HYPDM.Entities;

namespace HYPDM.BLL
{
    public  interface  IDRAWINGService
    {

        /// <summary>
        /// 获取图纸对象
        /// </summary>
        /// <param name="objId"></param>
        /// <returns></returns>
        PDM_DRAWING GetDrawObjectDCID(string objId);
        /// <summary>
        /// 删除图纸对象及关联文件
        /// </summary>
        /// <param name="documentList"></param>
        /// <param name="docFileList"></param>
        void DocDel(IList<PDM_DRAWING> documentList, IList<DOC_FILE_LIST> docFileList);

        /// <summary>
        /// 保存图纸文档
        /// </summary>
        /// <param name="documentList"></param>
        void DocSave(IList<PDM_DRAWING> documentList);
    }
}
