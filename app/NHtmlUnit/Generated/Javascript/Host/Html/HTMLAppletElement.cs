// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAppletElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAppletElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement o) =>
            new HTMLAppletElement(o));
      }

      public HTMLAppletElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement)WrappedObject; }
      }

      public HTMLAppletElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement()) {}

// Generating method code for jsxGet_alt
      public virtual string JsxGet_alt()
      {
         return WObj.jsxGet_alt();
      }

// Generating method code for jsxSet_alt
      public virtual void JsxSet_alt(string alt)
      {
         WObj.jsxSet_alt(alt);
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

// Generating method code for jsxGet_align
      public virtual string JsxGet_align()
      {
         return WObj.jsxGet_align();
      }

// Generating method code for jsxSet_align
      public virtual void JsxSet_align(string align)
      {
         WObj.jsxSet_align(align);
      }

   }


}
