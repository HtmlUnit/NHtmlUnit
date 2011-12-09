// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCollection : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.W3C.Dom.INodeList
   {
      static HTMLCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection o) =>
            new HTMLCollection(o));
      }

      public HTMLCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection)WrappedObject; }
      }

      public HTMLCollection(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
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

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(object index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for jsxFunction_namedItem
      public virtual object JsxFunction_namedItem(string name)
      {
         return WObj.jsxFunction_namedItem(name);
      }

// Generating method code for jsxFunction_nextNode
      public virtual object JsxFunction_nextNode()
      {
         return WObj.jsxFunction_nextNode();
      }

// Generating method code for jsxFunction_reset
      public virtual void JsxFunction_reset()
      {
         WObj.jsxFunction_reset();
      }

// Generating method code for jsxFunction_tags
      public virtual object JsxFunction_tags(string tagName)
      {
         return WObj.jsxFunction_tags(tagName);
      }

// Generating method code for item
      public virtual NHtmlUnit.W3C.Dom.INode Item(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.item(index));
      }

   }


}
