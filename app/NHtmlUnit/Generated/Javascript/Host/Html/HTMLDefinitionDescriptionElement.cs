// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDefinitionDescriptionElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLDefinitionDescriptionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionDescriptionElement o) =>
            new HTMLDefinitionDescriptionElement(o));
      }

      public HTMLDefinitionDescriptionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionDescriptionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionDescriptionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionDescriptionElement)WrappedObject; }
      }

      public HTMLDefinitionDescriptionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDefinitionDescriptionElement()) {}


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
