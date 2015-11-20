// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLHttpRequestUpload : NHtmlUnit.Javascript.Host.Xml.XMLHttpRequestEventTarget
   {
      static XMLHttpRequestUpload()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestUpload o) =>
            new XMLHttpRequestUpload(o));
      }

      public XMLHttpRequestUpload(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestUpload wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestUpload WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestUpload)WrappedObject; }
      }

      public XMLHttpRequestUpload()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestUpload()) {}

   }


}
