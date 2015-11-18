// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTextElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTextElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextElement o) =>
            new HTMLTextElement(o));
      }

      public HTMLTextElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextElement)WrappedObject; }
      }

      public HTMLTextElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextElement()) {}

   }


}
