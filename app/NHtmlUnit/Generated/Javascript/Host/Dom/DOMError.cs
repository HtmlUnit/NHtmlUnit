// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMError : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMError()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMError o) =>
            new DOMError(o));
      }

      public DOMError(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMError wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMError WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMError)WrappedObject; }
      }

      public DOMError()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMError()) {}

   }


}
