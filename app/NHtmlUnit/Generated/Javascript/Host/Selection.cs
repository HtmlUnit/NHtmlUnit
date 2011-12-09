// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Selection : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Selection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Selection o) =>
            new Selection(o));
      }

      public Selection(com.gargoylesoftware.htmlunit.javascript.host.Selection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Selection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Selection)WrappedObject; }
      }

      public Selection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Selection()) {}

// Generating method code for jsxGet_anchorNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_anchorNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_anchorNode());
      }

// Generating method code for jsxGet_anchorOffset
      public virtual int JsxGet_anchorOffset()
      {
         return WObj.jsxGet_anchorOffset();
      }

// Generating method code for jsxGet_focusNode
      public virtual NHtmlUnit.Javascript.Host.Node JsxGet_focusNode()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.jsxGet_focusNode());
      }

// Generating method code for jsxGet_focusOffset
      public virtual int JsxGet_focusOffset()
      {
         return WObj.jsxGet_focusOffset();
      }

// Generating method code for jsxGet_isCollapsed
      public virtual bool JsxGet_isCollapsed()
      {
         return WObj.jsxGet_isCollapsed();
      }

// Generating method code for jsxGet_rangeCount
      public virtual int JsxGet_rangeCount()
      {
         return WObj.jsxGet_rangeCount();
      }

// Generating method code for jsxGet_type
      public virtual string JsxGet_type()
      {
         return WObj.jsxGet_type();
      }

// Generating method code for jsxFunction_createRange
      public virtual NHtmlUnit.Javascript.Host.TextRange JsxFunction_createRange()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.TextRange>(WObj.jsxFunction_createRange());
      }

// Generating method code for jsxFunction_addRange
      public virtual void JsxFunction_addRange(NHtmlUnit.Javascript.Host.Range range)
      {
         WObj.jsxFunction_addRange((com.gargoylesoftware.htmlunit.javascript.host.Range)range.WrappedObject);
      }

// Generating method code for jsxFunction_removeRange
      public virtual void JsxFunction_removeRange(NHtmlUnit.Javascript.Host.Range range)
      {
         WObj.jsxFunction_removeRange((com.gargoylesoftware.htmlunit.javascript.host.Range)range.WrappedObject);
      }

// Generating method code for jsxFunction_removeAllRanges
      public virtual void JsxFunction_removeAllRanges()
      {
         WObj.jsxFunction_removeAllRanges();
      }

// Generating method code for jsxFunction_getRangeAt
      public virtual NHtmlUnit.Javascript.Host.Range JsxFunction_getRangeAt(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Range>(WObj.jsxFunction_getRangeAt(index));
      }

// Generating method code for jsxFunction_collapse
      public virtual void JsxFunction_collapse(NHtmlUnit.Javascript.Host.Node parentNode, int offset)
      {
         WObj.jsxFunction_collapse((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject, offset);
      }

// Generating method code for jsxFunction_collapseToEnd
      public virtual void JsxFunction_collapseToEnd()
      {
         WObj.jsxFunction_collapseToEnd();
      }

// Generating method code for jsxFunction_collapseToStart
      public virtual void JsxFunction_collapseToStart()
      {
         WObj.jsxFunction_collapseToStart();
      }

// Generating method code for jsxFunction_empty
      public virtual void JsxFunction_empty()
      {
         WObj.jsxFunction_empty();
      }

// Generating method code for jsxFunction_extend
      public virtual void JsxFunction_extend(NHtmlUnit.Javascript.Host.Node parentNode, int offset)
      {
         WObj.jsxFunction_extend((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject, offset);
      }

// Generating method code for jsxFunction_selectAllChildren
      public virtual void JsxFunction_selectAllChildren(NHtmlUnit.Javascript.Host.Node parentNode)
      {
         WObj.jsxFunction_selectAllChildren((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject);
      }

   }


}
