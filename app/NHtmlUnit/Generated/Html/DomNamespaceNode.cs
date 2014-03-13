// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomNamespaceNode : NHtmlUnit.Html.DomNode, NHtmlUnit.W3C.Dom.INode
   {
      static DomNamespaceNode()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomNamespaceNode o) =>
            new DomNamespaceNode(o));
      }

      public DomNamespaceNode(com.gargoylesoftware.htmlunit.html.DomNamespaceNode wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.html.DomNamespaceNode WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomNamespaceNode)WrappedObject; }
      }


      public System.String QualifiedName
      {
         get
         {
            return WObj.getQualifiedName();
         }
      }
   }


}
