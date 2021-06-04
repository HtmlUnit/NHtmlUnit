// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlLegend : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlLegend()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlLegend o) =>
            new HtmlLegend(o));
      }

      public HtmlLegend(com.gargoylesoftware.htmlunit.html.HtmlLegend wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlLegend WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlLegend)WrappedObject; }
      }


      public System.String AccessKeyAttribute
      {
         get
         {
            return WObj.getAccessKeyAttribute();
         }
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
