// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Activex.Javascript.Msxml
{
   public partial class XMLHTTPRequest : NHtmlUnit.Activex.Javascript.Msxml.MSXMLScriptable
   {
      static XMLHTTPRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLHTTPRequest o) =>
            new XMLHTTPRequest(o));
      }

      public XMLHTTPRequest(com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLHTTPRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLHTTPRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLHTTPRequest)WrappedObject; }
      }

      public XMLHTTPRequest()
         : this(new com.gargoylesoftware.htmlunit.activex.javascript.msxml.XMLHTTPRequest()) {}


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
// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for abort
      public virtual void Abort()
      {
         WObj.abort();
      }

// Generating method code for getResponseHeader
      public virtual string GetResponseHeader(string header)
      {
         return WObj.getResponseHeader(header);
      }

// Generating method code for open
      public virtual void Open(string method, object url, bool async, object user, object password)
      {
         WObj.open(method, url, async, user, password);
      }

// Generating method code for send
      public virtual void Send(object body)
      {
         WObj.send(body);
      }

// Generating method code for setRequestHeader
      public virtual void SetRequestHeader(string name, string value)
      {
         WObj.setRequestHeader(name, value);
      }

// Generating method code for getOnreadystatechange
      public virtual object GetOnreadystatechange()
      {
         return WObj.getOnreadystatechange();
      }

// Generating method code for setOnreadystatechange
      public virtual void SetOnreadystatechange(net.sourceforge.htmlunit.corejs.javascript.Function stateChangeHandler)
      {
         WObj.setOnreadystatechange(stateChangeHandler);
      }

   }


}
