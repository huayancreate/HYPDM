using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using HYPDM.Entities;
using EAS.Data.ORM;
using EAS.Explorer;
namespace HYPDM.WinUI.AddObjectParams
{
    public partial class FrmAddParms : Form
    {

        protected string tableName = ""; //主表名称
        protected string pkValue = ""; //表的主键值
        protected string pkColName = "";//表的主键栏位名称
        protected bool isHaveValue = false;
        protected int maxcolumns=0;
        List<TextBox> textBoxList = new List<TextBox>();
        List<Label> labelList = new List<Label>();
        //TextBox txtFocus = new TextBox();
        //public FrmAddParms()
        //{
        //    InitializeComponent();
        //    this.CenterToParent();
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblName">主表名称</param>
        /// <param name="Value">表的主键值</param>
        /// <param name="ColName">表的主键栏位名称</param>
        public FrmAddParms(string tblName, string Value, string ColName)
        {  
            InitializeComponent();
            this.CenterToParent();

            if (tblName == "" || Value == "" || ColName == "")
            {
                MessageBox.Show("请输入正确的参数值","打开指定窗体时候输入的参数值不对",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.tableName = tblName;
                this.pkColName = ColName;
                this.pkValue = Value;
            }

        }
        private void FrmAddParms_Load(object sender, EventArgs e)
        {
            ///初始化控件
            CreateParams(pnlIsHasParams);
           // txtFocus.Focus();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctl">容器</param>
        protected void CreateParams(Control ctl)
        {

            ctl.Controls.Clear();
            textBoxList.Clear();
            labelList.Clear();
            DataTable dtTemp = ObjectParams.getDataTableBySql(
                "PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME",
                "WHERE   MASTER_TABLE_NAME ='ALL' OR  MASTER_TABLE_NAME ='" + tableName + "' ORDER BY TARGET_COLNAME", 
                "PDM_Params");

            maxcolumns = dtTemp.Rows.Count;
            DataTable dtTempValue = ObjectParams.getDataTableBySql(
                " * ",
                "WHERE MASTER_TABLE_NAME ='" + tableName + "'  AND  PK_COL_NAME ='" + pkColName + "'  AND  PK_VALUE = '" + pkValue + "'  ",
                "PDM_Params_DETAIL");

            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                return;  //没有记录的时候返回
            }
            else
            {
                if (dtTempValue == null || dtTempValue.Rows.Count == 0)
                {
                    isHaveValue = false;
                    int x = 10;
                    int y = 10;
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        System.Windows.Forms.Panel pnl = new Panel();
                        pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        //  pnl.Location = new System.Drawing.Point(10, 10);
                        pnl.Location = new System.Drawing.Point(x, y);
                        pnl.Name = "pnl" + dr["PARAMS_NAME"].ToString();
                        pnl.Size = new System.Drawing.Size(338, 25);


                        // 
                        // txtCC
                        // 
                        TextBox txt = new TextBox();
                        txt.Location = new System.Drawing.Point(85, 1);
                        txt.Name = "txt" + dr["PARAMS_NAME"].ToString();
                        txt.Size = new System.Drawing.Size(250, 21);
                        txt.Tag = dr["TARGET_COLNAME"].ToString(); //存放该列名称对应的detail表中的列名
                        textBoxList.Add(txt);

                        //if (y == 10)
                        //{
                        //    txtFocus = txt;
                        //}
                        // 
                        // lblCC
                        // 
                        Label lbl = new Label();
                        lbl.AutoSize = true;
                        lbl.Location = new System.Drawing.Point(3, 5);
                        lbl.Name = "lbl" + dr["PARAMS_NAME"].ToString();
                        lbl.Size = new System.Drawing.Size(35, 12);
                        lbl.TabIndex = 2;
                        lbl.Text = dr["PARAMS_NAME"].ToString() + ":";
                        labelList.Add(lbl);

                        pnl.Controls.Add(lbl);
                        pnl.Controls.Add(txt);
                        ctl.Controls.Add(pnl);
                        y += 25 + 5;
                    }
                }
                else {
                    isHaveValue = true;
                    int x = 10;
                    int y = 10;
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        System.Windows.Forms.Panel pnl = new Panel();
                        pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        //  pnl.Location = new System.Drawing.Point(10, 10);
                        pnl.Location = new System.Drawing.Point(x, y);
                        pnl.Name = "pnl" + dr["PARAMS_NAME"].ToString();
                        pnl.Size = new System.Drawing.Size(338, 25);


                        // 
                        // txtCC
                        // 
                        TextBox txt = new TextBox();
                        txt.Location = new System.Drawing.Point(85, 1);
                        txt.Name = "txt" + dr["PARAMS_NAME"].ToString();
                        txt.Size = new System.Drawing.Size(250, 21);
                        txt.Tag = dr["TARGET_COLNAME"].ToString(); //存放该列名称对应的detail表中的列名
                        txt.Text = dtTempValue.Rows[0][dr["TARGET_COLNAME"].ToString()].ToString();
                        textBoxList.Add(txt);
                        //if (y == 10)
                        //{
                        //    txtFocus = txt;
                        //}
                        // 
                        // lblCC
                        // 
                        Label lbl = new Label();
                        lbl.AutoSize = true;
                        lbl.Location = new System.Drawing.Point(3, 5);
                        lbl.Name = "lbl" + dr["PARAMS_NAME"].ToString();
                        lbl.Size = new System.Drawing.Size(35, 12);
                        lbl.TabIndex = 2;
                        lbl.Text = dr["PARAMS_NAME"].ToString() + ":";
                        labelList.Add(lbl);

                        pnl.Controls.Add(lbl);
                        pnl.Controls.Add(txt);
                        ctl.Controls.Add(pnl);
                        y += 25 + 5;
                    }
                
                }          
            }
        }
        private void SaveColumnAndValue(PDM_Params p_params,String p_ProValue){
            try {
                     p_params.Save();
                 }catch(Exception e1){
                     MessageBox.Show("添加属性失败！"+e1.Message);
             }
            /*     
                 StringBuilder values = new StringBuilder();
                 values.Append(" '").Append(p_params.PARAMS_NAME).Append("','");
                 values.Append(p_params.PARAMS_DATA_TYPE).Append("','");
                 values.Append(p_params.TARGET_COLNAME).Append("','");
                 values.Append(p_params.MASTER_TABLE_NAME).Append("'");
                 String columns = "PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME,MASTER_TABLE_NAME";
                 ObjectParams.SaveParamBySql(columns, values.ToString(), "PDM_Params");
            */
            TextBox t = new TextBox();
            t.Tag = p_params.TARGET_COLNAME;
            t.Text = p_ProValue;
            textBoxList.Add(t);

            InsertOrUpDateExtPro();
            /*if (!isHaveValue)
            {
                InsertExtPro();
            }
            else
            {
                UpDateExtPro();
            }*/
            MessageBox.Show("添加属性成功");
        }

        //添加新属性按钮
        private void btnAddNewParams_Click(object sender, EventArgs e)
        {
            if (maxcolumns >= 30) {
                MessageBox.Show("最多只能添加30个属性");
                return;
            }
     
            FrmAddNewParams frmNew = new FrmAddNewParams(tableName);
            if (frmNew.ShowDialog() == DialogResult.OK)
            {
                PDM_Params t_params= frmNew.M_PDM_Params;

                foreach (Label t in labelList)
                {
                    if (t.Text.ToString().Equals(t_params.PARAMS_NAME+ ":")) { MessageBox.Show("属性已经存在，不能添加"); return; }
                }
                t_params.TARGET_COLNAME = "C" + (maxcolumns + 1);

                SaveColumnAndValue(t_params,frmNew.M_ProValue);

                CreateParams(pnlIsHasParams);
            } 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*if (!isHaveValue) {
                InsertExtPro();
            } else {
                UpDateExtPro();
            }*/
            InsertOrUpDateExtPro();
            MessageBox.Show("提交成功");
        }

        #region  自定义函数

        //添加或更新扩展属性记录
        private void InsertOrUpDateExtPro() {

            PDM_Params_DETAIL temp = new PDM_Params_DETAIL();
            Type t_type = temp.GetType(); 
          
            foreach (TextBox t in textBoxList) {
                t_type.GetProperty(t.Tag.ToString()).SetValue(temp, t.Text.ToString(), null);
            }

            temp.MASTER_TABLE_NAME = tableName;
            temp.PK_COL_NAME = pkColName;
            temp.PK_VALUE = pkValue;

            if (!isHaveValue)
            {
                temp.Save();
            }
            else
            {
                temp.Update();
            }
        }

        //添加扩展属性记录
        private void InsertExtPro()
        {
            StringBuilder valuesDetail = new StringBuilder();
            StringBuilder columnDetail = new StringBuilder();
            foreach (TextBox t in textBoxList)
            {
                valuesDetail.Append(" '").Append(t.Text.ToString()).Append("',");
                columnDetail.Append(t.Tag.ToString()).Append(",");
            }
            valuesDetail.Append("'").Append(tableName).Append("','").Append(pkColName).Append("','").Append(pkValue).Append("' ");
            columnDetail.Append("MASTER_TABLE_NAME, PK_COL_NAME, PK_VALUE ");
            ObjectParams.SaveParamBySql(columnDetail.ToString(), valuesDetail.ToString(), " PDM_Params_DETAIL");
        }
        //更新扩展属性记录
        private void UpDateExtPro() {
            string fields = "";
            string where = "";
            StringBuilder sb = new StringBuilder();

            //设置更新列
            foreach (TextBox t in textBoxList)
            {
                sb.Append(t.Tag.ToString()).Append("= '").Append(t.Text.ToString()).Append("',");
            }
            if (sb.Length<=0) return;
            sb.Length--;
            fields = sb.ToString();

            //设置条件
            sb.Length = 0;
            sb.Append(" WHERE  MASTER_TABLE_NAME ='").Append(tableName);
            sb.Append("' AND PK_COL_NAME ='").Append(pkColName);
            sb.Append("' AND PK_VALUE ='").Append(pkValue).Append("'");
            where = sb.ToString();
            ObjectParams.UpDateParamBySql(fields, where, " PDM_Params_DETAIL");
        }
        #endregion
    }
}
