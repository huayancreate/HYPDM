using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace HYPDM.WinUI.AddObjectParams
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmAdvanceQuery : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmAdvanceQuery()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Height = MinHeigh;
            this.splitmain.Panel2Collapsed = true;
            btnExtandAdvanceQuery.Text = collapsTitle;

            // Initial();
        }
        public FrmAdvanceQuery(string masteTblName)
        {   
            InitializeComponent();
            this.MasterTableName = masteTblName;
            this.CenterToParent();
            this.Height = MinHeigh;
            this.splitmain.Panel2Collapsed = true;
            btnExtandAdvanceQuery.Text = collapsTitle;

            // Initial();
        }
        private Boolean isExtandAdvanceOption = false;
        private int minHeigh = 206;//普通查询界面加上高级查询按钮的高度
        private string masterTableName; //主表名称
        private int maxHeigh = 471;//总高度
        /// <summary>
        /// 展开高级查询时候的按钮名称
        /// </summary>
        private string extandTitle = "高级查询>>>";
        /// <summary>
        /// 未展开高级查询按钮时候的名称
        /// </summary>
        private string collapsTitle = "高级查询<<<";

        private string advanceQueryString = ""; //对外提供get方法，根据用户选择的查询条件组合成数据库可以识别的where条件

        public string AdvanceQueryString
        {
            get { return GetQueryString(); }
        }

        // private StringBuilder stbadvanceQueryString = new StringBuilder("1=1");
        //存放查询条件由AdvanceQueryString返回给客户,字典集合中
        private Dictionary<string, string> dicadvanceQueryString = new Dictionary<string, string>();
        /// <summary>
        /// 主表名称
        /// </summary>
        public string MasterTableName
        {
            get { return masterTableName; }
            set
            {
                masterTableName = value;

                if (isExtandAdvanceOption) //展开状态
                {
                    Initial();
                }

            }
        }
        /// <summary>
        /// 普通查询界面加上高级查询按钮的高度
        /// </summary>
        public int MinHeigh
        {
            get { return minHeigh; }
            set
            {
                minHeigh = value;
                if (!isExtandAdvanceOption)
                {
                    this.Height = MinHeigh;
                }
            }
        }

        /// <summary>
        /// 总高度
        /// </summary>
        public int MaxHeigh
        {
            get { return maxHeigh; }
            set
            {
                maxHeigh = value;
                if (isExtandAdvanceOption)
                {
                    this.Height = MaxHeigh;
                }

            }
        }

        /// <summary>
        /// 展开高级查询时候的按钮名称
        /// </summary>
        public string ExtandTitle
        {
            get { return extandTitle; }
            set
            {
                extandTitle = value;
                if (isExtandAdvanceOption) //展开状态
                {
                    btnExtandAdvanceQuery.Text = ExtandTitle;
                }

            }
        }

        /// <summary>
        /// 未展开高级查询按钮时候的名称
        /// </summary>
        public string CollapsTitle
        {
            get { return collapsTitle; }
            set
            {
                collapsTitle = value;
                if (!isExtandAdvanceOption) //没有展开
                {
                    btnExtandAdvanceQuery.Text = collapsTitle;
                }
            }
        }

        private void btnExtandAdvanceQuery_Click(object sender, EventArgs e)
        {
            if (!isExtandAdvanceOption) //没有展开的话->展开
            {
                this.Height = MaxHeigh;
                this.splitmain.Panel2Collapsed = false;
                btnExtandAdvanceQuery.Text = ExtandTitle;
                isExtandAdvanceOption = true;
                Initial();
            }
            else
            {
                this.Height = MinHeigh;
                this.splitmain.Panel2Collapsed = true;
                btnExtandAdvanceQuery.Text = CollapsTitle;
                isExtandAdvanceOption = false;
                dicadvanceQueryString = new Dictionary<string, string>(); //初始化

            }
        }

        DataTable dtExtandCol = null;
        private void Initial()
        {
            //cbmColName.SelectedIndexChanged -= cbmColName_SelectedIndexChanged;
            //ObjectParams.NewInstance.SetColNameToCmb(this.cbmColName);
            //cbmColName.SelectedIndexChanged += cbmColName_SelectedIndexChanged;
            dicadvanceQueryString = new Dictionary<string, string>(); //初始化
            dtExtandCol = ObjectParams.NewInstance.GetMastableExtandColumns(MasterTableName);
            this.dgvExtandCols.DataSource = dtExtandCol;

            // dtExtandCol = (DataTable)this.dgvExtandCols.DataSource;
            if (dtExtandCol != null || dtExtandCol.Rows.Count > 0)
            {
                for (int i = 0; i < dtExtandCol.Rows.Count; i++)
                {
                    DataGridViewTextBoxCell txtboxVal1 = dgvExtandCols.Rows[i].Cells["val1"] as DataGridViewTextBoxCell;
                    DataGridViewTextBoxCell txtboxVal2 = dgvExtandCols.Rows[i].Cells["val2"] as DataGridViewTextBoxCell;
                    txtboxVal1.Style.BackColor = Color.Gray;
                    txtboxVal1.Value = "";
                    txtboxVal1.ReadOnly = true;
                    txtboxVal2.Style.BackColor = Color.Gray;
                    txtboxVal2.Value = "";
                    txtboxVal2.ReadOnly = true;

                    //DataRow dr = this.dtExtandCol.Rows[i];
                    DataGridViewRow dgr = this.dgvExtandCols.Rows[i];
                    //  DataGridViewComboBoxCell cell = dgvExtandCols[4,i] as DataGridViewComboBoxCell;
                    DataGridViewComboBoxCell cell = dgr.Cells["operation"] as DataGridViewComboBoxCell;
                    ObjectParams.NewInstance.SetOperations(MasterTableName, dgr.Cells["PARAMS_NAME"].Value.ToString(), cell);
                }
            }
        }
        // private void cbmColName_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //1.根据选定的参数名称类型判定运算符号哪些显示
        //2.根据选择的运算符号决定显示的文本框个数及样式
        //3.在界面添加查询按钮，在触发查询按钮的时候组合高级查询条件
        //if (this.cbmColName.SelectedIndex == -1)
        //{
        //    return;
        //}
        //  MessageBox.Show(this.cbmColName.SelectedValue.ToString());
        // ObjectParams.NewInstance.SetOperations(ObjectParams.NewInstance.GetDataColumnType(MasterTableName, this.cbmColName.Text), this.cmbOper);
        // }

        //private void dgvExtandCols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //MessageBox.Show(e.ColumnIndex.ToString());
        //    //if (e.ColumnIndex == 4 && e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow)
        //    //{

        //    //    String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
        //    //    if (oper != "between")
        //    //    {
        //    //       DataGridViewTextBoxCell txtbox=dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
        //    //       txtbox.ReadOnly = true;
        //    //    }

        //    //}
        //}

        //private void dgvExtandCols_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //   // MessageBox.Show(e.ColumnIndex.ToString());
        //    if (e.ColumnIndex == 4 && e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow && dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString()!="")
        //    {

        //        String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
        //        MessageBox.Show(oper);
        //        if (oper != "between")
        //        {
        //            DataGridViewTextBoxCell txtbox = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
        //            txtbox.Value = "";
        //            txtbox.ReadOnly = true;
        //        }

        //    }
        //}

        //private void dgvExtandCols_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex == 4 && e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow && dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString() != "")
        //    {

        //        String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
        //        //MessageBox.Show(oper);
        //        if (oper != "between")
        //        {
        //            DataGridViewTextBoxCell txtbox = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
        //            txtbox.Value = "";
        //            txtbox.ReadOnly = true;
        //        }

        //    }
        //}

        //private void dgvExtandCols_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex == 4 && e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow && dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString() != "")
        //    {

        //        String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
        //        //MessageBox.Show(oper);
        //        if (oper != "between")
        //        {
        //            DataGridViewTextBoxCell txtbox = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
        //            txtbox.Value = "";
        //            txtbox.ReadOnly = true;
        //        }

        //    }
        //}

        private void dgvExtandCols_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow && dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString() != "")
            {
                DataGridViewTextBoxCell txtboxval2 = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
                DataGridViewTextBoxCell txtboxval1 = dgvExtandCols.Rows[e.RowIndex].Cells["val1"] as DataGridViewTextBoxCell;
                String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
                DataType.DataColumnType colDataType = (DataType.DataColumnType)Enum.Parse(typeof(DataType.DataColumnType), dgvExtandCols.Rows[e.RowIndex].Cells["PARAMS_DATA_TYPE"].Value.ToString(), false);
                DataGridViewRow currentDataRow = dgvExtandCols.Rows[e.RowIndex];
                string key = currentDataRow.Cells["TARGET_COLNAME"].Value.ToString();
                string value = "";
                //if (e.ColumnIndex == 4)
                switch (e.ColumnIndex)
                {
                    case 4:
                        //String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
                        //DataGridViewTextBoxCell txtboxval2 = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
                        //DataGridViewTextBoxCell txtboxval1 = dgvExtandCols.Rows[e.RowIndex].Cells["val1"] as DataGridViewTextBoxCell;
                        //MessageBox.Show(oper);
                        if (oper != "between")
                        {
                            txtboxval2.Style.BackColor = Color.Gray;
                            txtboxval2.Value = "";
                            txtboxval2.ReadOnly = true;
                            // txtboxval1.Style.BackColor = Color.AliceBlue;
                            txtboxval1.Style.BackColor = Color.White;
                            txtboxval1.Value = "";
                            txtboxval1.ReadOnly = false;
                            //  txtboxval1.S
                        }
                        else
                        {
                            //txtboxval2.Style.BackColor = Color.AliceBlue;
                            txtboxval2.Style.BackColor = Color.White;
                            txtboxval2.ReadOnly = false;

                            //txtboxval1.Style.BackColor = Color.AliceBlue;
                            txtboxval1.Style.BackColor = Color.White;
                            txtboxval1.ReadOnly = false;
                        }
                        break;
                    case 5:
                        {
                            if (oper == "")
                            {
                                if (dicadvanceQueryString != null)
                                {
                                    if (dicadvanceQueryString.ContainsKey(key))
                                    {
                                        dicadvanceQueryString.Remove(key);
                                    }
                                }
                                return;
                            }

                            if (oper == "between")
                            {
                                if (txtboxval1.Value.ToString() == "" && txtboxval2.Value.ToString() == "")
                                {
                                    if (dicadvanceQueryString != null)
                                    {
                                        if (dicadvanceQueryString.ContainsKey(key))
                                        {
                                            dicadvanceQueryString.Remove(key);
                                        }
                                    }
                                    return;
                                }

                                if (txtboxval1.Value.ToString() == "" || txtboxval2.Value.ToString() == "")
                                {

                                    //// MessageBox.Show("请输入范围的起始值.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                    // if (txtboxval1.Value.ToString() == "")
                                    // {
                                    //     this.dgvExtandCols.CurrentCell = dgvExtandCols.Rows[e.RowIndex].Cells["val1"];
                                    //     this.dgvExtandCols.BeginEdit(true);
                                    // }
                                    // else
                                    // {
                                    //     this.dgvExtandCols.CurrentCell = dgvExtandCols.Rows[e.RowIndex].Cells["val2"];
                                    //     this.dgvExtandCols.BeginEdit(true);
                                    // }
                                    if (dicadvanceQueryString != null)
                                    {
                                        if (dicadvanceQueryString.ContainsKey(key))
                                        {
                                            dicadvanceQueryString.Remove(key);
                                        }
                                    }
                                    return;
                                }
                            }
                            else
                            {
                                if (txtboxval1.Value.ToString() == "")
                                {
                                    if (dicadvanceQueryString != null)
                                    {
                                        if (dicadvanceQueryString.ContainsKey(key))
                                        {
                                            dicadvanceQueryString.Remove(key);
                                        }
                                    }
                                    return;
                                }
                            }



                            if (oper == "like")
                            {
                                switch (colDataType)
                                {
                                    case DataType.DataColumnType.DateTime:
                                        //value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append("'").Append(txtboxval1.Value.ToString()).Append("' AND '").Append(txtboxval2.Value.ToString()).Append("'").ToString();
                                        break;
                                    case DataType.DataColumnType.Number:

                                        //value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append(txtboxval1.Value.ToString()).Append(" AND ").Append(txtboxval2.Value.ToString()).Append("").ToString();
                                        break;
                                    case DataType.DataColumnType.Text:
                                        value = new StringBuilder().Append(" ").Append(oper).Append(" '%").Append(txtboxval1.Value.ToString()).Append("%'").ToString();
                                        break;
                                }
                            }
                            else
                            {
                                if (oper != "between")
                                {
                                    //value = "'" +oper+ txtboxval1 .Value.ToString()+ "'";
                                    //value = new StringBuilder().Append(oper).Append("'").Append(txtboxval1.Value.ToString()).Append("'").ToString();
                                    switch (colDataType)
                                    {
                                        case DataType.DataColumnType.DateTime:
                                            value = new StringBuilder().Append(" ").Append(oper).Append("'").Append(txtboxval1.Value.ToString()).Append("'").ToString();
                                            break;
                                        case DataType.DataColumnType.Number:

                                            value = new StringBuilder().Append(" ").Append(oper).Append(txtboxval1.Value.ToString()).ToString();
                                            break;
                                        case DataType.DataColumnType.Text:
                                            value = new StringBuilder().Append(" ").Append(oper).Append("'").Append(txtboxval1.Value.ToString()).Append("'").ToString();
                                            break;
                                    }
                                }
                                else
                                {

                                    switch (colDataType)
                                    {
                                        case DataType.DataColumnType.DateTime:
                                            value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append("'").Append(txtboxval1.Value.ToString()).Append("' AND '").Append(txtboxval2.Value.ToString()).Append("'").ToString();
                                            break;
                                        case DataType.DataColumnType.Number:

                                            value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append(txtboxval1.Value.ToString()).Append(" AND ").Append(txtboxval2.Value.ToString()).Append("").ToString();
                                            break;
                                        case DataType.DataColumnType.Text:
                                            break;
                                    }
                                }
                            }
                            if (dicadvanceQueryString != null)
                            {
                                if (dicadvanceQueryString.ContainsKey(key))
                                {

                                    //foreach (KeyValuePair<string, string> item in DicadvanceQueryString)
                                    //{
                                    //    if (item.Key == key)
                                    //    {
                                    //       // item.Value = value;
                                    //    }
                                    //    DicadvanceQueryString[key] = value;
                                    //}
                                    dicadvanceQueryString[key] = value;
                                    //foreach(Dictionary<string,string>.Enumerator item in DicadvanceQueryString.GetEnumerator())
                                    //{

                                    //}
                                    // DicadvanceQueryString.GetEnumerator();
                                    //for(Dictionary dir in DicadvanceQueryString)
                                    //{
                                    //}
                                    //Dictionary myDictionary = new Dictionary(); 
                                }
                                else
                                {
                                    dicadvanceQueryString.Add(key, value);
                                }
                            }
                            else
                            {
                                dicadvanceQueryString.Add(key, value);
                            }
                            break;
                        }
                    case 6:  //默认为between
                        {

                            if (oper == "between")
                            {
                                if (txtboxval1.Value.ToString() == "" && txtboxval2.Value.ToString() == "")
                                {
                                    if (dicadvanceQueryString != null)
                                    {
                                        if (dicadvanceQueryString.ContainsKey(key))
                                        {
                                            dicadvanceQueryString.Remove(key);
                                        }
                                    }
                                    return;
                                }

                                if (txtboxval1.Value.ToString() == "" || txtboxval2.Value.ToString() == "")
                                {
                                    if (dicadvanceQueryString != null)
                                    {
                                        if (dicadvanceQueryString.ContainsKey(key))
                                        {
                                            dicadvanceQueryString.Remove(key);
                                        }
                                    }
                                    return;
                                }
                                switch (colDataType)
                                {
                                    case DataType.DataColumnType.DateTime:
                                        value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append("'").Append(txtboxval1.Value.ToString()).Append("' AND '").Append(txtboxval2.Value.ToString()).Append("'").ToString();
                                        break;
                                    case DataType.DataColumnType.Number:

                                        value = new StringBuilder().Append(" ").Append(oper).Append(" ").Append(txtboxval1.Value.ToString()).Append(" AND ").Append(txtboxval2.Value.ToString()).Append("").ToString();
                                        break;
                                    case DataType.DataColumnType.Text:
                                        break;
                                }
                                if (dicadvanceQueryString != null)
                                {
                                    if (dicadvanceQueryString.ContainsKey(key))
                                    {
                                        dicadvanceQueryString[key] = value;
                                    }
                                    else
                                    {
                                        dicadvanceQueryString.Add(key, value);
                                    }
                                }
                                else
                                {
                                    dicadvanceQueryString.Add(key, value);
                                }
                            }
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// 遍历集合组成查询字符串
        /// </summary>
        /// <returns></returns>
        private string GetQueryString()
        {

            if (dicadvanceQueryString == null || dicadvanceQueryString.Count == 0)
            {
                return "";
            }
            else
            {
                StringBuilder stb = new StringBuilder();
                foreach (KeyValuePair<string, string> item in dicadvanceQueryString)
                {
                    stb.Append(" AND").Append(" ").Append(item.Key).Append(item.Value.ToString());
                }
                return stb.ToString();
            }

        }


    }
}
