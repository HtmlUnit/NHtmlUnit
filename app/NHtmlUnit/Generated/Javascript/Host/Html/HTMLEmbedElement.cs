// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLEmbedElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLEmbedElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement o) =>
            new HTMLEmbedElement(o));
      }

      public HTMLEmbedElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement)WrappedObject; }
      }

      public HTMLEmbedElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement()) {}

   }


}
