// Wrapper for com.gargoylesoftware.htmlunit.html.impl.SelectableTextInput
// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Html.Impl
{
   public interface ISelectableTextInput : NHtmlUnit.IObjectWrapper, NHtmlUnit.W3C.Dom.INode
   {
      System.Int32 SelectionStart { get; set; }
      System.Int32 SelectionEnd { get; set; }
      NHtmlUnit.IPage Page  { get; }
      System.String Text { get; set; }
      System.String SelectedText  { get; }
// Generating method code for focus
      void Focus();
// Generating method code for select
      void Select();

   }
}
