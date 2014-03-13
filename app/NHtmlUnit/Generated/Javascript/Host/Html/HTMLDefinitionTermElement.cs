// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDefinitionTermElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDefinitionTermElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionTermElement o) =>
            new HTMLDefinitionTermElement(o));
      }

      public HTMLDefinitionTermElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionTermElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionTermElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionTermElement)WrappedObject; }
      }

      public HTMLDefinitionTermElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionTermElement()) {}


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
