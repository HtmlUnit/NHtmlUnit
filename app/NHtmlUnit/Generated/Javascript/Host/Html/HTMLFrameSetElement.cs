// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFrameSetElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFrameSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement o) =>
            new HTMLFrameSetElement(o));
      }

      public HTMLFrameSetElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement)WrappedObject; }
      }

      public HTMLFrameSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFrameSetElement()) {}


      public System.String Rows
      {
         get
         {
            return WObj.getRows();
         }
         set
         {
            WObj.setRows(value);
         }

      }

      public System.String Cols
      {
         get
         {
            return WObj.getCols();
         }
         set
         {
            WObj.setCols(value);
         }

      }

      public System.String Border
      {
         get
         {
            return WObj.getBorder();
         }
         set
         {
            WObj.setBorder(value);
         }

      }
   }


}
