// Generated class v2.19.0.0, don't modify

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


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for getNamedItemWithoutSytheticClassAttr
      public virtual object GetNamedItemWithoutSytheticClassAttr(string name)
      {
         var arg = WObj.getNamedItemWithoutSytheticClassAttr(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getNamedItem
      public virtual object GetNamedItem(string name)
      {
         var arg = WObj.getNamedItem(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         var arg = WObj.getWithFallback(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for removeNamedItem
      public virtual void RemoveNamedItem(string name)
      {
         WObj.removeNamedItem(name);
      }

   }


}
