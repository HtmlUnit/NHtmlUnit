// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMException : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMException()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException o) =>
            new DOMException(o));
      }

      public DOMException(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException)WrappedObject; }
      }

      public DOMException(string message, System.Int16 errorCode)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException(message, errorCode)) {}

      public DOMException()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMException()) {}


      public System.Object Code
      {
         get
         {
            return WObj.getCode();
         }
      }

      public System.Object Message
      {
         get
         {
            return WObj.getMessage();
         }
      }

      public System.Object LineNumber
      {
         get
         {
            return WObj.getLineNumber();
         }
      }

      public System.Object Filename
      {
         get
         {
            return WObj.getFilename();
         }
      }
// Generating method code for setLocation
      public virtual void SetLocation(string fileName, int lineNumber)
      {
         WObj.setLocation(fileName, lineNumber);
      }

   }


}
