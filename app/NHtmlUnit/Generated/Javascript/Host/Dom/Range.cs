// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Range : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Range()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Range o) =>
            new Range(o));
      }

      public Range(com.gargoylesoftware.htmlunit.javascript.host.dom.Range wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Range WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Range)WrappedObject; }
      }

      public Range(NHtmlUnit.Javascript.Host.Dom.Document document)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Range((com.gargoylesoftware.htmlunit.javascript.host.dom.Document)document.WrappedObject)) {}

      public Range()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Range()) {}


      public System.Object StartContainer
      {
         get
         {
            return WObj.getStartContainer();
         }
      }

      public System.Object EndContainer
      {
         get
         {
            return WObj.getEndContainer();
         }
      }

      public System.Int32 StartOffset
      {
         get
         {
            return WObj.getStartOffset();
         }
      }

      public System.Int32 EndOffset
      {
         get
         {
            return WObj.getEndOffset();
         }
      }

      public System.Object CommonAncestorContainer
      {
         get
         {
            return WObj.getCommonAncestorContainer();
         }
      }

      public NHtmlUnit.Javascript.Host.ClientRectList ClientRects
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRectList>(
               WObj.getClientRects());
         }
      }


      public NHtmlUnit.Javascript.Host.ClientRect BoundingClientRect
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.ClientRect>(
               WObj.getBoundingClientRect());
         }
      }

// Generating method code for toW3C
      public virtual NHtmlUnit.Html.Impl.SimpleRange ToW3C()
      {
         var arg = WObj.toW3C();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.Impl.SimpleRange>(arg);
      }

// Generating method code for setStart
      public virtual void SetStart(NHtmlUnit.Javascript.Host.Dom.Node refNode, int offset)
      {
         WObj.setStart((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)refNode.WrappedObject, offset);
      }

// Generating method code for isCollapsed
      public virtual bool IsCollapsed()
      {
         return WObj.isCollapsed();
      }

// Generating method code for setEnd
      public virtual void SetEnd(NHtmlUnit.Javascript.Host.Dom.Node refNode, int offset)
      {
         WObj.setEnd((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)refNode.WrappedObject, offset);
      }

// Generating method code for selectNodeContents
      public virtual void SelectNodeContents(NHtmlUnit.Javascript.Host.Dom.Node refNode)
      {
         WObj.selectNodeContents((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)refNode.WrappedObject);
      }

// Generating method code for selectNode
      public virtual void SelectNode(NHtmlUnit.Javascript.Host.Dom.Node refNode)
      {
         WObj.selectNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)refNode.WrappedObject);
      }

// Generating method code for collapse
      public virtual void Collapse(bool toStart)
      {
         WObj.collapse(toStart);
      }

// Generating method code for createContextualFragment
      public virtual object CreateContextualFragment(string valueAsString)
      {
         var arg = WObj.createContextualFragment(valueAsString);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for extractContents
      public virtual object ExtractContents()
      {
         var arg = WObj.extractContents();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for compareBoundaryPoints
      public virtual object CompareBoundaryPoints(int how, NHtmlUnit.Javascript.Host.Dom.Range sourceRange)
      {
         var arg = WObj.compareBoundaryPoints(how, (com.gargoylesoftware.htmlunit.javascript.host.dom.Range)sourceRange.WrappedObject);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for cloneContents
      public virtual object CloneContents()
      {
         var arg = WObj.cloneContents();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for deleteContents
      public virtual void DeleteContents()
      {
         WObj.deleteContents();
      }

// Generating method code for insertNode
      public virtual void InsertNode(NHtmlUnit.Javascript.Host.Dom.Node newNode)
      {
         WObj.insertNode((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)newNode.WrappedObject);
      }

// Generating method code for surroundContents
      public virtual void SurroundContents(NHtmlUnit.Javascript.Host.Dom.Node newNode)
      {
         WObj.surroundContents((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)newNode.WrappedObject);
      }

// Generating method code for cloneRange
      public virtual object CloneRange()
      {
         var arg = WObj.cloneRange();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for detach
      public virtual void Detach()
      {
         WObj.detach();
      }

// Generating method code for jsToString
      public virtual string JsToString()
      {
         return WObj.jsToString();
      }

   }


}
