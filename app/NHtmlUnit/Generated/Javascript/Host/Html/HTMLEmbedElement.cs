// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLEmbedElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLEmbedElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement o) =>
            new HTMLEmbedElement(o));
      }

      public HTMLEmbedElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement)WrappedObject; }
      }

      public HTMLEmbedElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLEmbedElement()) {}


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

      public System.String HeightString
      {
         get
         {
            return WObj.getHeightString();
         }
         set
         {
            WObj.setHeightString(value);
         }

      }

      public System.String WidthString
      {
         get
         {
            return WObj.getWidthString();
         }
         set
         {
            WObj.setWidthString(value);
         }

      }
   }


}
