// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TreeWalker : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TreeWalker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TreeWalker o) =>
            new TreeWalker(o));
      }

      public TreeWalker(com.gargoylesoftware.htmlunit.javascript.host.TreeWalker wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TreeWalker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TreeWalker)WrappedObject; }
      }

      public TreeWalker(NHtmlUnit.Javascript.Host.Node root, System.Int64 whatToShow, NHtmlUnit.Javascript.Host.NodeFilter filter, java.lang.Boolean expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TreeWalker((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject, whatToShow, (com.gargoylesoftware.htmlunit.javascript.host.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}

      public TreeWalker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TreeWalker()) {}

// Generating method code for jsxGet_root
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_root()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_root());
      }

// Generating method code for jsxGet_whatToShow
      public virtual System.Int64 JsxGet_whatToShow()
      {
         return WObj.jsxGet_whatToShow();
      }

// Generating method code for jsxGet_filter
      public virtual NHtmlUnit.Javascript.Host.NodeFilter JsxGet_filter()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.NodeFilter>(WObj.jsxGet_filter());
      }

// Generating method code for jsxGet_expandEntityReferences
      public virtual bool JsxGet_expandEntityReferences()
      {
         return WObj.jsxGet_expandEntityReferences();
      }

// Generating method code for jsxGet_currentNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_currentNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_currentNode());
      }

// Generating method code for jsxSet_currentNode
      public virtual void JsxSet_currentNode(NHtmlUnit.Javascript.Host.Node currentNode)
      {
         WObj.jsxSet_currentNode((com.gargoylesoftware.htmlunit.javascript.host.Node)currentNode.WrappedObject);
      }

// Generating method code for jsxFunction_parentNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_parentNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_parentNode());
      }

// Generating method code for jsxFunction_firstChild
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_firstChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_firstChild());
      }

// Generating method code for jsxFunction_lastChild
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_lastChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_lastChild());
      }

// Generating method code for jsxFunction_previousSibling
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_previousSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_previousSibling());
      }

// Generating method code for jsxFunction_nextSibling
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_nextSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_nextSibling());
      }

// Generating method code for jsxFunction_previousNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_previousNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_previousNode());
      }

// Generating method code for jsxFunction_nextNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxFunction_nextNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxFunction_nextNode());
      }

   }


}
