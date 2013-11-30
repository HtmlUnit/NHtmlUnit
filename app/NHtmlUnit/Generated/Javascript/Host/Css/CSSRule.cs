// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSRule : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule o) =>
            new CSSRule(o));
      }

      public CSSRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSRule)WrappedObject; }
      }


      public System.Int16 Type
      {
         get
         {
            return WObj.getType();
         }
      }

      public System.String CssText
      {
         get
         {
            return WObj.getCssText();
         }
         set
         {
            WObj.setCssText(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet ParentStyleSheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getParentStyleSheet());
         }
      }


      public NHtmlUnit.Javascript.Host.Css.CSSRule ParentRule
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSRule>(
               WObj.getParentRule());
         }
      }

   }


}
