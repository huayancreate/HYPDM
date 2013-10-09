using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace AutoCadPlugins.Common
{
    public class Util
    {
        /// <summary>
        /// 自定义WCF配置
        /// </summary>
        /// <param name="addr">WCF访问地址</param>
        /// <returns></returns>
        public PDMService.IPDMService proxy(string addr)
        {
		//AddressHeader addressHeader1 = AddressHeader.CreateAddressHeader("specialservice1", addr, 1);
		//EndpointIdentity endpointIdentity = EndpointIdentity.CreateUpnIdentity(WindowsIdentity.GetCurrent().Name);
            WSHttpBinding httpBinding = new WSHttpBinding();
            httpBinding.Security.Mode = SecurityMode.None;

            Uri uri = new Uri(addr);
            //EndpointAddress httpAddr = new EndpointAddress(uri, endpointIdentity);
            EndpointAddress httpAddr = new EndpointAddress(uri);
            //利用ChannelFactory创建一个IData的代理对象，指定binding与address，而不用配置文件中的  
            var proxy = new ChannelFactory<PDMService.IPDMService>(httpBinding, httpAddr).CreateChannel();
            return proxy;
        }
    }
}
