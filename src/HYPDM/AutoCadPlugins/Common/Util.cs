using HYPDM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WcfClient.pdmService;

namespace AutoCadPlugins.Common
{
    public static class Util
    {
        /// <summary>
        /// 自定义WCF配置
        /// </summary>
        /// <param name="addr">WCF访问地址</param>
        /// <returns></returns>
        //public static PDMService.IPDMService proxy(string addr)
        //{
        //    //AddressHeader addressHeader1 = AddressHeader.CreateAddressHeader("specialservice1", addr, 1);
        //    //EndpointIdentity endpointIdentity = EndpointIdentity.CreateUpnIdentity(WindowsIdentity.GetCurrent().Name);
        //    WSHttpBinding httpBinding = new WSHttpBinding();
        //    httpBinding.Security.Mode = SecurityMode.None;

        //    Uri uri = new Uri(addr);
        //    //EndpointAddress httpAddr = new EndpointAddress(uri, endpointIdentity);
        //    EndpointAddress httpAddr = new EndpointAddress(uri);
        //    //利用ChannelFactory创建一个IData的代理对象，指定binding与address，而不用配置文件中的  
        //    var proxy = new ChannelFactory<PDMService.IPDMService>(httpBinding, httpAddr).CreateChannel();
        //    return proxy;
        //}

        private static string userName;

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static IPDMService Service
        {
            get
            {
                return WcfClient.CommonUntils.proxy("192.168.0.8", "8000");
            }
        }

        public static string GetValueForKey(string appKey)
        {
            string activeXForm = Directory.GetCurrentDirectory() + @"\cadSetting.config";
            XmlDocument doc = new XmlDocument();
            doc.Load(activeXForm);
            XmlNode node = doc.SelectSingleNode(@"//add[@key='" + appKey + "']");
            XmlElement ele = (XmlElement)node;
            if (node != null)
            {
                return ele.GetAttribute("value");
            }
            return null;
        }

        public static WcfClient.ParamsEntity paramsEntity(PDM_DRAWING obj)
        {
            WcfClient.ParamsEntity entity = new WcfClient.ParamsEntity();
            entity.WcfAddr = "192.168.0.8";
            entity.WcfPort = "8000";
            entity.SockServerIP = "192.168.0.8";
            entity.Port1 = 2005;
            entity.Port2 = 2006;
            entity.Port3 = 2007;
            entity.LoginID = UserName;
            entity.PdmDrawObj = obj;
            return entity;
        }
    }
}
