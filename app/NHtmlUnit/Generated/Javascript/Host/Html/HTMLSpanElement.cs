// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSpanElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLSpanElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpanElement o) =>
            new HTMLSpanElement(o));
      }

      public HTMLSpanElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpanElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpanElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpanElement)WrappedObject; }
      }

      public HTMLSpanElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSpanElement()) {}


      public System.String Cite
      {
         get
         {
            return WObj.getCite();
         }
         set
         {
            WObj.setCite(value);
         }

      }

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
