using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EAS.Services;
using EAS.Data.ORM;
using HYPDM.BLL;
using System.Windows.Forms;

namespace HYDocumentMS
{
    /// <summary>
    /// 文档管理系统需要的方法
    /// </summary>
    public class FileHelper : IFileHelper
    {

        /// <summary>
        /// 返回指定删除标识的文件清单列表,true:delflag为N,false:delfalg为Y
        /// </summary>
        /// <param name="bl">true为只会返回删除标识为N的文件列表清单，false返回删除标识为Y的文件列表清单</param>
        /// <returns>DataTable</returns>
        public DataTable getDocFileList(Boolean bl)
        {
            dtDocFileList = new DataTable();
            dtDocFileList = EAS.Services.ServiceContainer.GetService<DocFileListService>().GetDocFileListForDatatable(bl);
            //this.InitList(documentList);
            return dtDocFileList;
        }
        /// <summary>
        /// 返回所有文件清单，不管是否删除
        /// </summary>
        /// <returns></returns>
        public DataTable getDocFileList()
        {
            dtDocFileList = new DataTable();
            dtDocFileList = EAS.Services.ServiceContainer.GetService<DocFileListService>().GetDocFileListForDatatable();
            //this.InitList(documentList);
            return dtDocFileList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getDocFileDir(Boolean bl)
        {
            DataTable tbDirList = new DataTable();
            tbDirList = EAS.Services.ServiceContainer.GetService<DocFileListService>().GetDocFileDir(bl);
            return tbDirList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getDocFileDir()
        {
            DataTable tbDirList = new DataTable();
            tbDirList = EAS.Services.ServiceContainer.GetService<DocFileListService>().GetDocFileDir();
            return tbDirList;
        }
        DataTable dtDirList = null;//获取文档目录的清单
        TreeNode rootNode = null; //treeview的根节点
        DataTable dtDocFileList = null;//文档清单列表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="dtDocList"></param>
        public void getTreeViewByDocFileList(TreeView tv, DataTable dtDocList)
        {
            this.dtDocFileList = dtDocList;
            dtDirList = getDocFileDir(true); //获取文档目录的清单
            CreatTree(tv.Nodes, "0", dtDirList);
        }
        //private void BindData(TreeView  tv,DataTable dt)
        //{
        //    initTree(tv.Nodes, "A001", dt);

        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentID"></param>
        /// <param name="dt"></param>
        public void CreatTree(TreeNodeCollection Nds, string parentID, DataTable dt)
        {
            //DataView dv = new DataView();
            TreeNode tmpNode;
            //dv.Table = dt;
            //dv.RowFilter = "上级单位ID='" + parentID + "'";
            DataRow[] dv = dt.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", parentID));
            foreach (DataRow drv in dv)
            {
                tmpNode = new TreeNode();
                tmpNode.Text = drv["DFD_PATH_NAME"].ToString();
                tmpNode.Tag = drv["DFD_ID"].ToString();
                listFileTree(tmpNode);  //遍历文件
                tmpNode.ExpandAll();
                Nds.Add(tmpNode);
                CreatTree(tmpNode.Nodes, tmpNode.Tag.ToString(), dt);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        private void listFileTree(TreeNode node)
        {
            string id = node.Tag.ToString();
            TreeNode fileNode;
            DataRow[] fileRows = dtDocFileList.Select(string.Format("DFL_FILE_CHILD_PATH='{0}'", id));
            foreach (DataRow fileRow in fileRows)
            {
                fileNode = new TreeNode();
                fileNode.Text = fileRow["DFL_FILE_NAME"].ToString();
                fileNode.Tag = fileRow["DFL_ID"].ToString();
                //  fileNode.Tag = fileRow;
                node.Nodes.Add(fileNode);
            }

        }
        List<string> list = null; //存放路径节点
        DataTable dtTemp = null;

        public string getDocumentAllPathByFileID(string fileid)
        {
            DataRow dr = this.getDataTableBySql("DFL_FILE_CHILD_PATH", "WHERE DFL_ID='" + fileid + "'", "DOC_FILE_LIST").Rows[0];
            return getDocumentAllPathByPathID(dr["DFL_FILE_CHILD_PATH"].ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathid"></param>
        /// <returns></returns>
        public string getDocumentAllPathByPathID(string pathid)
        {
            list = new List<string>();
            dtTemp = this.getDocFileDir(true);
            string strPath = ""; //返回路径
            DataRow[] rows = dtTemp.Select(string.Format("DFD_ID='{0}'", pathid));
            DataRow row = null;
            if (rows.Length > 0)
            {
                row = rows[0];
                list.Add(row["DFD_PATH_NAME"].ToString());
                if (!row["DFD_PARENT_DIR_ID"].ToString().Equals("0"))
                {
                    getFilePath(row["DFD_PARENT_DIR_ID"].ToString());
                }

            }
            else
            {
                MessageBox.Show("非法路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            if (list.Count > 0)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    strPath += list[i].ToString() + "\\";
                }
            }

            return strPath;
        }

        /// <summary>
        /// 递归出路径的子路径
        /// </summary>
        /// <param name="pathParentID"></param>
        private void getFilePath(string pathParentID)
        {
            DataRow[] rows = dtTemp.Select(string.Format("DFD_ID='{0}'", pathParentID));
            DataRow row = null;
            if (rows.Length > 0)
            {
                row = rows[0];
                list.Add(row["DFD_PATH_NAME"].ToString());
                if (!row["DFD_PARENT_DIR_ID"].ToString().Equals("0"))
                {
                    getFilePath(row["DFD_PARENT_DIR_ID"].ToString());
                }
            }
        }

        public DataTable getDataTableBySql(String fields, string where, string tableName)
        {
            DataTable tb = null;
            StringBuilder stb = new StringBuilder();
            stb.Append("SELECT " + fields + " FROM " + tableName + " " + where);
            tb = EAS.Services.ServiceContainer.GetService<DocFileListService>().getDataTableBySql(stb.ToString());
            return tb;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nds"></param>
        /// <param name="parentID"></param>
        /// <param name="dt"></param>
        private void CreatTreeDir(TreeNodeCollection Nds, string parentID, DataTable dt)
        {
            //DataView dv = new DataView();
            TreeNode tmpNode;
            //dv.Table = dt;
            //dv.RowFilter = "上级单位ID='" + parentID + "'";
            DataRow[] dv = dt.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", parentID));
            foreach (DataRow drv in dv)
            {
                tmpNode = new TreeNode();
                tmpNode.Text = drv["DFD_PATH_NAME"].ToString();
                tmpNode.Tag = drv["DFD_ID"].ToString();
                tmpNode.ExpandAll();
                Nds.Add(tmpNode);
                CreatTreeDir(tmpNode.Nodes, tmpNode.Tag.ToString(), dt);
            }
        }
        public void getTreeViewByPathDir(TreeView treeview)
        {
            HYDocumentMS.IFileHelper filehelper = new HYDocumentMS.FileHelper();
            dtDirList = filehelper.getDocFileDir(true);//获取文档目录的清单
            CreatTreeDir(treeview.Nodes, "0", dtDirList);
            treeview.ExpandAll();
        }

        public string getNewVer(string prefix)
        {
            string str = DateTime.Now.ToString("yyyyMMddHHmmss");
            return (prefix + str).Trim();
        }

        /// <summary>
        /// 给定需要判定的权限类型,用户账号key,文件key值，获取对应权限
        /// </summary>
        /// <param name="authType">查询的权限参数,查看,编辑</param>
        /// <param name="userAccount">用户账户(KEY值)</param>
        /// <param name="fileKey">文件key值</param>
        /// <returns>boolean</returns>
        public Boolean isHasAuth(DataType.AuthParmsType authType, string userAccount, string fileKey)
        {
            Boolean bl = true;

            //            //*************************************************************************************************************************//
            //            //
            //            //                         1、判定需要判定权限的类型，如查看、编辑
            //            //                         2、给定权限类型、用户登录账号、文件KEY值，调用方法进行权限判定。
            //            //                         3、权限判定方法:
            //            //                            3.1  根据userAccount获取其归属群组:  SELECT ROLENAME  FROM  EAS_ACCOUNTGROUPING  WHERE LOGINID='PDM'
            //            //                            3.2  根据fileKey获取其归属文件夹: SELECT  DFL_FILE_CHILD_PATH FROM DOC_FILE_LIST  WHERE DFL_ID='5f0a9b8d-a291-43c4-966d-4d04d3457465'
            //            //                            3.3  查询出群组的群组关系:SELECT FAURR_TO_ROLE FROM FILE_AUTH_ROLE_ROLE WHERE FAURR_FROM_ROLE='FFFF' AND DEL_FLAG='N'
            //            //                            3.4  整合userAccount对该文件ACL:
            //            //                                      3.4.1 在File_Auth中查询出文件的ACl:
            //            //                                                SELECT * FROM [drugshop].[dbo].[FILE_AUTH] WHERE DEL_FLAG='N' AND DFL_ID='111111'
            //            //                                      3.5.1 遍历3.4.1ACL:
            //            //                                             3.5.1.1 如果FAU_OBJ_TYPE=AuthObjectType.SingleUser AND FAU_OBJ_VALUE='userAccount' ,
            //            //                                                     如果结果集>0表示有权限,否则没有权限
            //            //                                             3.5.1.2 如果FAU_OBJ_TYPE=AuthObjectType.UserRole  AND FAU_OBJ_VALUE IN ('角色1','角色2','角色3'),IN中为给定账号所属群组,
            //            //                                                     如果结果集>0说明有权限,否则没有权限
            //            //
            //            //
            //            //
            //           // *************************************************************************************************************************//
            string queryFields = ""; //对应权限字段名,供查询使用
            switch (authType)
            {
                case DataType.AuthParmsType.View:
                    {
                        queryFields = "FAU_VIEW";
                        break;
                    }
                case DataType.AuthParmsType.Edit:
                    {
                        queryFields = "FAU_EDIT";
                        break;
                    }
                case DataType.AuthParmsType.Delete:
                    {
                        queryFields = "FAU_DELETE";
                        break;
                    }
                case DataType.AuthParmsType.DownLoad:
                    {
                        queryFields = "FAU_DOWNLOAD";
                        break;
                    }
                case DataType.AuthParmsType.CheckIn:
                    {
                        queryFields = "FAU_CHECKIN";
                        break;
                    }
                case DataType.AuthParmsType.CheckOut:
                    {
                        queryFields = "FAU_CHECKOUT";
                        break;
                    }
                case DataType.AuthParmsType.UpLoad:
                    {
                        queryFields = "FAU_UPLOAD";  //如果为上传的话，传的是文件夹的ID，判定用户在此文件夹下可有上传文件的权限
                        break;
                    }
                case DataType.AuthParmsType.FolderCreate:
                    {
                        queryFields = "FOLDERCREATE";
                        break;
                    }
                case DataType.AuthParmsType.FolderDelete:
                    {
                        queryFields = "FOLDERDELETE";
                        break;
                    }
                case DataType.AuthParmsType.FolderEdit:
                    {
                        queryFields = "FOLDEREDIT";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("判定权限类型不正确!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        break;

                    }
            }
            if (authType == DataType.AuthParmsType.FolderEdit || authType == DataType.AuthParmsType.FolderDelete || authType == DataType.AuthParmsType.FolderCreate || authType == DataType.AuthParmsType.UpLoad)
            {
                //针对文件夹的权限判定
                bl = IsTrueFolderAuth(queryFields, fileKey, userAccount);
            }
            else
            {
                //针对文件的权限的判定
                bl = isTrue(queryFields, userAccount, fileKey);
            }
            return bl;
        }

        /// <summary>
        /// 针对文件夹的权限进行判定
        /// </summary>
        /// <param name="queryAuthFields"></param>
        /// <param name="folderKey"></param>
        /// <param name="userKey"></param>
        /// <returns></returns>
        private Boolean IsTrueFolderAuth(string queryAuthFields, string folderKey, string userKey)
        {
            Boolean b = true;
            DataTable dtFolderAuth = null;
            dtFolderAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + folderKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.SingleUser.ToString() + "' AND FAU_OBJ_VALUE='" + userKey + "'  AND FAU_IS_FOLDER='Y' AND DEL_FLAG='N'", "FILE_AUTH");
            // return dtFolderAuth;
            if (dtFolderAuth == null || dtFolderAuth.Rows.Count == 0)
            {
                // b = false;

                dtFolderAuth = null;
                DataTable dtTemp = getUserRoleByAccount(userKey);  //用户账号归属群组
                if (dtTemp == null || dtTemp.Rows.Count == 0)
                {
                    b = false;
                }
                else
                {
                    //List<string> list = new List<string>();
                    string roleFields = "";
                    foreach (DataRow r in dtTemp.Rows)
                    {

                        //list.Add(r["ROLENAME"].ToString());
                        roleFields += "'" + r["ROLENAME"].ToString() + "',";

                        //dtFolderAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + folderKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.UserRole.ToString() + "' AND FAU_OBJ_VALUE='" + userKey + "'  AND FAU_IS_FOLDER='Y' AND DEL_FLAG='N'", "FILE_AUTH");
                    }
                    roleFields = roleFields.Remove(roleFields.Length - 1);
                    dtFolderAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + folderKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.UserRole.ToString() + "' AND FAU_OBJ_VALUE IN (" + roleFields + ")  AND FAU_IS_FOLDER='Y' AND DEL_FLAG='N'", "FILE_AUTH");

                    if (dtFolderAuth.Rows.Count >= 1)
                    {
                        foreach (DataRow rr in dtFolderAuth.Rows)
                        {
                            b = rr[queryAuthFields].ToString() == "Y" ? true : false;
                            if (b == true)
                            {
                                return b;
                            }
                        }
                    }
                    else
                    {
                        b = false;
                    }
                }
            }
            else
            {
                b = dtFolderAuth.Rows[0][queryAuthFields].ToString() == "Y" ? true : false;
            }
            return b;
        }






        /// <summary>
        /// 给定需要判定的权限类型,用户账号key,文件key值，获取对应权限
        /// </summary>
        /// <param name="strAuthType">需要查询的权限类型,如:查看,编辑等</param>
        /// <param name="userAccount">用户账户(KEY值)</param>
        /// <param name="fileKey">文件key值</param>
        /// <returns>boolean</returns>
        private Boolean isTrue(string strAuthType, string userAccount, string fileKey)
        {
            Boolean bl = true;

            //                         3、权限判定方法:
            //                            3.1  根据userAccount获取其归属群组:  SELECT ROLENAME  FROM  EAS_ACCOUNTGROUPING  WHERE LOGINID='PDM'
            //                            3.2  根据fileKey获取其归属文件夹: SELECT  DFL_FILE_CHILD_PATH FROM DOC_FILE_LIST  WHERE DFL_ID='5f0a9b8d-a291-43c4-966d-4d04d3457465'
            //                            3.3  查询出群组的群组关系:SELECT FAURR_TO_ROLE FROM FILE_AUTH_ROLE_ROLE WHERE FAURR_FROM_ROLE='FFFF' AND DEL_FLAG='N'
            //                            3.4  整合userAccount对该文件ACL:
            //                                      3.4.1 在File_Auth中查询出文件的ACl:
            //                                                SELECT * FROM [drugshop].[dbo].[FILE_AUTH] WHERE DEL_FLAG='N' AND DFL_ID='111111'
            //                                      3.5.1 遍历3.4.1ACL:
            //                                             3.5.1.1 如果FAU_OBJ_TYPE=AuthObjectType.SingleUser AND FAU_OBJ_VALUE='userAccount' ,
            //                                                     如果结果集>0表示有权限,否则没有权限
            //                                             3.5.1.2 如果FAU_OBJ_TYPE=AuthObjectType.UserRole  AND FAU_OBJ_VALUE IN ('角色1','角色2','角色3'),IN中为给定账号所属群组,
            //                                                     如果结果集>0说明有权限,否则没有权限

            DataTable dtSingleUserFileAuth = getSingleUserFileAuth(userAccount, fileKey, strAuthType);
            if (dtSingleUserFileAuth == null || dtSingleUserFileAuth.Rows.Count == 0)
            {
                bl = false;
            }
            else if (dtSingleUserFileAuth.Rows.Count > 1)
            {
                ///数据异常???
                bl = false;
            }
            else
            {
                bl = dtSingleUserFileAuth.Rows[0][0].ToString() == "Y" ? true : false;
                if (bl == true)
                {
                    return bl;   //如果有权限就直接返回,不继续下面的的判定
                }
            }


            DataTable dtUserRole = getUserRoleByAccount(userAccount);  //用户账号归属群组
            List<string> listRoleName = new List<string>(); //用户对应的群组,可能一个用户会归属多个群组

            foreach (DataRow dr in dtUserRole.Rows)
            {
                listRoleName.Add(dr["ROLENAME"].ToString());
            }

            if (listRoleName == null || listRoleName.Count == 0)
            {
                bl = false;
            }
            else
            {

                DataTable dtTemp = getUserRolesFileAuth(listRoleName, fileKey, strAuthType);
                if (dtTemp == null || dtTemp.Rows.Count == 0)
                {
                    bl = false;
                }
                else
                {
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        bl = dr[0].ToString() == "Y" ? true : false;
                        if (bl == true)
                        {
                            return bl;    //如果有权限就直接返回,不继续下面的的判定
                        }
                    }
                }
            }

            //  List<string> listFilder = null; //存放文件对应的文件夹
            string fileFolderKey = "";
            DataTable dtFileFolder = getFileFolder(fileKey);  //文件归属文件夹
            if (dtFileFolder == null || dtFileFolder.Rows.Count == 0)
            {
                bl = false;
            }
            else if (dtFileFolder.Rows.Count > 1)
            {
                bl = false;
                MessageBox.Show("一个文件不能同时归属几个文件夹!", "数据异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;  //异常返回
            }
            //foreach (DataRow dr in dtFileFolder.Rows)
            //{
            //    listFilder.Add(dr["DFL_FILE_CHILD_PATH"].ToString());
            //}
            fileFolderKey = dtFileFolder.Rows[0]["DFL_FILE_CHILD_PATH"].ToString();

            DataTable dtUserFileFolderAuth = getUserFileFolderAuth(strAuthType, fileFolderKey, userAccount);
            if (dtUserFileFolderAuth == null || dtUserFileFolderAuth.Rows.Count == 0)
            {
                bl = false;
            }
            else if (dtUserFileFolderAuth.Rows.Count > 1)
            {
                bl = false;
                MessageBox.Show("一个用户对一个文件夹只能有一笔资料!", "数据异常", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;  //异常返回
            }
            else
            {
                bl = dtUserFileFolderAuth.Rows[0][0].ToString() == "Y" ? true : false;
                if (bl == true)
                {
                    return bl;    //如果有权限就直接返回,不继续下面的的判定
                }
            }
            // DataTable dtUserRoleRole = getUserRoleRole();//用户角色归属角色

            DataTable dtUserRolesFileFolderAuth = getUserRolesFileFolderAuth(listRoleName, fileFolderKey, strAuthType);
            if (dtUserRolesFileFolderAuth == null || dtUserRolesFileFolderAuth.Rows.Count == 0)
            {
                bl = false;
            }
            else
            {
                foreach (DataRow dr in dtUserRolesFileFolderAuth.Rows)
                {
                    bl = dr[0].ToString() == "Y" ? true : false;
                    if (bl == true)
                    {
                        return bl;  //如果有权限就直接返回,不继续下面的的判定
                    }
                }
            }


            return bl;
        }
        /// <summary>
        /// 给定用户归属的多群组角色对给定文件的文件夹的权限判定
        /// </summary>
        /// <param name="roleList"></param>
        /// <param name="fileFolderKey"></param>
        /// <param name="queryAuthFields"></param>
        /// <returns></returns>
        private DataTable getUserRolesFileFolderAuth(List<string> roleList, string fileFolderKey, string queryAuthFields)
        {
            string roleFields = "";
            if (roleList == null || roleList.Count == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < roleList.Count; i++)
                {
                    roleFields += "'" + roleList[i].ToString() + "',";
                }
            }
            roleFields = roleFields.Remove(roleFields.Length - 1);
            DataTable dtUserRolesFileAuth = null;
            ///当FAU_IS_FOLDER='Y'的时候，DFL_ID为文件夹的KEY值
            dtUserRolesFileAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + fileFolderKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.UserRole.ToString() + "' AND FAU_OBJ_VALUE IN (" + roleFields + ")  AND FAU_IS_FOLDER='Y' AND DEL_FLAG='N'", "FILE_AUTH");
            return dtUserRolesFileAuth;
        }
        /// <summary>
        /// 单用户对给定文件夹的权限判定
        /// </summary>
        /// <param name="queryAuthFields"></param>
        /// <param name="fileFolderKey">文件夹Key值</param>
        /// <param name="userKey">用户Key值</param>
        /// <returns></returns>
        private DataTable getUserFileFolderAuth(string queryAuthFields, string fileFolderKey, string userKey)
        {
            DataTable dtUserFileFolderAuth = null;
            ///当FAU_IS_FOLDER='Y'的时候，DFL_ID为文件夹的KEY值
            dtUserFileFolderAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + fileFolderKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.SingleUser.ToString() + "' AND FAU_OBJ_VALUE='" + userKey + "' AND  FAU_IS_FOLDER='Y' AND DEL_FLAG='N'", "FILE_AUTH");
            return dtUserFileFolderAuth;
        }
        /// <summary>
        /// 用户归属多角色对给定文件的权限判定
        /// </summary>
        /// <param name="roleList"></param>
        /// <param name="fileKey"></param>
        /// <param name="queryAuthFields"></param>
        /// <returns></returns>
        private DataTable getUserRolesFileAuth(List<string> roleList, string fileKey, string queryAuthFields)
        {
            string roleFields = "";
            if (roleList == null || roleList.Count == 0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < roleList.Count; i++)
                {
                    roleFields += "'" + roleList[i].ToString() + "',";
                }
            }
            roleFields = roleFields.Remove(roleFields.Length - 1);
            DataTable dtUserRolesFileAuth = null;
            dtUserRolesFileAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + fileKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.UserRole.ToString() + "' AND FAU_OBJ_VALUE IN (" + roleFields + ")  AND FAU_IS_FOLDER='N' AND DEL_FLAG='N'", "FILE_AUTH");
            return dtUserRolesFileAuth;
        }
        /// <summary>
        /// 判定单用户对单文件的访问权限
        /// </summary>
        /// <param name="userKey"></param>
        /// <param name="fileKey"></param>
        /// <param name="queryAuthFields"></param>
        /// <returns></returns>
        private DataTable getSingleUserFileAuth(string userKey, string fileKey, string queryAuthFields)
        {
            DataTable dtSingleUserFileAuth = null;
            dtSingleUserFileAuth = this.getDataTableBySql(queryAuthFields, "WHERE DFL_ID='" + fileKey + "' AND FAU_OBJ_TYPE='" + DataType.AuthObjectType.SingleUser.ToString() + "' AND FAU_OBJ_VALUE='" + userKey + "'  AND FAU_IS_FOLDER='N' AND DEL_FLAG='N'", "FILE_AUTH");
            return dtSingleUserFileAuth;
        }
        /// <summary>
        /// 用户账号归属群组
        /// </summary>
        /// <param name="userAccount"></param>
        /// <returns></returns>
        private DataTable getUserRoleByAccount(string userAccount)
        {
            DataTable dtUserRole = null;
            dtUserRole = this.getDataTableBySql("LOGINID,ROLENAME", " WHERE LOGINID='" + userAccount + "'", "EAS_ACCOUNTGROUPING");
            return dtUserRole;
        }
        /// <summary>
        /// 文件归属文件夹
        /// </summary>
        /// <param name="fileKey"></param>
        /// <returns></returns>
        private DataTable getFileFolder(string fileKey)
        {
            DataTable dtFileFolder = null;
            dtFileFolder = this.getDataTableBySql("DFL_FILE_CHILD_PATH", " WHERE DFL_ID='" + fileKey + "'", "DOC_FILE_LIST");
            return dtFileFolder;
        }
        //private DataTable getUserRoleRole(string userRole)
        //{
        //    DataTable dtRoleRole = null;
        //    dtRoleRole = this.getDataTableBySql("FAURR_TO_ROLE", " WHERE FAURR_FROM_ROLE='" + userRole + "'", "FILE_AUTH_ROLE_ROLE");
        //    return dtRoleRole;
        //}
        public void SetComboBoxValue(System.Windows.Forms.ComboBox cobbox, string dataType,int selectedIndex)
        {
            cobbox.DataSource = this.getDataTableBySql("COMBTEXT,COMBVALUE", "WHERE COMBTYPE='" + dataType + "'", "ComboBoxValue");
            cobbox.DisplayMember = "COMBTEXT";
            cobbox.ValueMember = "COMBVALUE";
            cobbox.SelectedIndex = selectedIndex;
        }
    }

}
