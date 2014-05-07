// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHeading6 : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlHeading6()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHeading6 o) =>
            new HtmlHeading6(o));
      }

      public HtmlHeading6(com.gargoylesoftware.htmlunit.html.HtmlHeading6 wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHeading6 WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHeading6)WrappedObject; }
      }


      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }
   }


}
