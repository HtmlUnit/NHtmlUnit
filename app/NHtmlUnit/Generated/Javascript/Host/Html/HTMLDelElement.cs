// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDelElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDelElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement o) =>
            new HTMLDelElement(o));
      }

      public HTMLDelElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement)WrappedObject; }
      }

      public HTMLDelElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDelElement()) {}


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
