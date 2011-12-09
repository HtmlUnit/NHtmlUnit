// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Storage : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Storage()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Storage o) =>
            new Storage(o));
      }

      public Storage(com.gargoylesoftware.htmlunit.javascript.host.Storage wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Storage WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Storage)WrappedObject; }
      }

      public Storage()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Storage()) {}

// Generating method code for jsxFunction_setItem
      public virtual void JsxFunction_setItem(string key, string data)
      {
         WObj.jsxFunction_setItem(key, data);
      }

// Generating method code for jsxFunction_getItem
      public virtual object JsxFunction_getItem(string key)
      {
         return WObj.jsxFunction_getItem(key);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_removeItem
      public virtual void JsxFunction_removeItem(string key)
      {
         WObj.jsxFunction_removeItem(key);
      }

// Generating method code for jsxFunction_key
      public virtual string JsxFunction_key(int index)
      {
         return WObj.jsxFunction_key(index);
      }

// Generating method code for jsxFunction_clear
      public virtual void JsxFunction_clear()
      {
         WObj.jsxFunction_clear();
      }

   }


}
