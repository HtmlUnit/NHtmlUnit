// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Arrays
{
   public partial class Atomics : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Atomics()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.arrays.Atomics o) =>
            new Atomics(o));
      }

      public Atomics(com.gargoylesoftware.htmlunit.javascript.host.arrays.Atomics wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.arrays.Atomics WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.arrays.Atomics)WrappedObject; }
      }

      public Atomics()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.arrays.Atomics()) {}

   }


}
