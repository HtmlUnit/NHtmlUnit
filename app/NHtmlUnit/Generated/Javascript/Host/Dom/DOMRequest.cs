// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMRequest : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static DOMRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRequest o) =>
            new DOMRequest(o));
      }

      public DOMRequest(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRequest)WrappedObject; }
      }

      public DOMRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMRequest()) {}

   }


}
