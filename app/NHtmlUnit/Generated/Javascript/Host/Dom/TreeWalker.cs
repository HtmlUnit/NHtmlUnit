// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class TreeWalker : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TreeWalker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker o) =>
            new TreeWalker(o));
      }

      public TreeWalker(com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker)WrappedObject; }
      }

      public TreeWalker(NHtmlUnit.SgmlPage page, NHtmlUnit.Javascript.Host.Dom.Node root, int whatToShow, NHtmlUnit.W3C.Dom.Traversal.INodeFilter filter, bool expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, (com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, (org.w3c.dom.traversal.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}

      public TreeWalker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker()) {}


      public NHtmlUnit.Javascript.Host.Dom.Node Root
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getRoot());
         }
      }


      public System.Int64 WhatToShow
      {
         get
         {
            return WObj.getWhatToShow();
         }
      }

      public System.Object Filter
      {
         get
         {
            return WObj.getFilter();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Node CurrentNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getCurrentNode());
         }
         set
         {
            WObj.setCurrentNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)value.WrappedObject);
         }

      }

// Generating method code for isExpandEntityReferences
      public virtual bool IsExpandEntityReferences()
      {
         return WObj.isExpandEntityReferences();
      }

// Generating method code for parentNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Node ParentNode()
      {
         var arg = WObj.parentNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for firstChild
      public virtual NHtmlUnit.Javascript.Host.Dom.Node FirstChild()
      {
         var arg = WObj.firstChild();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for lastChild
      public virtual NHtmlUnit.Javascript.Host.Dom.Node LastChild()
      {
         var arg = WObj.lastChild();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for previousSibling
      public virtual NHtmlUnit.Javascript.Host.Dom.Node PreviousSibling()
      {
         var arg = WObj.previousSibling();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for nextSibling
      public virtual NHtmlUnit.Javascript.Host.Dom.Node NextSibling()
      {
         var arg = WObj.nextSibling();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for previousNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Node PreviousNode()
      {
         var arg = WObj.previousNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for nextNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Node NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

   }


}
