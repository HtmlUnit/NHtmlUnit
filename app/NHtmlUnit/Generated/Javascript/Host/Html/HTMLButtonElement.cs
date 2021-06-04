// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLButtonElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLButtonElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement o) =>
            new HTMLButtonElement(o));
      }

      public HTMLButtonElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement)WrappedObject; }
      }

      public HTMLButtonElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLButtonElement()) {}


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

      public NHtmlUnit.Javascript.Host.Dom.AbstractList Labels
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.AbstractList>(
               WObj.getLabels());
         }
      }

// Generating method code for createTextRange
      public virtual NHtmlUnit.Javascript.Host.Dom.TextRange CreateTextRange()
      {
         var arg = WObj.createTextRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.TextRange>(arg);
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

   }


}
