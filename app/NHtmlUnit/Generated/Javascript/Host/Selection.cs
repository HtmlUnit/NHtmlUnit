// Generated class v2.14.1.0, don't modify

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


      public NHtmlUnit.Javascript.Host.Node AnchorNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
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

      public NHtmlUnit.Javascript.Host.Node FocusNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(
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

      public System.Boolean IsCollapsed
      {
         get
         {
            return WObj.getIsCollapsed();
         }
      }

      public System.Int32 RangeCount
      {
         get
         {
            return WObj.getRangeCount();
         }
      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }
// Generating method code for createRange
      public virtual NHtmlUnit.Javascript.Host.TextRange CreateRange()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.TextRange>(WObj.createRange());
      }

// Generating method code for addRange
      public virtual void AddRange(NHtmlUnit.Javascript.Host.Range range)
      {
         WObj.addRange((com.gargoylesoftware.htmlunit.javascript.host.Range)range.WrappedObject);
      }

// Generating method code for removeRange
      public virtual void RemoveRange(NHtmlUnit.Javascript.Host.Range range)
      {
         WObj.removeRange((com.gargoylesoftware.htmlunit.javascript.host.Range)range.WrappedObject);
      }

// Generating method code for removeAllRanges
      public virtual void RemoveAllRanges()
      {
         WObj.removeAllRanges();
      }

// Generating method code for getRangeAt
      public virtual NHtmlUnit.Javascript.Host.Range GetRangeAt(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Range>(WObj.getRangeAt(index));
      }

// Generating method code for collapse
      public virtual void Collapse(NHtmlUnit.Javascript.Host.Node parentNode, int offset)
      {
         WObj.collapse((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject, offset);
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
      public virtual void Extend(NHtmlUnit.Javascript.Host.Node parentNode, int offset)
      {
         WObj.extend((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject, offset);
      }

// Generating method code for selectAllChildren
      public virtual void SelectAllChildren(NHtmlUnit.Javascript.Host.Node parentNode)
      {
         WObj.selectAllChildren((com.gargoylesoftware.htmlunit.javascript.host.Node)parentNode.WrappedObject);
      }

   }


}
