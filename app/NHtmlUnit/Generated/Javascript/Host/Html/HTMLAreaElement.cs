// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAreaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAreaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement o) =>
            new HTMLAreaElement(o));
      }

      public HTMLAreaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement)WrappedObject; }
      }

      public HTMLAreaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAreaElement()) {}


      public System.String Alt
      {
         get
         {
            return WObj.getAlt();
         }
         set
         {
            WObj.setAlt(value);
         }

      }
   }


}
