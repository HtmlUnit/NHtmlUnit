// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMNodeList : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable, NHtmlUnit.W3C.Dom.INodeList
   {
      static XMLDOMNodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList o) =>
            new XMLDOMNodeList(o));
      }

      public XMLDOMNodeList(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList)WrappedObject; }
      }

      public XMLDOMNodeList()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList()) {}

      public XMLDOMNodeList(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNodeList((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual object Item(object index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for nextNode
      public virtual object NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for construct
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Construct(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, System.Object[] args)
      {
         return WObj.construct(cx, scope, args);
      }

// Generating method code for call
      public virtual object Call(net.sourceforge.htmlunit.corejs.javascript.Context cx, net.sourceforge.htmlunit.corejs.javascript.Scriptable scope, net.sourceforge.htmlunit.corejs.javascript.Scriptable thisObj, System.Object[] args)
      {
         var arg = WObj.call(cx, scope, thisObj, args);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for item
      public virtual NHtmlUnit.W3C.Dom.INode Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(arg);
      }

   }


}
