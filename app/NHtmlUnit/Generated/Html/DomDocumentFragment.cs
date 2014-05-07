// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomDocumentFragment : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode, NHtmlUnit.W3C.Dom.IDocumentFragment
   {
      static DomDocumentFragment()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomDocumentFragment o) =>
            new DomDocumentFragment(o));
      }

      public DomDocumentFragment(com.gargoylesoftware.htmlunit.html.DomDocumentFragment wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomDocumentFragment WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomDocumentFragment)WrappedObject; }
      }

      public DomDocumentFragment(NHtmlUnit.SgmlPage page)
         : this(new com.gargoylesoftware.htmlunit.html.DomDocumentFragment((com.gargoylesoftware.htmlunit.SgmlPage)page.WrappedObject)) {}

   }


}
