using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYDocumentMS.FileAuth
{
    public partial class UserFileAuthFrm : Form
    {

        IFileHelper fileHelper = null;
        /// <summary>
        /// 需要设定文件权限的用户登录账号
        /// </summary>
        private string userAccount = "";
        private string group = "";
        public string UserAccount
        {
            get { return userAccount; }
            set { userAccount = value; }
        }



        public UserFileAuthFrm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void UserFileAuthFrm_Load(object sender, EventArgs e)
        {
            if (this.UserAccount == null || this.UserAccount == "")
            {
                MessageBox.Show("没有指定需要设定文件权限的用户信息!!","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                this.Close();
            }
            initial();
        }

        private void initial()
        {
            fileHelper = new FileHelper();
            this.dGVFileList.DataSource = fileHelper.getDataTableBySql("'false' as CHK ,DFL_ID ,DFL_FILE_NAME,DFL_FILE_CHILD_PATH,DFL_VER_LATEST ,DEL_FLAG ,CREATEDATE ,CREATEUSER", "WHERE DEL_FLAG='N' ORDER BY LASTUPDATEDATE ASC ", "DOC_FILE_LIST");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dGVFileList.Rows)
            {
                Boolean bl = false;
                string temp = row.Cells[0].Value.ToString();
                //if (temp == "")
                //{
                //    bl = false;
                //}
                //else
                //{
                bl = Convert.ToBoolean(temp);
                //}
                
                //DBNull
                //if (bl)
                //{
                    MessageBox.Show(bl.ToString());
                //}
            
            }
        }

    }
}
