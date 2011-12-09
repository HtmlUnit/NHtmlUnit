// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BoxObject : NHtmlUnit.Javascript.SimpleScriptable
   {
      static BoxObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BoxObject o) =>
            new BoxObject(o));
      }

      public BoxObject(com.gargoylesoftware.htmlunit.javascript.host.BoxObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BoxObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BoxObject)WrappedObject; }
      }

      public BoxObject(NHtmlUnit.Javascript.Host.Html.HTMLElement element)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BoxObject((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLElement)element.WrappedObject)) {}

      public BoxObject()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BoxObject()) {}

// Generating method code for jsxGet_x
      public virtual int JsxGet_x()
      {
         return WObj.jsxGet_x();
      }

// Generating method code for jsxGet_y
      public virtual int JsxGet_y()
      {
         return WObj.jsxGet_y();
      }

// Generating method code for jsxGet_element
      public virtual NHtmlUnit.Javascript.Host.Html.HTMLElement JsxGet_element()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLElement>(WObj.jsxGet_element());
      }

// Generating method code for jsxGet_firstChild
      public virtual object JsxGet_firstChild()
      {
         return WObj.jsxGet_firstChild();
      }

// Generating method code for jsxGet_lastChild
      public virtual object JsxGet_lastChild()
      {
         return WObj.jsxGet_lastChild();
      }

// Generating method code for jsxGet_nextSibling
      public virtual object JsxGet_nextSibling()
      {
         return WObj.jsxGet_nextSibling();
      }

// Generating method code for jsxGet_previousSibling
      public virtual object JsxGet_previousSibling()
      {
         return WObj.jsxGet_previousSibling();
      }

// Generating method code for jsxGet_screenX
      public virtual int JsxGet_screenX()
      {
         return WObj.jsxGet_screenX();
      }

// Generating method code for jsxGet_screenY
      public virtual int JsxGet_screenY()
      {
         return WObj.jsxGet_screenY();
      }

// Generating method code for jsxGet_width
      public virtual int JsxGet_width()
      {
         return WObj.jsxGet_width();
      }

// Generating method code for jsxGet_height
      public virtual int JsxGet_height()
      {
         return WObj.jsxGet_height();
      }

   }


}
