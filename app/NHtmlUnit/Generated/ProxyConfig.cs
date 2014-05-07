// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class ProxyConfig : ObjectWrapper
   {
      static ProxyConfig()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.ProxyConfig o) =>
            new ProxyConfig(o));
      }

      public ProxyConfig(com.gargoylesoftware.htmlunit.ProxyConfig wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.ProxyConfig WObj
      {
         get { return (com.gargoylesoftware.htmlunit.ProxyConfig)WrappedObject; }
      }

      public ProxyConfig(string proxyHost, int proxyPort)
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig(proxyHost, proxyPort)) {}

      public ProxyConfig(string proxyHost, int proxyPort, bool isSocks)
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig(proxyHost, proxyPort, isSocks)) {}

      public ProxyConfig()
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig()) {}


      public System.String ProxyHost
      {
         get
         {
            return WObj.getProxyHost();
         }
         set
         {
            WObj.setProxyHost(value);
         }

      }

      public System.Int32 ProxyPort
      {
         get
         {
            return WObj.getProxyPort();
         }
         set
         {
            WObj.setProxyPort(value);
         }

      }

      public System.String ProxyAutoConfigUrl
      {
         get
         {
            return WObj.getProxyAutoConfigUrl();
         }
         set
         {
            WObj.setProxyAutoConfigUrl(value);
         }

      }
// Generating method code for isSocksProxy
      public virtual bool IsSocksProxy()
      {
         return WObj.isSocksProxy();
      }

// Generating method code for addHostsToProxyBypass
      public virtual void AddHostsToProxyBypass(string pattern)
      {
         WObj.addHostsToProxyBypass(pattern);
      }

// Generating method code for removeHostsFromProxyBypass
      public virtual void RemoveHostsFromProxyBypass(string pattern)
      {
         WObj.removeHostsFromProxyBypass(pattern);
      }

   }


}
