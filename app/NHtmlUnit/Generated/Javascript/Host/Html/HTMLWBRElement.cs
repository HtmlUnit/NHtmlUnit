// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLWBRElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLWBRElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLWBRElement o) =>
            new HTMLWBRElement(o));
      }

      public HTMLWBRElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLWBRElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLWBRElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLWBRElement)WrappedObject; }
      }

      public HTMLWBRElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLWBRElement()) {}

   }


}
