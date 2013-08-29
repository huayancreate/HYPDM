using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYDocumentMS
{
    public static class DataType
    {  
       /// <summary>
        /// 文件权限设定时候的对象,SingleUser标识对单用户进行设定,UserRole以用户角色为设定对象,Folder以文件夹为对象
       /// </summary>
        public enum AuthObjectType
        {     
            //单用户
               SingleUser,
            //用户角色
               UserRole,
        }

        /// <summary>
        /// View 查看,Eidt编辑...
        /// </summary>
        public enum AuthParmsType
        {  
            /// <summary>
            /// 
            /// </summary>
            View,
            Edit,
            Delete,
            DownLoad,
            UpLoad,
            CheckIn,
            CheckOut,
            FolderCreate,
            FolderDelete,
            FolderEdit
        }
        /// <summary>
        /// 关联及被关联对象的类型
        /// </summary>
        public enum RelationObjectType
        {   
            /// <summary>
            /// 文档
            /// </summary>
            Document,
            /// <summary>
            /// 文件
            /// </summary>
            File,
            /// <summary>
            /// 产品
            /// </summary>
            Product,
            /// <summary>
            /// 半产品
            /// </summary>
            SemiProduct,
            /// <summary>
            /// 物料
            /// </summary>
            Material
        }
    }
}
