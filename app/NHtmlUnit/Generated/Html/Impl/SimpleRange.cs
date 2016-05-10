// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html.Impl
{
   public partial class SimpleRange : ObjectWrapper, NHtmlUnit.W3C.Dom.Ranges.IRange
   {
      static SimpleRange()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.impl.SimpleRange o) =>
            new SimpleRange(o));
      }

      public SimpleRange(com.gargoylesoftware.htmlunit.html.impl.SimpleRange wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.impl.SimpleRange WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.impl.SimpleRange)WrappedObject; }
      }

      public SimpleRange(NHtmlUnit.W3C.Dom.INode startNode, int startOffset, NHtmlUnit.W3C.Dom.INode endNode, int endOffset)
         : this(new com.gargoylesoftware.htmlunit.html.impl.SimpleRange((org.w3c.dom.Node)startNode.WrappedObject, startOffset, (org.w3c.dom.Node)endNode.WrappedObject, endOffset)) {}

      public SimpleRange(NHtmlUnit.W3C.Dom.INode node, int offset)
         : this(new com.gargoylesoftware.htmlunit.html.impl.SimpleRange((org.w3c.dom.Node)node.WrappedObject, offset)) {}

      public SimpleRange()
         : this(new com.gargoylesoftware.htmlunit.html.impl.SimpleRange()) {}

      public SimpleRange(NHtmlUnit.W3C.Dom.INode node)
         : this(new com.gargoylesoftware.htmlunit.html.impl.SimpleRange((org.w3c.dom.Node)node.WrappedObject)) {}


      public NHtmlUnit.W3C.Dom.INode CommonAncestorContainer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getCommonAncestorContainer());
         }
      }


      public System.Boolean Collapsed
      {
         get
         {
            return WObj.getCollapsed();
         }
      }

      public NHtmlUnit.W3C.Dom.INode EndContainer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getEndContainer());
         }
      }


      public System.Int32 EndOffset
      {
         get
         {
            return WObj.getEndOffset();
         }
      }

      public NHtmlUnit.W3C.Dom.INode StartContainer
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.INode>(
               WObj.getStartContainer());
         }
      }


      public System.Int32 StartOffset
      {
         get
         {
            return WObj.getStartOffset();
         }
      }
// Generating method code for cloneContents
      public virtual NHtmlUnit.Html.DomDocumentFragment CloneContents()
      {
         var arg = WObj.cloneContents();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomDocumentFragment>(arg);
      }

// Generating method code for deleteContents
      public virtual void DeleteContents()
      {
         WObj.deleteContents();
      }

// Generating method code for setStart
      public virtual void SetStart(NHtmlUnit.W3C.Dom.INode refNode, int offset)
      {
         WObj.setStart((org.w3c.dom.Node)refNode.WrappedObject, offset);
      }

// Generating method code for extractContents
      public virtual NHtmlUnit.Html.DomDocumentFragment ExtractContents()
      {
         var arg = WObj.extractContents();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomDocumentFragment>(arg);
      }

// Generating method code for insertNode
      public virtual void InsertNode(NHtmlUnit.W3C.Dom.INode newNode)
      {
         WObj.insertNode((org.w3c.dom.Node)newNode.WrappedObject);
      }

// Generating method code for setEnd
      public virtual void SetEnd(NHtmlUnit.W3C.Dom.INode refNode, int offset)
      {
         WObj.setEnd((org.w3c.dom.Node)refNode.WrappedObject, offset);
      }

// Generating method code for cloneRange
      public virtual NHtmlUnit.W3C.Dom.Ranges.IRange CloneRange()
      {
         var arg = WObj.cloneRange();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.Ranges.IRange>(arg);
      }

// Generating method code for collapse
      public virtual void Collapse(bool toStart)
      {
         WObj.collapse(toStart);
      }

// Generating method code for compareBoundaryPoints
      public virtual System.Int16 CompareBoundaryPoints(System.Int16 how, NHtmlUnit.W3C.Dom.Ranges.IRange sourceRange)
      {
         return WObj.compareBoundaryPoints(how, (org.w3c.dom.ranges.Range)sourceRange.WrappedObject);
      }

// Generating method code for detach
      public virtual void Detach()
      {
         WObj.detach();
      }

// Generating method code for selectNode
      public virtual void SelectNode(NHtmlUnit.W3C.Dom.INode node)
      {
         WObj.selectNode((org.w3c.dom.Node)node.WrappedObject);
      }

// Generating method code for selectNodeContents
      public virtual void SelectNodeContents(NHtmlUnit.W3C.Dom.INode node)
      {
         WObj.selectNodeContents((org.w3c.dom.Node)node.WrappedObject);
      }

// Generating method code for surroundContents
      public virtual void SurroundContents(NHtmlUnit.W3C.Dom.INode newParent)
      {
         WObj.surroundContents((org.w3c.dom.Node)newParent.WrappedObject);
      }

   }


}
