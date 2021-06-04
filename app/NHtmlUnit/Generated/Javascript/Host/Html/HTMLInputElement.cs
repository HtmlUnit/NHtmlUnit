// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLInputElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLInputElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement o) =>
            new HTMLInputElement(o));
      }

      public HTMLInputElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement)WrappedObject; }
      }

      public HTMLInputElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLInputElement()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
         }

      }

      public System.String DefaultValue
      {
         get
         {
            return WObj.getDefaultValue();
         }
         set
         {
            WObj.setDefaultValue(value);
         }

      }

      public System.Int32 TextLength
      {
         get
         {
            return WObj.getTextLength();
         }
      }

      public System.Int32 MaxLength
      {
         get
         {
            return WObj.getMaxLength();
         }
         set
         {
            WObj.setMaxLength(value);
         }

      }

      public System.Int32 MinLength
      {
         get
         {
            return WObj.getMinLength();
         }
         set
         {
            WObj.setMinLength(value);
         }

      }

      public System.String Min
      {
         get
         {
            return WObj.getMin();
         }
         set
         {
            WObj.setMin(value);
         }

      }

      public System.String Max
      {
         get
         {
            return WObj.getMax();
         }
         set
         {
            WObj.setMax(value);
         }

      }

      public System.String Step
      {
         get
         {
            return WObj.getStep();
         }
         set
         {
            WObj.setStep(value);
         }

      }

      public System.String Alt
      {
         get
         {
            return WObj.getAlt();
         }
         set
         {
            WObj.setAlt(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
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

      public System.String Src
      {
         get
         {
            return WObj.getSrc();
         }
         set
         {
            WObj.setSrc(value);
         }

      }

      public System.String Size
      {
         get
         {
            return WObj.getSize();
         }
         set
         {
            WObj.setSize(value);
         }

      }

      public System.String Accept
      {
         get
         {
            return WObj.getAccept();
         }
         set
         {
            WObj.setAccept(value);
         }

      }

      public System.String Autocomplete
      {
         get
         {
            return WObj.getAutocomplete();
         }
         set
         {
            WObj.setAutocomplete(value);
         }

      }

      public System.Object Files
      {
         get
         {
            return WObj.getFiles();
         }
      }

      public System.String Placeholder
      {
         get
         {
            return WObj.getPlaceholder();
         }
         set
         {
            WObj.setPlaceholder(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Dom.AbstractList Labels
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.AbstractList>(
               WObj.getLabels());
         }
      }

// Generating method code for isChecked
      public virtual bool IsChecked()
      {
         return WObj.isChecked();
      }

// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

// Generating method code for isDefaultChecked
      public virtual bool IsDefaultChecked()
      {
         return WObj.isDefaultChecked();
      }

// Generating method code for isReadOnly
      public virtual bool IsReadOnly()
      {
         return WObj.isReadOnly();
      }

// Generating method code for setSelectionRange
      public virtual void SetSelectionRange(int start, int end)
      {
         WObj.setSelectionRange(start, end);
      }

// Generating method code for isRequired
      public virtual bool IsRequired()
      {
         return WObj.isRequired();
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

// Generating method code for createTextRange
      public virtual NHtmlUnit.Javascript.Host.Dom.TextRange CreateTextRange()
      {
         var arg = WObj.createTextRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.TextRange>(arg);
      }

// Generating method code for getSelectionStart
      public virtual object GetSelectionStart()
      {
         var arg = WObj.getSelectionStart();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setSelectionStart
      public virtual void SetSelectionStart(int start)
      {
         WObj.setSelectionStart(start);
      }

// Generating method code for getSelectionEnd
      public virtual object GetSelectionEnd()
      {
         var arg = WObj.getSelectionEnd();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setSelectionEnd
      public virtual void SetSelectionEnd(int end)
      {
         WObj.setSelectionEnd(end);
      }

   }


}
