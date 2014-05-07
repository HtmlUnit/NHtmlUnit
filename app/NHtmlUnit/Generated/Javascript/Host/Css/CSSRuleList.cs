// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSRuleList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CSSRuleList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList o) =>
            new CSSRuleList(o));
      }

      public CSSRuleList(com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList)WrappedObject; }
      }

      public CSSRuleList(NHtmlUnit.Javascript.Host.Css.CSSStyleSheet stylesheet)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSRuleList((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)stylesheet.WrappedObject)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
      }

   }


}
