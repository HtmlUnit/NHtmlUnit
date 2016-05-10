// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTextAreaElement : NHtmlUnit.Javascript.Host.Html.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public System.Boolean ReadOnly
      {
         get
         {
            return WObj.getReadOnly();
         }
         set
         {
            WObj.setReadOnly(value);
         }

      }

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
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

   }


}
