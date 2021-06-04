// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Selection : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Selection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Selection o) =>
            new Selection(o));
      }

      public Selection(com.gargoylesoftware.htmlunit.javascript.host.dom.Selection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Selection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Selection)WrappedObject; }
      }

      public Selection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Selection()) {}


      public System.Int32 RangeCount
      {
         get
         {
            return WObj.getRangeCount();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Node AnchorNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getAnchorNode());
         }
      }


      public System.Int32 AnchorOffset
      {
         get
         {
            return WObj.getAnchorOffset();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.Node FocusNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(
               WObj.getFocusNode());
         }
      }


      public System.Int32 FocusOffset
      {
         get
         {
            return WObj.getFocusOffset();
         }
      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }
// Generating method code for jsToString
      public virtual string JsToString()
      {
         return WObj.jsToString();
      }

// Generating method code for removeAllRanges
      public virtual void RemoveAllRanges()
      {
         WObj.removeAllRanges();
      }

// Generating method code for isIsCollapsed
      public virtual bool IsIsCollapsed()
      {
         return WObj.isIsCollapsed();
      }

// Generating method code for addRange
      public virtual void AddRange(NHtmlUnit.Javascript.Host.Dom.Range range)
      {
         WObj.addRange((com.gargoylesoftware.htmlunit.javascript.host.dom.Range)range.WrappedObject);
      }

// Generating method code for removeRange
      public virtual void RemoveRange(NHtmlUnit.Javascript.Host.Dom.Range range)
      {
         WObj.removeRange((com.gargoylesoftware.htmlunit.javascript.host.dom.Range)range.WrappedObject);
      }

// Generating method code for getRangeAt
      public virtual NHtmlUnit.Javascript.Host.Dom.Range GetRangeAt(int index)
      {
         var arg = WObj.getRangeAt(index);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Range>(arg);
      }

// Generating method code for collapse
      public virtual void Collapse(NHtmlUnit.Javascript.Host.Dom.Node parentNode, int offset)
      {
         WObj.collapse((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)parentNode.WrappedObject, offset);
      }

// Generating method code for collapseToEnd
      public virtual void CollapseToEnd()
      {
         WObj.collapseToEnd();
      }

// Generating method code for collapseToStart
      public virtual void CollapseToStart()
      {
         WObj.collapseToStart();
      }

// Generating method code for empty
      public virtual void Empty()
      {
         WObj.empty();
      }

// Generating method code for extend
      public virtual void Extend(NHtmlUnit.Javascript.Host.Dom.Node parentNode, int offset)
      {
         WObj.extend((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)parentNode.WrappedObject, offset);
      }

// Generating method code for selectAllChildren
      public virtual void SelectAllChildren(NHtmlUnit.Javascript.Host.Dom.Node parentNode)
      {
         WObj.selectAllChildren((com.gargoylesoftware.htmlunit.javascript.host.dom.Node)parentNode.WrappedObject);
      }

   }


}
