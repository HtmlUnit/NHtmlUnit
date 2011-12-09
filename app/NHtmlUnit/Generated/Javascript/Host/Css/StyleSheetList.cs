// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class StyleSheetList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StyleSheetList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList o) =>
            new StyleSheetList(o));
      }

      public StyleSheetList(com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList)WrappedObject; }
      }

      public StyleSheetList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList()) {}

      public StyleSheetList(NHtmlUnit.Javascript.Host.Html.HTMLDocument document)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)document.WrappedObject)) {}

// Generating method code for jsxFunction_item
      public virtual object JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

   }


}
