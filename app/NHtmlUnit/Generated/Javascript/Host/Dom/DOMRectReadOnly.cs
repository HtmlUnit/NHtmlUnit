// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMRectReadOnly : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMRectReadOnly()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRectReadOnly o) =>
            new DOMRectReadOnly(o));
      }

      public DOMRectReadOnly(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRectReadOnly wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRectReadOnly WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRectReadOnly)WrappedObject; }
      }

      public DOMRectReadOnly()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRectReadOnly()) {}

   }


}
