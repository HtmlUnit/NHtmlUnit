// Wrapper for com.gargoylesoftware.htmlunit.html.impl.SelectableTextInput
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html.Impl
{
   public interface ISelectableTextInput : NHtmlUnit.IObjectWrapper, NHtmlUnit.W3C.Dom.INode
   {
      System.String Text { get; set; }
      System.Int32 SelectionStart { get; set; }
      NHtmlUnit.IPage Page  { get; }
      System.String SelectedText  { get; }
      System.Int32 SelectionEnd { get; set; }
// Generating method code for focus
      void Focus();
// Generating method code for select
      void Select();

   }
}
