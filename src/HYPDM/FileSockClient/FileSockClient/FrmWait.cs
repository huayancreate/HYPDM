using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSockClient
{
    public partial class FrmWait : Form
    {

        private string msg = "文件处理中,请稍等......";

        /// <summary>
        /// 等待提示语句
        /// </summary>
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public FrmWait()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void FrmWait_Load(object sender, EventArgs e)
        {
            this.lblMSg.Text = Msg;
        }
    }
}
