// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class History : NHtmlUnit.Javascript.SimpleScriptable
   {
      static History()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.History o) =>
            new History(o));
      }

      public History(com.gargoylesoftware.htmlunit.javascript.host.History wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.History WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.History)WrappedObject; }
      }

      public History()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.History()) {}

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_item
      public virtual string JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for jsxFunction_back
      public virtual void JsxFunction_back()
      {
         WObj.jsxFunction_back();
      }

// Generating method code for jsxFunction_forward
      public virtual void JsxFunction_forward()
      {
         WObj.jsxFunction_forward();
      }

// Generating method code for jsxFunction_go
      public virtual void JsxFunction_go(int relativeIndex)
      {
         WObj.jsxFunction_go(relativeIndex);
      }

// Generating method code for jsxGet_current
      public virtual string JsxGet_current()
      {
         return WObj.jsxGet_current();
      }

// Generating method code for jsxGet_previous
      public virtual string JsxGet_previous()
      {
         return WObj.jsxGet_previous();
      }

// Generating method code for jsxGet_next
      public virtual string JsxGet_next()
      {
         return WObj.jsxGet_next();
      }

   }


}
