// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLInputElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
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

      public System.Boolean Checked
      {
         get
         {
            return WObj.getChecked();
         }
         set
         {
            WObj.setChecked(value);
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

      public System.Boolean DefaultChecked
      {
         get
         {
            return WObj.getDefaultChecked();
         }
         set
         {
            WObj.setDefaultChecked(value);
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
// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

// Generating method code for setSelectionRange
      public virtual void SetSelectionRange(int start, int end)
      {
         WObj.setSelectionRange(start, end);
      }

   }


}
