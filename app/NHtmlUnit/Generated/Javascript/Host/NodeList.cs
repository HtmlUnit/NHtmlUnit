// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class NodeList : NHtmlUnit.Javascript.SimpleScriptable, NHtmlUnit.W3C.Dom.INodeList
   {
      static NodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.NodeList o) =>
            new NodeList(o));
      }

      public NodeList(com.gargoylesoftware.htmlunit.javascript.host.NodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.NodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.NodeList)WrappedObject; }
      }

      public NodeList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.NodeList()) {}

      public NodeList(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.NodeList((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}


      public IList<java.lang.Object> Elements
      {
         get
         {
            return new ShallowListWrapper<java.lang.Object>(
               WObj.getElements());
         }
       }

      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
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

// Generating method code for item
      public virtual object Item(object index)
      {
         return WObj.item(index);
      }

// Generating method code for item
      public virtual NHtmlUnit.W3C.Dom.INode Item(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(WObj.item(index));
      }

   }


}
