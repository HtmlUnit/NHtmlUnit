// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLModElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLModElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLModElement o) =>
            new HTMLModElement(o));
      }

      public HTMLModElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLModElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLModElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLModElement)WrappedObject; }
      }

      public HTMLModElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLModElement()) {}


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
