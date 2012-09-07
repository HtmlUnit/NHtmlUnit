// Generated class v4, don't modify

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

// Generating method code for jsxFunction_createAttribute
      public virtual object JsxFunction_createAttribute(string attributeName)
      {
         return WObj.jsxFunction_createAttribute(attributeName);
      }

// Generating method code for jsxFunction_createElement
      public virtual object JsxFunction_createElement(string tagName)
      {
         return WObj.jsxFunction_createElement(tagName);
      }

// Generating method code for jsxFunction_createComment
      public virtual object JsxFunction_createComment(string comment)
      {
         return WObj.jsxFunction_createComment(comment);
      }

// Generating method code for jsxFunction_createDocumentFragment
      public virtual object JsxFunction_createDocumentFragment()
      {
         return WObj.jsxFunction_createDocumentFragment();
      }

// Generating method code for jsxFunction_createTextNode
      public virtual object JsxFunction_createTextNode(string newData)
      {
         return WObj.jsxFunction_createTextNode(newData);
      }

   }


}
