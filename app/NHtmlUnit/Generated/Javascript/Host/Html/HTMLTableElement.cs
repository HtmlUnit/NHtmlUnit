// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableElement : NHtmlUnit.Javascript.Host.Html.RowContainer
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

      public System.String Summary
      {
         get
         {
            return WObj.getSummary();
         }
         set
         {
            WObj.setSummary(value);
         }

      }

      public System.String Rules
      {
         get
         {
            return WObj.getRules();
         }
         set
         {
            WObj.setRules(value);
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
         var arg = WObj.createCaption();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createTFoot
      public virtual object CreateTFoot()
      {
         var arg = WObj.createTFoot();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createTBody
      public virtual object CreateTBody()
      {
         var arg = WObj.createTBody();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for createTHead
      public virtual object CreateTHead()
      {
         var arg = WObj.createTHead();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
