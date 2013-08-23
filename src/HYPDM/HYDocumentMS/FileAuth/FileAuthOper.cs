using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;

namespace HYDocumentMS.FileAuth
{  
    /// <summary>
    /// 
    /// </summary>
   [Module("{7C8BF2CA-CD71-4394-BE5D-449099ABDC69}", "文档权限设定", "文档权限设定")]
    public partial class FileAuthOper : UserControl
    {


       IFileHelper fileHelper = null;
       /// <summary>
       /// 
       /// </summary>
        public FileAuthOper()
        {
            InitializeComponent();
        }
       /// <summary>
       /// 
       /// </summary>
        [ModuleStart]
        public void StartEx()
        {

            initial();
            //DataTable

            ucPaging1.SourceDataGridView = this.dGVUsers;

        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        private void initial()
        { 

        }

        private void btnSet_Click(object sender, EventArgs e)
        {


            UserFileAuthFrm frm = new UserFileAuthFrm();
            frm.UserAccount = "PDM";
            frm.AuthObjectType = DataType.AuthObjectType.SingleUser;
            frm.ShowDialog();
        }

        private void tabAuth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabSigleUser_Click(object sender, EventArgs e)
        {

        }

        private void tabGroup_Click(object sender, EventArgs e)
        {

        }

        private void tabGroupToGroup_Click(object sender, EventArgs e)
        {

        }

        private void tabDescription_Click(object sender, EventArgs e)
        {

        }

        private void pnlDescription_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGroupGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSingle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewExt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucPaging1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnGroupAuth_Click(object sender, EventArgs e)
        {
            UserFileAuthFrm frm = new UserFileAuthFrm();
            frm.UserRole = "PDM";
            frm.AuthObjectType = DataType.AuthObjectType.UserRole;
            frm.ShowDialog();
        }

        private void FileAuthOper_Load(object sender, EventArgs e)
        {
          
        }

    }
}
