// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlParameter : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlParameter()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlParameter o) =>
            new HtmlParameter(o));
      }

      public HtmlParameter(com.gargoylesoftware.htmlunit.html.HtmlParameter wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlParameter WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlParameter)WrappedObject; }
      }


      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String ValueAttribute
      {
         get
         {
            return WObj.getValueAttribute();
         }
      }

      public System.String IdAttribute
      {
         get
         {
            return WObj.getIdAttribute();
         }
      }

      public System.String ValueTypeAttribute
      {
         get
         {
            return WObj.getValueTypeAttribute();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }
   }


}
