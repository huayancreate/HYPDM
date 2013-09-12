using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYPDM.WorkSpace.WorkManager
{
    public partial class NewFloderAddForm : Form
    {
        
        public NewFloderAddForm()
        {
            InitializeComponent();
        }

        public String m_FloderName
        {
            get;
            set;
        }

        private Boolean ValueVld() {
            Boolean flag=false;
            if(string.IsNullOrEmpty(this.tb_FloderName.Text)){
                flag =true;
            }
            return flag;
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            if (ValueVld())
            {
                MessageBox.Show("文件夹名称含有非法字符"); return;
            }
            this.m_FloderName = this.tb_FloderName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void bt_canel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}
