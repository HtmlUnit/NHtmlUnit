// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class SimpleArray : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static SimpleArray()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.SimpleArray o) =>
            new SimpleArray(o));
      }

      public SimpleArray(com.gargoylesoftware.htmlunit.javascript.host.SimpleArray wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.SimpleArray WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.SimpleArray)WrappedObject; }
      }

      public SimpleArray()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.SimpleArray()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for namedItem
      public virtual object NamedItem(string name)
      {
         return WObj.namedItem(name);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

   }


}
