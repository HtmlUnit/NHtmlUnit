// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBaseElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBaseElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement o) =>
            new HTMLBaseElement(o));
      }

      public HTMLBaseElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement)WrappedObject; }
      }

      public HTMLBaseElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseElement()) {}


      public System.String Href
      {
         get
         {
            return WObj.getHref();
         }
         set
         {
            WObj.setHref(value);
         }

      }

      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
         set
         {
            WObj.setTarget(value);
         }

      }
   }


}
