// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDTElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDTElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDTElement o) =>
            new HTMLDTElement(o));
      }

      public HTMLDTElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDTElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDTElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDTElement)WrappedObject; }
      }

      public HTMLDTElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDTElement()) {}

   }


}
