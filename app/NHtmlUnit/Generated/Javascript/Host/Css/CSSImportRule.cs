// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSImportRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSImportRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSImportRule o) =>
            new CSSImportRule(o));
      }

      public CSSImportRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSImportRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSImportRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSImportRule)WrappedObject; }
      }

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxGet_media
      public virtual NHtmlUnit.Javascript.Host.MediaList JsxGet_media()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.MediaList>(WObj.jsxGet_media());
      }

// Generating method code for jsxGet_styleSheet
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleSheet JsxGet_styleSheet()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(WObj.jsxGet_styleSheet());
      }

   }


}
