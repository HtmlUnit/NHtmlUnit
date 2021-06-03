// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDataListElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLDataListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataListElement o) =>
            new HTMLDataListElement(o));
      }

      public HTMLDataListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataListElement)WrappedObject; }
      }

      public HTMLDataListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDataListElement()) {}


      public System.Object Options
      {
         get
         {
            return WObj.getOptions();
         }
      }
   }


}
