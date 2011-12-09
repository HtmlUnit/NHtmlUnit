// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLPreElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLPreElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement o) =>
            new HTMLPreElement(o));
      }

      public HTMLPreElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement)WrappedObject; }
      }

      public HTMLPreElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPreElement()) {}

// Generating method code for jsxGet_cite
      public virtual string JsxGet_cite()
      {
         return WObj.jsxGet_cite();
      }

// Generating method code for jsxSet_cite
      public virtual void JsxSet_cite(string cite)
      {
         WObj.jsxSet_cite(cite);
      }

   }


}
