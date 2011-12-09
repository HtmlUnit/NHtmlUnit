// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableColElement : NHtmlUnit.Javascript.Host.Html.HTMLTableComponent, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableColElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement o) =>
            new HTMLTableColElement(o));
      }

      public HTMLTableColElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement)WrappedObject; }
      }

      public HTMLTableColElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement()) {}

// Generating method code for jsxGet_span
      public virtual int JsxGet_span()
      {
         return WObj.jsxGet_span();
      }

// Generating method code for jsxSet_span
      public virtual void JsxSet_span(object span)
      {
         WObj.jsxSet_span(span);
      }

// Generating method code for jsxGet_width
      public virtual string JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxSet_width
      public virtual void JsxSet_width(object width)
      {
         WObj.jsxSet_width(width);
      }

   }


}
