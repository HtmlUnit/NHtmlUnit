// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebResponse : ObjectWrapper
   {
      static WebResponse()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebResponse o) =>
            new WebResponse(o));
      }

      public WebResponse(com.gargoylesoftware.htmlunit.WebResponse wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebResponse WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebResponse)WrappedObject; }
      }

      public WebResponse(NHtmlUnit.WebResponseData responseData, NHtmlUnit.WebRequest request, System.Int64 loadTime)
         : this(new com.gargoylesoftware.htmlunit.WebResponse((com.gargoylesoftware.htmlunit.WebResponseData)responseData.WrappedObject, (com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject, loadTime)) {}

      public WebResponse(NHtmlUnit.WebResponseData responseData, java.net.URL url, NHtmlUnit.HttpMethod requestMethod, System.Int64 loadTime)
         : this(new com.gargoylesoftware.htmlunit.WebResponse((com.gargoylesoftware.htmlunit.WebResponseData)responseData.WrappedObject, url, (com.gargoylesoftware.htmlunit.HttpMethod)requestMethod.WrappedObject, loadTime)) {}


      public NHtmlUnit.WebRequest WebRequest
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebRequest>(
               WObj.getWebRequest());
         }
      }


      public System.String ContentAsString
      {
         get
         {
            return WObj.getContentAsString();
         }
      }

      public System.String ContentType
      {
         get
         {
            return WObj.getContentType();
         }
      }

      public System.Int32 StatusCode
      {
         get
         {
            return WObj.getStatusCode();
         }
      }

      public System.String StatusMessage
      {
         get
         {
            return WObj.getStatusMessage();
         }
      }

      public IList<NHtmlUnit.Util.NameValuePair> ResponseHeaders
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Util.NameValuePair>(
               WObj.getResponseHeaders());
         }
       }

      public java.io.InputStream ContentAsStream
      {
         get
         {
            return WObj.getContentAsStream();
         }
      }

      public java.nio.charset.Charset ContentCharsetOrNull
      {
         get
         {
            return WObj.getContentCharsetOrNull();
         }
      }

      public java.nio.charset.Charset ContentCharset
      {
         get
         {
            return WObj.getContentCharset();
         }
      }

      public System.Int64 ContentLength
      {
         get
         {
            return WObj.getContentLength();
         }
      }

      public java.io.InputStream ContentAsStreamWithBomIfApplicable
      {
         get
         {
            return WObj.getContentAsStreamWithBomIfApplicable();
         }
      }

      public System.Int64 LoadTime
      {
         get
         {
            return WObj.getLoadTime();
         }
      }
// Generating method code for cleanUp
      public virtual void CleanUp()
      {
         WObj.cleanUp();
      }

// Generating method code for getResponseHeaderValue
      public virtual string GetResponseHeaderValue(string headerName)
      {
         return WObj.getResponseHeaderValue(headerName);
      }

// Generating method code for defaultCharsetUtf8
      public virtual void DefaultCharsetUtf8()
      {
         WObj.defaultCharsetUtf8();
      }

// Generating method code for getContentAsString
      public virtual string GetContentAsString(java.nio.charset.Charset encoding)
      {
         return WObj.getContentAsString(encoding);
      }

// Generating method code for getContentAsString
      public virtual string GetContentAsString(java.nio.charset.Charset encoding, bool ignoreUtf8Bom)
      {
         return WObj.getContentAsString(encoding, ignoreUtf8Bom);
      }

   }


}
