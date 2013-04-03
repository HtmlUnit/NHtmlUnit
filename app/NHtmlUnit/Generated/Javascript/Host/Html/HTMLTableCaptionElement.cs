// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableCaptionElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableCaptionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement o) =>
            new HTMLTableCaptionElement(o));
      }

      public HTMLTableCaptionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement)WrappedObject; }
      }

      public HTMLTableCaptionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCaptionElement()) {}


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
// Generating method code for getVAlign
      public virtual string GetVAlign()
      {
         return WObj.getVAlign();
      }

// Generating method code for setVAlign
      public virtual void SetVAlign(object vAlign)
      {
         WObj.setVAlign(vAlign);
      }

   }


}
