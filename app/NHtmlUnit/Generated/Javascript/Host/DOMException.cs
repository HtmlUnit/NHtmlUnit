// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DOMException : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMException()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DOMException o) =>
            new DOMException(o));
      }

      public DOMException(com.gargoylesoftware.htmlunit.javascript.host.DOMException wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DOMException WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DOMException)WrappedObject; }
      }

      public DOMException(string message, System.Int16 errorCode)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DOMException(message, errorCode)) {}

      public DOMException()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DOMException()) {}

// Generating method code for setLocation
      public virtual void SetLocation(string fileName, int lineNumber)
      {
         WObj.setLocation(fileName, lineNumber);
      }

// Generating method code for jsxGet_code
      public virtual object JsxGet_code()
      {
         return WObj.jsxGet_code();
      }

// Generating method code for jsxGet_message
      public virtual object JsxGet_message()
      {
         return WObj.jsxGet_message();
      }

// Generating method code for jsxGet_lineNumber
      public virtual object JsxGet_lineNumber()
      {
         return WObj.jsxGet_lineNumber();
      }

// Generating method code for jsxGet_filename
      public virtual object JsxGet_filename()
      {
         return WObj.jsxGet_filename();
      }

   }


}
