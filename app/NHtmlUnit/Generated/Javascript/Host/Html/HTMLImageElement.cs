// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLImageElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLImageElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement o) =>
            new HTMLImageElement(o));
      }

      public HTMLImageElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement)WrappedObject; }
      }

      public HTMLImageElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLImageElement()) {}


      public System.String Src
      {
         get
         {
            return WObj.getSrc();
         }
         set
         {
            WObj.setSrc(value);
         }

      }

      public System.Object Onload
      {
         get
         {
            return WObj.getOnload();
         }
         set
         {
            WObj.setOnload(value);
         }

      }

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
// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

   }


}
