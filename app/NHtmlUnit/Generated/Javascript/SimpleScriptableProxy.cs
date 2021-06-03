// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class SimpleScriptableProxy : ObjectWrapper
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

   }


}
