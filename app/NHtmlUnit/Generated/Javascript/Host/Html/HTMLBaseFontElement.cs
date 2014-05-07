// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBaseFontElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLBaseFontElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseFontElement o) =>
            new HTMLBaseFontElement(o));
      }

      public HTMLBaseFontElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseFontElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseFontElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseFontElement)WrappedObject; }
      }

      public HTMLBaseFontElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBaseFontElement()) {}


      public System.String Color
      {
         get
         {
            return WObj.getColor();
         }
         set
         {
            WObj.setColor(value);
         }

      }

      public System.String Face
      {
         get
         {
            return WObj.getFace();
         }
         set
         {
            WObj.setFace(value);
         }

      }

      public System.Int32 Size
      {
         get
         {
            return WObj.getSize();
         }
         set
         {
            WObj.setSize(value);
         }

      }
   }


}
