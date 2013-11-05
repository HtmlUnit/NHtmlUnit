// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLScriptElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLScriptElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement o) =>
            new HTMLScriptElement(o));
      }

      public HTMLScriptElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement)WrappedObject; }
      }

      public HTMLScriptElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLScriptElement()) {}


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

      public System.Object Onreadystatechange
      {
         get
         {
            return WObj.getOnreadystatechange();
         }
         set
         {
            WObj.setOnreadystatechange(value);
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

      public System.String ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }
   }


}
