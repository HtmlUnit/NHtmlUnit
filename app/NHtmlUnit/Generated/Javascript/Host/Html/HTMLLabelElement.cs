// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLabelElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLabelElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement o) =>
            new HTMLLabelElement(o));
      }

      public HTMLLabelElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement)WrappedObject; }
      }

      public HTMLLabelElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement()) {}

// Generating method code for jsxGet_htmlFor
      public virtual string JsxGet_htmlFor()
      {
         return WObj.jsxGet_htmlFor();
      }

// Generating method code for jsxSet_htmlFor
      public virtual void JsxSet_htmlFor(string id)
      {
         WObj.jsxSet_htmlFor(id);
      }

   }


}
