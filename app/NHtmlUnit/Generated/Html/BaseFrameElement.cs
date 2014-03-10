// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class BaseFrameElement : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static BaseFrameElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.BaseFrameElement o) =>
            new BaseFrameElement(o));
      }

      public BaseFrameElement(com.gargoylesoftware.htmlunit.html.BaseFrameElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.BaseFrameElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.BaseFrameElement)WrappedObject; }
      }


      public System.String SrcAttribute
      {
         get
         {
            return WObj.getSrcAttribute();
         }
         set
         {
            WObj.setSrcAttribute(value);
         }

      }

      public NHtmlUnit.IPage EnclosedPage
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(
               WObj.getEnclosedPage());
         }
      }


      public NHtmlUnit.Html.FrameWindow EnclosedWindow
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.FrameWindow>(
               WObj.getEnclosedWindow());
         }
      }


      public System.String LongDescAttribute
      {
         get
         {
            return WObj.getLongDescAttribute();
         }
      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
         set
         {
            WObj.setNameAttribute(value);
         }

      }

      public System.String FrameBorderAttribute
      {
         get
         {
            return WObj.getFrameBorderAttribute();
         }
      }

      public System.String MarginWidthAttribute
      {
         get
         {
            return WObj.getMarginWidthAttribute();
         }
      }

      public System.String MarginHeightAttribute
      {
         get
         {
            return WObj.getMarginHeightAttribute();
         }
      }

      public System.String NoResizeAttribute
      {
         get
         {
            return WObj.getNoResizeAttribute();
         }
      }

      public System.String ScrollingAttribute
      {
         get
         {
            return WObj.getScrollingAttribute();
         }
      }

      public System.String OnLoadAttribute
      {
         get
         {
            return WObj.getOnLoadAttribute();
         }
      }
// Generating method code for loadInnerPage
      public virtual void LoadInnerPage()
      {
         WObj.loadInnerPage();
      }

// Generating method code for markAsCreatedByJavascript
      public virtual void MarkAsCreatedByJavascript()
      {
         WObj.markAsCreatedByJavascript();
      }

// Generating method code for unmarkAsCreatedByJavascript
      public virtual void UnmarkAsCreatedByJavascript()
      {
         WObj.unmarkAsCreatedByJavascript();
      }

// Generating method code for wasCreatedByJavascript
      public virtual bool WasCreatedByJavascript()
      {
         return WObj.wasCreatedByJavascript();
      }

   }


}
