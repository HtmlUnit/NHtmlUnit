// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHeading4 : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlHeading4()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHeading4 o) =>
            new HtmlHeading4(o));
      }

      public HtmlHeading4(com.gargoylesoftware.htmlunit.html.HtmlHeading4 wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHeading4 WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHeading4)WrappedObject; }
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
