using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HYPDM
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
            Material,
            /// <summary>
            /// 不区分,公用
            /// </summary>
            ALL,
            /// <summary>
            /// 图纸
            /// </summary>
            Drawing
        }
        /// <summary>
        /// 根据RelationObjectType类型获取对应的主表名称及form
        /// </summary>
        /// <param name="RelationObjectType"> DataType.RelationObjectTyp</param>
        /// <returns></returns>
        public static string GetTableName(DataType.RelationObjectType RelationObjectType)
        {
            string tableName = "";
            switch (RelationObjectType)
            {
                case DataType.RelationObjectType.Document:
                    {
                        tableName = "PDM_DOCUMENT";
                        break;
                    }
                case DataType.RelationObjectType.File:
                    {
                        tableName = "DOC_FILE_LIST";
                        break;
                    }
                case DataType.RelationObjectType.Material:
                    {
                        tableName = "PDM_MATERAIL";
                        break;
                    }
                case DataType.RelationObjectType.Product:
                    {
                        tableName = "PDM_ALL_PRODUCT";  //PRODUCTLEVEL为1的时候表示是产品
                        break;
                    }
                case DataType.RelationObjectType.SemiProduct:
                    {
                        tableName = "PDM_ALL_PRODUCT"; //PRODUCTLEVEL为2的时候表示是半产品
                        break;
                    }
                case DataType.RelationObjectType.Drawing:
                    {
                        tableName = "PDM_DRAWING"; //图纸对象
                        break;
                    }
                default:
                    {
                        tableName = "";
                        break;
                    }
            }
            return tableName;
        }
        /// <summary>
        /// 工作流模板状态
        /// </summary>
        public enum WFTEMPLATESSTATUS
        {
            /// <summary>
            /// 完成
            /// </summary>
            Complete,
            /// <summary>
            /// 修改
            /// </summary>
            Modify,
            /// <summary>
            /// 暂停使用
            /// </summary>
            Hold
        }
        /// <summary>
        /// 工作流实例状态
        /// </summary>
        public enum WFDetailSTATUS
        {
            /// <summary>
            /// 未激活
            /// </summary>
            UNActivate,
            /// <summary>
            /// 激活中
            /// </summary>
            Activated,
            /// <summary>
            /// 返回
            /// </summary>
            Return,
            /// <summary>
            /// 完成
            /// </summary>
            Complete
        }
        public struct UserOrGroupSelected
        {
            /// <summary>
            /// 类型
            /// </summary>
            public DataType.AuthObjectType ObjectType;
            public string Value;
        }

        /// <summary>
        /// 扩展栏位的列数据类型
        /// </summary>
        public enum DataColumnType
        {
            /// <summary>
            /// 文本
            /// </summary>
            Text,
            /// <summary>
            /// 数值
            /// </summary>
            Number,
            /// <summary>
            /// 日期
            /// </summary>
            DateTime
        }

        ///// <summary>
        ///// 文件类型
        ///// </summary>
        //public enum FileType
        //{

        //    /// <summary>
        //    /// 工艺文件
        //    /// </summary>
        //    A=1,
        //    /// <summary>
        //    /// 图纸文件
        //    /// </summary>
        //    B

        //}
        //区分文件的大分类，工艺文件 工程文件(图纸)
        public enum FileType
        {
            /// <summary>
            /// 工艺文件
            /// </summary>
            ProcessFile,
            /// <summary>
            /// 图纸文件
            /// </summary>
            Drawing
        }

    }
}
