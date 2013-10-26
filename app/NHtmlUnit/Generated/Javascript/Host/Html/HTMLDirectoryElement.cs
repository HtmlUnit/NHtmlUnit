// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDirectoryElement : NHtmlUnit.Javascript.Host.Html.HTMLListElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDirectoryElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDirectoryElement o) =>
            new HTMLDirectoryElement(o));
      }

      public HTMLDirectoryElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDirectoryElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDirectoryElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDirectoryElement)WrappedObject; }
      }

      public HTMLDirectoryElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDirectoryElement()) {}

   }


}
