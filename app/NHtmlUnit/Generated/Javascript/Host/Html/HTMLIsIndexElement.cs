// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLIsIndexElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLIsIndexElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIsIndexElement o) =>
            new HTMLIsIndexElement(o));
      }

      public HTMLIsIndexElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIsIndexElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIsIndexElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIsIndexElement)WrappedObject; }
      }

      public HTMLIsIndexElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLIsIndexElement()) {}

   }


}
