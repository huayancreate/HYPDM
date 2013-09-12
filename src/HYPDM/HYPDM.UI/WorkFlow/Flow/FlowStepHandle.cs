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
    public partial class FlowStepHandle : Form
    {  
        /// <summary>
        /// 返回主调用窗体
        /// </summary>
        private string contentMsg = "";

        public string ContentMsg
        {
            get { return contentMsg; }
            set { contentMsg = value; }
        }
        public FlowStepHandle()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void FlowStepHandle_Load(object sender, EventArgs e)
        {
            this.txtMsg.Text = "请输入通知信息(将附加在默认消息之后)";
            this.txtContent.Focus();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            contentMsg = this.txtContent.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
