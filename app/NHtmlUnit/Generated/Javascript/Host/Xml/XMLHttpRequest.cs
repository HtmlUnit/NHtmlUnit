// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLHttpRequest : NHtmlUnit.Javascript.SimpleScriptable
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

// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

// Generating method code for jsxGet_onreadystatechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function JsxGet_onreadystatechange()
      {
         return WObj.jsxGet_onreadystatechange();
      }

// Generating method code for jsxSet_onreadystatechange
      public virtual void JsxSet_onreadystatechange(net.sourceforge.htmlunit.corejs.javascript.Function stateChangeHandler)
      {
         WObj.jsxSet_onreadystatechange(stateChangeHandler);
      }

// Generating method code for jsxGet_onload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function JsxGet_onload()
      {
         return WObj.jsxGet_onload();
      }

// Generating method code for jsxSet_onload
      public virtual void JsxSet_onload(net.sourceforge.htmlunit.corejs.javascript.Function loadHandler)
      {
         WObj.jsxSet_onload(loadHandler);
      }

// Generating method code for jsxGet_onerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function JsxGet_onerror()
      {
         return WObj.jsxGet_onerror();
      }

// Generating method code for jsxSet_onerror
      public virtual void JsxSet_onerror(net.sourceforge.htmlunit.corejs.javascript.Function errorHandler)
      {
         WObj.jsxSet_onerror(errorHandler);
      }

// Generating method code for jsxGet_readyState
      public virtual int JsxGet_readyState()
      {
         return WObj.jsxGet_readyState();
      }

// Generating method code for jsxGet_responseText
      public virtual string JsxGet_responseText()
      {
         return WObj.jsxGet_responseText();
      }

// Generating method code for jsxGet_responseXML
      public virtual object JsxGet_responseXML()
      {
         return WObj.jsxGet_responseXML();
      }

// Generating method code for jsxGet_status
      public virtual int JsxGet_status()
      {
         return WObj.jsxGet_status();
      }

// Generating method code for jsxGet_statusText
      public virtual string JsxGet_statusText()
      {
         return WObj.jsxGet_statusText();
      }

// Generating method code for jsxFunction_abort
      public virtual void JsxFunction_abort()
      {
         WObj.jsxFunction_abort();
      }

// Generating method code for jsxFunction_getAllResponseHeaders
      public virtual string JsxFunction_getAllResponseHeaders()
      {
         return WObj.jsxFunction_getAllResponseHeaders();
      }

// Generating method code for jsxFunction_getResponseHeader
      public virtual string JsxFunction_getResponseHeader(string headerName)
      {
         return WObj.jsxFunction_getResponseHeader(headerName);
      }

// Generating method code for jsxFunction_open
      public virtual void JsxFunction_open(string method, object urlParam, bool async, object user, object password)
      {
         WObj.jsxFunction_open(method, urlParam, async, user, password);
      }

// Generating method code for jsxFunction_send
      public virtual void JsxFunction_send(object content)
      {
         WObj.jsxFunction_send(content);
      }

// Generating method code for jsxFunction_setRequestHeader
      public virtual void JsxFunction_setRequestHeader(string name, string value)
      {
         WObj.jsxFunction_setRequestHeader(name, value);
      }

// Generating method code for jsxFunction_overrideMimeType
      public virtual void JsxFunction_overrideMimeType(string mimeType)
      {
         WObj.jsxFunction_overrideMimeType(mimeType);
      }

   }


}
