// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Set : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Set()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Set o) =>
            new Set(o));
      }

      public Set(com.gargoylesoftware.htmlunit.javascript.host.Set wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Set WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Set)WrappedObject; }
      }

      public Set()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Set()) {}

      public Set(object iterable)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Set(iterable)) {}


      public System.Int32 Size
      {
         get
         {
            return WObj.getSize();
         }
      }
// Generating method code for add
      public virtual NHtmlUnit.Javascript.Host.Set Add(object value)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Set>(WObj.add(value));
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

// Generating method code for values
      public virtual object Values()
      {
         return WObj.values();
      }

   }


}
