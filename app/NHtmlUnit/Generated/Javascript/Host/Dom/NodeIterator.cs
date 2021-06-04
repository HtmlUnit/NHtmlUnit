// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class NodeIterator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static NodeIterator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator o) =>
            new NodeIterator(o));
      }

      public NodeIterator(com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator)WrappedObject; }
      }

      public NodeIterator(NHtmlUnit.SgmlPage page, NHtmlUnit.Javascript.Host.Dom.Node root, int whatToShow, NHtmlUnit.W3C.Dom.Traversal.INodeFilter filter)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject, (com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, (org.w3c.dom.traversal.NodeFilter)filter.WrappedObject)) {}

      public NodeIterator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator()) {}


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
// Generating method code for detach
      public virtual void Detach()
      {
         WObj.detach();
      }

// Generating method code for nextNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Node NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for previousNode
      public virtual NHtmlUnit.Javascript.Host.Dom.Node PreviousNode()
      {
         var arg = WObj.previousNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

   }


}
