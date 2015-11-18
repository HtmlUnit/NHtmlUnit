// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class WebKitMutationObserver : NHtmlUnit.Javascript.Host.Dom.MutationObserver, NHtmlUnit.Html.IHtmlAttributeChangeListener, NHtmlUnit.Html.ICharacterDataChangeListener
   {
      static WebKitMutationObserver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver o) =>
            new WebKitMutationObserver(o));
      }

      public WebKitMutationObserver(com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver)WrappedObject; }
      }

      public WebKitMutationObserver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver()) {}

      public WebKitMutationObserver(net.sourceforge.htmlunit.corejs.javascript.Function function)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.WebKitMutationObserver(function)) {}

   }


}
