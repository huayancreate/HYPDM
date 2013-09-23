using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.AddObjectParams
{
    public partial class FrmAddParms : Form
    {

        protected string tableName = ""; //主表名称
        protected string pkValue = ""; //表的主键值
        protected string pkColName = "";//表的主键栏位名称
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


            DataTable dtTemp = ObjectParams.getDataTableBySql("PARAMS_NAME,PARAMS_DATA_TYPE,TARGET_COLNAME", " ORDER BY TARGET_COLNAME", "PDM_Params");

            if (dtTemp == null || dtTemp.Rows.Count == 0)
            {
                return;  //没有记录的时候返回
            }
            else
            {
                
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


                    pnl.Controls.Add(lbl);
                    pnl.Controls.Add(txt);
                    ctl.Controls.Add(pnl);
                    y += 25 + 5;
                }
               
            }
        }

        private void btnAddNewParams_Click(object sender, EventArgs e)
        {
            FrmAddNewParams frmNew = new FrmAddNewParams();
            frmNew.ShowDialog();
        }

    }
}
