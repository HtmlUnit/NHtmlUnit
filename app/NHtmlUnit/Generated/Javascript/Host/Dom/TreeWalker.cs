// Generated class v2.19.0.0, don't modify

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

      public TreeWalker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker()) {}

      public TreeWalker(NHtmlUnit.Javascript.Host.Dom.Node root, System.Int64 whatToShow, NHtmlUnit.Javascript.Host.Dom.NodeFilter filter, bool expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TreeWalker((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)root.WrappedObject, whatToShow, (com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}


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

      public NHtmlUnit.Javascript.Host.Dom.NodeFilter Filter
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeFilter>(
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
