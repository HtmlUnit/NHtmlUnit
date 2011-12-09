// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFrameSetElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFrameSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement o) =>
            new HTMLFrameSetElement(o));
      }

      public HTMLFrameSetElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement)WrappedObject; }
      }

      public HTMLFrameSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement()) {}

// Generating method code for jsxSet_rows
      public virtual void JsxSet_rows(string rows)
      {
         WObj.jsxSet_rows(rows);
      }

// Generating method code for jsxGet_rows
      public virtual string JsxGet_rows()
      {
         return WObj.jsxGet_rows();
      }

// Generating method code for jsxSet_cols
      public virtual void JsxSet_cols(string cols)
      {
         WObj.jsxSet_cols(cols);
      }

// Generating method code for jsxGet_cols
      public virtual string JsxGet_cols()
      {
         return WObj.jsxGet_cols();
      }

// Generating method code for jsxGet_border
      public virtual string JsxGet_border()
      {
         return WObj.jsxGet_border();
      }

// Generating method code for jsxSet_border
      public virtual void JsxSet_border(string border)
      {
         WObj.jsxSet_border(border);
      }

   }


}
