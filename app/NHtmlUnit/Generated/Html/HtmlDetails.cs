// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlDetails : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlDetails()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlDetails o) =>
            new HtmlDetails(o));
      }

      public HtmlDetails(com.gargoylesoftware.htmlunit.html.HtmlDetails wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlDetails WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlDetails)WrappedObject; }
      }

// Generating method code for isOpen
      public virtual bool IsOpen()
      {
         return WObj.isOpen();
      }

   }


}
