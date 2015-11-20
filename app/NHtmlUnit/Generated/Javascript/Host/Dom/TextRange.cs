// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class TextRange : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextRange()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange o) =>
            new TextRange(o));
      }

      public TextRange(com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange)WrappedObject; }
      }

      public TextRange(NHtmlUnit.W3C.Dom.Ranges.IRange range)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange((org.w3c.dom.ranges.Range)range.WrappedObject)) {}

      public TextRange()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange()) {}

      public TextRange(NHtmlUnit.Javascript.Host.Html.HTMLElement elt)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)elt.WrappedObject)) {}


      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.String HtmlText
      {
         get
         {
            return WObj.getHtmlText();
         }
      }

      public System.String Bookmark
      {
         get
         {
            return WObj.getBookmark();
         }
      }
// Generating method code for collapse
      public virtual void Collapse(bool toStart)
      {
         WObj.collapse(toStart);
      }

// Generating method code for moveStart
      public virtual int MoveStart(string unit, object count)
      {
         return WObj.moveStart(unit, count);
      }

// Generating method code for duplicate
      public virtual object Duplicate()
      {
         return WObj.duplicate();
      }

// Generating method code for parentElement
      public virtual NHtmlUnit.Javascript.Host.Dom.Node ParentElement()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(WObj.parentElement());
      }

// Generating method code for select
      public virtual void Select()
      {
         WObj.select();
      }

// Generating method code for move
      public virtual int Move(string unit, object count)
      {
         return WObj.move(unit, count);
      }

// Generating method code for moveEnd
      public virtual int MoveEnd(string unit, object count)
      {
         return WObj.moveEnd(unit, count);
      }

// Generating method code for moveToElementText
      public virtual void MoveToElementText(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
      {
         WObj.moveToElementText((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject);
      }

// Generating method code for inRange
      public virtual bool InRange(NHtmlUnit.Javascript.Host.Dom.TextRange other)
      {
         return WObj.inRange((com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange)other.WrappedObject);
      }

// Generating method code for setEndPoint
      public virtual void SetEndPoint(string type, NHtmlUnit.Javascript.Host.Dom.TextRange other)
      {
         WObj.setEndPoint(type, (com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange)other.WrappedObject);
      }

// Generating method code for moveToBookmark
      public virtual bool MoveToBookmark(string bookmark)
      {
         return WObj.moveToBookmark(bookmark);
      }

// Generating method code for compareEndPoints
      public virtual int CompareEndPoints(string how, NHtmlUnit.Javascript.Host.Dom.TextRange sourceRange)
      {
         return WObj.compareEndPoints(how, (com.gargoylesoftware.htmlunit.javascript.host.dom.TextRange)sourceRange.WrappedObject);
      }

   }


}
