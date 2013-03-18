// Generated class v5, don't modify

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

      public NamedNodeMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.NamedNodeMap()) {}

      public NamedNodeMap(NHtmlUnit.Html.DomElement element)
         : this(new com.gargoylesoftware.htmlunit.javascript.NamedNodeMap((com.gargoylesoftware.htmlunit.html.DomElement)element.WrappedObject)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
      }

// Generating method code for getNamedItem
      public virtual object GetNamedItem(string name)
      {
         return WObj.getNamedItem(name);
      }

// Generating method code for getNamedItemWithoutSytheticClassAttr
      public virtual object GetNamedItemWithoutSytheticClassAttr(string name)
      {
         return WObj.getNamedItemWithoutSytheticClassAttr(name);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for removeNamedItem
      public virtual void RemoveNamedItem(string name)
      {
         WObj.removeNamedItem(name);
      }

   }


}
