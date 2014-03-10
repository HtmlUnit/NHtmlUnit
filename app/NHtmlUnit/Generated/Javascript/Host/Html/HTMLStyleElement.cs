// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLStyleElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLStyleElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement o) =>
            new HTMLStyleElement(o));
      }

      public HTMLStyleElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement)WrappedObject; }
      }

      public HTMLStyleElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLStyleElement()) {}


      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet Sheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getSheet());
         }
      }


      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet StyleSheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getStyleSheet());
         }
      }


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
         }

      }

      public System.String Media
      {
         get
         {
            return WObj.getMedia();
         }
      }
   }


}
