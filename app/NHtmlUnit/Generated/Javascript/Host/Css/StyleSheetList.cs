// Generated class v2.50.0.0, don't modify

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

      public StyleSheetList(NHtmlUnit.Javascript.Host.Dom.Document document)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheetList((com.gargoylesoftware.htmlunit.javascript.host.dom.Document)document.WrappedObject)) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for isActiveStyleSheetLink
      public virtual bool IsActiveStyleSheetLink(NHtmlUnit.Html.DomNode domNode)
      {
         return WObj.isActiveStyleSheetLink((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject);
      }

// Generating method code for item
      public virtual object Item(int index)
      {
         var arg = WObj.item(index);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
