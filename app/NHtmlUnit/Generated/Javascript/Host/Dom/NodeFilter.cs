// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class NodeFilter : NHtmlUnit.Javascript.SimpleScriptable
   {
      static NodeFilter()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter o) =>
            new NodeFilter(o));
      }

      public NodeFilter(com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter)WrappedObject; }
      }

      public NodeFilter()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.NodeFilter()) {}

   }


}
