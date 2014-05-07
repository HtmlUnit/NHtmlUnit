// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptGroupElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLOptGroupElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptGroupElement o) =>
            new HTMLOptGroupElement(o));
      }

      public HTMLOptGroupElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptGroupElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptGroupElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptGroupElement)WrappedObject; }
      }

      public HTMLOptGroupElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptGroupElement()) {}


      public System.String Label
      {
         get
         {
            return WObj.getLabel();
         }
         set
         {
            WObj.setLabel(value);
         }

      }
   }


}
