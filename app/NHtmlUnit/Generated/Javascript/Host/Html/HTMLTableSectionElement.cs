// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableSectionElement : NHtmlUnit.Javascript.Host.RowContainer, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableSectionElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement o) =>
            new HTMLTableSectionElement(o));
      }

      public HTMLTableSectionElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement)WrappedObject; }
      }

      public HTMLTableSectionElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableSectionElement()) {}


      public System.String Ch
      {
         get
         {
            return WObj.getCh();
         }
         set
         {
            WObj.setCh(value);
         }

      }

      public System.String ChOff
      {
         get
         {
            return WObj.getChOff();
         }
         set
         {
            WObj.setChOff(value);
         }

      }
// Generating method code for getVAlign
      public virtual string GetVAlign()
      {
         return WObj.getVAlign();
      }

// Generating method code for setVAlign
      public virtual void SetVAlign(object vAlign)
      {
         WObj.setVAlign(vAlign);
      }

   }


}
