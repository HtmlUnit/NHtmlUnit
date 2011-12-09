// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFieldSetElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFieldSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement o) =>
            new HTMLFieldSetElement(o));
      }

      public HTMLFieldSetElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement)WrappedObject; }
      }

      public HTMLFieldSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement()) {}

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
