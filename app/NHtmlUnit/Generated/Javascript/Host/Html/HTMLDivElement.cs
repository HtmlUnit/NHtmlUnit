// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDivElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLDivElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement o) =>
            new HTMLDivElement(o));
      }

      public HTMLDivElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement)WrappedObject; }
      }

      public HTMLDivElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDivElement()) {}


      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
         }

      }
// Generating method code for isNoWrap
      public virtual bool IsNoWrap()
      {
         return WObj.isNoWrap();
      }

   }


}
