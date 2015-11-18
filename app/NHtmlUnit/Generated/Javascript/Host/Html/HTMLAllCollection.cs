// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAllCollection : NHtmlUnit.Javascript.Host.Html.HTMLCollection
   {
      static HTMLAllCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection o) =>
            new HTMLAllCollection(o));
      }

      public HTMLAllCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection)WrappedObject; }
      }

      public HTMLAllCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection()) {}

      public HTMLAllCollection(NHtmlUnit.Html.DomNode parentScope, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAllCollection((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, description)) {}

   }


}
