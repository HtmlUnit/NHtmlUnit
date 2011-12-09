// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDivElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDivElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement o) =>
            new HTMLDivElement(o));
      }

      public HTMLDivElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement)WrappedObject; }
      }

      public HTMLDivElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement()) {}

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
