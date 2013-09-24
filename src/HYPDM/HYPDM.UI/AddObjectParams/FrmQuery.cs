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
    public partial class FrmQuery : Form
    {
        public FrmQuery()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Height = MinHeigh;
            this.splitmain.Panel2Collapsed = true;
            btnExtandAdvanceQuery.Text = collapsTitle;

            
        }

        private Boolean isExtandAdvanceOption = false;
        private int minHeigh = 206;//普通查询界面加上高级查询按钮的高度
        private string masterTableName; //主表名称

        public string MasterTableName
        {
            get { return masterTableName; }
            set { masterTableName = value;
              
            }
        }
        public int MinHeigh
        {
            get { return minHeigh; }
            set { minHeigh = value; }
        }
        private int maxHeigh = 471;//总高度

        public int MaxHeigh
        {
            get { return maxHeigh; }
            set { maxHeigh = value; }
        }
        private string extandTitle = "高级查询>>>";
        private string collapsTitle = "高级查询<<<";

        private void btnExtandAdvanceQuery_Click(object sender, EventArgs e)
        {
            if (!isExtandAdvanceOption) //没有展开的话->展开
            {
               
                this.Height = MaxHeigh;
                this.splitmain.Panel2Collapsed = false;
                btnExtandAdvanceQuery.Text = extandTitle;
                isExtandAdvanceOption = true;
                Initial();
            }
            else
            {
                this.Height = MinHeigh;
                this.splitmain.Panel2Collapsed = true;
                btnExtandAdvanceQuery.Text = collapsTitle;
                isExtandAdvanceOption = false;
            }
        }

        DataTable dtExtandCol = null;
        private void Initial()
        {
            //cbmColName.SelectedIndexChanged -= cbmColName_SelectedIndexChanged;
            //ObjectParams.NewInstance.SetColNameToCmb(this.cbmColName);
            //cbmColName.SelectedIndexChanged += cbmColName_SelectedIndexChanged;

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
            if (e.ColumnIndex == 4 && e.RowIndex != -1 && !dgvExtandCols.Rows[e.RowIndex].IsNewRow && dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString() != "")
            {

                String oper = dgvExtandCols.Rows[e.RowIndex].Cells["operation"].Value.ToString();
                DataGridViewTextBoxCell txtboxval2 = dgvExtandCols.Rows[e.RowIndex].Cells["val2"] as DataGridViewTextBoxCell;
                DataGridViewTextBoxCell txtboxval1 = dgvExtandCols.Rows[e.RowIndex].Cells["val1"] as DataGridViewTextBoxCell;
                //MessageBox.Show(oper);
                if (oper != "between")
                {
                    txtboxval2.Style.BackColor = Color.Gray;
                    txtboxval2.Value = "";
                    txtboxval2.ReadOnly = true;


                  //  txtboxval1.Style.BackColor = Color.AliceBlue;
                    txtboxval1.Style.BackColor = Color.White;
                    txtboxval1.Value = "";
                    txtboxval1.ReadOnly = false;
                    //  txtboxval1.S
                }
                else
                {
                  //  txtboxval2.Style.BackColor = Color.AliceBlue;
                    txtboxval2.Style.BackColor = Color.White;
                    txtboxval2.ReadOnly = false;

                   // txtboxval1.Style.BackColor = Color.AliceBlue;
                    txtboxval1.Style.BackColor = Color.White;
                    txtboxval1.ReadOnly = false;

                }

            }
        }

        private void FrmQuery_Load(object sender, EventArgs e)
        {

        }



    }
}
