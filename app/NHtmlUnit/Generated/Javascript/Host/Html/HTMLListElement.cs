// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLListElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement o) =>
            new HTMLListElement(o));
      }

      public HTMLListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement)WrappedObject; }
      }

      public HTMLListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement()) {}

// Generating method code for jsxGet_compact
      public virtual bool JsxGet_compact()
      {
         return WObj.jsxGet_compact();
      }

// Generating method code for jsxSet_compact
      public virtual void JsxSet_compact(object compact)
      {
         WObj.jsxSet_compact(compact);
      }

   }


}
