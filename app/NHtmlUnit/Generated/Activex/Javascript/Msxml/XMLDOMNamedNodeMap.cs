// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMNamedNodeMap : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static XMLDOMNamedNodeMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap o) =>
            new XMLDOMNamedNodeMap(o));
      }

      public XMLDOMNamedNodeMap(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap)WrappedObject; }
      }

      public XMLDOMNamedNodeMap(NHtmlUnit.Html.DomNode node)
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap((com.gargoylesoftware.htmlunit.html.DomNode)node.WrappedObject)) {}

      public XMLDOMNamedNodeMap()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNamedNodeMap()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for getNamedItemWithoutSyntheticClassAttr
      public virtual object GetNamedItemWithoutSyntheticClassAttr(string name)
      {
         var arg = WObj.getNamedItemWithoutSyntheticClassAttr(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getNamedItem
      public virtual object GetNamedItem(string name)
      {
         var arg = WObj.getNamedItem(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         var arg = WObj.getWithFallback(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for nextNode
      public virtual object NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for removeNamedItem
      public virtual object RemoveNamedItem(string name)
      {
         var arg = WObj.removeNamedItem(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for setNamedItem
      public virtual object SetNamedItem(NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode node)
      {
         var arg = WObj.setNamedItem((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)node.WrappedObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
