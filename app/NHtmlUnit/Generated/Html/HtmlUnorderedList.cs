// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlUnorderedList : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlUnorderedList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlUnorderedList o) =>
            new HtmlUnorderedList(o));
      }

      public HtmlUnorderedList(com.gargoylesoftware.htmlunit.html.HtmlUnorderedList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlUnorderedList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlUnorderedList)WrappedObject; }
      }


      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
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
