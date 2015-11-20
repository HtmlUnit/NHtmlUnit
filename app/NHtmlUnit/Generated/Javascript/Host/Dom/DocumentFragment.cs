// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class DocumentFragment : NHtmlUnit.Javascript.Host.Dom.Node
   {
      static DocumentFragment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentFragment o) =>
            new DocumentFragment(o));
      }

      public DocumentFragment(com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentFragment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentFragment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentFragment)WrappedObject; }
      }

      public DocumentFragment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.DocumentFragment()) {}


      public System.String URL
      {
         get
         {
            return WObj.getURL();
         }
      }
// Generating method code for createAttribute
      public virtual object CreateAttribute(string attributeName)
      {
         return WObj.createAttribute(attributeName);
      }

// Generating method code for createElement
      public virtual object CreateElement(string tagName)
      {
         return WObj.createElement(tagName);
      }

// Generating method code for createComment
      public virtual object CreateComment(string comment)
      {
         return WObj.createComment(comment);
      }

// Generating method code for createDocumentFragment
      public virtual object CreateDocumentFragment()
      {
         return WObj.createDocumentFragment();
      }

// Generating method code for createTextNode
      public virtual object CreateTextNode(string newData)
      {
         return WObj.createTextNode(newData);
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.Dom.StaticNodeList QuerySelectorAll(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.StaticNodeList>(WObj.querySelectorAll(selectors));
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Dom.Node QuerySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(WObj.querySelector(selectors));
      }

   }


}
