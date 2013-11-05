// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlArea : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlArea()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlArea o) =>
            new HtmlArea(o));
      }

      public HtmlArea(com.gargoylesoftware.htmlunit.html.HtmlArea wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlArea WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlArea)WrappedObject; }
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

      public System.String ShapeAttribute
      {
         get
         {
            return WObj.getShapeAttribute();
         }
      }

      public System.String CoordsAttribute
      {
         get
         {
            return WObj.getCoordsAttribute();
         }
      }

      public System.String NoHrefAttribute
      {
         get
         {
            return WObj.getNoHrefAttribute();
         }
      }

      public System.String AltAttribute
      {
         get
         {
            return WObj.getAltAttribute();
         }
      }

      public System.String TabIndexAttribute
      {
         get
         {
            return WObj.getTabIndexAttribute();
         }
      }

      public System.String AccessKeyAttribute
      {
         get
         {
            return WObj.getAccessKeyAttribute();
         }
      }

      public System.String OnFocusAttribute
      {
         get
         {
            return WObj.getOnFocusAttribute();
         }
      }

      public System.String OnBlurAttribute
      {
         get
         {
            return WObj.getOnBlurAttribute();
         }
      }
   }


}
