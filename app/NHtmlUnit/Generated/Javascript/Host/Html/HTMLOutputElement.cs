// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOutputElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLOutputElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement o) =>
            new HTMLOutputElement(o));
      }

      public HTMLOutputElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement)WrappedObject; }
      }

      public HTMLOutputElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOutputElement()) {}


      public NHtmlUnit.Javascript.Host.Dom.AbstractList Labels
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.AbstractList>(
               WObj.getLabels());
         }
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

   }


}
