// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlAnchor : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlAnchor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlAnchor o) =>
            new HtmlAnchor(o));
      }

      public HtmlAnchor(com.gargoylesoftware.htmlunit.html.HtmlAnchor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlAnchor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlAnchor)WrappedObject; }
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

      public System.String CharsetAttribute
      {
         get
         {
            return WObj.getCharsetAttribute();
         }
      }

      public System.String TypeAttribute
      {
         get
         {
            return WObj.getTypeAttribute();
         }
      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String HrefLangAttribute
      {
         get
         {
            return WObj.getHrefLangAttribute();
         }
      }

      public System.String RelAttribute
      {
         get
         {
            return WObj.getRelAttribute();
         }
      }

      public System.String RevAttribute
      {
         get
         {
            return WObj.getRevAttribute();
         }
      }

      public System.String AccessKeyAttribute
      {
         get
         {
            return WObj.getAccessKeyAttribute();
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

      public System.String TabIndexAttribute
      {
         get
         {
            return WObj.getTabIndexAttribute();
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
// Generating method code for openLinkInNewWindow
      public virtual NHtmlUnit.IPage OpenLinkInNewWindow()
      {
         var arg = WObj.openLinkInNewWindow();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

   }


}
