// Generated class v5, don't modify

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


      public System.String Href
      {
         get
         {
            return WObj.getHref();
         }
      }

      public NHtmlUnit.Javascript.Host.MediaList Media
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.MediaList>(
               WObj.getMedia());
         }
      }


      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet StyleSheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getStyleSheet());
         }
      }

   }


}
