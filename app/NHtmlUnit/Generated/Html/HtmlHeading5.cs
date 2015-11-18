// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlHeading5 : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlHeading5()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlHeading5 o) =>
            new HtmlHeading5(o));
      }

      public HtmlHeading5(com.gargoylesoftware.htmlunit.html.HtmlHeading5 wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlHeading5 WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlHeading5)WrappedObject; }
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
