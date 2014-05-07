// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class DocumentProxy : NHtmlUnit.Javascript.SimpleScriptableProxy, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static DocumentProxy()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.DocumentProxy o) =>
            new DocumentProxy(o));
      }

      public DocumentProxy(com.gargoylesoftware.htmlunit.javascript.host.html.DocumentProxy wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.DocumentProxy WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.DocumentProxy)WrappedObject; }
      }

      public DocumentProxy(NHtmlUnit.IWebWindow webWindow)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.DocumentProxy((com.gargoylesoftware.htmlunit.WebWindow)webWindow.WrappedObject)) {}

   }


}
