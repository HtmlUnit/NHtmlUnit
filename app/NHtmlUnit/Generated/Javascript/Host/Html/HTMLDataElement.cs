// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDataElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDataElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataElement o) =>
            new HTMLDataElement(o));
      }

      public HTMLDataElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataElement)WrappedObject; }
      }

      public HTMLDataElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataElement()) {}

   }


}
