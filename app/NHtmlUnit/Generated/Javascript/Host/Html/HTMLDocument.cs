// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLDocument : NHtmlUnit.Javascript.Host.Dom.Document
   {
      static HTMLDocument()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument o) =>
            new HTMLDocument(o));
      }

      public HTMLDocument(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument)WrappedObject; }
      }

      public HTMLDocument()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLDocument()) {}

// Generating method code for open
      public virtual object Open(object url, object name, object features, object replace)
      {
         var arg = WObj.open(url, name, features, replace);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
