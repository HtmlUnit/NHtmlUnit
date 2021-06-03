// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFontElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLFontElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement o) =>
            new HTMLFontElement(o));
      }

      public HTMLFontElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement)WrappedObject; }
      }

      public HTMLFontElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFontElement()) {}


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
