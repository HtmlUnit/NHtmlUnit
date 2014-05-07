// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBlockElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBlockElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement o) =>
            new HTMLBlockElement(o));
      }

      public HTMLBlockElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement)WrappedObject; }
      }

      public HTMLBlockElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement()) {}


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
