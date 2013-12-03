// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlMenu : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlMenu()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlMenu o) =>
            new HtmlMenu(o));
      }

      public HtmlMenu(com.gargoylesoftware.htmlunit.html.HtmlMenu wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlMenu WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlMenu)WrappedObject; }
      }


      public System.String CompactAttribute
      {
         get
         {
            return WObj.getCompactAttribute();
         }
      }
   }


}
