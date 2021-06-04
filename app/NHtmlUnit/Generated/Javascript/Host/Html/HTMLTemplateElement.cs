// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTemplateElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLTemplateElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTemplateElement o) =>
            new HTMLTemplateElement(o));
      }

      public HTMLTemplateElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTemplateElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTemplateElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTemplateElement)WrappedObject; }
      }

      public HTMLTemplateElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTemplateElement()) {}


      public NHtmlUnit.Javascript.Host.Dom.DocumentFragment Content
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DocumentFragment>(
               WObj.getContent());
         }
      }

   }


}
