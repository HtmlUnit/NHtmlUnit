// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class BrowserVersion : ObjectWrapper
   {
      static BrowserVersion()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.BrowserVersion o) =>
            new BrowserVersion(o));
      }

      public BrowserVersion(com.gargoylesoftware.htmlunit.BrowserVersion wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.BrowserVersion WObj
      {
         get { return (com.gargoylesoftware.htmlunit.BrowserVersion)WrappedObject; }
      }

      public BrowserVersion(string applicationName, string applicationVersion, string userAgent, System.Single browserVersionNumeric)
         : this(new com.gargoylesoftware.htmlunit.BrowserVersion(applicationName, applicationVersion, userAgent, browserVersionNumeric)) {}

      public BrowserVersion(string applicationName, string applicationVersion, string userAgent, System.Single browserVersionNumeric, com.gargoylesoftware.htmlunit.BrowserVersionFeatures[] features)
         : this(new com.gargoylesoftware.htmlunit.BrowserVersion(applicationName, applicationVersion, userAgent, browserVersionNumeric, features)) {}


      public System.Single BrowserVersionNumeric
      {
         get
         {
            return WObj.getBrowserVersionNumeric();
         }
      }

      public System.String ApplicationVersion
      {
         get
         {
            return WObj.getApplicationVersion();
         }
         set
         {
            WObj.setApplicationVersion(value);
         }

      }

      public System.String Nickname
      {
         get
         {
            return WObj.getNickname();
         }
      }

      public System.String ApplicationName
      {
         get
         {
            return WObj.getApplicationName();
         }
         set
         {
            WObj.setApplicationName(value);
         }

      }

      public System.String UserAgent
      {
         get
         {
            return WObj.getUserAgent();
         }
         set
         {
            WObj.setUserAgent(value);
         }

      }

      public System.String ApplicationCodeName
      {
         get
         {
            return WObj.getApplicationCodeName();
         }
         set
         {
            WObj.setApplicationCodeName(value);
         }

      }

      public System.String ApplicationMinorVersion
      {
         get
         {
            return WObj.getApplicationMinorVersion();
         }
         set
         {
            WObj.setApplicationMinorVersion(value);
         }

      }

      public System.String Vendor
      {
         get
         {
            return WObj.getVendor();
         }
         set
         {
            WObj.setVendor(value);
         }

      }

      public System.String BrowserLanguage
      {
         get
         {
            return WObj.getBrowserLanguage();
         }
         set
         {
            WObj.setBrowserLanguage(value);
         }

      }

      public System.String CpuClass
      {
         get
         {
            return WObj.getCpuClass();
         }
         set
         {
            WObj.setCpuClass(value);
         }

      }

      public System.String Platform
      {
         get
         {
            return WObj.getPlatform();
         }
         set
         {
            WObj.setPlatform(value);
         }

      }

      public System.String SystemLanguage
      {
         get
         {
            return WObj.getSystemLanguage();
         }
         set
         {
            WObj.setSystemLanguage(value);
         }

      }

      public System.String UserLanguage
      {
         get
         {
            return WObj.getUserLanguage();
         }
         set
         {
            WObj.setUserLanguage(value);
         }

      }

      public System.String BuildId
      {
         get
         {
            return WObj.getBuildId();
         }
      }

      public System.String HtmlAcceptHeader
      {
         get
         {
            return WObj.getHtmlAcceptHeader();
         }
         set
         {
            WObj.setHtmlAcceptHeader(value);
         }

      }

      public System.String ImgAcceptHeader
      {
         get
         {
            return WObj.getImgAcceptHeader();
         }
         set
         {
            WObj.setImgAcceptHeader(value);
         }

      }

      public System.String CssAcceptHeader
      {
         get
         {
            return WObj.getCssAcceptHeader();
         }
         set
         {
            WObj.setCssAcceptHeader(value);
         }

      }

      public System.String ScriptAcceptHeader
      {
         get
         {
            return WObj.getScriptAcceptHeader();
         }
         set
         {
            WObj.setScriptAcceptHeader(value);
         }

      }

      public System.String XmlHttpRequestAcceptHeader
      {
         get
         {
            return WObj.getXmlHttpRequestAcceptHeader();
         }
         set
         {
            WObj.setXmlHttpRequestAcceptHeader(value);
         }

      }

      public System.String[] HeaderNamesOrdered
      {
         get
         {
            return WObj.getHeaderNamesOrdered();
         }
         set
         {
            WObj.setHeaderNamesOrdered(value);
         }

      }

      public ICollection<NHtmlUnit.PluginConfiguration> Plugins
      {
         get
         {
            return new CollectionWrapper<NHtmlUnit.PluginConfiguration>(
               WObj.getPlugins());
         }
       }
// Generating method code for isIE
      public virtual bool IsIE()
      {
         return WObj.isIE();
      }

// Generating method code for isFirefox
      public virtual bool IsFirefox()
      {
         return WObj.isFirefox();
      }

// Generating method code for isEdge
      public virtual bool IsEdge()
      {
         return WObj.isEdge();
      }

// Generating method code for hasFeature
      public virtual bool HasFeature(NHtmlUnit.BrowserVersionFeatures property)
      {
         return WObj.hasFeature((com.gargoylesoftware.htmlunit.BrowserVersionFeatures)property.WrappedObject);
      }

// Generating method code for isOnLine
      public virtual bool IsOnLine()
      {
         return WObj.isOnLine();
      }

// Generating method code for clone
      public virtual NHtmlUnit.BrowserVersion Clone()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(WObj.clone());
      }

// Generating method code for isChrome
      public virtual bool IsChrome()
      {
         return WObj.isChrome();
      }

   }


}
