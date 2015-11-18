// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XDomainRequest : NHtmlUnit.Javascript.SimpleScriptable
   {
      static XDomainRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XDomainRequest o) =>
            new XDomainRequest(o));
      }

      public XDomainRequest(com.gargoylesoftware.htmlunit.javascript.host.xml.XDomainRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XDomainRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XDomainRequest)WrappedObject; }
      }

      public XDomainRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XDomainRequest()) {}

   }


}
