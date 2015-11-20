// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLListElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLListElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement o) =>
            new HTMLListElement(o));
      }

      public HTMLListElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement)WrappedObject; }
      }

      public HTMLListElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLListElement()) {}

// Generating method code for getCompact
      public virtual bool GetCompact()
      {
         return WObj.getCompact();
      }

// Generating method code for setCompact
      public virtual void SetCompact(object compact)
      {
         WObj.setCompact(compact);
      }

   }


}
