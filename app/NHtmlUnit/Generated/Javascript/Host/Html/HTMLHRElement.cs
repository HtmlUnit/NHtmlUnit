// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLHRElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLHRElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHRElement o) =>
            new HTMLHRElement(o));
      }

      public HTMLHRElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHRElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHRElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHRElement)WrappedObject; }
      }

      public HTMLHRElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLHRElement()) {}


      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }
   }


}
