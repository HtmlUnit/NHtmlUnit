// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCollection : NHtmlUnit.Javascript.Host.Dom.AbstractList
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

      public HTMLCollection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection()) {}

      public HTMLCollection(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCollection((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}

// Generating method code for namedItem
      public virtual object NamedItem(string name)
      {
         var arg = WObj.namedItem(name);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for nextNode
      public virtual object NextNode()
      {
         var arg = WObj.nextNode();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

// Generating method code for reset
      public virtual void Reset()
      {
         WObj.reset();
      }

// Generating method code for tags
      public virtual object Tags(string tagName)
      {
         var arg = WObj.tags(tagName);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
