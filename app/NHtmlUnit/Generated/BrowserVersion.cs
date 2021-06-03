// Generated class v2.50.0.0, don't modify

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


      public System.String Nickname
      {
         get
         {
            return WObj.getNickname();
         }
      }

      public System.Int32 BrowserVersionNumeric
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
      }

      public System.String UserAgent
      {
         get
         {
            return WObj.getUserAgent();
         }
      }

      public System.String ApplicationName
      {
         get
         {
            return WObj.getApplicationName();
         }
      }

      public System.String ApplicationCodeName
      {
         get
         {
            return WObj.getApplicationCodeName();
         }
      }

      public System.String ApplicationMinorVersion
      {
         get
         {
            return WObj.getApplicationMinorVersion();
         }
      }

      public System.String Vendor
      {
         get
         {
            return WObj.getVendor();
         }
      }

      public System.String BrowserLanguage
      {
         get
         {
            return WObj.getBrowserLanguage();
         }
      }

      public System.String CpuClass
      {
         get
         {
            return WObj.getCpuClass();
         }
      }

      public System.String Platform
      {
         get
         {
            return WObj.getPlatform();
         }
      }

      public System.String SystemLanguage
      {
         get
         {
            return WObj.getSystemLanguage();
         }
      }

      public java.util.TimeZone SystemTimezone
      {
         get
         {
            return WObj.getSystemTimezone();
         }
      }

      public System.String UserLanguage
      {
         get
         {
            return WObj.getUserLanguage();
         }
      }

      public System.String BuildId
      {
         get
         {
            return WObj.getBuildId();
         }
      }

      public System.String ProductSub
      {
         get
         {
            return WObj.getProductSub();
         }
      }

      public System.String AcceptEncodingHeader
      {
         get
         {
            return WObj.getAcceptEncodingHeader();
         }
      }

      public System.String AcceptLanguageHeader
      {
         get
         {
            return WObj.getAcceptLanguageHeader();
         }
      }

      public System.String HtmlAcceptHeader
      {
         get
         {
            return WObj.getHtmlAcceptHeader();
         }
      }

      public System.String ImgAcceptHeader
      {
         get
         {
            return WObj.getImgAcceptHeader();
         }
      }

      public System.String CssAcceptHeader
      {
         get
         {
            return WObj.getCssAcceptHeader();
         }
      }

      public System.String ScriptAcceptHeader
      {
         get
         {
            return WObj.getScriptAcceptHeader();
         }
      }

      public System.String XmlHttpRequestAcceptHeader
      {
         get
         {
            return WObj.getXmlHttpRequestAcceptHeader();
         }
      }

      public System.String[] HeaderNamesOrdered
      {
         get
         {
            return WObj.getHeaderNamesOrdered();
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

      public System.Int32 PixesPerChar
      {
         get
         {
            return WObj.getPixesPerChar();
         }
      }
// Generating method code for isChrome
      public virtual bool IsChrome()
      {
         return WObj.isChrome();
      }

// Generating method code for isEdge
      public virtual bool IsEdge()
      {
         return WObj.isEdge();
      }

// Generating method code for isIE
      public virtual bool IsIE()
      {
         return WObj.isIE();
      }

// Generating method code for isFirefox78
      public virtual bool IsFirefox78()
      {
         return WObj.isFirefox78();
      }

// Generating method code for isFirefox
      public virtual bool IsFirefox()
      {
         return WObj.isFirefox();
      }

// Generating method code for isOnLine
      public virtual bool IsOnLine()
      {
         return WObj.isOnLine();
      }

// Generating method code for registerUploadMimeType
      public virtual void RegisterUploadMimeType(string fileExtension, string mimeType)
      {
         WObj.registerUploadMimeType(fileExtension, mimeType);
      }

// Generating method code for hasFeature
      public virtual bool HasFeature(NHtmlUnit.BrowserVersionFeatures property)
      {
         return WObj.hasFeature((com.gargoylesoftware.htmlunit.BrowserVersionFeatures)property.WrappedObject);
      }

// Generating method code for getUploadMimeType
      public virtual string GetUploadMimeType(java.io.File file)
      {
         return WObj.getUploadMimeType(file);
      }

// Generating method code for getFontHeight
      public virtual int GetFontHeight(string fontSize)
      {
         return WObj.getFontHeight(fontSize);
      }

   }


}
