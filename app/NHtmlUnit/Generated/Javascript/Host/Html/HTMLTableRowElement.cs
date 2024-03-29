// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableRowElement : NHtmlUnit.Javascript.Host.Html.HTMLTableComponent
   {
      static HTMLTableRowElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableRowElement o) =>
            new HTMLTableRowElement(o));
      }

      public HTMLTableRowElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableRowElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableRowElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableRowElement)WrappedObject; }
      }

      public HTMLTableRowElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableRowElement()) {}


      public System.Int32 RowIndex
      {
         get
         {
            return WObj.getRowIndex();
         }
      }

      public System.Int32 SectionRowIndex
      {
         get
         {
            return WObj.getSectionRowIndex();
         }
      }

      public System.Object Cells
      {
         get
         {
            return WObj.getCells();
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
// Generating method code for insertCell
      public virtual object InsertCell(object index)
      {
         var arg = WObj.insertCell(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for deleteCell
      public virtual void DeleteCell(object index)
      {
         WObj.deleteCell(index);
      }

   }


}
