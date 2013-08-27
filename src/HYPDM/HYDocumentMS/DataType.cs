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
    }
}
