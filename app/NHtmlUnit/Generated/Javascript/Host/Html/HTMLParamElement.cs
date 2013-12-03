// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLParamElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLParamElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement o) =>
            new HTMLParamElement(o));
      }

      public HTMLParamElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement)WrappedObject; }
      }

      public HTMLParamElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement()) {}

   }


}
