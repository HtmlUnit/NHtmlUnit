// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlDivision : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlDivision()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlDivision o) =>
            new HtmlDivision(o));
      }

      public HtmlDivision(com.gargoylesoftware.htmlunit.html.HtmlDivision wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlDivision WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlDivision)WrappedObject; }
      }

      public HtmlDivision(string namespaceURI, string qualifiedName, NHtmlUnit.SgmlPage page, java.util.Map attributes)
         : this(new com.gargoylesoftware.htmlunit.html.HtmlDivision(namespaceURI, qualifiedName, (com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, attributes)) {}


      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }
   }


}
