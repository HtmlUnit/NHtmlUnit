// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableColElement : NHtmlUnit.Javascript.Host.Html.HTMLTableComponent, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableColElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement o) =>
            new HTMLTableColElement(o));
      }

      public HTMLTableColElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement)WrappedObject; }
      }

      public HTMLTableColElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableColElement()) {}


      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }
// Generating method code for getSpan
      public virtual int GetSpan()
      {
         return WObj.getSpan();
      }

// Generating method code for setSpan
      public virtual void SetSpan(object span)
      {
         WObj.setSpan(span);
      }

   }


}
