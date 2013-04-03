// Generated class v5, don't modify

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

      public TreeWalker()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TreeWalker()) {}

      public TreeWalker(NHtmlUnit.Javascript.Host.Node root, System.Int64 whatToShow, NHtmlUnit.Javascript.Host.NodeFilter filter, bool expandEntityReferences)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TreeWalker((com.gargoylesoftware.htmlunit.javascript.host.Node)root.WrappedObject, whatToShow, (com.gargoylesoftware.htmlunit.javascript.host.NodeFilter)filter.WrappedObject, expandEntityReferences)) {}


      public NHtmlUnit.Javascript.Host.Node Root
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
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

      public NHtmlUnit.Javascript.Host.NodeFilter Filter
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.NodeFilter>(
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

      public NHtmlUnit.Javascript.Host.Node CurrentNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
               WObj.getCurrentNode());
         }
         set
         {
            WObj.setCurrentNode((com.gargoylesoftware.htmlunit.javascript.host.Node)value.WrappedObject);
         }

      }

// Generating method code for parentNode
      public virtual NHtmlUnit.Javascript.Host.Node ParentNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.parentNode());
      }

// Generating method code for firstChild
      public virtual NHtmlUnit.Javascript.Host.Node FirstChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.firstChild());
      }

// Generating method code for lastChild
      public virtual NHtmlUnit.Javascript.Host.Node LastChild()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.lastChild());
      }

// Generating method code for previousSibling
      public virtual NHtmlUnit.Javascript.Host.Node PreviousSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.previousSibling());
      }

// Generating method code for nextSibling
      public virtual NHtmlUnit.Javascript.Host.Node NextSibling()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.nextSibling());
      }

// Generating method code for previousNode
      public virtual NHtmlUnit.Javascript.Host.Node PreviousNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.previousNode());
      }

// Generating method code for nextNode
      public virtual NHtmlUnit.Javascript.Host.Node NextNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.nextNode());
      }

   }


}
