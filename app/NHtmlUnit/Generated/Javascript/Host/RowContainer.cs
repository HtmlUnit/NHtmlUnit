// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class RowContainer : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static RowContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.RowContainer o) =>
            new RowContainer(o));
      }

      public RowContainer(com.gargoylesoftware.htmlunit.javascript.host.RowContainer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.RowContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.RowContainer)WrappedObject; }
      }

      public RowContainer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.RowContainer()) {}

// Generating method code for jsxGet_rows
      public virtual object JsxGet_rows()
      {
         return WObj.jsxGet_rows();
      }

// Generating method code for insertRow
      public virtual object InsertRow(int index)
      {
         return WObj.insertRow(index);
      }

// Generating method code for jsxFunction_deleteRow
      public virtual void JsxFunction_deleteRow(int rowIndex)
      {
         WObj.jsxFunction_deleteRow(rowIndex);
      }

// Generating method code for jsxFunction_insertRow
      public virtual object JsxFunction_insertRow(object index)
      {
         return WObj.jsxFunction_insertRow(index);
      }

// Generating method code for jsxFunction_moveRow
      public virtual object JsxFunction_moveRow(int sourceIndex, int targetIndex)
      {
         return WObj.jsxFunction_moveRow(sourceIndex, targetIndex);
      }

// Generating method code for jsxGet_align
      public virtual string JsxGet_align()
      {
         return WObj.jsxGet_align();
      }

// Generating method code for jsxSet_align
      public virtual void JsxSet_align(string align)
      {
         WObj.jsxSet_align(align);
      }

   }


}
