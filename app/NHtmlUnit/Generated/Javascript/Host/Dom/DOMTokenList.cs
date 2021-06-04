// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DOMTokenList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DOMTokenList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList o) =>
            new DOMTokenList(o));
      }

      public DOMTokenList(com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList)WrappedObject; }
      }

      public DOMTokenList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList()) {}

      public DOMTokenList(NHtmlUnit.Javascript.Host.Dom.Node node, string attributeName)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DOMTokenList((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)node.WrappedObject, attributeName)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for contains
      public virtual bool Contains(string token)
      {
         return WObj.contains(token);
      }

// Generating method code for remove
      public virtual void Remove(string token)
      {
         WObj.remove(token);
      }

// Generating method code for add
      public virtual void Add(string token)
      {
         WObj.add(token);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for toggle
      public virtual bool Toggle(string token)
      {
         return WObj.toggle(token);
      }

   }


}
