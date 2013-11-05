// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLFieldSetElement : NHtmlUnit.Javascript.Host.FormChild, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLFieldSetElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement o) =>
            new HTMLFieldSetElement(o));
      }

      public HTMLFieldSetElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement)WrappedObject; }
      }

      public HTMLFieldSetElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLFieldSetElement()) {}


      public System.String Align
      {
         get
         {
            return WObj.getAlign();
         }
         set
         {
            WObj.setAlign(value);
         }

      }
   }


}
