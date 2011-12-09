// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLOptionsCollection : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLOptionsCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection o) =>
            new HTMLOptionsCollection(o));
      }

      public HTMLOptionsCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection)WrappedObject; }
      }

      public HTMLOptionsCollection(NHtmlUnit.Javascript.SimpleScriptable parentScope)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)parentScope.WrappedObject)) {}

      public HTMLOptionsCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionsCollection()) {}

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.Html.HtmlSelect select)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.html.HtmlSelect)select.WrappedObject);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxSet_length
      public virtual void JsxSet_length(int newLength)
      {
         WObj.jsxSet_length(newLength);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for jsxFunction_add
      public virtual void JsxFunction_add(object newOptionObject, object newIndex)
      {
         WObj.jsxFunction_add(newOptionObject, newIndex);
      }

// Generating method code for jsxFunction_remove
      public virtual void JsxFunction_remove(int index)
      {
         WObj.jsxFunction_remove(index);
      }

   }


}
