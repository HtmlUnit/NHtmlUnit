// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Iterator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Iterator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Iterator o) =>
            new Iterator(o));
      }

      public Iterator(com.gargoylesoftware.htmlunit.javascript.host.Iterator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Iterator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Iterator)WrappedObject; }
      }

      public Iterator(string className, java.util.Iterator iterator)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Iterator(className, iterator)) {}

// Generating method code for next
      public virtual object Next()
      {
         return WObj.next();
      }

   }


}
