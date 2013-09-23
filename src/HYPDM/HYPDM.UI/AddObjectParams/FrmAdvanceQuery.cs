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
    public partial class FrmAdvanceQuery : Form
    {
        public FrmAdvanceQuery()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private Boolean isExtandAdvanceOption = false;
        private int min = 255;//普通查询界面加上高级查询按钮的高度
        private int max = 471;//总高度
        private string extandTitle = "高级查询>>>";
        private string collapsTitle = "高级查询<<<";
        private void FrmAdvanceQuery_Load(object sender, EventArgs e)
        {
              this.Height = min;
              this.splitmain.Panel2Collapsed = true;
              btnExtandAdvanceQuery.Text = collapsTitle;
        }

        private void btnExtandAdvanceQuery_Click(object sender, EventArgs e)
        {
            if (!isExtandAdvanceOption) //没有展开的话->展开
            {
                this.Height = max;
                this.splitmain.Panel2Collapsed = false;
                btnExtandAdvanceQuery.Text = extandTitle;
                isExtandAdvanceOption = true;
            }
            else
            {
                this.Height = min;
                this.splitmain.Panel2Collapsed = true;
                btnExtandAdvanceQuery.Text = collapsTitle;
                isExtandAdvanceOption = false;
            }
        }

        private void cbmColName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.根据选定的参数名称类型判定运算符号哪些显示
            //2.根据选择的运算符号决定显示的文本框个数及样式
            //3.在界面添加查询按钮，在触发查询按钮的时候组合高级查询条件
        }
    }
}
