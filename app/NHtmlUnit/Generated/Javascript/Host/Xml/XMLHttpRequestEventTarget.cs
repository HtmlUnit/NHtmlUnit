// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLHttpRequestEventTarget : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static XMLHttpRequestEventTarget()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget o) =>
            new XMLHttpRequestEventTarget(o));
      }

      public XMLHttpRequestEventTarget(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget)WrappedObject; }
      }

      public XMLHttpRequestEventTarget()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget()) {}

   }


}
