using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAS.Modularization;
using EAS.Data.Linq;
using EAS.Explorer;
using EAS.Data.ORM;
using HYPDM.Entities;
using HYPDM.BLL;
namespace HYPDM.WorkSpace
{
    [Module("{3C424749-7455-4BF1-B246-51CEC6690509}", "工作区", "我的工作区")]
    public partial class WorkSapce : UserControl
    {

        IMyWorkSpaceService m_MyWorkSpaceService = EAS.Services.ServiceContainer.GetService<IMyWorkSpaceService>();
        IAccount LoginInfo = EAS.Application.Instance.Session.Client as IAccount;
        UserControl uc = null;

        private TreeNode m_treeNode = null;
        private int m_loginPre = 0;
        
        [ModuleStart]
        public void StartEx()
        {
           
           
        }
        public WorkSapce()
        {
            InitializeComponent();
            treeInit();
            controlInit(CommonEnum.moduleType.WorkSpace, (MYWOKSPACE)m_treeNode.Tag);               
        }

        #region 构造导航树

        private void treeInit()
        {
            List<MYWOKSPACE> t_list = null;
            if (m_loginPre == 1)//修改全部权限
            {
                t_list = m_MyWorkSpaceService.GetList();
                this.tsl_addNode.Visible = true;
                this.tsb_del.Visible = true;
                this.tsb_modify.Visible = true;
            }
            else
            {
                this.tsl_addNode.Visible = false;
                this.tsb_del.Visible = false;
                this.tsb_modify.Visible = false;
                t_list = m_MyWorkSpaceService.GetList(LoginInfo.LoginID);
            }

            tree_Root(t_list);
        }

        private void tree_Root(List<MYWOKSPACE> p_list)
        {
            this.tv_navigator.Nodes.Clear();
            TreeNode node = new TreeNode(LoginInfo.LoginID, 0, 0); node.Tag = null;
            this.tv_navigator.Nodes.Add(node);
           // node.Expand() ;
            tree_Creater(p_list,node.Nodes, "0");
            node.Expand();
        }

        private void tree_Creater(List<MYWOKSPACE> p_list,TreeNodeCollection nodes, String p_parentID){
            bool first = true;
            for (int i = 0; i < p_list.Count; i++)
            {
                if (p_list[i].PARENTID == p_parentID)
                {

                    TreeNode node = new TreeNode(p_list[i].NAME, p_list[i].IMAGETYPE, p_list[i].IMAGETYPE);
                    node.Tag = p_list[i];
                    nodes.Add(node);

                    if (first && p_parentID == "0" && this.m_loginPre == 0)
                    {
                        this.tv_navigator.SelectedNode = node;
                        m_treeNode = node;
                        first = false;
                    }
                    tree_Creater(p_list,node.Nodes, p_list[i].ID);
                }
            }
        
        }
        #endregion

        #region  控件展示操作
        private void controlInit(CommonEnum.moduleType p_module, MYWOKSPACE p_myWorkSpace)
        {


            if (this.splitContainer1.Panel2.Controls.Contains(uc))
            {
                this.splitContainer1.Panel2.Controls.Remove(uc);
            }

            if (p_module.Equals(CommonEnum.moduleType.WorkSpace))
            {
                uc = new WorkManager.WorkManager(p_myWorkSpace);
            }
            else if (p_module.Equals(CommonEnum.moduleType.RecentWorkSpace))
            {
                uc = new WorkManager.RecentWorkManager(p_myWorkSpace);
            }
            else if (p_module.Equals(CommonEnum.moduleType.Project))
            {
                uc = new ProjcetManger.ProjectModule();
            }
            else if (p_module.Equals(CommonEnum.moduleType.MyFloder))
            {
                uc = new WorkManager.MyFloderManager();
            }
            uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(uc);
        }


        private void tv_navigator_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null) return;     //根节点不操作

            this.tv_navigator.SelectedNode = e.Node;
            MYWOKSPACE t_myWorkSpace=(MYWOKSPACE)e.Node.Tag;

            if (this.m_loginPre == 1) return;    //如果是树结构配置状态不操作

            if(e.Button==MouseButtons.Right){

                if (t_myWorkSpace.ISADDCHILD == 1)
                {
                    cms_MyFloderMenu.Show(MousePosition.X,MousePosition.Y);
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (m_treeNode == e.Node) return; //两次点击同一个按钮不操作
                m_treeNode = e.Node;
                if (e.Node.Nodes.Count > 0) return;//不是叶子节点不操作
                CommonEnum.moduleType t_type = (CommonEnum.moduleType)t_myWorkSpace.MODULETYPE;
                controlInit(t_type, t_myWorkSpace);
            }
        }

        #endregion

        #region 右键菜单操作
        private void tsmi_New_Click(object sender, EventArgs e)
        {
            WorkManager.NewFloderAddForm o = new WorkManager.NewFloderAddForm();
            o.StartPosition = FormStartPosition.CenterParent;
            if (o.ShowDialog() == DialogResult.OK) {
                //MessageBox.Show();
                addFloder(o.m_FloderName);
            }
        }

        private void tsm_Del_Click(object sender, EventArgs e)
        {
            delFloder();
        }
        private void delFloder() {
            TreeNode node = this.tv_navigator.SelectedNode;
            MYWOKSPACE t_myworkspace = (MYWOKSPACE)node.Tag;
            m_MyWorkSpaceService.DelAssoByID(t_myworkspace.ID);

            if (t_myworkspace.USERID != "ALL")
            {
                m_MyWorkSpaceService.DelByID(t_myworkspace);
                node.Remove();
            }
            else {
                node.Nodes.Clear();
            }
            
        }
        private void addFloder(string p_FloderName) {
            TreeNode node = this.tv_navigator.SelectedNode;
            TreeNode newNode = new TreeNode(p_FloderName, 0, 1);
            MYWOKSPACE t_myWorkSpace = new MYWOKSPACE();
            t_myWorkSpace.ID = Guid.NewGuid().ToString();
            t_myWorkSpace .NAME= p_FloderName;
            t_myWorkSpace.PARENTID = ((MYWOKSPACE)node.Tag).ID;
            t_myWorkSpace.ISADDCHILD = 1;
            t_myWorkSpace.USERID = LoginInfo.LoginID;
            t_myWorkSpace.MODULETYPE = Convert.ToInt16(CommonEnum.moduleType.MyFloder);

            m_MyWorkSpaceService.Save(t_myWorkSpace);
            //t.save();
            newNode.Tag = t_myWorkSpace;
            node.Nodes.Add(newNode);
            node.Expand();
           // MessageBox.Show(newNode.Tag.ToString());
        }
        #endregion

        #region 导航栏操作
        private void tsl_addNode_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tv_navigator.SelectedNode;
            if(node==null) node =this.tv_navigator.TopNode;

            WorkManager.NewNodeAddForm o = new WorkManager.NewNodeAddForm(null, node);
            o.StartPosition=FormStartPosition.CenterParent;
 
            if (o.ShowDialog() == DialogResult.OK) {

                MYWOKSPACE t_myworkspace = new MYWOKSPACE();
                t_myworkspace = o.m_myWorkSapce;
                m_MyWorkSpaceService.Save(t_myworkspace);

               // TreeNode newNode = new TreeNode(t_myworkspace.NAME, t_myworkspace.IMAGETYPE, t_myworkspace.IMAGETYPE);
               // newNode.Tag = t_myworkspace;
                //node.Nodes.Add(newNode);
                treeInit();
                MessageBox.Show("添加成功");
            }
        }

        private void tsb_del_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tv_navigator.SelectedNode;
            if (node == null) { MessageBox.Show("请选择一个节点"); return; }
            if (node == this.tv_navigator.TopNode) { MessageBox.Show("根节点不能删除"); return; }
            MYWOKSPACE t_myworkspace = (MYWOKSPACE)node.Tag;
            m_MyWorkSpaceService.DelAssoByID(t_myworkspace.ID);
            m_MyWorkSpaceService.DelByID(t_myworkspace);

            //node.Remove();

            treeInit();
            MessageBox.Show("删除成功");
        }

        private void tsb_modify_Click(object sender, EventArgs e)
        {
            TreeNode node = this.tv_navigator.SelectedNode;
            if (node == null) { MessageBox.Show("请选择一个节点"); return; }
            if (node == this.tv_navigator.TopNode) { MessageBox.Show("根节点不能修改"); return; }

            WorkManager.NewNodeAddForm o = new WorkManager.NewNodeAddForm((MYWOKSPACE)node.Tag, node);
            o.StartPosition = FormStartPosition.CenterParent;

            if (o.ShowDialog() == DialogResult.OK)
            {

                MYWOKSPACE t_myworkspace = new MYWOKSPACE();
                t_myworkspace = o.m_myWorkSapce;
                m_MyWorkSpaceService.UpDateByID(t_myworkspace);

               // node.Tag = t_myworkspace;
               // node.Text = t_myworkspace.NAME;
                treeInit();
                MessageBox.Show("修改成功");
            }
        }
        #endregion

        private void tsl_test_Click(object sender, EventArgs e)
        {
            if (m_loginPre == 1)
            {
                m_loginPre = 0;                        
            } else {
                m_loginPre = 1;     
            }
            treeInit();
        }

        
    }
  
}
