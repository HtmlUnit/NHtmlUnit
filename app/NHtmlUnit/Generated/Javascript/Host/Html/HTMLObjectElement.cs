// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLObjectElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLObjectElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement o) =>
            new HTMLObjectElement(o));
      }

      public HTMLObjectElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement)WrappedObject; }
      }

      public HTMLObjectElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLObjectElement()) {}

// Generating method code for jsxSet_classid
      public virtual void JsxSet_classid(string classid)
      {
         WObj.jsxSet_classid(classid);
      }

// Generating method code for jsxGet_alt
      public virtual string JsxGet_alt()
      {
         return WObj.jsxGet_alt();
      }

// Generating method code for jsxSet_alt
      public virtual void JsxSet_alt(string alt)
      {
         WObj.jsxSet_alt(alt);
      }

// Generating method code for jsxGet_border
      public virtual string JsxGet_border()
      {
         return WObj.jsxGet_border();
      }

// Generating method code for jsxSet_border
      public virtual void JsxSet_border(string border)
      {
         WObj.jsxSet_border(border);
      }

// Generating method code for jsxGet_classid
      public virtual string JsxGet_classid()
      {
         return WObj.jsxGet_classid();
      }

   }


}
