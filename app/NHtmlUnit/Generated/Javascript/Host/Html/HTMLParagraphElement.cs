// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLParagraphElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLParagraphElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement o) =>
            new HTMLParagraphElement(o));
      }

      public HTMLParagraphElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement)WrappedObject; }
      }

      public HTMLParagraphElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParagraphElement()) {}


      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
         }

      }
   }


}
