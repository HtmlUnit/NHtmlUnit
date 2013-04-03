// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableCellElement : NHtmlUnit.Javascript.Host.Html.HTMLTableComponent, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableCellElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCellElement o) =>
            new HTMLTableCellElement(o));
      }

      public HTMLTableCellElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCellElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCellElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCellElement)WrappedObject; }
      }

      public HTMLTableCellElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableCellElement()) {}


      public java.lang.Integer CellIndex
      {
         get
         {
            return WObj.getCellIndex();
         }
      }

      public System.String Abbr
      {
         get
         {
            return WObj.getAbbr();
         }
         set
         {
            WObj.setAbbr(value);
         }

      }

      public System.String Axis
      {
         get
         {
            return WObj.getAxis();
         }
         set
         {
            WObj.setAxis(value);
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

      public System.Boolean NoWrap
      {
         get
         {
            return WObj.getNoWrap();
         }
         set
         {
            WObj.setNoWrap(value);
         }

      }

      public System.String Width_js
      {
         get
         {
            return WObj.getWidth_js();
         }
      }

      public System.String Height_js
      {
         get
         {
            return WObj.getHeight_js();
         }
      }
// Generating method code for getColSpan
      public virtual int GetColSpan()
      {
         return WObj.getColSpan();
      }

// Generating method code for setColSpan
      public virtual void SetColSpan(string colSpan)
      {
         WObj.setColSpan(colSpan);
      }

// Generating method code for getRowSpan
      public virtual int GetRowSpan()
      {
         return WObj.getRowSpan();
      }

// Generating method code for setRowSpan
      public virtual void SetRowSpan(string rowSpan)
      {
         WObj.setRowSpan(rowSpan);
      }

   }


}
