// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLLabelElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLLabelElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement o) =>
            new HTMLLabelElement(o));
      }

      public HTMLLabelElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement)WrappedObject; }
      }

      public HTMLLabelElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLLabelElement()) {}


      public System.String HtmlFor
      {
         get
         {
            return WObj.getHtmlFor();
         }
         set
         {
            WObj.setHtmlFor(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Html.HTMLElement Control
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(
               WObj.getControl());
         }
         set
         {
            WObj.setControl((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)value.WrappedObject);
         }

      }

   }


}
