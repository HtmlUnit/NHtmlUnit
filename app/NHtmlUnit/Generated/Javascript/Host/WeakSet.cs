// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WeakSet : NHtmlUnit.Javascript.SimpleScriptable
   {
      static WeakSet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.WeakSet o) =>
            new WeakSet(o));
      }

      public WeakSet(com.gargoylesoftware.htmlunit.javascript.host.WeakSet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.WeakSet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.WeakSet)WrappedObject; }
      }

      public WeakSet()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WeakSet()) {}

      public WeakSet(object iterable)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WeakSet(iterable)) {}

// Generating method code for add
      public virtual NHtmlUnit.Javascript.Host.WeakSet Add(object value)
      {
         var arg = WObj.add(value);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.WeakSet>(arg);
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
      public virtual bool Has(object value)
      {
         return WObj.has(value);
      }

   }


}
