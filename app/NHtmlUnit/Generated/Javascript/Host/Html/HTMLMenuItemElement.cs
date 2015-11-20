// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMenuItemElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMenuItemElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuItemElement o) =>
            new HTMLMenuItemElement(o));
      }

      public HTMLMenuItemElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuItemElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuItemElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuItemElement)WrappedObject; }
      }

      public HTMLMenuItemElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMenuItemElement()) {}

   }


}
