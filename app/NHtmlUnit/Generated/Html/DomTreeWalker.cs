// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomTreeWalker : ObjectWrapper, NHtmlUnit.W3C.Dom.Traversal.ITreeWalker
   {
      static DomTreeWalker()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomTreeWalker o) =>
            new DomTreeWalker(o));
      }

      public DomTreeWalker(com.gargoylesoftware.htmlunit.html.DomTreeWalker wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.DomTreeWalker WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomTreeWalker)WrappedObject; }
      }

      public DomTreeWalker(NHtmlUnit.Html.DomNode root, int whatToShow, NHtmlUnit.W3C.Dom.Traversal.INodeFilter filter, bool expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.html.DomTreeWalker((com.gargoylesoftware.htmlunit.html.DomNode)root.WrappedObject, whatToShow, (org.w3c.dom.traversal.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}


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

      public NHtmlUnit.W3C.Dom.Traversal.INodeFilter Filter
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.Traversal.INodeFilter>(
               WObj.getFilter());
         }
      }


      public System.Boolean ExpandEntityReferences
      {
         get
         {
            return WObj.getExpandEntityReferences();
         }
      }
// Generating method code for nextNode
      public virtual NHtmlUnit.Html.DomNode NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for previousNode
      public virtual NHtmlUnit.Html.DomNode PreviousNode()
      {
         var arg = WObj.previousNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for nextSibling
      public virtual NHtmlUnit.Html.DomNode NextSibling()
      {
         var arg = WObj.nextSibling();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for previousSibling
      public virtual NHtmlUnit.Html.DomNode PreviousSibling()
      {
         var arg = WObj.previousSibling();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for lastChild
      public virtual NHtmlUnit.Html.DomNode LastChild()
      {
         var arg = WObj.lastChild();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for firstChild
      public virtual NHtmlUnit.Html.DomNode FirstChild()
      {
         var arg = WObj.firstChild();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for parentNode
      public virtual NHtmlUnit.Html.DomNode ParentNode()
      {
         var arg = WObj.parentNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for getCurrentNode
      public virtual NHtmlUnit.Html.DomNode GetCurrentNode()
      {
         var arg = WObj.getCurrentNode();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(arg);
      }

// Generating method code for setCurrentNode
      public virtual void SetCurrentNode(NHtmlUnit.W3C.Dom.INode currentNode)
      {
         WObj.setCurrentNode((org.w3c.dom.Node)currentNode.WrappedObject);
      }

   }


}
