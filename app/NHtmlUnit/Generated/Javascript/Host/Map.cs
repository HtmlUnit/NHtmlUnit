// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Map : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Map()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Map o) =>
            new Map(o));
      }

      public Map(com.gargoylesoftware.htmlunit.javascript.host.Map wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Map WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Map)WrappedObject; }
      }

      public Map()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Map()) {}

      public Map(object iterable)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Map(iterable)) {}


      public System.Int32 Size
      {
         get
         {
            return WObj.getSize();
         }
      }
// Generating method code for set
      public virtual NHtmlUnit.Javascript.Host.Map Set(object key, object value)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Map>(WObj.set(key, value));
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

// Generating method code for entries
      public virtual object Entries()
      {
         return WObj.entries();
      }

// Generating method code for keys
      public virtual object Keys()
      {
         return WObj.keys();
      }

// Generating method code for values
      public virtual object Values()
      {
         return WObj.values();
      }

   }


}
