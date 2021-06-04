// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCanvasElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLCanvasElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement o) =>
            new HTMLCanvasElement(o));
      }

      public HTMLCanvasElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement)WrappedObject; }
      }

      public HTMLCanvasElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCanvasElement()) {}

// Generating method code for getContext
      public virtual object GetContext(string contextId)
      {
         var arg = WObj.getContext(contextId);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for toDataURL
      public virtual string ToDataURL(object type)
      {
         return WObj.toDataURL(type);
      }

   }


}
