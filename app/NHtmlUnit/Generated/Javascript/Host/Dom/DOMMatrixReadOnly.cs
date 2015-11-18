// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMMatrixReadOnly : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMMatrixReadOnly()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrixReadOnly o) =>
            new DOMMatrixReadOnly(o));
      }

      public DOMMatrixReadOnly(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrixReadOnly wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrixReadOnly WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrixReadOnly)WrappedObject; }
      }

      public DOMMatrixReadOnly()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMMatrixReadOnly()) {}

   }


}
