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
            dtDocFileList = EAS.Services.ServiceContainer.GetService<IDocFileListService>().GetDocFileListForDatatable(bl);
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
            dtDocFileList = EAS.Services.ServiceContainer.GetService<IDocFileListService>().GetDocFileListForDatatable();
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
            tbDirList = EAS.Services.ServiceContainer.GetService<IDocFileListService>().GetDocFileDir(bl);
            return tbDirList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable getDocFileDir()
        {
            DataTable tbDirList = new DataTable();
            tbDirList = EAS.Services.ServiceContainer.GetService<IDocFileListService>().GetDocFileDir();
            return tbDirList;
        }
        DataTable dtDirList = null;//获取文档目录的清单
        TreeNode rootNode = null; //treeview的根节点
        DataTable dtDocFileList = null;//文档清单列表

        //public void getTreeViewByDocFileList1(TreeView treeview, DataTable dtDocList)
        //{

        //    dtDocFileList = dtDocList;
        //    rootNode = new TreeNode();
        //    TreeNode node;



        //    dtDirList = getDocFileDir(true); //获取文档目录的清单
        //    // dt.Select("DFD_PARENT_DIR_ID=0");

        //    DataRow[] rootDir = dtDirList.Select("DFD_PARENT_DIR_ID='0'"); //根目录
        //    if (rootDir.Length > 0)
        //    {
        //        foreach (DataRow row in rootDir)
        //        {

        //            rootNode.Text = row["DFD_PATH_NAME"].ToString();
        //            rootNode.Tag = row["DFD_ID"].ToString();  //根节点
        //            //   listFileTree(rootNode);


        //            DataRow[] rowdir = dtDirList.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", row["DFD_ID"].ToString())); //一级子目录
        //            if (rowdir.Length > 0)
        //            {
        //                foreach (DataRow r in rowdir)
        //                {
        //                    node = new TreeNode();
        //                    node.Text = r["DFD_PATH_NAME"].ToString();
        //                    node.Tag = r["DFD_ID"].ToString();
        //                    //    listFileTree(node);
        //                    listChildDir(node, r["DFD_ID"].ToString()); //遍历指定一级目录的子目录
        //                }
        //            }

        //        }
        //    }
        //    rootNode.ExpandAll();
        //    treeview.Nodes.Add(rootNode);
        //}
        /// <summary>
        /// 遍历节点的子目录
        /// </summary>
        /// <param name="node"></param>
        /// <param name="dfd_id"></param>
        /// <returns></returns>
        //private void listChildDir(TreeNode node, string dfd_id)
        //{
        //    TreeNode nnode = null;

        //    DataRow[] rdir = dtDirList.Select(string.Format("DFD_PARENT_DIR_ID='{0}'", dfd_id)); //指定目录存在的子目录
        //    if (rdir.Length > 0)
        //    {
        //        foreach (DataRow r in rdir)
        //        {
        //            nnode = new TreeNode();
        //            nnode.Text = r["DFD_PATH_NAME"].ToString();
        //            // nnode.Tag = r["DFD_ID"].ToString();
        //            nnode.Tag = r["DFD_ID"].ToString();
        //            //node.Nodes.Add(nnode);
        //            //listFileTree(nnode);
        //            node.Nodes.Add(nnode);
        //            listChildDir(nnode, r["DFD_ID"].ToString()); //遍历节点的子目录
        //            foreach (TreeNode nnn in nnode.Nodes)
        //            {
        //                string hh = nnn.Text.ToString();
        //            }


        //        }
        //        rootNode.Nodes.Add(node);
        //        return;

        //    }

        //}
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
                //fileNode.Tag = fileRow["DFL_ID"].ToString();
                fileNode.Tag = fileRow;
                node.Nodes.Add(fileNode);
            }

        }
        List<string> list = null; //存放路径节点
        DataTable dtTemp = null;
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
            tb = EAS.Services.ServiceContainer.GetService<IDocFileListService>().getDataTableBySql(stb.ToString());
            return tb;
        }




        //    DataTable dtDirList = null;//获取文档目录的清单
        //TreeNode rootNode = null; //treeview的根节点
        //DataTable dtDocFileList = null;//文档清单列表
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
            string  str=DateTime.Now.ToString("yyyyMMddHHmmss");
            return (prefix + str).Trim();
         }
      
    }

}
