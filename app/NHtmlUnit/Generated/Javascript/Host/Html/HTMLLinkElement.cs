// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLinkElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLLinkElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement o) =>
            new HTMLLinkElement(o));
      }

      public HTMLLinkElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement)WrappedObject; }
      }

      public HTMLLinkElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLinkElement()) {}


      public System.String Href
      {
         get
         {
            return WObj.getHref();
         }
         set
         {
            WObj.setHref(value);
         }

      }

      public System.String Rel
      {
         get
         {
            return WObj.getRel();
         }
         set
         {
            WObj.setRel(value);
         }

      }

      public System.String Rev
      {
         get
         {
            return WObj.getRev();
         }
         set
         {
            WObj.setRev(value);
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

      public NHtmlUnit.Javascript.Host.Css.CSSStyleSheet Sheet
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleSheet>(
               WObj.getSheet());
         }
      }

   }


}
