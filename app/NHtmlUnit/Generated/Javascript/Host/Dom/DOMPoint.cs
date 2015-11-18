// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMPoint : NHtmlUnit.Javascript.Host.Dom.DOMPointReadOnly
   {
      static DOMPoint()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPoint o) =>
            new DOMPoint(o));
      }

      public DOMPoint(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPoint wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPoint WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPoint)WrappedObject; }
      }

      public DOMPoint()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMPoint()) {}

   }


}
