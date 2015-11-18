// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLTableComponent : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLTableComponent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent o) =>
            new HTMLTableComponent(o));
      }

      public HTMLTableComponent(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent)WrappedObject; }
      }

      public HTMLTableComponent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLTableComponent()) {}


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
