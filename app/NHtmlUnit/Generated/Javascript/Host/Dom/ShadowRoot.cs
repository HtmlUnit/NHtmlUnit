// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class ShadowRoot : NHtmlUnit.Javascript.Host.Dom.DocumentFragment
   {
      static ShadowRoot()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.ShadowRoot o) =>
            new ShadowRoot(o));
      }

      public ShadowRoot(com.gargoylesoftware.htmlunit.javascript.host.dom.ShadowRoot wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.ShadowRoot WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.ShadowRoot)WrappedObject; }
      }

      public ShadowRoot()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.ShadowRoot()) {}

   }


}
