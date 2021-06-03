// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlAttributeChangeEvent : ObjectWrapper
   {
      static HtmlAttributeChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent o) =>
            new HtmlAttributeChangeEvent(o));
      }

      public HtmlAttributeChangeEvent(com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent)WrappedObject; }
      }

      public HtmlAttributeChangeEvent(NHtmlUnit.Html.HtmlElement element, string name, string value)
         : this(new com.gargoylesoftware.htmlunit.html.HtmlAttributeChangeEvent((com.gargoylesoftware.htmlunit.html.HtmlElement)element.WrappedObject, name, value)) {}


      public NHtmlUnit.Html.HtmlElement HtmlElement
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlElement>(
               WObj.getHtmlElement());
         }
      }


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
      }
   }


}
