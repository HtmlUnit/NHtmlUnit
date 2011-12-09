// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableCaptionElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableCaptionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement o) =>
            new HTMLTableCaptionElement(o));
      }

      public HTMLTableCaptionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement)WrappedObject; }
      }

      public HTMLTableCaptionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement()) {}

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

// Generating method code for jsxGet_vAlign
      public virtual string JsxGet_vAlign()
      {
         return WObj.jsxGet_vAlign();
      }

// Generating method code for jsxSet_vAlign
      public virtual void JsxSet_vAlign(object vAlign)
      {
         WObj.jsxSet_vAlign(vAlign);
      }

   }


}
