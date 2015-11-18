// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class XPathNSResolver : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XPathNSResolver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.XPathNSResolver o) =>
            new XPathNSResolver(o));
      }

      public XPathNSResolver(com.gargoylesoftware.htmlunit.javascript.host.dom.XPathNSResolver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathNSResolver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.XPathNSResolver)WrappedObject; }
      }

      public XPathNSResolver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.XPathNSResolver()) {}


      public System.String BaseIdentifier
      {
         get
         {
            return WObj.getBaseIdentifier();
         }
      }
// Generating method code for lookupNamespaceURI
      public virtual string LookupNamespaceURI(string prefix)
      {
         return WObj.lookupNamespaceURI(prefix);
      }

// Generating method code for getNamespaceForPrefix
      public virtual string GetNamespaceForPrefix(string prefix)
      {
         return WObj.getNamespaceForPrefix(prefix);
      }

// Generating method code for getNamespaceForPrefix
      public virtual string GetNamespaceForPrefix(string prefix, NHtmlUnit.W3C.Dom.INode context)
      {
         return WObj.getNamespaceForPrefix(prefix, (org.w3c.dom.Node)context.WrappedObject);
      }

// Generating method code for handlesNullPrefixes
      public virtual bool HandlesNullPrefixes()
      {
         return WObj.handlesNullPrefixes();
      }

   }


}
