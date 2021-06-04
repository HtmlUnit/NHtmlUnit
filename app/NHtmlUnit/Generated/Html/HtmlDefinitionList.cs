// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlDefinitionList : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlDefinitionList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlDefinitionList o) =>
            new HtmlDefinitionList(o));
      }

      public HtmlDefinitionList(com.gargoylesoftware.htmlunit.html.HtmlDefinitionList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlDefinitionList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlDefinitionList)WrappedObject; }
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
