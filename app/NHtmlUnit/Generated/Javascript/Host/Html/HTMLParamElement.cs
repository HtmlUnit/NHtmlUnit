// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLParamElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLParamElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement o) =>
            new HTMLParamElement(o));
      }

      public HTMLParamElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement)WrappedObject; }
      }

      public HTMLParamElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLParamElement()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }

      public System.String ValueType
      {
         get
         {
            return WObj.getValueType();
         }
      }
   }


}
