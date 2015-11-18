// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableDataCellElement : NHtmlUnit.Javascript.Host.Html.HTMLTableCellElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableDataCellElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableDataCellElement o) =>
            new HTMLTableDataCellElement(o));
      }

      public HTMLTableDataCellElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableDataCellElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableDataCellElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableDataCellElement)WrappedObject; }
      }

      public HTMLTableDataCellElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableDataCellElement()) {}

   }


}
