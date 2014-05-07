// Generated class v2.14.1.0, don't modify

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


      public System.Object Rows
      {
         get
         {
            return WObj.getRows();
         }
      }

      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
         }

      }
// Generating method code for insertRow
      public virtual object InsertRow(int index)
      {
         return WObj.insertRow(index);
      }

// Generating method code for deleteRow
      public virtual void DeleteRow(int rowIndex)
      {
         WObj.deleteRow(rowIndex);
      }

// Generating method code for insertRow
      public virtual object InsertRow(object index)
      {
         return WObj.insertRow(index);
      }

// Generating method code for moveRow
      public virtual object MoveRow(int sourceIndex, int targetIndex)
      {
         return WObj.moveRow(sourceIndex, targetIndex);
      }

   }


}
