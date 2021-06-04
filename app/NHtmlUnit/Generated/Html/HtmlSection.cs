// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlSection : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlSection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlSection o) =>
            new HtmlSection(o));
      }

      public HtmlSection(com.gargoylesoftware.htmlunit.html.HtmlSection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlSection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlSection)WrappedObject; }
      }

   }


}
