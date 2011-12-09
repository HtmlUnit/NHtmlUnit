// Generated class v4, don't modify

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

// Generating method code for jsxGet_cellIndex
      public virtual java.lang.Integer JsxGet_cellIndex()
      {
         return WObj.jsxGet_cellIndex();
      }

// Generating method code for jsxGet_abbr
      public virtual string JsxGet_abbr()
      {
         return WObj.jsxGet_abbr();
      }

// Generating method code for jsxSet_abbr
      public virtual void JsxSet_abbr(string abbr)
      {
         WObj.jsxSet_abbr(abbr);
      }

// Generating method code for jsxGet_axis
      public virtual string JsxGet_axis()
      {
         return WObj.jsxGet_axis();
      }

// Generating method code for jsxSet_axis
      public virtual void JsxSet_axis(string axis)
      {
         WObj.jsxSet_axis(axis);
      }

// Generating method code for jsxGet_bgColor
      public virtual string JsxGet_bgColor()
      {
         return WObj.jsxGet_bgColor();
      }

// Generating method code for jsxSet_bgColor
      public virtual void JsxSet_bgColor(string bgColor)
      {
         WObj.jsxSet_bgColor(bgColor);
      }

// Generating method code for jsxGet_colSpan
      public virtual int JsxGet_colSpan()
      {
         return WObj.jsxGet_colSpan();
      }

// Generating method code for jsxSet_colSpan
      public virtual void JsxSet_colSpan(string colSpan)
      {
         WObj.jsxSet_colSpan(colSpan);
      }

// Generating method code for jsxGet_rowSpan
      public virtual int JsxGet_rowSpan()
      {
         return WObj.jsxGet_rowSpan();
      }

// Generating method code for jsxSet_rowSpan
      public virtual void JsxSet_rowSpan(string rowSpan)
      {
         WObj.jsxSet_rowSpan(rowSpan);
      }

// Generating method code for jsxGet_noWrap
      public virtual bool JsxGet_noWrap()
      {
         return WObj.jsxGet_noWrap();
      }

// Generating method code for jsxSet_noWrap
      public virtual void JsxSet_noWrap(bool noWrap)
      {
         WObj.jsxSet_noWrap(noWrap);
      }

// Generating method code for jsxGet_width
      public virtual string JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxSet_width
      public virtual void JsxSet_width(string width)
      {
         WObj.jsxSet_width(width);
      }

// Generating method code for jsxGet_height
      public virtual string JsxGet_height()
      {
         return WObj.jsxGet_height();
      }

// Generating method code for jsxSet_height
      public virtual void JsxSet_height(string width)
      {
         WObj.jsxSet_height(width);
      }

   }


}
