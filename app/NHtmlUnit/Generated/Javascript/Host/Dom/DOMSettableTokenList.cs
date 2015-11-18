// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMSettableTokenList : NHtmlUnit.Javascript.Host.Dom.DOMTokenList
   {
      static DOMSettableTokenList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMSettableTokenList o) =>
            new DOMSettableTokenList(o));
      }

      public DOMSettableTokenList(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMSettableTokenList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMSettableTokenList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMSettableTokenList)WrappedObject; }
      }

      public DOMSettableTokenList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMSettableTokenList()) {}

   }


}
