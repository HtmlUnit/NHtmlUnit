// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMenuElement : NHtmlUnit.Javascript.Host.Html.HTMLListElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMenuElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuElement o) =>
            new HTMLMenuElement(o));
      }

      public HTMLMenuElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuElement)WrappedObject; }
      }

      public HTMLMenuElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuElement()) {}

   }


}
