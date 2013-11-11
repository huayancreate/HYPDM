using AutoCAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using services = Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Windows;

namespace AutoCadPlugins.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //MessageBox.Show(Common.Util.GetValueForKey("port"));
        }

        WcfClient.pdmService.IPDMService client = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            //client = WcfClient.CommonUntils.proxy("192.168.0.8", "8000");
            client = Common.Util.Service;
            WcfClient.pdmService.ResultObject obj = client.Login(txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            if (obj.AckResult)
            {
                if (DialogResult.OK == MessageBox.Show("用户登录成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    Common.Util.UserName = txtUserName.Text.Trim();
                    //COM方式获取AutoCAD应用程序对象
                    AcadApplication acadApp = (AcadApplication)services.Application.AcadApplication;
                    var menuCount = acadApp.MenuGroups.Item(0).Menus.Item(0).Count;
                    for (int i = 0; i < menuCount; i++)
                    {
                        acadApp.MenuGroups.Item(0).Menus.Item(0).Item(i).Enable = true;
                    }
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(obj.ErrMessage);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
