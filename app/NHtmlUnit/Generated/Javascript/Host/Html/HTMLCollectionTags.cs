// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCollectionTags : NHtmlUnit.Javascript.Host.Html.HTMLCollection, NHtmlUnit.W3C.Dom.INodeList
   {
      static HTMLCollectionTags()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollectionTags o) =>
            new HTMLCollectionTags(o));
      }

      public HTMLCollectionTags(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollectionTags wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollectionTags WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollectionTags)WrappedObject; }
      }

      public HTMLCollectionTags(NHtmlUnit.Html.DomNode parentScope, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollectionTags((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, description)) {}

   }


}
