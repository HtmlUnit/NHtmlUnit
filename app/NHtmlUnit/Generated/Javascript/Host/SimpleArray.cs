// Generated class v4, don't modify

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

// Generating method code for jsxFunction_namedItem
      public virtual object JsxFunction_namedItem(string name)
      {
         return WObj.jsxFunction_namedItem(name);
      }

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

   }


}
