﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAS.Explorer;
using EAS.Modularization;
using HYPDM.BLL;
namespace HYPDM.WinUI.AddObjectParams
{
    public class ObjectParams
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

        private static ObjectParams newInstance;

        public static ObjectParams NewInstance
        {
            get {
                if (newInstance == null)
                {
                    newInstance = new ObjectParams();
                }
                return ObjectParams.newInstance; }
            set { ObjectParams.newInstance = value; }
        }
   

        public void SetColNameToCmb(System.Windows.Forms.ComboBox cbx)
        {
            cbx.DataSource = getDataTableBySql("PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME", " ORDER BY TARGET_COLNAME", "PDM_Params");
            cbx.ValueMember = "TARGET_COLNAME";
            cbx.DisplayMember = "PARAMS_NAME";
         
            cbx.SelectedIndex = -1;
        }
        public void  SetOperations(DataType.DataColumnType dct,System.Windows.Forms.ComboBox cmbOper)
        {
            cmbOper.Items.Clear();
          ///= > < like between
            switch (dct)
            {
                case DataType.DataColumnType.Number:
                    cmbOper.Items.Add("=");
                    cmbOper.Items.Add(">");
                    cmbOper.Items.Add("<");
                    cmbOper.Items.Add("like");
                    cmbOper.Items.Add("between");

                    break;
                case DataType.DataColumnType.Text:
                    cmbOper.Items.Add("=");
                    cmbOper.Items.Add("like");
                    break;
                case  DataType.DataColumnType.DateTime:
                    cmbOper.Items.Add("=");
                    cmbOper.Items.Add(">");
                    cmbOper.Items.Add("<");
                    cmbOper.Items.Add("between");
                    break;
                default:
                    //System.Windows.Forms.MessageBox.Show("数据类型异常");
                     cmbOper.Items.Add("=");
                    break;
            }
        }
    }
}
