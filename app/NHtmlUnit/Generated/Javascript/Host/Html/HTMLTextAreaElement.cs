// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTextAreaElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLTextAreaElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement o) =>
            new HTMLTextAreaElement(o));
      }

      public HTMLTextAreaElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement)WrappedObject; }
      }

      public HTMLTextAreaElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTextAreaElement()) {}


      public System.Int32 SelectionStart
      {
         get
         {
            return WObj.getSelectionStart();
         }
         set
         {
            WObj.setSelectionStart(value);
         }

      }

      public System.Int32 SelectionEnd
      {
         get
         {
            return WObj.getSelectionEnd();
         }
         set
         {
            WObj.setSelectionEnd(value);
         }

      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
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

// Generating method code for setSelectionRange
      public virtual void SetSelectionRange(int start, int end)
      {
         WObj.setSelectionRange(start, end);
      }

// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

// Generating method code for isReadOnly
      public virtual bool IsReadOnly()
      {
         return WObj.isReadOnly();
      }

// Generating method code for createTextRange
      public virtual NHtmlUnit.Javascript.Host.Dom.TextRange CreateTextRange()
      {
         var arg = WObj.createTextRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.TextRange>(arg);
      }

// Generating method code for checkValidity
      public virtual bool CheckValidity()
      {
         return WObj.checkValidity();
      }

// Generating method code for isRequired
      public virtual bool IsRequired()
      {
         return WObj.isRequired();
      }

// Generating method code for getCols
      public virtual int GetCols()
      {
         return WObj.getCols();
      }

// Generating method code for setCols
      public virtual void SetCols(string cols)
      {
         WObj.setCols(cols);
      }

// Generating method code for getRows
      public virtual int GetRows()
      {
         return WObj.getRows();
      }

// Generating method code for setRows
      public virtual void SetRows(string rows)
      {
         WObj.setRows(rows);
      }

// Generating method code for getMaxLength
      public virtual object GetMaxLength()
      {
         var arg = WObj.getMaxLength();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setMaxLength
      public virtual void SetMaxLength(string maxLength)
      {
         WObj.setMaxLength(maxLength);
      }

// Generating method code for getMinLength
      public virtual object GetMinLength()
      {
         var arg = WObj.getMinLength();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for setMinLength
      public virtual void SetMinLength(string minLength)
      {
         WObj.setMinLength(minLength);
      }

   }


}
