// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableHeaderCellElement : NHtmlUnit.Javascript.Host.Html.HTMLTableCellElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableHeaderCellElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableHeaderCellElement o) =>
            new HTMLTableHeaderCellElement(o));
      }

      public HTMLTableHeaderCellElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableHeaderCellElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableHeaderCellElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableHeaderCellElement)WrappedObject; }
      }

      public HTMLTableHeaderCellElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableHeaderCellElement()) {}

   }


}
