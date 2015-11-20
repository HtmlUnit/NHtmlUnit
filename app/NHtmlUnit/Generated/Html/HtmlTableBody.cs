// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlTableBody : NHtmlUnit.Html.TableRowGroup, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlTableBody()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlTableBody o) =>
            new HtmlTableBody(o));
      }

      public HtmlTableBody(com.gargoylesoftware.htmlunit.html.HtmlTableBody wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlTableBody WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlTableBody)WrappedObject; }
      }

   }


}
