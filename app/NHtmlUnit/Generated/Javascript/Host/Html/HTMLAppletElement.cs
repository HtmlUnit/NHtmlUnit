// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAppletElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAppletElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement o) =>
            new HTMLAppletElement(o));
      }

      public HTMLAppletElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement)WrappedObject; }
      }

      public HTMLAppletElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAppletElement()) {}


      public System.String Alt
      {
         get
         {
            return WObj.getAlt();
         }
         set
         {
            WObj.setAlt(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }

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
