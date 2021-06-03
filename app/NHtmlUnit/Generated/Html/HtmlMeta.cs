// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlMeta : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement
   {
      static HtmlMeta()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlMeta o) =>
            new HtmlMeta(o));
      }

      public HtmlMeta(com.gargoylesoftware.htmlunit.html.HtmlMeta wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlMeta WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlMeta)WrappedObject; }
      }


      public System.String HttpEquivAttribute
      {
         get
         {
            return WObj.getHttpEquivAttribute();
         }
      }

      public System.String ContentAttribute
      {
         get
         {
            return WObj.getContentAttribute();
         }
      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String SchemeAttribute
      {
         get
         {
            return WObj.getSchemeAttribute();
         }
      }
   }


}
