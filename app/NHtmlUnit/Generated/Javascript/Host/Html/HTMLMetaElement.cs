// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMetaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLMetaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement o) =>
            new HTMLMetaElement(o));
      }

      public HTMLMetaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement)WrappedObject; }
      }

      public HTMLMetaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMetaElement()) {}


      public System.String Charset
      {
         get
         {
            return WObj.getCharset();
         }
         set
         {
            WObj.setCharset(value);
         }

      }

      public System.String Content
      {
         get
         {
            return WObj.getContent();
         }
         set
         {
            WObj.setContent(value);
         }

      }

      public System.String HttpEquiv
      {
         get
         {
            return WObj.getHttpEquiv();
         }
         set
         {
            WObj.setHttpEquiv(value);
         }

      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
         set
         {
            WObj.setName(value);
         }

      }

      public System.String Scheme
      {
         get
         {
            return WObj.getScheme();
         }
         set
         {
            WObj.setScheme(value);
         }

      }

      public System.String Url
      {
         get
         {
            return WObj.getUrl();
         }
         set
         {
            WObj.setUrl(value);
         }

      }
   }


}
