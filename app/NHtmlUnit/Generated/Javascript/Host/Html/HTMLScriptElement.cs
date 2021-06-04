// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLScriptElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
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

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
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
// Generating method code for isAsync
      public virtual bool IsAsync()
      {
         return WObj.isAsync();
      }

   }


}
