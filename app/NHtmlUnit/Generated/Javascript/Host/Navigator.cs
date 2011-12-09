// Generated class v4, don't modify

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

// Generating method code for jsxGet_appCodeName
      public virtual string JsxGet_appCodeName()
      {
         return WObj.jsxGet_appCodeName();
      }

// Generating method code for jsxGet_appMinorVersion
      public virtual string JsxGet_appMinorVersion()
      {
         return WObj.jsxGet_appMinorVersion();
      }

// Generating method code for jsxGet_appName
      public virtual string JsxGet_appName()
      {
         return WObj.jsxGet_appName();
      }

// Generating method code for jsxGet_appVersion
      public virtual string JsxGet_appVersion()
      {
         return WObj.jsxGet_appVersion();
      }

// Generating method code for jsxGet_browserLanguage
      public virtual string JsxGet_browserLanguage()
      {
         return WObj.jsxGet_browserLanguage();
      }

// Generating method code for jsxGet_language
      public virtual string JsxGet_language()
      {
         return WObj.jsxGet_language();
      }

// Generating method code for jsxGet_cookieEnabled
      public virtual bool JsxGet_cookieEnabled()
      {
         return WObj.jsxGet_cookieEnabled();
      }

// Generating method code for jsxGet_cpuClass
      public virtual string JsxGet_cpuClass()
      {
         return WObj.jsxGet_cpuClass();
      }

// Generating method code for jsxGet_onLine
      public virtual bool JsxGet_onLine()
      {
         return WObj.jsxGet_onLine();
      }

// Generating method code for jsxGet_platform
      public virtual string JsxGet_platform()
      {
         return WObj.jsxGet_platform();
      }

// Generating method code for jsxGet_product
      public virtual string JsxGet_product()
      {
         return WObj.jsxGet_product();
      }

// Generating method code for jsxGet_productSub
      public virtual string JsxGet_productSub()
      {
         return WObj.jsxGet_productSub();
      }

// Generating method code for jsxGet_systemLanguage
      public virtual string JsxGet_systemLanguage()
      {
         return WObj.jsxGet_systemLanguage();
      }

// Generating method code for jsxGet_userAgent
      public virtual string JsxGet_userAgent()
      {
         return WObj.jsxGet_userAgent();
      }

// Generating method code for jsxGet_userLanguage
      public virtual string JsxGet_userLanguage()
      {
         return WObj.jsxGet_userLanguage();
      }

// Generating method code for jsxGet_plugins
      public virtual object JsxGet_plugins()
      {
         return WObj.jsxGet_plugins();
      }

// Generating method code for jsxGet_mimeTypes
      public virtual object JsxGet_mimeTypes()
      {
         return WObj.jsxGet_mimeTypes();
      }

// Generating method code for jsxFunction_javaEnabled
      public virtual bool JsxFunction_javaEnabled()
      {
         return WObj.jsxFunction_javaEnabled();
      }

// Generating method code for jsxFunction_taintEnabled
      public virtual bool JsxFunction_taintEnabled()
      {
         return WObj.jsxFunction_taintEnabled();
      }

   }


}
