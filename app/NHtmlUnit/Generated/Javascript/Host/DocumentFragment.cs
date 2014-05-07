// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class DocumentFragment : NHtmlUnit.Javascript.Host.Node
   {
      static DocumentFragment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment o) =>
            new DocumentFragment(o));
      }

      public DocumentFragment(com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment)WrappedObject; }
      }

      public DocumentFragment()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.DocumentFragment()) {}

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
      public virtual NHtmlUnit.Javascript.Host.StaticNodeList QuerySelectorAll(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.StaticNodeList>(WObj.querySelectorAll(selectors));
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Node QuerySelector(string selectors)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.querySelector(selectors));
      }

   }


}
