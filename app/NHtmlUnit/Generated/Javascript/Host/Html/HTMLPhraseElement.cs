// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLPhraseElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLPhraseElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPhraseElement o) =>
            new HTMLPhraseElement(o));
      }

      public HTMLPhraseElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPhraseElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPhraseElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPhraseElement)WrappedObject; }
      }

      public HTMLPhraseElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLPhraseElement()) {}


      public System.String Cite
      {
         get
         {
            return WObj.getCite();
         }
         set
         {
            WObj.setCite(value);
         }

      }

      public System.String DateTime
      {
         get
         {
            return WObj.getDateTime();
         }
         set
         {
            WObj.setDateTime(value);
         }

      }
   }


}
