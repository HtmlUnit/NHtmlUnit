// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Enumerator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Enumerator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Enumerator o) =>
            new Enumerator(o));
      }

      public Enumerator(com.gargoylesoftware.htmlunit.javascript.host.Enumerator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Enumerator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Enumerator)WrappedObject; }
      }

      public Enumerator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Enumerator()) {}

// Generating method code for atEnd
      public virtual bool AtEnd()
      {
         return WObj.atEnd();
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor(object o)
      {
         WObj.jsConstructor(o);
      }

// Generating method code for item
      public virtual object Item()
      {
         return WObj.item();
      }

// Generating method code for moveFirst
      public virtual void MoveFirst()
      {
         WObj.moveFirst();
      }

// Generating method code for moveNext
      public virtual void MoveNext()
      {
         WObj.moveNext();
      }

   }


}
