// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLDOMSelection : NHtmlUnit.Activex.Javascript.Msxml.XMLDOMNodeList, NHtmlUnit.W3C.Dom.INodeList
   {
      static XMLDOMSelection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection o) =>
            new XMLDOMSelection(o));
      }

      public XMLDOMSelection(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection)WrappedObject; }
      }

      public XMLDOMSelection()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection()) {}

      public XMLDOMSelection(NHtmlUnit.Html.DomNode parentScope, bool attributeChangeSensitive, string description)
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLDOMSelection((com.gargoylesoftware.htmlunit.html.DomNode)parentScope.WrappedObject, attributeChangeSensitive, description)) {}

   }


}
