// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class NodeList : NHtmlUnit.Javascript.Host.Dom.AbstractList
   {
      static NodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList o) =>
            new NodeList(o));
      }

      public NodeList(com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList)WrappedObject; }
      }

      public NodeList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList()) {}

      public NodeList(NHtmlUnit.Html.DomNode domNode, bool attributeChangeSensitive)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, attributeChangeSensitive)) {}

      public NodeList(NHtmlUnit.Html.DomNode domNode, java.util.List initialElements)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, initialElements)) {}

// Generating method code for values
      public virtual net.sourceforge.htmlunit.corejs.javascript.ES6Iterator Values()
      {
         return WObj.values();
      }

// Generating method code for keys
      public virtual net.sourceforge.htmlunit.corejs.javascript.ES6Iterator Keys()
      {
         return WObj.keys();
      }

// Generating method code for entries
      public virtual net.sourceforge.htmlunit.corejs.javascript.ES6Iterator Entries()
      {
         return WObj.entries();
      }

// Generating method code for iterator
      public virtual net.sourceforge.htmlunit.corejs.javascript.ES6Iterator Iterator()
      {
         return WObj.iterator();
      }

// Generating method code for forEach
      public virtual void ForEach(object callback)
      {
         WObj.forEach(callback);
      }

   }


}
