// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class Enumerator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Enumerator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.Enumerator o) =>
            new Enumerator(o));
      }

      public Enumerator(com.gargoylesoftware.htmlunit.javascript.host.html.Enumerator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.Enumerator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.Enumerator)WrappedObject; }
      }

      public Enumerator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.Enumerator()) {}

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
         var arg = WObj.item();
         return ObjectWrapper.CreateWrapper<object>(arg);
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
