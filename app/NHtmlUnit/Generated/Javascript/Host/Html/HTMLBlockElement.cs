// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLBlockElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLBlockElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement o) =>
            new HTMLBlockElement(o));
      }

      public HTMLBlockElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement)WrappedObject; }
      }

      public HTMLBlockElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLBlockElement()) {}


      public System.String Cite
      {
         get
         {
            return WObj.getCite();
         }
         set
         {
            WObj.setCite(value);
         }

      }

      public System.String DateTime
      {
         get
         {
            return WObj.getDateTime();
         }
         set
         {
            WObj.setDateTime(value);
         }

      }

      public System.String Clear
      {
         get
         {
            return WObj.getClear();
         }
         set
         {
            WObj.setClear(value);
         }

      }

      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }
   }


}
