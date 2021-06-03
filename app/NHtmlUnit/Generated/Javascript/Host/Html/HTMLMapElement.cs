// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMapElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLMapElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMapElement o) =>
            new HTMLMapElement(o));
      }

      public HTMLMapElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMapElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMapElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMapElement)WrappedObject; }
      }

      public HTMLMapElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMapElement()) {}


      public NHtmlUnit.Javascript.Host.Html.HTMLCollection Areas
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getAreas());
         }
      }

   }


}
