// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WeakMap : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WeakMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.WeakMap o) =>
            new WeakMap(o));
      }

      public WeakMap(com.gargoylesoftware.htmlunit.javascript.host.WeakMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.WeakMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.WeakMap)WrappedObject; }
      }

      public WeakMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WeakMap()) {}

      public WeakMap(object iterable)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WeakMap(iterable)) {}

// Generating method code for set
      public virtual NHtmlUnit.Javascript.Host.WeakMap Set(object key, object value)
      {
         var arg = WObj.set(key, value);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WeakMap>(arg);
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

// Generating method code for delete
      public virtual bool Delete(object key)
      {
         return WObj.delete(key);
      }

// Generating method code for has
      public virtual bool Has(object key)
      {
         return WObj.has(key);
      }

   }


}
