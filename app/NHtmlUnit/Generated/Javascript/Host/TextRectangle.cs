// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TextRectangle : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextRectangle()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TextRectangle o) =>
            new TextRectangle(o));
      }

      public TextRectangle(com.gargoylesoftware.htmlunit.javascript.host.TextRectangle wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TextRectangle WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TextRectangle)WrappedObject; }
      }

      public TextRectangle(int bottom, int left, int right, int top)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextRectangle(bottom, left, right, top)) {}

      public TextRectangle()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TextRectangle()) {}

// Generating method code for jsxSet_bottom
      public virtual void JsxSet_bottom(int bottom)
      {
         WObj.jsxSet_bottom(bottom);
      }

// Generating method code for jsxGet_bottom
      public virtual int JsxGet_bottom()
      {
         return WObj.jsxGet_bottom();
      }

// Generating method code for jsxSet_left
      public virtual void JsxSet_left(int left)
      {
         WObj.jsxSet_left(left);
      }

// Generating method code for jsxGet_left
      public virtual int JsxGet_left()
      {
         return WObj.jsxGet_left();
      }

// Generating method code for jsxSet_right
      public virtual void JsxSet_right(int right)
      {
         WObj.jsxSet_right(right);
      }

// Generating method code for jsxGet_right
      public virtual int JsxGet_right()
      {
         return WObj.jsxGet_right();
      }

// Generating method code for jsxSet_top
      public virtual void JsxSet_top(int top)
      {
         WObj.jsxSet_top(top);
      }

// Generating method code for jsxGet_top
      public virtual int JsxGet_top()
      {
         return WObj.jsxGet_top();
      }

   }


}
