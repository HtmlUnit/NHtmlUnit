// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlMap : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlMap o) =>
            new HtmlMap(o));
      }

      public HtmlMap(com.gargoylesoftware.htmlunit.html.HtmlMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlMap)WrappedObject; }
      }


      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }
   }


}
