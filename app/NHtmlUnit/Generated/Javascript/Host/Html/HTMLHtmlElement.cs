// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLHtmlElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLHtmlElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHtmlElement o) =>
            new HTMLHtmlElement(o));
      }

      public HTMLHtmlElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHtmlElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHtmlElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHtmlElement)WrappedObject; }
      }

      public HTMLHtmlElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHtmlElement()) {}


      public System.String Version
      {
         get
         {
            return WObj.getVersion();
         }
         set
         {
            WObj.setVersion(value);
         }

      }
   }


}
