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

namespace AutoCadPlugins.Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //定义绑定与服务地址 
            Common.Util util = new Common.Util();
            PDMService.IPDMService s = util.proxy("http://192.168.0.8:8000/");
            //调用SayHello方法并关闭连接 
            PDMService.ResultObject obj = s.Login("PDM", "PDM");
            if (obj.AckResult)
            {
                MessageBox.Show("OK");
            }
            ((IChannel)s).Close();
        }
    }
}
