// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Navigator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Navigator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Navigator o) =>
            new Navigator(o));
      }

      public Navigator(com.gargoylesoftware.htmlunit.javascript.host.Navigator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Navigator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Navigator)WrappedObject; }
      }

      public Navigator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Navigator()) {}


      public System.Boolean CookieEnabled
      {
         get
         {
            return WObj.getCookieEnabled();
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

      public System.String UserLanguage
      {
         get
         {
            return WObj.getUserLanguage();
         }
      }

      public System.String AppCodeName
      {
         get
         {
            return WObj.getAppCodeName();
         }
      }

      public System.String AppMinorVersion
      {
         get
         {
            return WObj.getAppMinorVersion();
         }
      }

      public System.String AppName
      {
         get
         {
            return WObj.getAppName();
         }
      }

      public System.String AppVersion
      {
         get
         {
            return WObj.getAppVersion();
         }
      }

      public System.String BrowserLanguage
      {
         get
         {
            return WObj.getBrowserLanguage();
         }
      }

      public System.String Language
      {
         get
         {
            return WObj.getLanguage();
         }
      }

      public System.Boolean OnLine
      {
         get
         {
            return WObj.getOnLine();
         }
      }

      public System.String Product
      {
         get
         {
            return WObj.getProduct();
         }
      }

      public System.String ProductSub
      {
         get
         {
            return WObj.getProductSub();
         }
      }

      public System.String UserAgent
      {
         get
         {
            return WObj.getUserAgent();
         }
      }

      public System.Object Plugins
      {
         get
         {
            return WObj.getPlugins();
         }
      }

      public System.Object MimeTypes
      {
         get
         {
            return WObj.getMimeTypes();
         }
      }

      public NHtmlUnit.Javascript.Host.Geo.Geolocation Geolocation
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Geo.Geolocation>(
               WObj.getGeolocation());
         }
      }


      public System.String BuildID
      {
         get
         {
            return WObj.getBuildID();
         }
      }

      public System.String Vendor
      {
         get
         {
            return WObj.getVendor();
         }
      }

      public System.String VendorSub
      {
         get
         {
            return WObj.getVendorSub();
         }
      }

      public System.String DoNotTrack
      {
         get
         {
            return WObj.getDoNotTrack();
         }
      }

      public System.String MsDoNotTrack
      {
         get
         {
            return WObj.getMsDoNotTrack();
         }
      }

      public System.String Oscpu
      {
         get
         {
            return WObj.getOscpu();
         }
      }
// Generating method code for javaEnabled
      public virtual bool JavaEnabled()
      {
         return WObj.javaEnabled();
      }

// Generating method code for taintEnabled
      public virtual bool TaintEnabled()
      {
         return WObj.taintEnabled();
      }

   }


}
