// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLabelElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLabelElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement o) =>
            new HTMLLabelElement(o));
      }

      public HTMLLabelElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement)WrappedObject; }
      }

      public HTMLLabelElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement()) {}


      public System.String HtmlFor
      {
         get
         {
            return WObj.getHtmlFor();
         }
         set
         {
            WObj.setHtmlFor(value);
         }

      }
   }


}
