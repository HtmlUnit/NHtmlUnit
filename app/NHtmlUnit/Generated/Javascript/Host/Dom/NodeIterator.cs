// Generated class v2.19.0.0, don't modify

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

      public NodeIterator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator()) {}

      public NodeIterator(NHtmlUnit.Javascript.Host.Dom.Node root, System.Double whatToShow, net.sourceforge.htmlunit.corejs.javascript.Scriptable filter)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeIterator((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, filter)) {}


      public NHtmlUnit.Javascript.Host.Dom.Node Root
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getRoot());
         }
      }


      public System.Double WhatToShow
      {
         get
         {
            return WObj.getWhatToShow();
         }
      }

      public net.sourceforge.htmlunit.corejs.javascript.Scriptable Filter
      {
         get
         {
            return WObj.getFilter();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Node ReferenceNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getReferenceNode());
         }
      }

// Generating method code for isPointerBeforeReferenceNode
      public virtual bool IsPointerBeforeReferenceNode()
      {
         return WObj.isPointerBeforeReferenceNode();
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
