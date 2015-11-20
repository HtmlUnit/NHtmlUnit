// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Promise : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Promise()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Promise o) =>
            new Promise(o));
      }

      public Promise(com.gargoylesoftware.htmlunit.javascript.host.Promise wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Promise WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Promise)WrappedObject; }
      }

      public Promise(object objectArg)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Promise(objectArg)) {}

      public Promise(NHtmlUnit.Javascript.Host.Window window)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Promise((com.gargoylesoftware.htmlunit.javascript.host.Window)window.WrappedObject)) {}

      public Promise()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Promise()) {}

// Generating method code for then
      public virtual NHtmlUnit.Javascript.Host.Promise Then(net.sourceforge.htmlunit.corejs.javascript.Function onFulfilled, net.sourceforge.htmlunit.corejs.javascript.Function onRejected)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Promise>(WObj.then(onFulfilled, onRejected));
      }

   }


}
