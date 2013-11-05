// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebClientOptions : ObjectWrapper
   {
      static WebClientOptions()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebClientOptions o) =>
            new WebClientOptions(o));
      }

      public WebClientOptions(com.gargoylesoftware.htmlunit.WebClientOptions wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebClientOptions WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebClientOptions)WrappedObject; }
      }

      public WebClientOptions()
         : this(new com.gargoylesoftware.htmlunit.WebClientOptions()) {}


      public System.Int32 Timeout
      {
         get
         {
            return WObj.getTimeout();
         }
         set
         {
            WObj.setTimeout(value);
         }

      }

      public System.String HomePage
      {
         get
         {
            return WObj.getHomePage();
         }
         set
         {
            WObj.setHomePage(value);
         }

      }

      public NHtmlUnit.ProxyConfig ProxyConfig
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.ProxyConfig>(
               WObj.getProxyConfig());
         }
         set
         {
            WObj.setProxyConfig((com.gargoylesoftware.htmlunit.ProxyConfig)value.WrappedObject);
         }

      }


      public System.Boolean PrintContentOnFailingStatusCode
      {
         get
         {
            return WObj.getPrintContentOnFailingStatusCode();
         }
         set
         {
            WObj.setPrintContentOnFailingStatusCode(value);
         }

      }
// Generating method code for isCssEnabled
      public virtual bool IsCssEnabled()
      {
         return WObj.isCssEnabled();
      }

// Generating method code for isJavaScriptEnabled
      public virtual bool IsJavaScriptEnabled()
      {
         return WObj.isJavaScriptEnabled();
      }

// Generating method code for isAppletEnabled
      public virtual bool IsAppletEnabled()
      {
         return WObj.isAppletEnabled();
      }

// Generating method code for isUseInsecureSSL
      public virtual bool IsUseInsecureSSL()
      {
         return WObj.isUseInsecureSSL();
      }

// Generating method code for isDoNotTrackEnabled
      public virtual bool IsDoNotTrackEnabled()
      {
         return WObj.isDoNotTrackEnabled();
      }

// Generating method code for setSSLClientCertificate
      public virtual void SetSSLClientCertificate(java.net.URL certificateUrl, string certificatePassword, string certificateType)
      {
         WObj.setSSLClientCertificate(certificateUrl, certificatePassword, certificateType);
      }

// Generating method code for isActiveXNative
      public virtual bool IsActiveXNative()
      {
         return WObj.isActiveXNative();
      }

// Generating method code for isGeolocationEnabled
      public virtual bool IsGeolocationEnabled()
      {
         return WObj.isGeolocationEnabled();
      }

// Generating method code for isPopupBlockerEnabled
      public virtual bool IsPopupBlockerEnabled()
      {
         return WObj.isPopupBlockerEnabled();
      }

// Generating method code for isThrowExceptionOnScriptError
      public virtual bool IsThrowExceptionOnScriptError()
      {
         return WObj.isThrowExceptionOnScriptError();
      }

// Generating method code for isThrowExceptionOnFailingStatusCode
      public virtual bool IsThrowExceptionOnFailingStatusCode()
      {
         return WObj.isThrowExceptionOnFailingStatusCode();
      }

// Generating method code for isRedirectEnabled
      public virtual bool IsRedirectEnabled()
      {
         return WObj.isRedirectEnabled();
      }

   }


}
