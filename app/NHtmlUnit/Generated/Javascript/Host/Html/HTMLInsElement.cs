// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLInsElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLInsElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInsElement o) =>
            new HTMLInsElement(o));
      }

      public HTMLInsElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInsElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInsElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInsElement)WrappedObject; }
      }

      public HTMLInsElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInsElement()) {}


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
