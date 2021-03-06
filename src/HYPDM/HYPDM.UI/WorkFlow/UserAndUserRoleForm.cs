﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HYPDM.Entities;
using HYPDM.BLL;
using EAS.Services;
using HYPDM.BaseControl;
namespace HYPDM.WinUI.WorkFlow
{
    public partial class UserAndUserRoleForm : Form
    {
        //  IAccountsService _accountsService = ServiceContainer.GetService<AccountsService>();
        private IList<EasAccountEntity> accountsUnSelectedList = new List<EasAccountEntity>();
        private IList<EasAccountEntity> accountsOldSelectedList = new List<EasAccountEntity>();
        /// <summary>
        /// 选中的用户或者群组
        /// </summary>
        private List<DataType.UserOrGroupSelected> selectedUserOrGroupList = new List<DataType.UserOrGroupSelected>();
        /// <summary>
        /// 标示该节点已经选择的用户信息
        /// </summary>
        private List<DataType.UserOrGroupSelected> oldSelectedUserList = new List<DataType.UserOrGroupSelected>();

        public List<DataType.UserOrGroupSelected> OldSelectedUserList
        {
            get { return oldSelectedUserList; }
            set { oldSelectedUserList = value; }
        }
        public List<DataType.UserOrGroupSelected> SelectedUserOrGroupList
        {
            get { return selectedUserOrGroupList; }
            set { selectedUserOrGroupList = value; }
        }

        public UserAndUserRoleForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void UserAndUserRoleForm_Load(object sender, EventArgs e)
        {
            InitAccountsList();
            
        }

        StringBuilder stbOldSelected = null;
        private void InitAccountsList()
        {
            this.accountsUnSelectedList.Clear();
            this.accountsOldSelectedList.Clear();
            //  this.accountsList = _accountsService.GetAllAccountsList();

            //  DataTable dtUserRole= CommonFuns.getDataTableBySql("NAME,DESCRIPTION", " WHERE NAME NOT IN ('Administrators','Guests','平台演示')", "EAS_ROLES");

            if (this.OldSelectedUserList == null || this.OldSelectedUserList.Count == 0)
            {

            }
            else
            {
                stbOldSelected = new StringBuilder("(");
                foreach (DataType.UserOrGroupSelected it in this.OldSelectedUserList)
                {
                    stbOldSelected.Append("'" + it.Value + "'").Append(",");
                }
                stbOldSelected.Remove(stbOldSelected.Length - 1, 1).Append(")");
            }
            DataTable dtUnSelectedUsers;
            DataTable dtOldSelectedUsers;
            if (stbOldSelected == null || stbOldSelected.ToString() == "")
            {
                dtUnSelectedUsers = CommonFuns.getDataTableBySql("A.LOGINID,A.ROLENAME,B.Name,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175') ", "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");

                //未选择的用户
                foreach (DataRow dr in dtUnSelectedUsers.Rows)
                {
                    EasAccountEntity userAndRole = new EasAccountEntity();
                    userAndRole.LoginID = dr["LOGINID"].ToString();
                    userAndRole.RoleName = dr["ROLENAME"].ToString();
                    userAndRole.Name = dr["Name"].ToString();
                    userAndRole.ObjectType = DataType.AuthObjectType.SingleUser; //单用户
                    accountsUnSelectedList.Add(userAndRole);
                }
                reloadAccountList(this.accountsUnSelectedList, lvNotSelect);

                // dtOldSelectedUsers = new DataTable();
            }
            else
            {
                dtUnSelectedUsers = CommonFuns.getDataTableBySql("A.LOGINID,A.ROLENAME,B.Name,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175') AND A.LOGINID NOT IN " + stbOldSelected.ToString(), "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");
                dtOldSelectedUsers = CommonFuns.getDataTableBySql("A.LOGINID,A.ROLENAME,B.Name,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175') AND A.LOGINID  IN " + stbOldSelected.ToString(), "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");

                //未选择的用户
                foreach (DataRow dr in dtUnSelectedUsers.Rows)
                {
                    EasAccountEntity userAndRole = new EasAccountEntity();
                    userAndRole.LoginID = dr["LOGINID"].ToString();
                    userAndRole.RoleName = dr["ROLENAME"].ToString();
                    userAndRole.Name = dr["Name"].ToString();
                    userAndRole.ObjectType = DataType.AuthObjectType.SingleUser; //单用户
                    accountsUnSelectedList.Add(userAndRole);
                }

                ///已经选择了的用户
                foreach (DataRow dr in dtOldSelectedUsers.Rows)
                {
                    EasAccountEntity userAndRole = new EasAccountEntity();
                    userAndRole.LoginID = dr["LOGINID"].ToString();
                    userAndRole.RoleName = dr["ROLENAME"].ToString();
                    userAndRole.Name = dr["Name"].ToString();
                    userAndRole.ObjectType = DataType.AuthObjectType.SingleUser; //单用户
                    accountsOldSelectedList.Add(userAndRole);
                }
                reloadAccountList(this.accountsUnSelectedList, lvNotSelect);
                reloadAccountList(this.accountsOldSelectedList, lvSelected);
            }
            newSelectItemList();
            ///用户群组信息，暂时去掉
            // DataTable dtUserGroup = CommonFuns.getDataTableBySql("NAME,DESCRIPTION", " WHERE NAME NOT IN ('Administrators','Guests','平台演示')", "EAS_ROLES");


            ///用户群组信息，暂时去掉
            //foreach (DataRow dr in dtUserGroup.Rows)
            //{
            //    EasAccountEntity userAndRole = new EasAccountEntity();
            //    userAndRole.LoginID = dr["NAME"].ToString();
            //    userAndRole.RoleName = dr["NAME"].ToString();
            //    userAndRole.Name = dr["NAME"].ToString();
            //    userAndRole.ObjectType = DataType.AuthObjectType.UserRole; //用户群组
            //    accountsList.Add(userAndRole);
            //}

        }

        private void reloadAccountList(IList<EasAccountEntity> accountsList, ListView lv)
        {
            //if (this.accountsUnSelectedList.Count != 0)
            //{
                EasAccountEntity account = null;

                // 添加数据项 
                lv.BeginUpdate();
                for (int i = 0; i < accountsList.Count; i++)
                {
                    account = accountsList[i];
                    ListViewItem lvi = new ListViewItem(account.Name, i);


                    if (account.ObjectType == DataType.AuthObjectType.UserRole)
                    {
                        //lvi.SubItems.Add(account.RoleName + "【群组】");
                        //FontStyle style=new FontStyle();
                        //Font font = new System.Drawing.Font("宋体", 9,style);
                        // font.Underline = true;
                        // lvi.SubItems.Add("【群组】", Color.Black, Color.Red, font);
                        lvi.SubItems.Add("【群组】");
                        lvi.ForeColor = Color.Red;
                    }
                    else
                    {
                        //lvi.SubItems.Add(account.RoleName + "【单用户】");
                        lvi.SubItems.Add("【用户】");
                    }
                    lvi.SubItems.Add(account.LoginID);
                    lvi.Tag = account.ObjectType; //存放类型
                    lv.Items.Add(lvi);
                }
                lv.EndUpdate();
            //}
        }

        private void reloadListView(ListView lv)
        {

        }

        #region
        private ListView m_unSelcetList=new ListView();
        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.lvNotSelect.Items.Clear();
            string[] t =new string[4];
            ListViewItem sourceLvi = null;
            ListViewItem targetLvi = null;
            String str = this.txtName.Text;
            for (int i = 0; i < m_unSelcetList.Items.Count; i++)     // 此处lvSelected.SelectedItems.Count每循环一次减1,因此无须 i++
            {
                sourceLvi = m_unSelcetList.Items[i];

                String temp = sourceLvi.SubItems[0].Text;
                if (temp.Contains(str)) {
                    targetLvi = new ListViewItem(sourceLvi.SubItems[0].Text, i);
                    targetLvi.SubItems.Add(sourceLvi.SubItems[1].Text);
                    targetLvi.SubItems.Add(sourceLvi.SubItems[2].Text);
                    if ((DataType.AuthObjectType)sourceLvi.Tag == DataType.AuthObjectType.UserRole)
                    {
                        targetLvi.ForeColor = Color.Red;
                    }
                    targetLvi.Tag = sourceLvi.Tag;
                    lvNotSelect.Items.Add(targetLvi);
                }
            }
            
        }

        private void newSelectItemList() {
            ListViewItem sourceLvi = null;
            ListViewItem targetLvi = null;
            m_unSelcetList.Items.Clear();
            for (int i = 0; i < lvNotSelect.Items.Count; i++)     // 此处lvSelected.SelectedItems.Count每循环一次减1,因此无须 i++
            {
                sourceLvi = lvNotSelect.Items[i];
                targetLvi = new ListViewItem(sourceLvi.SubItems[0].Text, i);
                targetLvi.SubItems.Add(sourceLvi.SubItems[1].Text);
                targetLvi.SubItems.Add(sourceLvi.SubItems[2].Text);
                if ((DataType.AuthObjectType)sourceLvi.Tag == DataType.AuthObjectType.UserRole)
                {
                    targetLvi.ForeColor = Color.Red;
                }
                targetLvi.Tag = sourceLvi.Tag;
                m_unSelcetList.Items.Add(targetLvi);
            }
        }
        // 删除ListView中被选中的Item
        public void delListViewItems(ListView listView)
        {
            for (int i = 0; i < listView.SelectedItems.Count; )     // 此处lvSelected.SelectedItems.Count每循环一次减1,因此无须 i++
            {
                listView.Items.RemoveAt(listView.SelectedItems[i].Index);
            }
        }

        // 向ListView中添加被选中的Item
        public void addListViewItems(ListView source, ListView target)
        {
            ListViewItem sourceLvi = null;
            ListViewItem targetLvi = null;
            for (int i = 0; i < source.SelectedItems.Count; i++)
            {
                sourceLvi = source.SelectedItems[i];
                targetLvi = new ListViewItem(sourceLvi.SubItems[0].Text, i);
                targetLvi.SubItems.Add(sourceLvi.SubItems[1].Text);
                targetLvi.SubItems.Add(sourceLvi.SubItems[2].Text);
                if ((DataType.AuthObjectType)sourceLvi.Tag == DataType.AuthObjectType.UserRole)
                {
                    targetLvi.ForeColor = Color.Red;
                }
                targetLvi.Tag = sourceLvi.Tag;
                target.Items.Add(targetLvi);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 修改lvSelected
            lvSelected.BeginUpdate();
            addListViewItems(lvNotSelect, lvSelected);
            lvSelected.EndUpdate();

            // 修改lvNotSelecet
            lvNotSelect.BeginUpdate();
            delListViewItems(lvNotSelect);
            //delListViewItems(lvNotSelect);

            lvNotSelect.EndUpdate();
            newSelectItemList();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            // 先把选中的Item添加回lvNotSelect
            lvNotSelect.BeginUpdate();
            addListViewItems(lvSelected, lvNotSelect);
            lvNotSelect.EndUpdate();

            // 删除lvSelected中被选中的ListView.Items
            lvSelected.BeginUpdate();
            for (int i = 0; i < lvSelected.SelectedItems.Count; )   // 此处lvSelected.SelectedItems.Count每循环一次减1,因此无须 i++
            {
                lvSelected.Items.RemoveAt(lvSelected.SelectedItems[i].Index);
            }
            lvSelected.EndUpdate();
            newSelectItemList();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            lvSelected.BeginUpdate();
            for (int i = 0; i < lvNotSelect.Items.Count; )
            {
                item = lvNotSelect.Items[i];
                if ((DataType.AuthObjectType)item.Tag == DataType.AuthObjectType.UserRole)
                {
                    item.ForeColor = Color.Red;
                }
                lvNotSelect.Items.RemoveAt(i);
                lvSelected.Items.Add(item);

            }
            lvSelected.EndUpdate();
            newSelectItemList();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            lvSelected.BeginUpdate();
            for (int i = 0; i < lvSelected.Items.Count; )
            {
                item = lvSelected.Items[i];
                if ((DataType.AuthObjectType)item.Tag == DataType.AuthObjectType.UserRole)
                {
                    item.ForeColor = Color.Red;
                }

                lvSelected.Items.RemoveAt(i); //先删除后添加
                lvNotSelect.Items.Add(item);
            }
            lvSelected.EndUpdate();
            newSelectItemList();

            //lvNotSelect.BeginUpdate();
            //for (int i = 0; i < lvNotSelect.Items.Count; )
            //{
            //    //lvNotSelect.Items.Add(
            //}
            //lvNotSelect.EndUpdate();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataType.UserOrGroupSelected item = new DataType.UserOrGroupSelected();
            for (int i = 0; i < lvSelected.Items.Count; i++)
            {
                ListViewItem selItem = lvSelected.Items[i];
                //if(( DataType.AuthObjectType)selItem.Tag== DataType.AuthObjectType.UserRole)
                item.ObjectType = (DataType.AuthObjectType)selItem.Tag;
                item.Value = selItem.SubItems[2].Text.ToString();
                selectedUserOrGroupList.Add(item);
            }
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        private void lvNotSelecet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSelectedIndexChanged(lvNotSelect);
        }

        private void lvSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSelectedIndexChanged(lvSelected);
        }

        private void lvSelectedIndexChanged(ListView lv)
        {
            foreach (ListViewItem item in lv.Items)
            {
                if (item.Selected == true)
                {
                    item.BackColor = Color.Silver;
                    //item.SubItems[0].BackColor = Color.Silver;
                    //item.SubItems[1].BackColor = Color.Silver;
                }
                else
                {
                    item.BackColor = lv.BackColor;
                }
            }
        }

        public class EasAccountEntity
        {
            private string loginID;

            public string LoginID
            {
                get { return loginID; }
                set { loginID = value; }
            }
            private string roleName;

            public string RoleName
            {
                get { return roleName; }
                set { roleName = value; }
            }
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            /// <summary>
            /// 说明是单用户还是群组用户
            /// </summary>
            private DataType.AuthObjectType objectType;
            /// <summary>
            /// 说明是单用户还是群组用户
            /// </summary>
            public DataType.AuthObjectType ObjectType
            {
                get { return objectType; }
                set { objectType = value; }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
