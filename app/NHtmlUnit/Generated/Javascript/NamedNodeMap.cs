// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class NamedNodeMap : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static NamedNodeMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.NamedNodeMap o) =>
            new NamedNodeMap(o));
      }

      public NamedNodeMap(com.gargoylesoftware.htmlunit.javascript.NamedNodeMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.NamedNodeMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.NamedNodeMap)WrappedObject; }
      }

      public NamedNodeMap(NHtmlUnit.Html.DomElement element)
         : this(new com.gargoylesoftware.htmlunit.javascript.NamedNodeMap((com.gargoylesoftware.htmlunit.html.DomElement)element.WrappedObject)) {}

      public NamedNodeMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.NamedNodeMap()) {}

// Generating method code for jsxFunction_getNamedItem
      public virtual object JsxFunction_getNamedItem(string name)
      {
         return WObj.jsxFunction_getNamedItem(name);
      }

// Generating method code for getNamedItemWithoutSytheticClassAttr
      public virtual object GetNamedItemWithoutSytheticClassAttr(string name)
      {
         return WObj.getNamedItemWithoutSytheticClassAttr(name);
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

// Generating method code for jsxFunction_setNamedItem
      public virtual void JsxFunction_setNamedItem(NHtmlUnit.Javascript.Host.Node node)
      {
         WObj.jsxFunction_setNamedItem((com.gargoylesoftware.htmlunit.javascript.host.Node)node.WrappedObject);
      }

// Generating method code for jsxFunction_removeNamedItem
      public virtual void JsxFunction_removeNamedItem(string name)
      {
         WObj.jsxFunction_removeNamedItem(name);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

   }


}
