// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMPointReadOnly : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMPointReadOnly()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPointReadOnly o) =>
            new DOMPointReadOnly(o));
      }

      public DOMPointReadOnly(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPointReadOnly wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPointReadOnly WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPointReadOnly)WrappedObject; }
      }

      public DOMPointReadOnly()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPointReadOnly()) {}

   }


}
