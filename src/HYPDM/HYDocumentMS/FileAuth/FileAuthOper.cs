using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EAS.Modularization;
using HYDocumentMS;
namespace HYDocumentMS.FileAuth
{
    /// <summary>
    /// 
    /// </summary>
    [Module("{7C8BF2CA-CD71-4394-BE5D-449099ABDC69}", "文档权限设定", "文档权限设定")]
    public partial class FileAuthOper : UserControl
    {


        HYDocumentMS.IFileHelper fileHelper = null;
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
            webBrowser1.Navigate(Application.StartupPath +"\\"+ "文件权限管理V1.0.swf");
            ucPaging1.SourceDataGridView = this.dGVUsers;

        }
        /// <summary>
        /// 初始化事件
        /// </summary>
        private void initial()
        {
            this.dgvRoles.DataSource = new FileHelper().getDataTableBySql("NAME,DESCRIPTION", " WHERE NAME NOT IN ('Administrators','Guests','平台演示')", "EAS_ROLES");
            this.dGVUsers.DataSource = new FileHelper().getDataTableBySql("A.LOGINID,A.ROLENAME,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175')", "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (this.dGVUsers.CurrentRow == null)
            {
                MessageBox.Show("请选择需要设定的群组信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UserFileAuthFrm frm = new UserFileAuthFrm();
                frm.UserAccount = this.dGVUsers.CurrentRow.Cells["LOGINID"].Value.ToString();
                frm.AuthObjectType =  HYPDM.DataType.AuthObjectType.SingleUser;
                frm.ShowDialog();

            }
        }


        private void btnGroupAuth_Click(object sender, EventArgs e)
        {
            if (this.dgvRoles.CurrentRow == null)
            {
                MessageBox.Show("请选择需要设定的群组信息!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                UserFileAuthFrm frm = new UserFileAuthFrm();
                frm.UserRole = this.dgvRoles.CurrentRow.Cells["NAME1"].Value.ToString();
                frm.AuthObjectType = HYPDM.DataType.AuthObjectType.UserRole;
                frm.ShowDialog();
            }
        }

        private void FileAuthOper_Load(object sender, EventArgs e)
        {

        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dgvRoles.CurrentRow.Cells["NAME1"].Value.ToString());
            if (this.dgvRoles.CurrentRow != null)
            {
                this.dgvRoleUsers.DataSource = new FileHelper().getDataTableBySql("A.LOGINID,A.ROLENAME,B.DESCRIPTION,B.ORGANNAME", "WHERE B.ORGANID NOT IN ('7ECC3D03-B80E-4EBC-9DEC-CAE93143321F','7987FC8D-BF40-4A3D-B7CD-588CD6CDD175') AND ROLENAME='" + this.dgvRoles.CurrentRow.Cells["NAME1"].Value.ToString() + "'", "EAS_ACCOUNTGROUPING A LEFT JOIN EAS_ACCOUNTS  B ON A.LOGINID=B.LOGINID");
            }
        }


        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnGroupAuth_Click(sender, new EventArgs());
        }

        private void dGVUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSet_Click(sender, new EventArgs());
        }

    }
}
