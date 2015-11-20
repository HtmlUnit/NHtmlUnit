// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class NodeList : NHtmlUnit.Javascript.Host.Dom.AbstractList
   {
      static NodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList o) =>
            new NodeList(o));
      }

      public NodeList(com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList)WrappedObject; }
      }

      public NodeList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList()) {}

      public NodeList(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeList((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}

   }


}
