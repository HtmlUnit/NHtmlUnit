// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomNodeIterator : ObjectWrapper, NHtmlUnit.W3C.Dom.Traversal.INodeIterator
   {
      static DomNodeIterator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomNodeIterator o) =>
            new DomNodeIterator(o));
      }

      public DomNodeIterator(com.gargoylesoftware.htmlunit.html.DomNodeIterator wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.DomNodeIterator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomNodeIterator)WrappedObject; }
      }

      public DomNodeIterator(NHtmlUnit.Html.DomNode root, int whatToShow, NHtmlUnit.W3C.Dom.Traversal.INodeFilter filter, bool expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.html.DomNodeIterator((com.gargoylesoftware.htmlunit.html.DomNode)root.WrappedObject, whatToShow, (org.w3c.dom.traversal.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}


      public NHtmlUnit.Html.DomNode Root
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getRoot());
         }
      }


      public System.Int32 WhatToShow
      {
         get
         {
            return WObj.getWhatToShow();
         }
      }

      public System.Boolean ExpandEntityReferences
      {
         get
         {
            return WObj.getExpandEntityReferences();
         }
      }

      public NHtmlUnit.W3C.Dom.Traversal.INodeFilter Filter
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.Traversal.INodeFilter>(
               WObj.getFilter());
         }
      }

// Generating method code for previousNode
      public virtual NHtmlUnit.Html.DomNode PreviousNode()
      {
         var arg = WObj.previousNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for nextNode
      public virtual NHtmlUnit.Html.DomNode NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
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

   }


}
