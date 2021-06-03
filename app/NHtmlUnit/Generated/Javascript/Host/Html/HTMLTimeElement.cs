// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTimeElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLTimeElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTimeElement o) =>
            new HTMLTimeElement(o));
      }

      public HTMLTimeElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTimeElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTimeElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTimeElement)WrappedObject; }
      }

      public HTMLTimeElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTimeElement()) {}


      public System.String DateTime
      {
         get
         {
            return WObj.getDateTime();
         }
         set
         {
            WObj.setDateTime(value);
         }

      }
   }


}
