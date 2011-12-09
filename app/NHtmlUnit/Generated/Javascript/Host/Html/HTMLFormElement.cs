// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFormElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFormElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement o) =>
            new HTMLFormElement(o));
      }

      public HTMLFormElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement)WrappedObject; }
      }

      public HTMLFormElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFormElement()) {}

// Generating method code for jsxGet_elements
      public virtual IList<NHtmlUnit.W3C.Dom.INode> JsxGet_elements()
      {

         return new NodeListWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.jsxGet_elements());
      }

// Generating method code for jsxGet_target
      public virtual string JsxGet_target()
      {
         return WObj.jsxGet_target();
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxSet_name
      public virtual void JsxSet_name(string name)
      {
         WObj.jsxSet_name(name);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxGet_action
      public virtual string JsxGet_action()
      {
         return WObj.jsxGet_action();
      }

// Generating method code for jsxSet_action
      public virtual void JsxSet_action(string action)
      {
         WObj.jsxSet_action(action);
      }

// Generating method code for jsxGet_method
      public virtual string JsxGet_method()
      {
         return WObj.jsxGet_method();
      }

// Generating method code for jsxSet_method
      public virtual void JsxSet_method(string method)
      {
         WObj.jsxSet_method(method);
      }

// Generating method code for jsxGet_onsubmit
      public virtual object JsxGet_onsubmit()
      {
         return WObj.jsxGet_onsubmit();
      }

// Generating method code for jsxSet_onsubmit
      public virtual void JsxSet_onsubmit(object onsubmit)
      {
         WObj.jsxSet_onsubmit(onsubmit);
      }

// Generating method code for jsxSet_target
      public virtual void JsxSet_target(string target)
      {
         WObj.jsxSet_target(target);
      }

// Generating method code for jsxGet_encoding
      public virtual string JsxGet_encoding()
      {
         return WObj.jsxGet_encoding();
      }

// Generating method code for jsxSet_encoding
      public virtual void JsxSet_encoding(string encoding)
      {
         WObj.jsxSet_encoding(encoding);
      }

// Generating method code for jsxFunction_submit
      public virtual void JsxFunction_submit()
      {
         WObj.jsxFunction_submit();
      }

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(object index, object subIndex)
      {
         return WObj.jsxFunction_item(index, subIndex);
      }

// Generating method code for jsxFunction_reset
      public virtual void JsxFunction_reset()
      {
         WObj.jsxFunction_reset();
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         return WObj.call(cx, scope, thisObj, args);
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

   }


}
