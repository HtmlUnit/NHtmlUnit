// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLSelectElement : NHtmlUnit.Javascript.Host.FormField, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLSelectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement o) =>
            new HTMLSelectElement(o));
      }

      public HTMLSelectElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement)WrappedObject; }
      }

      public HTMLSelectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLSelectElement()) {}

// Generating method code for jsxSet_selectedIndex
      public virtual void JsxSet_selectedIndex(int index)
      {
         WObj.jsxSet_selectedIndex(index);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for jsxGet_selectedIndex
      public virtual int JsxGet_selectedIndex()
      {
         return WObj.jsxGet_selectedIndex();
      }

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxFunction_remove
      public virtual void JsxFunction_remove(int index)
      {
         WObj.jsxFunction_remove(index);
      }

// Generating method code for jsxFunction_add
      public virtual void JsxFunction_add(NHtmlUnit.Javascript.Host.Html.HTMLOptionElement newOptionObject, object arg2)
      {
         WObj.jsxFunction_add((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLOptionElement)newOptionObject.WrappedObject, arg2);
      }

// Generating method code for jsxFunction_insertBefore
      public virtual object JsxFunction_insertBefore(System.Object[] args)
      {
         return WObj.jsxFunction_insertBefore(args);
      }

// Generating method code for jsxFunction_item
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLOptionElement JsxFunction_item(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLOptionElement>(WObj.jsxFunction_item(index));
      }

// Generating method code for jsxGet_options
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection JsxGet_options()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLOptionsCollection>(WObj.jsxGet_options());
      }

// Generating method code for jsxSet_length
      public virtual void JsxSet_length(int newLength)
      {
         WObj.jsxSet_length(newLength);
      }

// Generating method code for jsxGet_size
      public virtual int JsxGet_size()
      {
         return WObj.jsxGet_size();
      }

// Generating method code for jsxSet_size
      public virtual void JsxSet_size(string size)
      {
         WObj.jsxSet_size(size);
      }

// Generating method code for jsxGet_multiple
      public virtual bool JsxGet_multiple()
      {
         return WObj.jsxGet_multiple();
      }

// Generating method code for jsxSet_multiple
      public virtual void JsxSet_multiple(bool multiple)
      {
         WObj.jsxSet_multiple(multiple);
      }

   }


}
