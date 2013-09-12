using System;
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
        private IList<EasAccountEntity> accountsList = new List<EasAccountEntity>();
        /// <summary>
        /// 选中的用户或者群组
        /// </summary>
        private List<DataType.UserOrGroupSelected> selectedUserOrGroupList = new List<DataType.UserOrGroupSelected>();

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

        private void InitAccountsList()
        {
            this.accountsList.Clear();
            //  this.accountsList = _accountsService.GetAllAccountsList();

            //  DataTable dtUserRole= CommonFuns.getDataTableBySql("NAME,DESCRIPTION", " WHERE NAME NOT IN ('Administrators','Guests','平台演示')", "EAS_ROLES");
            DataTable dtUser = CommonFuns.getDataTableBySql("A.LOGINID,A.ROLENAME,B.Name,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175')", "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");
            DataTable dtUserGroup = CommonFuns.getDataTableBySql("NAME,DESCRIPTION", " WHERE NAME NOT IN ('Administrators','Guests','平台演示')", "EAS_ROLES");
            foreach (DataRow dr in dtUser.Rows)
            {
                EasAccountEntity userAndRole = new EasAccountEntity();
                userAndRole.LoginID = dr["LOGINID"].ToString();
                userAndRole.RoleName = dr["ROLENAME"].ToString();
                userAndRole.Name = dr["Name"].ToString();
                userAndRole.ObjectType =  DataType.AuthObjectType.SingleUser; //单用户
                accountsList.Add(userAndRole);
            }
            foreach (DataRow dr in dtUserGroup.Rows)
            {
                EasAccountEntity userAndRole = new EasAccountEntity();
                userAndRole.LoginID = dr["NAME"].ToString();
                userAndRole.RoleName = dr["NAME"].ToString();
                userAndRole.Name = dr["NAME"].ToString();
                userAndRole.ObjectType =  DataType.AuthObjectType.UserRole; //用户群组
                accountsList.Add(userAndRole);
            }
            reloadAccountList(this.accountsList, lvNotSelect);
        }

        private void reloadAccountList(IList<EasAccountEntity> accountsList, ListView lv)
        {
            if (this.accountsList.Count != 0)
            {
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
            }
        }

        private void reloadListView(ListView lv)
        {

        }

        #region
        private void btnQuery_Click(object sender, EventArgs e)
        {

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
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            lvSelected.BeginUpdate();
            for (int i = 0; i < lvNotSelect.Items.Count; )
            {
                item = lvNotSelect.Items[i];
                if ((DataType.AuthObjectType)item.Tag ==DataType.AuthObjectType.UserRole)
                {
                    item.ForeColor = Color.Red;
                }
                lvNotSelect.Items.RemoveAt(i);
                lvSelected.Items.Add(item);
             
            }
            lvSelected.EndUpdate();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            ListViewItem item = null;
            lvSelected.BeginUpdate();
            for (int i = 0; i < lvSelected.Items.Count; )
            {
                item = lvSelected.Items[i];
                if (( DataType.AuthObjectType)item.Tag ==  DataType.AuthObjectType.UserRole)
                {
                    item.ForeColor = Color.Red;
                }
                
                lvSelected.Items.RemoveAt(i); //先删除后添加
                lvNotSelect.Items.Add(item);
            }
            lvSelected.EndUpdate();


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
            for (int i = 0; i < lvSelected.Items.Count;i++ )
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
