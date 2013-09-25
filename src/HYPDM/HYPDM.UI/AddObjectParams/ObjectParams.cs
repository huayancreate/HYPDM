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
            get
            {
                if (newInstance == null)
                {
                    newInstance = new ObjectParams();
                }
                return ObjectParams.newInstance;
            }
            set { ObjectParams.newInstance = value; }
        }


        public void SetColNameToCmb(System.Windows.Forms.ComboBox cbx)
        {
            cbx.DataSource = getDataTableBySql("PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME", " ORDER BY TARGET_COLNAME", "PDM_Params");
            cbx.ValueMember = "TARGET_COLNAME";
            cbx.DisplayMember = "PARAMS_NAME";

            cbx.SelectedIndex = -1;
        }

        public DataType.DataColumnType GetDataColumnType(string masterTblname, string colName)
        {
            DataTable dt = getDataTableBySql("PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME", "  WHERE MASTER_TABLE_NAME IN ('" + masterTblname + "','ALL') AND PARAMS_NAME='" + colName + "'", "PDM_Params");
            return (DataType.DataColumnType)Enum.Parse(typeof(DataType.DataColumnType), dt.Rows[0]["PARAMS_DATA_TYPE"].ToString(), false);
            //return 
        }


        public DataTable GetMastableExtandColumns(string masterTblname)
        {
            DataTable dt = getDataTableBySql("PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME,MASTER_TABLE_NAME,'' operation,'' val1,'' val2", "  WHERE MASTER_TABLE_NAME IN ('" + masterTblname + "','ALL')", "PDM_Params");
            return dt;
            //return 
        }


        //public void  SetOperations(DataType.DataColumnType dct,System.Windows.Forms.ComboBox cmbOper)
        //{
        //    cmbOper.Items.Clear();
        //  ///= > < like between
        //    switch (dct)
        //    {
        //        case DataType.DataColumnType.Number:
        //            cmbOper.Items.Add("=");
        //            cmbOper.Items.Add(">");
        //            cmbOper.Items.Add("<");
        //            cmbOper.Items.Add("like");
        //            cmbOper.Items.Add("between");

        //            break;
        //        case DataType.DataColumnType.Text:
        //            cmbOper.Items.Add("=");
        //            cmbOper.Items.Add("like");
        //            break;
        //        case  DataType.DataColumnType.DateTime:
        //            cmbOper.Items.Add("=");
        //            cmbOper.Items.Add(">");
        //            cmbOper.Items.Add("<");
        //            cmbOper.Items.Add("between");
        //            break;
        //        default:
        //            //System.Windows.Forms.MessageBox.Show("数据类型异常");
        //             cmbOper.Items.Add("=");
        //            break;
        //    }
        //}
        public void SetOperations(string masterTblname, string colName, System.Windows.Forms.DataGridViewComboBoxCell cmbOper)
        {

            string[] operNumber = { "=", "<", ">", "<=", ">=", "between" };
            string[] operDateTime = { "=", "<", ">", "<=", ">=", "between" };
            string[] operText = { "=", "like" };
            string[] operDefault = { "=" };
            DataType.DataColumnType dct = GetDataColumnType(masterTblname, colName);
            if (cmbOper != null)
            {
                cmbOper.Items.Clear();
            }
            else
            {
                cmbOper = new System.Windows.Forms.DataGridViewComboBoxCell();
            }
            ///= > < like between
            switch (dct)
            {
                case DataType.DataColumnType.Number:
                    //cmbOper.Items.Add("=");
                    //cmbOper.Items.Add(">");
                    //cmbOper.Items.Add("<");
                    //cmbOper.Items.Add("like");
                    //cmbOper.Items.Add("between");
                    cmbOper.Items.AddRange(operNumber);
                    break;
                case DataType.DataColumnType.Text:
                    //cmbOper.Items.Add("=");
                    //cmbOper.Items.Add("like");
                    cmbOper.Items.AddRange(operText);
                    break;
                case DataType.DataColumnType.DateTime:
                    //cmbOper.Items.Add("=");
                    //cmbOper.Items.Add(">");
                    //cmbOper.Items.Add("<");
                    //cmbOper.Items.Add("between");
                    cmbOper.Items.AddRange(operDateTime);
                    break;
                default:
                    //System.Windows.Forms.MessageBox.Show("数据类型异常");
                    cmbOper.Items.AddRange(operDefault);
                    break;
            }
        }

        public DataTable GetExtendsProperties(string masterTableName, string pkValue, string pkId)
        {
            DataTable dt;
            DataTable dtParams = getDataTableBySql(" PARAMS_NAME,TARGET_COLNAME,'' colValue", " WHERE  MASTER_TABLE_NAME IN ('" + masterTableName + "','ALL')", "PDM_Params");
            DataTable dtResult = dtParams.Clone();
            DataTable dtTemp = dtParams.Copy();
            string colValue = "";

            if (dtParams == null || dtParams.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                // foreach (DataRow dr in dtParams.Rows)
                for (int i = 0; i < dtParams.Rows.Count; i++)
                {
                    dt = getDataTableBySql(dtParams.Rows[i]["TARGET_COLNAME"].ToString().Trim().ToUpper(), "WHERE MASTER_TABLE_NAME='" + masterTableName + "' AND PK_VALUE='" + pkValue + "'", "PDM_Params_DETAIL");
                    if (dt != null && dt.Rows.Count != 0 )
                    {
                        colValue = dt.Rows[0][0].ToString();
                        //dtParams.Rows[i]["colValue"] = colValue;
                        if (colValue != "")
                        {
                            dtTemp.Rows[i]["colValue"] = colValue;
                            dtResult.Rows.Add(dtTemp.Rows[i].ItemArray);
                        }
                        
                        //

                    }
                    //else
                    //{
                    //    //dtParams.Rows.Remove(dtParams.Rows[i]);
                    //    //dtTemp.Rows.Remove(dtTemp.Rows[i]);
                    //}
                }
              //  dtResult.AcceptChanges();

            }
            return dtResult;
        }
        //public static void SaveParamBySql(String fields, string values, string tableName)
        //{

        //    StringBuilder stb = new StringBuilder();
        //    stb.Append("INSERT  " + tableName + "(" + fields + ") values (" + values+")");
        //    EAS.Services.ServiceContainer.GetService<DocFileListService>().SaveParamValue(stb.ToString());
        //}

        //public static void UpDateParamBySql(String fields, string where, string tableName)
        //{
        //    StringBuilder stb = new StringBuilder();
        //    stb.Append("UPDATE   " + tableName + "  SET " + fields + "  " + where);
        //    EAS.Services.ServiceContainer.GetService<DocFileListService>().SaveParamValue(stb.ToString());
        //}


    }
}
