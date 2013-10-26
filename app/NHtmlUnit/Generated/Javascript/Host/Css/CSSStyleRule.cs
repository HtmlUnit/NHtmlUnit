// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSStyleRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSStyleRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule o) =>
            new CSSStyleRule(o));
      }

      public CSSStyleRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleRule)WrappedObject; }
      }


      public System.String SelectorText
      {
         get
         {
            return WObj.getSelectorText();
         }
         set
         {
            WObj.setSelectorText(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration Style
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(
               WObj.getStyle());
         }
      }

   }


}
