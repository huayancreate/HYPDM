using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WinUI.WorkFlow.Flow
{
    public partial class FlowStepHandleCommon : Form
    {  
        /// <summary>
        /// 返回主调用窗体,审核人员意见内容
        /// </summary>
        private string contentMsg = "";
        /// <summary>
        ///  返回主调用窗体,表明是否通过该流程节点
        /// </summary>
        private Boolean iSThrough = true;

        public Boolean ISThrough
        {
            get { return iSThrough; }
            set { iSThrough = value; }
        }
        public string ContentMsg
        {
            get { return contentMsg; }
            set { contentMsg = value; }
        }
        public FlowStepHandleCommon()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void FlowStepHandle_Load(object sender, EventArgs e)
        {
            this.txtContent.Focus();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.radioPass.Checked == false && this.radioReturn.Checked == false)
            {
                MessageBox.Show("未选中处理结果，请选择【通过】【否决->并返回拟制状态】按钮", "工作流实例建立向导提示您:", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if (this.radioPass.Checked == true)
            {
                this.ISThrough = true;
            }
            else
            {
                ISThrough = false;
            }
            contentMsg = this.txtContent.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio1.Checked == true)
            {
                this.txtContent.Text= radio1.Text;
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2.Checked == true)
            {
                this.txtContent.Text= radio2.Text;
            }
        }
    }
}
