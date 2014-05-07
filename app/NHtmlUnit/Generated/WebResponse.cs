// Generated class v2.14.1.0, don't modify

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

      public NHtmlUnit.WebRequest WebRequest
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.WebRequest>(
               WObj.getWebRequest());
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

      public System.String ContentCharsetOrNull
      {
         get
         {
            return WObj.getContentCharsetOrNull();
         }
      }

      public System.String ContentCharset
      {
         get
         {
            return WObj.getContentCharset();
         }
      }

      public System.Int64 LoadTime
      {
         get
         {
            return WObj.getLoadTime();
         }
      }
// Generating method code for getResponseHeaderValue
      public virtual string GetResponseHeaderValue(string headerName)
      {
         return WObj.getResponseHeaderValue(headerName);
      }

// Generating method code for getContentAsString
      public virtual string GetContentAsString(string encoding)
      {
         return WObj.getContentAsString(encoding);
      }

// Generating method code for cleanUp
      public virtual void CleanUp()
      {
         WObj.cleanUp();
      }

   }


}
