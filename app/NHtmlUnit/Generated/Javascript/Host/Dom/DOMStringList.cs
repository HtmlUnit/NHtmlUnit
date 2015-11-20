// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMStringList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMStringList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMStringList o) =>
            new DOMStringList(o));
      }

      public DOMStringList(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMStringList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMStringList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMStringList)WrappedObject; }
      }

      public DOMStringList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMStringList()) {}

   }


}
