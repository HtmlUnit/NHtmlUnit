// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Range : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Range()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Range o) =>
            new Range(o));
      }

      public Range(com.gargoylesoftware.htmlunit.javascript.host.Range wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Range WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Range)WrappedObject; }
      }

      public Range(NHtmlUnit.Javascript.Host.Html.HTMLDocument document)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Range((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)document.WrappedObject)) {}

      public Range()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Range()) {}

// Generating method code for toW3C
      public virtual NHtmlUnit.Html.Impl.SimpleRange ToW3C()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.Impl.SimpleRange>(WObj.toW3C());
      }

// Generating method code for jsxFunction_setStartBefore
      public virtual void JsxFunction_setStartBefore(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_setStartBefore((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxFunction_setEndAfter
      public virtual void JsxFunction_setEndAfter(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_setEndAfter((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxGet_startContainer
      public virtual object JsxGet_startContainer()
      {
         return WObj.jsxGet_startContainer();
      }

// Generating method code for jsxGet_endContainer
      public virtual object JsxGet_endContainer()
      {
         return WObj.jsxGet_endContainer();
      }

// Generating method code for jsxGet_startOffset
      public virtual int JsxGet_startOffset()
      {
         return WObj.jsxGet_startOffset();
      }

// Generating method code for jsxGet_endOffset
      public virtual int JsxGet_endOffset()
      {
         return WObj.jsxGet_endOffset();
      }

// Generating method code for jsxFunction_setStart
      public virtual void JsxFunction_setStart(NHtmlUnit.Javascript.Host.Node refNode, int offset)
      {
         WObj.jsxFunction_setStart((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject, offset);
      }

// Generating method code for jsxFunction_setStartAfter
      public virtual void JsxFunction_setStartAfter(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_setStartAfter((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxGet_collapsed
      public virtual bool JsxGet_collapsed()
      {
         return WObj.jsxGet_collapsed();
      }

// Generating method code for jsxFunction_setEnd
      public virtual void JsxFunction_setEnd(NHtmlUnit.Javascript.Host.Node refNode, int offset)
      {
         WObj.jsxFunction_setEnd((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject, offset);
      }

// Generating method code for jsxFunction_setEndBefore
      public virtual void JsxFunction_setEndBefore(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_setEndBefore((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxFunction_selectNodeContents
      public virtual void JsxFunction_selectNodeContents(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_selectNodeContents((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxFunction_selectNode
      public virtual void JsxFunction_selectNode(NHtmlUnit.Javascript.Host.Node refNode)
      {
         WObj.jsxFunction_selectNode((com.gargoylesoftware.htmlunit.javascript.host.Node)refNode.WrappedObject);
      }

// Generating method code for jsxFunction_collapse
      public virtual void JsxFunction_collapse(bool toStart)
      {
         WObj.jsxFunction_collapse(toStart);
      }

// Generating method code for jsxGet_commonAncestorContainer
      public virtual object JsxGet_commonAncestorContainer()
      {
         return WObj.jsxGet_commonAncestorContainer();
      }

// Generating method code for jsxFunction_createContextualFragment
      public virtual object JsxFunction_createContextualFragment(string valueAsString)
      {
         return WObj.jsxFunction_createContextualFragment(valueAsString);
      }

// Generating method code for jsxFunction_extractContents
      public virtual object JsxFunction_extractContents()
      {
         return WObj.jsxFunction_extractContents();
      }

// Generating method code for jsxFunction_compareBoundaryPoints
      public virtual object JsxFunction_compareBoundaryPoints(int how, NHtmlUnit.Javascript.Host.Range sourceRange)
      {
         return WObj.jsxFunction_compareBoundaryPoints(how, (com.gargoylesoftware.htmlunit.javascript.host.Range)sourceRange.WrappedObject);
      }

   }


}
