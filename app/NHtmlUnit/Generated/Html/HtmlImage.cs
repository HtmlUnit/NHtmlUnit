// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlImage : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal
   {
      static HtmlImage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlImage o) =>
            new HtmlImage(o));
      }

      public HtmlImage(com.gargoylesoftware.htmlunit.html.HtmlImage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlImage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlImage)WrappedObject; }
      }


      public System.String SrcAttribute
      {
         get
         {
            return WObj.getSrcAttribute();
         }
      }

      public javax.imageio.ImageReader ImageReader
      {
         get
         {
            return WObj.getImageReader();
         }
      }

      public System.String UseMapAttribute
      {
         get
         {
            return WObj.getUseMapAttribute();
         }
      }

      public System.String IsmapAttribute
      {
         get
         {
            return WObj.getIsmapAttribute();
         }
      }

      public System.String AltAttribute
      {
         get
         {
            return WObj.getAltAttribute();
         }
      }

      public System.String NameAttribute
      {
         get
         {
            return WObj.getNameAttribute();
         }
      }

      public System.String LongDescAttribute
      {
         get
         {
            return WObj.getLongDescAttribute();
         }
      }

      public System.String HeightAttribute
      {
         get
         {
            return WObj.getHeightAttribute();
         }
      }

      public System.String WidthAttribute
      {
         get
         {
            return WObj.getWidthAttribute();
         }
      }

      public System.String AlignAttribute
      {
         get
         {
            return WObj.getAlignAttribute();
         }
      }

      public System.String BorderAttribute
      {
         get
         {
            return WObj.getBorderAttribute();
         }
      }

      public System.String HspaceAttribute
      {
         get
         {
            return WObj.getHspaceAttribute();
         }
      }

      public System.String VspaceAttribute
      {
         get
         {
            return WObj.getVspaceAttribute();
         }
      }

      public System.Int32 Height
      {
         get
         {
            return WObj.getHeight();
         }
      }

      public System.Int32 Width
      {
         get
         {
            return WObj.getWidth();
         }
      }
// Generating method code for doOnLoad
      public virtual void DoOnLoad()
      {
         WObj.doOnLoad();
      }

// Generating method code for click
      public virtual NHtmlUnit.IPage Click(int x, int y)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(WObj.click(x, y));
      }

// Generating method code for getWebResponse
      public virtual NHtmlUnit.WebResponse GetWebResponse(bool downloadIfNeeded)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.WebResponse>(WObj.getWebResponse(downloadIfNeeded));
      }

// Generating method code for saveAs
      public virtual void SaveAs(java.io.File file)
      {
         WObj.saveAs(file);
      }

   }


}
