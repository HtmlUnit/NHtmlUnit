// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class SimpleScriptableProxy : ObjectWrapper, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static SimpleScriptableProxy()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.SimpleScriptableProxy o) =>
            new SimpleScriptableProxy(o));
      }

      public SimpleScriptableProxy(com.gargoylesoftware.htmlunit.javascript.SimpleScriptableProxy wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.SimpleScriptableProxy WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.SimpleScriptableProxy)WrappedObject; }
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

   }


}
