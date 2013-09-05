using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.DefineControl
{
    public partial class Pagination : UserControl
    {

        public delegate void LoadDataDelegate();
        public event LoadDataDelegate LoadData;

        private int current_Page=1;//当前页（默认第一页）
        private int current_Rows=20;//当前没有的记录数（默认20条）
        private int total_Page; //总页数
        private int total_Rows; //总记录数
        private Object queryCondition;//查询条件


        public Pagination()
        {
            InitializeComponent();
            initControl();
        }

        private void  initControl(){
            this.page_RowsNum.Text = "20";
            this.page_CurrentPage.Text = "1";
        }
        //查询条件
        public Object QueryCondition {

            get { return queryCondition; }
            set
            {
                this.queryCondition = value;

            }
        
        }

        //总页数
        public int TotalPage 
        {
            get { return total_Page; }
            set
            {
                this.total_Page = value;
                
            }
        }

         //总记录数
        public int TotalRows 
        {
            get { return total_Rows; }
            set
            {
                this.total_Rows = value;
            }
        }

        //每页的记录数
        public int CurrentRows
        {
            get { return current_Rows; }
            set
            {
                this.current_Rows = value;
                this.page_RowsNum.Text = value.ToString();
            }
        }

        //记录的页数
        public int CurrentPage
        {
            get { return current_Page; }
            set
            {
                this.current_Page = value;
                this.page_CurrentPage.Text = value.ToString();
            }
        }

        /// <summary>
        /// 输入显示的记录数更新记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageRowsCtrl_TextChanged(object sender, EventArgs e)
        {
            this.CurrentRows = Convert.ToInt16(this.page_RowsNum.Text);
            if (this.CurrentRows < 1) {
                this.CurrentRows = 1;
                this.page_RowsNum.Text = this.CurrentRows.ToString();
            }

            this.CurrentPage = 1;
            this.page_CurrentPage.Text = this.CurrentPage.ToString();

            if (LoadData != null)
            {
                LoadData();
            }
        }

        /// <summary>
        /// 输入页数的时候显示更新记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageNumCtrl_KeyUp(object sender, KeyEventArgs e)
        {
            pageNumChange();
        }
        private void pageNumChange() {

            this.CurrentPage = Convert.ToInt16(this.page_CurrentPage.Text);

            if (this.CurrentPage > this.TotalPage)
            {
                this.CurrentPage = this.TotalPage;
                this.page_CurrentPage.Text = this.CurrentPage.ToString();
            }

            if (this.CurrentPage < 1)
            {
                this.CurrentPage = 1;

                this.page_CurrentPage.Text = this.CurrentPage.ToString();
            }

            if (LoadData != null)
            {
                LoadData();
            }
        
        }
        public void changeMemo() {
            this.tsl_memoFirst.Text = "页 / 共{0}页";
            this.tsl_memoFirst.Text = this.tsl_memoFirst.Text.Replace("{0}", this.TotalPage.ToString());
            int start = (this.CurrentPage-1) * this.CurrentRows + 1;
            int end = this.CurrentPage * this.CurrentRows;
            if (end > this.TotalRows) { end = this.TotalRows; }
            this.tsl_memoTwo.Text = "显示第{0}-{1}条记录 / 共{2}条记录";
            this.tsl_memoTwo.Text = this.tsl_memoTwo.Text.Replace("{0}", start.ToString());
            this.tsl_memoTwo.Text = this.tsl_memoTwo.Text.Replace("{1}", end.ToString());
            this.tsl_memoTwo.Text = this.tsl_memoTwo.Text.Replace("{2}", this.TotalRows.ToString());
        }

        private void tool_firstPage_Click(object sender, EventArgs e)
        {
            this.CurrentPage = 1;
            this.page_CurrentPage.Text = this.CurrentPage.ToString();
            pageNumChange();
        }

        private void tool_prePage_Click(object sender, EventArgs e)
        {
            this.CurrentPage -= 1;
            this.page_CurrentPage.Text = this.CurrentPage.ToString();
            pageNumChange();
        }

        private void tool_nextPage_Click(object sender, EventArgs e)
        {
            this.CurrentPage += 1;
            this.page_CurrentPage.Text = this.CurrentPage.ToString();
            pageNumChange();
        }

        private void tool_lastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPage = this.TotalPage;
            this.page_CurrentPage.Text = this.CurrentPage.ToString();
            pageNumChange();
        }
    }
}
