// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMediaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMediaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMediaElement o) =>
            new HTMLMediaElement(o));
      }

      public HTMLMediaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMediaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMediaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMediaElement)WrappedObject; }
      }

      public HTMLMediaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMediaElement()) {}

// Generating method code for canPlayType
      public virtual string CanPlayType(string type)
      {
         return WObj.canPlayType(type);
      }

   }


}
