// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WindowProxy : NHtmlUnit.Javascript.SimpleScriptableProxy, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static WindowProxy()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.WindowProxy o) =>
            new WindowProxy(o));
      }

      public WindowProxy(com.gargoylesoftware.htmlunit.javascript.host.WindowProxy wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.WindowProxy WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.WindowProxy)WrappedObject; }
      }

      public WindowProxy(NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WindowProxy((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}

   }


}
