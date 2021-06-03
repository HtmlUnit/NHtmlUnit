// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOListElement : NHtmlUnit.Javascript.Host.Html.HTMLListElement
   {
      static HTMLOListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOListElement o) =>
            new HTMLOListElement(o));
      }

      public HTMLOListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOListElement)WrappedObject; }
      }

      public HTMLOListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOListElement()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
         }

      }
   }


}
