// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCollection : NHtmlUnit.Javascript.Host.NodeList, NHtmlUnit.W3C.Dom.INodeList
   {
      static HTMLCollection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection o) =>
            new HTMLCollection(o));
      }

      public HTMLCollection(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection)WrappedObject; }
      }

      public HTMLCollection(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}

// Generating method code for namedItem
      public virtual object NamedItem(string name)
      {
         return WObj.namedItem(name);
      }

// Generating method code for nextNode
      public virtual object NextNode()
      {
         return WObj.nextNode();
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for tags
      public virtual object Tags(string tagName)
      {
         return WObj.tags(tagName);
      }

   }


}
