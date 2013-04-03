// Generated class v5, don't modify

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

      public StyleSheetList(NHtmlUnit.Javascript.Host.Html.HTMLDocument document)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)document.WrappedObject)) {}

      public StyleSheetList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual object Item(int index)
      {
         return WObj.item(index);
      }

   }


}
