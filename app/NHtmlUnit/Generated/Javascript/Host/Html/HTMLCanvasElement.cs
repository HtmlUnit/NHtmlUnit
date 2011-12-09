// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCanvasElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLCanvasElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement o) =>
            new HTMLCanvasElement(o));
      }

      public HTMLCanvasElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement)WrappedObject; }
      }

      public HTMLCanvasElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement()) {}

// Generating method code for jsxGet_width
      public virtual int JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxSet_width
      public virtual void JsxSet_width(string width)
      {
         WObj.jsxSet_width(width);
      }

// Generating method code for jsxGet_height
      public virtual int JsxGet_height()
      {
         return WObj.jsxGet_height();
      }

// Generating method code for jsxSet_height
      public virtual void JsxSet_height(string height)
      {
         WObj.jsxSet_height(height);
      }

// Generating method code for jsxFunction_getContext
      public virtual object JsxFunction_getContext(string contextId)
      {
         return WObj.jsxFunction_getContext(contextId);
      }

// Generating method code for jsxFunction_toDataURL
      public virtual string JsxFunction_toDataURL(string type)
      {
         return WObj.jsxFunction_toDataURL(type);
      }

   }


}
