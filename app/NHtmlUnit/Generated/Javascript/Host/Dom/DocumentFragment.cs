// Generated class v2.50.0.0, don't modify

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


      public System.Int32 ChildElementCount
      {
         get
         {
            return WObj.getChildElementCount();
         }
      }

      public NHtmlUnit.Javascript.Host.Element FirstElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getFirstElementChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Element LastElementChild
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Element>(
               WObj.getLastElementChild());
         }
      }


      public NHtmlUnit.Javascript.Host.Html.HTMLCollection Children
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLCollection>(
               WObj.getChildren());
         }
      }

// Generating method code for querySelectorAll
      public virtual NHtmlUnit.Javascript.Host.Dom.NodeList QuerySelectorAll(string selectors)
      {
         var arg = WObj.querySelectorAll(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.NodeList>(arg);
      }

// Generating method code for querySelector
      public virtual NHtmlUnit.Javascript.Host.Dom.Node QuerySelector(string selectors)
      {
         var arg = WObj.querySelector(selectors);
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.Node>(arg);
      }

// Generating method code for getElementById
      public virtual object GetElementById(object id)
      {
         var arg = WObj.getElementById(id);
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
