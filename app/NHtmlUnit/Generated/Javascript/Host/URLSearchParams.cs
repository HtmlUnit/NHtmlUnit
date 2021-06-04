// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class URLSearchParams : NHtmlUnit.Javascript.SimpleScriptable
   {
      static URLSearchParams()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams o) =>
            new URLSearchParams(o));
      }

      public URLSearchParams(com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams)WrappedObject; }
      }

      public URLSearchParams(object paramsArg)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams(paramsArg)) {}

      public URLSearchParams()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams()) {}

// Generating method code for append
      public virtual void Append(string name, string value)
      {
         WObj.append(name, value);
      }

// Generating method code for jsToString
      public virtual string JsToString()
      {
         return WObj.jsToString();
      }

// Generating method code for getAll
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetAll(string name)
      {
         return WObj.getAll(name);
      }

// Generating method code for set
      public virtual void Set(string name, string value)
      {
         WObj.set(name, value);
      }

// Generating method code for has
      public virtual bool Has(string name)
      {
         return WObj.has(name);
      }

// Generating method code for entries
      public virtual object Entries()
      {
         var arg = WObj.entries();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for keys
      public virtual object Keys()
      {
         var arg = WObj.keys();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for values
      public virtual object Values()
      {
         var arg = WObj.values();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for fillRequest
      public virtual void FillRequest(NHtmlUnit.WebRequest webRequest)
      {
         WObj.fillRequest((com.gargoylesoftware.htmlunit.WebRequest)webRequest.WrappedObject);
      }

   }


}
