// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class NodeFilter : NHtmlUnit.Javascript.SimpleScriptable
   {
      static NodeFilter()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.NodeFilter o) =>
            new NodeFilter(o));
      }

      public NodeFilter(com.gargoylesoftware.htmlunit.javascript.host.NodeFilter wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.NodeFilter WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.NodeFilter)WrappedObject; }
      }

      public NodeFilter()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.NodeFilter()) {}

// Generating method code for acceptNode
      public virtual System.Int16 AcceptNode(NHtmlUnit.Javascript.Host.Node n)
      {
         return WObj.acceptNode((com.gargoylesoftware.htmlunit.javascript.host.Node)n.WrappedObject);
      }

   }


}
