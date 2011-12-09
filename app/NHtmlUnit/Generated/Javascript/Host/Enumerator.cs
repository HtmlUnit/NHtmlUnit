// Generated class v4, don't modify

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

// Generating method code for jsxFunction_atEnd
      public virtual bool JsxFunction_atEnd()
      {
         return WObj.jsxFunction_atEnd();
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor(object o)
      {
         WObj.jsConstructor(o);
      }

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item()
      {
         return WObj.jsxFunction_item();
      }

// Generating method code for jsxFunction_moveFirst
      public virtual void JsxFunction_moveFirst()
      {
         WObj.jsxFunction_moveFirst();
      }

// Generating method code for jsxFunction_moveNext
      public virtual void JsxFunction_moveNext()
      {
         WObj.jsxFunction_moveNext();
      }

   }


}
