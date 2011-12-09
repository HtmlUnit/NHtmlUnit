// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLParagraphElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLParagraphElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement o) =>
            new HTMLParagraphElement(o));
      }

      public HTMLParagraphElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement)WrappedObject; }
      }

      public HTMLParagraphElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement()) {}

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
