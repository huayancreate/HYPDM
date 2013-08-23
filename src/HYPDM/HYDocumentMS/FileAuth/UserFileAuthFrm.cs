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
    /// <summary>
    /// 用户文件权限管理
    /// </summary>
    public partial class UserFileAuthFrm : Form
    {

        IFileHelper fileHelper = null;
        /// <summary>
        /// 需要设定文件权限的用户登录账号
        /// </summary>
        private string userAccount = "";

        /// <summary>
        /// 用户角色Key值
        /// </summary>
        private string userRole = "";

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
        /// <summary>
        /// 需要设定权限的对象类别
        /// </summary>
        private DataType.AuthObjectType authObjectType;

        public DataType.AuthObjectType AuthObjectType
        {
            get { return authObjectType; }
            set { authObjectType = value; }
        }

   
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
            switch (this.AuthObjectType)
            {
                case DataType.AuthObjectType.SingleUser:
                    {
                        if (this.UserAccount == "" || this.UserAccount == null)
                        {
                            MessageBox.Show("请指定需要设定权限用户信息!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        break;
                    }
                case DataType.AuthObjectType.UserRole:
                    {
                        if (this.UserRole == "" || this.UserRole == null)
                        {
                            MessageBox.Show("请指定用户角色!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("设置权限的类型非法!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        this.Close();
                        break;
                    }
            }
            fileHelper = new FileHelper();
            fileHelper.getTreeViewByPathDir(this.trvFolderDir);


            initial();
        }

        private void initial()
        {
            //文件清单
            fileHelper = new FileHelper();
            this.dGVFileList.DataSource = fileHelper.getDataTableBySql("'false' as CHK ,DFL_ID ,DFL_FILE_NAME,DFL_FILE_CHILD_PATH,DFL_VER_LATEST ,DEL_FLAG ,CREATEDATE ,CREATEUSER", "WHERE DEL_FLAG='N' ORDER BY LASTUPDATEDATE ASC ", "DOC_FILE_LIST");
            //
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ////////foreach (DataGridViewRow row in this.dGVFileList.Rows)
            ////////{
            ////////    Boolean bl = false;
            ////////    string temp = row.Cells[0].Value.ToString();
            ////////    bl = Convert.ToBoolean(temp);
            ////////    MessageBox.Show(bl.ToString());

            ////////}
        }

    }
}
