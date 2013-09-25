using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAS.Explorer;
using EAS.Modularization;
using HYPDM.BLL;
using HYPDM.BaseControl;
namespace HYPDM.WinUI.SysConfig
{
    public class sys
    {
        /// <summary>
        /// 给定列名，where条件,及表明返回datatable
        /// </summary>
        /// <param name="fields">需要查询出来的字段,sample:fields1,field2,field3</param>
        /// <param name="where">查询条件,sample:  where 1=1 and a1='jjj' order by CreateDate asc</param>
        /// <param name="tableName">查询的表名,sample:DOC_FILE_LIST</param>
        /// <returns></returns>
        public static DataTable getDataTableBySql(String fields, string where, string tableName)
        {
            DataTable tb = null;
            StringBuilder stb = new StringBuilder();
            stb.Append("SELECT " + fields + " FROM " + tableName + " " + where);
            tb = EAS.Services.ServiceContainer.GetService<DocFileListService>().getDataTableBySql(stb.ToString());
            return tb;
        }

        private static sys newInstance;

        public static sys NewInstance
        {
            get
            {
                if (newInstance == null)
                {
                    newInstance = new sys();
                }
                return sys.newInstance;
            }
            set { sys.newInstance = value; }
        }


        /// <summary>
        /// 获取指定对象的属性栏位列表
        /// </summary>
        /// <param name="RelationObjectType"></param>
        /// <returns></returns>
        public DataTable GetDataTableForParams(DataType.RelationObjectType RelationObjectType)
        {
            DataTable dtTemp = null;
            string MastertableName = GetTableName(RelationObjectType);
            //StringBuilder stb = new StringBuilder();
           // stb.AppendFormat("SELECT PARAMS_NAME,MASTER_TABLE_NAME,PARAMS_DATA_TYPE FROM PDM_Params WHERE MASTER_TABLE_NAME='{0}'",RelationObjectType.ToString());
            dtTemp = getDataTableBySql("PARAMS_NAME,MASTER_TABLE_NAME,PARAMS_DATA_TYPE", "WHERE MASTER_TABLE_NAME='" + MastertableName + "'", "PDM_Params");
            return dtTemp;

        }
        /// <summary>
        /// 根据RelationObjectType类型获取对应的主表名称及form
        /// </summary>
        /// <param name="RelationObjectType"> DataType.RelationObjectTyp</param>
        /// <returns></returns>
        protected  string GetTableName(DataType.RelationObjectType RelationObjectType)
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
                default:
                    {
                        tableName = "ALL";
                        break;
                    }
            }
            return tableName;
        }


    }
}
