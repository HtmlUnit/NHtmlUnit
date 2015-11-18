// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableElement : NHtmlUnit.Javascript.Host.Html.RowContainer, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableElement o) =>
            new HTMLTableElement(o));
      }

      public HTMLTableElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableElement)WrappedObject; }
      }

      public HTMLTableElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableElement()) {}


      public System.Object Caption
      {
         get
         {
            return WObj.getCaption();
         }
         set
         {
            WObj.setCaption(value);
         }

      }

      public System.Object TFoot
      {
         get
         {
            return WObj.getTFoot();
         }
         set
         {
            WObj.setTFoot(value);
         }

      }

      public System.Object THead
      {
         get
         {
            return WObj.getTHead();
         }
         set
         {
            WObj.setTHead(value);
         }

      }

      public System.Object TBodies
      {
         get
         {
            return WObj.getTBodies();
         }
      }

      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }

      public System.String CellSpacing
      {
         get
         {
            return WObj.getCellSpacing();
         }
         set
         {
            WObj.setCellSpacing(value);
         }

      }

      public System.String CellPadding
      {
         get
         {
            return WObj.getCellPadding();
         }
         set
         {
            WObj.setCellPadding(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }

      public System.String BgColor
      {
         get
         {
            return WObj.getBgColor();
         }
         set
         {
            WObj.setBgColor(value);
         }

      }

      public System.String BorderColor
      {
         get
         {
            return WObj.getBorderColor();
         }
         set
         {
            WObj.setBorderColor(value);
         }

      }

      public System.String BorderColorDark
      {
         get
         {
            return WObj.getBorderColorDark();
         }
         set
         {
            WObj.setBorderColorDark(value);
         }

      }

      public System.String BorderColorLight
      {
         get
         {
            return WObj.getBorderColorLight();
         }
         set
         {
            WObj.setBorderColorLight(value);
         }

      }

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
         }

      }
// Generating method code for deleteCaption
      public virtual void DeleteCaption()
      {
         WObj.deleteCaption();
      }

// Generating method code for deleteTFoot
      public virtual void DeleteTFoot()
      {
         WObj.deleteTFoot();
      }

// Generating method code for deleteTHead
      public virtual void DeleteTHead()
      {
         WObj.deleteTHead();
      }

// Generating method code for createCaption
      public virtual object CreateCaption()
      {
         return WObj.createCaption();
      }

// Generating method code for createTFoot
      public virtual object CreateTFoot()
      {
         return WObj.createTFoot();
      }

// Generating method code for createTHead
      public virtual object CreateTHead()
      {
         return WObj.createTHead();
      }

// Generating method code for refresh
      public virtual void Refresh()
      {
         WObj.refresh();
      }

   }


}
