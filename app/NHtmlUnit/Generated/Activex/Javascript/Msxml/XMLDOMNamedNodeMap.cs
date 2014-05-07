// Generated class v2.14.1.0, don't modify

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
         return WObj.getNamedItemWithoutSyntheticClassAttr(name);
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

// Generating method code for getWithFallback
      public virtual object GetWithFallback(string name)
      {
         return WObj.getWithFallback(name);
      }

// Generating method code for nextNode
      public virtual object NextNode()
      {
         return WObj.nextNode();
      }

// Generating method code for removeNamedItem
      public virtual object RemoveNamedItem(string name)
      {
         return WObj.removeNamedItem(name);
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for setNamedItem
      public virtual object SetNamedItem(NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNode node)
      {
         return WObj.setNamedItem((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMNode)node.WrappedObject);
      }

   }


}
