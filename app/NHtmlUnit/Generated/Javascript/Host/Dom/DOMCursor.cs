// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMCursor : NHtmlUnit.Javascript.Host.Dom.DOMRequest
   {
      static DOMCursor()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMCursor o) =>
            new DOMCursor(o));
      }

      public DOMCursor(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMCursor wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMCursor WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMCursor)WrappedObject; }
      }

      public DOMCursor()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMCursor()) {}

   }


}
