// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class RowContainer : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static RowContainer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.RowContainer o) =>
            new RowContainer(o));
      }

      public RowContainer(com.gargoylesoftware.htmlunit.javascript.host.html.RowContainer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.RowContainer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.RowContainer)WrappedObject; }
      }

      public RowContainer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.RowContainer()) {}


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
         var arg = WObj.insertRow(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for deleteRow
      public virtual void DeleteRow(int rowIndex)
      {
         WObj.deleteRow(rowIndex);
      }

// Generating method code for insertRow
      public virtual object InsertRow(object index)
      {
         var arg = WObj.insertRow(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for moveRow
      public virtual object MoveRow(int sourceIndex, int targetIndex)
      {
         var arg = WObj.moveRow(sourceIndex, targetIndex);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
