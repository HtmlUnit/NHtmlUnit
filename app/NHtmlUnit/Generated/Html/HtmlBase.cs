// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlBase : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlBase()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlBase o) =>
            new HtmlBase(o));
      }

      public HtmlBase(com.gargoylesoftware.htmlunit.html.HtmlBase wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlBase WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlBase)WrappedObject; }
      }


      public System.String HrefAttribute
      {
         get
         {
            return WObj.getHrefAttribute();
         }
      }

      public System.String TargetAttribute
      {
         get
         {
            return WObj.getTargetAttribute();
         }
      }
   }


}
