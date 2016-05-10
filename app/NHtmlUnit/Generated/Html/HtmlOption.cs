// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class HtmlOption : NHtmlUnit.Html.HtmlElement, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IElement, NHtmlUnit.W3C.Dom.IElementTraversal, NHtmlUnit.Html.IDisabledElement
   {
      static HtmlOption()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.HtmlOption o) =>
            new HtmlOption(o));
      }

      public HtmlOption(com.gargoylesoftware.htmlunit.html.HtmlOption wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.HtmlOption WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.HtmlOption)WrappedObject; }
      }


      public NHtmlUnit.Html.HtmlSelect EnclosingSelect
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.HtmlSelect>(
               WObj.getEnclosingSelect());
         }
      }


      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.String SelectedAttribute
      {
         get
         {
            return WObj.getSelectedAttribute();
         }
      }

      public System.String DisabledAttribute
      {
         get
         {
            return WObj.getDisabledAttribute();
         }
      }

      public System.String LabelAttribute
      {
         get
         {
            return WObj.getLabelAttribute();
         }
         set
         {
            WObj.setLabelAttribute(value);
         }

      }

      public System.String ValueAttribute
      {
         get
         {
            return WObj.getValueAttribute();
         }
         set
         {
            WObj.setValueAttribute(value);
         }

      }
// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for setSelected
      public virtual void SetSelected(bool selected, bool invokeOnFocus)
      {
         WObj.setSelected(selected, invokeOnFocus);
      }

// Generating method code for isSelected
      public virtual bool IsSelected()
      {
         return WObj.isSelected();
      }

// Generating method code for isDisabled
      public virtual bool IsDisabled()
      {
         return WObj.isDisabled();
      }

// Generating method code for setSelected
      public virtual NHtmlUnit.IPage SetSelected(bool selected)
      {
         var arg = WObj.setSelected(selected);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.IPage>(arg);
      }

// Generating method code for isDefaultSelected
      public virtual bool IsDefaultSelected()
      {
         return WObj.isDefaultSelected();
      }

   }


}
