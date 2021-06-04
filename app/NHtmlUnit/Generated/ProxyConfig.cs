// Generated class v2.50.0.0, don't modify

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

      public ProxyConfig(string proxyHost, int proxyPort, string proxyScheme, bool isSocks)
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig(proxyHost, proxyPort, proxyScheme, isSocks)) {}

      public ProxyConfig()
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig()) {}

      public ProxyConfig(string proxyHost, int proxyPort, string proxyScheme)
         : this(new com.gargoylesoftware.htmlunit.ProxyConfig(proxyHost, proxyPort, proxyScheme)) {}


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

      public System.String ProxyScheme
      {
         get
         {
            return WObj.getProxyScheme();
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

// Generating method code for getProxyPort
      public virtual int GetProxyPort()
      {
         return WObj.getProxyPort();
      }

// Generating method code for setProxyPort
      public virtual void SetProxyPort(string proxyScheme)
      {
         WObj.setProxyPort(proxyScheme);
      }

   }


}
