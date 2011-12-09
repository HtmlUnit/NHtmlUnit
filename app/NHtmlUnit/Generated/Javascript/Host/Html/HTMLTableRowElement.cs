// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableRowElement : NHtmlUnit.Javascript.Host.Html.HTMLTableComponent, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

// Generating method code for jsxGet_rowIndex
      public virtual int JsxGet_rowIndex()
      {
         return WObj.jsxGet_rowIndex();
      }

// Generating method code for jsxGet_sectionRowIndex
      public virtual int JsxGet_sectionRowIndex()
      {
         return WObj.jsxGet_sectionRowIndex();
      }

// Generating method code for jsxGet_cells
      public virtual object JsxGet_cells()
      {
         return WObj.jsxGet_cells();
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

// Generating method code for jsxFunction_insertCell
      public virtual object JsxFunction_insertCell(object index)
      {
         return WObj.jsxFunction_insertCell(index);
      }

// Generating method code for jsxFunction_deleteCell
      public virtual void JsxFunction_deleteCell(object index)
      {
         WObj.jsxFunction_deleteCell(index);
      }

   }


}
