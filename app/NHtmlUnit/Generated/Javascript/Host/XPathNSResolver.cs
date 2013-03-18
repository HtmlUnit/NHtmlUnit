// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class XPathNSResolver : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathNSResolver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.XPathNSResolver o) =>
            new XPathNSResolver(o));
      }

      public XPathNSResolver(com.gargoylesoftware.htmlunit.javascript.host.XPathNSResolver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.XPathNSResolver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.XPathNSResolver)WrappedObject; }
      }

      public XPathNSResolver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.XPathNSResolver()) {}

// Generating method code for lookupNamespaceURI
      public virtual string LookupNamespaceURI(string prefix)
      {
         return WObj.lookupNamespaceURI(prefix);
      }

   }


}
