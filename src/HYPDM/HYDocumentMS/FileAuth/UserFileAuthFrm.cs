using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using EAS.Explorer;
using EAS.Data.Linq;
using EAS.Services;
using EAS.Data.ORM;
using HYPDM.BLL;
namespace HYDocumentMS.FileAuth
{
    /// <summary>
    /// 用户文件权限管理
    /// </summary>
    public partial class UserFileAuthFrm : Form
    {
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
         IFileAuthService _fileAuth = ServiceContainer.GetService<FileAuthService>();
       
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


        string fileView = "N";
        string fileEdit = "N";
        string fileDelete = "N";
        string fileUpload = "N";
        string fileDownLoad = "N";
        string fileChkIn = "N";
        string fileChkOut = "N";
        string folderCreate = "N";
        string folderEdit = "N";
        string folderDelete = "N";
        string createDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        List<string> listFileChk = new List<string>();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            createDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Boolean bl = false;
            listFileChk = new List<string>();
            foreach (DataGridViewRow row in this.dGVFileList.Rows)
            {

                string temp = row.Cells["CHK"].Value.ToString();
                bl = Convert.ToBoolean(temp);
                if (bl == true)
                {
                    listFileChk.Add(row.Cells["DFL_ID"].Value.ToString());
                }
                // MessageBox.Show(bl.ToString());
            }
            if (listFileChk.Count == 0)
            {
                MessageBox.Show("没有选中任何文件!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            fileView = this.chkFileView.Checked == true ? "Y" : "N";
            fileEdit = this.chkFileEdit.Checked == true ? "Y" : "N";
            fileDelete = this.chkFileDelete.Checked == true ? "Y" : "N";
            fileUpload = this.chkFileUpLoad.Checked == true ? "Y" : "N";
            fileDownLoad = this.chkFileDownLoad.Checked == true ? "Y" : "N";
            fileChkIn = this.chkFileCheckIn.Checked == true ? "Y" : "N";
            fileChkOut = this.chkFileCheckOut.Checked == true ? "Y" : "N";
            createDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //string folderCreate = this.chkFolderCreate.Checked == true ? "Y" : "N";
            //string folderDelete = this.chkFolderDelete.Checked == true ? "Y" : "N";
            //string folderEdit = this.chkFolderEdit.Checked == true ? "Y" : "N";
            FILE_AUTH auth = null;
            Boolean blStart = true;
            if (fileView == "N" && fileEdit == "N" && fileDelete == "N" && fileUpload == "N" && fileDownLoad == "N" && fileChkIn == "N" && fileChkOut == "N")
            {
                if (MessageBox.Show("没有设定任何权限,请确认是否继续!!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    ///继续
                    ///
                }
                else
                {
                    blStart = false;
                }
            }
            if (blStart)
            {
                if (AuthObjectType == DataType.AuthObjectType.UserRole)
                {

                    foreach (string fileKey in listFileChk)
                    {
                        try
                        {
                            auth = _fileAuth.GetFileAuth(DataType.AuthObjectType.UserRole.ToString(), this.UserRole, "N", fileKey);
                            if (auth == null)
                            {
                                auth = new FILE_AUTH();
                                auth.CREATEUSER = LoginInfo.LoginID;
                                auth.CREATEDATE = createDate;
                                auth.FAU_ID = Guid.NewGuid().ToString();
                            }
                            else
                            {
                                auth.LASTUPDATEUSER = LoginInfo.LoginID;
                                auth.LASTUPDATEDATE = createDate;
                            }
                          
                            auth.DEL_FLAG = "N";
                            auth.FAU_CHECKIN = fileChkIn;
                            auth.FAU_CHECKOUT = fileChkOut;
                            auth.FAU_DELETE = fileDelete;
                            auth.FAU_DOWNLOAD = fileDownLoad;
                            auth.FAU_UPLOAD = fileUpload;
                            auth.FAU_VIEW = fileView;
                            auth.FAU_EDIT = fileEdit;
                            
                            auth.FAU_OBJ_TYPE = DataType.AuthObjectType.UserRole.ToString();
                            auth.FAU_OBJ_VALUE = this.UserRole.ToString();
                            auth.DFL_ID = fileKey.ToString();
                            auth.FAU_IS_FOLDER = "N";
                            auth.Save();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "插入异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                        finally
                        {

                        }
                    }
                    MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                    //DOC_FILE_LIST list = new DOC_FILE_LIST();

                }
                else if (AuthObjectType == DataType.AuthObjectType.SingleUser)
                {
                    foreach (string fileKey in listFileChk)
                    {
                        try
                        {
                            auth = _fileAuth.GetFileAuth(DataType.AuthObjectType.SingleUser.ToString(),this.UserAccount, "N", fileKey);
                            if (auth == null)
                            {
                                auth = new FILE_AUTH();
                                auth.CREATEUSER = LoginInfo.LoginID;
                                auth.CREATEDATE = createDate;
                                auth.FAU_ID = Guid.NewGuid().ToString();
                            }
                            else
                            {
                                auth.LASTUPDATEUSER = LoginInfo.LoginID;
                                auth.LASTUPDATEDATE = createDate;
                            }
                            auth.DEL_FLAG = "N";
                            auth.FAU_CHECKIN = fileChkIn;
                            auth.FAU_CHECKOUT = fileChkOut;
                            auth.FAU_DELETE = fileDelete;
                            auth.FAU_DOWNLOAD = fileDownLoad;
                            auth.FAU_UPLOAD = fileUpload;
                            auth.FAU_VIEW = fileView;
                            auth.FAU_EDIT = fileEdit;
                            
                            auth.FAU_OBJ_TYPE = DataType.AuthObjectType.SingleUser.ToString();
                            auth.FAU_OBJ_VALUE = this.UserAccount.ToString();
                            auth.DFL_ID = fileKey.ToString();
                            auth.FAU_IS_FOLDER = "N";
                            auth.Save();
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "插入异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                        finally
                        {

                        }
                    }
                    MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
            }
        }

        private void btnFolderSubmit_Click(object sender, EventArgs e)
        {
            createDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string folderKey = "";
            TreeNode node = this.trvFolderDir.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("没有选中需要设定权限的文件夹!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                folderKey = node.Tag.ToString();
            }
            fileView = this.chkView.Checked == true ? "Y" : "N";
            fileEdit = this.chkEdit.Checked == true ? "Y" : "N";
            fileDelete = this.chkDelete.Checked == true ? "Y" : "N";
            fileUpload = this.chkUpLoad.Checked == true ? "Y" : "N";
            fileDownLoad = this.chkDownLoad.Checked == true ? "Y" : "N";
            fileChkIn = this.chkCheckIN.Checked == true ? "Y" : "N";
            fileChkOut = this.chkCheckOut.Checked == true ? "Y" : "N";
            createDate = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            folderCreate = this.chkFolderCreate.Checked == true ? "Y" : "N";
            folderDelete = this.chkFolderDelete.Checked == true ? "Y" : "N";
            folderEdit = this.chkFolderEdit.Checked == true ? "Y" : "N";
            FILE_AUTH auth = null;
            Boolean blStart = true;
            if (fileView == "N" && fileEdit == "N" && fileDelete == "N" && fileUpload == "N" && fileDownLoad == "N" && fileChkIn == "N" && fileChkOut == "N" && folderCreate == "N" && folderDelete == "N" && folderEdit == "N")
            {
                if (MessageBox.Show("没有设定任何权限,请确认是否继续!!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {

                }
                else
                {
                    blStart = false;
                }
            }

            if (blStart)
            {
                if (AuthObjectType == DataType.AuthObjectType.UserRole)
                {

                    if (!folderKey.Equals(""))
                    {
                        try
                        {
                            auth = _fileAuth.GetFileAuth(DataType.AuthObjectType.UserRole.ToString(), this.UserRole, "Y", folderKey);
                            if (auth == null)
                            {
                                auth = new FILE_AUTH();
                                auth.CREATEUSER = LoginInfo.LoginID;
                                auth.CREATEDATE = createDate;
                                auth.FAU_ID = Guid.NewGuid().ToString();
                            }
                            else
                            {
                                auth.LASTUPDATEUSER = LoginInfo.LoginID;
                                auth.LASTUPDATEDATE = createDate;
                            }
                            auth.DEL_FLAG = "N";
                            auth.DFL_ID = "";
                            auth.FAU_CHECKIN = fileChkIn;
                            auth.FAU_CHECKOUT = fileChkOut;
                            auth.FAU_DELETE = fileDelete;
                            auth.FAU_DOWNLOAD = fileDownLoad;
                            auth.FAU_UPLOAD = fileUpload;
                            auth.FAU_VIEW = fileView;
                            auth.FAU_EDIT = fileEdit;
                            auth.FOLDERCREATE = this.folderCreate;
                            auth.FOLDERDELETE = this.folderDelete;
                            auth.FOLDEREDIT = this.folderEdit;

                            
                            auth.FAU_OBJ_TYPE = DataType.AuthObjectType.UserRole.ToString();
                            auth.FAU_OBJ_VALUE = this.UserRole.ToString();
                            auth.DFL_ID = folderKey.ToString();
                            auth.FAU_IS_FOLDER = "Y";
                            auth.Save();
                            MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "插入异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("选中的文件夹主键不能为空!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    //MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    //this.Close();
                    //DOC_FILE_LIST list = new DOC_FILE_LIST();

                }
                else if (AuthObjectType == DataType.AuthObjectType.SingleUser)
                {
                    if (!folderKey.Equals(""))
                    {
                        try
                        {
                            Boolean operState = true;
                            auth = _fileAuth.GetFileAuth(DataType.AuthObjectType.SingleUser.ToString(), this.UserAccount, "Y", folderKey);
                            if (auth == null)
                            {
                                auth = new FILE_AUTH();
                                auth.CREATEUSER = LoginInfo.LoginID;
                                auth.CREATEDATE = createDate;
                                auth.FAU_ID = Guid.NewGuid().ToString();
                            }
                            else
                            {
                                auth.LASTUPDATEUSER = LoginInfo.LoginID;
                                auth.LASTUPDATEDATE = createDate;
                                operState = false;
                            }
                            auth.DEL_FLAG = "N";
                            auth.FAU_CHECKIN = fileChkIn;
                            auth.FAU_CHECKOUT = fileChkOut;
                            auth.FAU_DELETE = fileDelete;
                            auth.FAU_DOWNLOAD = fileDownLoad;
                            auth.FAU_UPLOAD = fileUpload;
                            auth.FAU_VIEW = fileView;
                            auth.FAU_EDIT = fileEdit;
                            auth.FOLDERCREATE = this.folderCreate;
                            auth.FOLDERDELETE = this.folderDelete;
                            auth.FOLDEREDIT = this.folderEdit;

                          
                            auth.FAU_OBJ_TYPE = DataType.AuthObjectType.SingleUser.ToString();
                            auth.FAU_OBJ_VALUE = this.UserAccount.ToString();
                            auth.DFL_ID = folderKey.ToString();
                            auth.FAU_IS_FOLDER = "Y";
                            auth.Save();
                            //if (operState)
                            //{
                            //    auth.Save();
                            //}
                            //else
                            //{
                            //    auth.Update();
                            //}
                            MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "插入异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("选中的文件夹主键不能为空!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
            }
        }

        private void btnFolderCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
