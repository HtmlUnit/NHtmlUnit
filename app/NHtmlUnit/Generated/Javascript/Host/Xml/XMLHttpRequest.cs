// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLHttpRequest : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static XMLHttpRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest o) =>
            new XMLHttpRequest(o));
      }

      public XMLHttpRequest(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest)WrappedObject; }
      }

      public XMLHttpRequest(bool caseSensitiveProperties)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest(caseSensitiveProperties)) {}

      public XMLHttpRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequest()) {}


      public System.Boolean WithCredentials
      {
         get
         {
            return WObj.getWithCredentials();
         }
         set
         {
            WObj.setWithCredentials(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onreadystatechange
      {
         get
         {
            return WObj.getOnreadystatechange();
         }
         set
         {
            WObj.setOnreadystatechange(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onload
      {
         get
         {
            return WObj.getOnload();
         }
         set
         {
            WObj.setOnload(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onerror
      {
         get
         {
            return WObj.getOnerror();
         }
         set
         {
            WObj.setOnerror(value);
         }

      }

      public System.Int32 ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }

      public System.String ResponseText
      {
         get
         {
            return WObj.getResponseText();
         }
      }

      public System.Object ResponseXML
      {
         get
         {
            return WObj.getResponseXML();
         }
      }

      public System.Int32 Status
      {
         get
         {
            return WObj.getStatus();
         }
      }

      public System.String StatusText
      {
         get
         {
            return WObj.getStatusText();
         }
      }

      public System.String AllResponseHeaders
      {
         get
         {
            return WObj.getAllResponseHeaders();
         }
      }

      public NHtmlUnit.Javascript.Host.Xml.XMLHttpRequestUpload Upload
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Xml.XMLHttpRequestUpload>(
               WObj.getUpload());
         }
      }

// Generating method code for abort
      public virtual void Abort()
      {
         WObj.abort();
      }

// Generating method code for getResponseHeader
      public virtual string GetResponseHeader(string headerName)
      {
         return WObj.getResponseHeader(headerName);
      }

// Generating method code for open
      public virtual void Open(string method, object urlParam, object asyncParam, object user, object password)
      {
         WObj.open(method, urlParam, asyncParam, user, password);
      }

// Generating method code for send
      public virtual void Send(object content)
      {
         WObj.send(content);
      }

// Generating method code for setRequestHeader
      public virtual void SetRequestHeader(string name, string value)
      {
         WObj.setRequestHeader(name, value);
      }

// Generating method code for overrideMimeType
      public virtual void OverrideMimeType(string mimeType)
      {
         WObj.overrideMimeType(mimeType);
      }

   }


}
