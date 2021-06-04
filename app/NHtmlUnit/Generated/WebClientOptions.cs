// Generated class v2.50.0.0, don't modify

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


      public System.Int32 HistorySizeLimit
      {
         get
         {
            return WObj.getHistorySizeLimit();
         }
         set
         {
            WObj.setHistorySizeLimit(value);
         }

      }

      public System.Int32 HistoryPageCacheLimit
      {
         get
         {
            return WObj.getHistoryPageCacheLimit();
         }
         set
         {
            WObj.setHistoryPageCacheLimit(value);
         }

      }

      public System.String[] SSLClientProtocols
      {
         get
         {
            return WObj.getSSLClientProtocols();
         }
         set
         {
            WObj.setSSLClientProtocols(value);
         }

      }

      public System.String[] SSLClientCipherSuites
      {
         get
         {
            return WObj.getSSLClientCipherSuites();
         }
         set
         {
            WObj.setSSLClientCipherSuites(value);
         }

      }

      public java.security.KeyStore SSLClientCertificateStore
      {
         get
         {
            return WObj.getSSLClientCertificateStore();
         }
      }

      public java.security.KeyStore SSLTrustStore
      {
         get
         {
            return WObj.getSSLTrustStore();
         }
      }

      public System.Char[] SSLClientCertificatePassword
      {
         get
         {
            return WObj.getSSLClientCertificatePassword();
         }
      }

      public System.String SSLInsecureProtocol
      {
         get
         {
            return WObj.getSSLInsecureProtocol();
         }
         set
         {
            WObj.setSSLInsecureProtocol(value);
         }

      }

      public java.net.InetAddress LocalAddress
      {
         get
         {
            return WObj.getLocalAddress();
         }
         set
         {
            WObj.setLocalAddress(value);
         }

      }

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


      public System.Int64 ConnectionTimeToLive
      {
         get
         {
            return WObj.getConnectionTimeToLive();
         }
         set
         {
            WObj.setConnectionTimeToLive(value);
         }

      }

      public System.Int32 MaxInMemory
      {
         get
         {
            return WObj.getMaxInMemory();
         }
         set
         {
            WObj.setMaxInMemory(value);
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

      public System.Int32 ScreenHeight
      {
         get
         {
            return WObj.getScreenHeight();
         }
         set
         {
            WObj.setScreenHeight(value);
         }

      }

      public System.Int32 ScreenWidth
      {
         get
         {
            return WObj.getScreenWidth();
         }
         set
         {
            WObj.setScreenWidth(value);
         }

      }

      public System.Int32 WebSocketMaxBinaryMessageSize
      {
         get
         {
            return WObj.getWebSocketMaxBinaryMessageSize();
         }
         set
         {
            WObj.setWebSocketMaxBinaryMessageSize(value);
         }

      }

      public System.Int32 WebSocketMaxBinaryMessageBufferSize
      {
         get
         {
            return WObj.getWebSocketMaxBinaryMessageBufferSize();
         }
         set
         {
            WObj.setWebSocketMaxBinaryMessageBufferSize(value);
         }

      }

      public System.Int32 WebSocketMaxTextMessageSize
      {
         get
         {
            return WObj.getWebSocketMaxTextMessageSize();
         }
         set
         {
            WObj.setWebSocketMaxTextMessageSize(value);
         }

      }

      public System.Int32 WebSocketMaxTextMessageBufferSize
      {
         get
         {
            return WObj.getWebSocketMaxTextMessageBufferSize();
         }
         set
         {
            WObj.setWebSocketMaxTextMessageBufferSize(value);
         }

      }
// Generating method code for isUseInsecureSSL
      public virtual bool IsUseInsecureSSL()
      {
         return WObj.isUseInsecureSSL();
      }

// Generating method code for isCssEnabled
      public virtual bool IsCssEnabled()
      {
         return WObj.isCssEnabled();
      }

// Generating method code for isDownloadImages
      public virtual bool IsDownloadImages()
      {
         return WObj.isDownloadImages();
      }

// Generating method code for isAppletEnabled
      public virtual bool IsAppletEnabled()
      {
         return WObj.isAppletEnabled();
      }

// Generating method code for isDoNotTrackEnabled
      public virtual bool IsDoNotTrackEnabled()
      {
         return WObj.isDoNotTrackEnabled();
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

// Generating method code for isWebSocketEnabled
      public virtual bool IsWebSocketEnabled()
      {
         return WObj.isWebSocketEnabled();
      }

// Generating method code for isThrowExceptionOnScriptError
      public virtual bool IsThrowExceptionOnScriptError()
      {
         return WObj.isThrowExceptionOnScriptError();
      }

// Generating method code for isPrintContentOnFailingStatusCode
      public virtual bool IsPrintContentOnFailingStatusCode()
      {
         return WObj.isPrintContentOnFailingStatusCode();
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

// Generating method code for isJavaScriptEnabled
      public virtual bool IsJavaScriptEnabled()
      {
         return WObj.isJavaScriptEnabled();
      }

// Generating method code for setSSLClientCertificate
      public virtual void SetSSLClientCertificate(java.io.InputStream certificateInputStream, string certificatePassword, string certificateType)
      {
         WObj.setSSLClientCertificate(certificateInputStream, certificatePassword, certificateType);
      }

// Generating method code for setSSLClientCertificate
      public virtual void SetSSLClientCertificate(java.net.URL certificateUrl, string certificatePassword, string certificateType)
      {
         WObj.setSSLClientCertificate(certificateUrl, certificatePassword, certificateType);
      }

// Generating method code for setSSLTrustStore
      public virtual void SetSSLTrustStore(java.net.URL sslTrustStoreUrl, string sslTrustStorePassword, string sslTrustStoreType)
      {
         WObj.setSSLTrustStore(sslTrustStoreUrl, sslTrustStorePassword, sslTrustStoreType);
      }

   }


}
