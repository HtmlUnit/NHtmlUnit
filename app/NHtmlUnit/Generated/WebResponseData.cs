// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebResponseData : ObjectWrapper
   {
      static WebResponseData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebResponseData o) =>
            new WebResponseData(o));
      }

      public WebResponseData(com.gargoylesoftware.htmlunit.WebResponseData wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebResponseData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebResponseData)WrappedObject; }
      }

      public WebResponseData(NHtmlUnit.IDownloadedContent downloadedContent, int statusCode, string statusMessage, java.util.List responseHeaders)
         : this(new com.gargoylesoftware.htmlunit.WebResponseData((com.gargoylesoftware.htmlunit.DownloadedContent)downloadedContent.WrappedObject, statusCode, statusMessage, responseHeaders)) {}

      public WebResponseData(System.Byte[] body, int statusCode, string statusMessage, java.util.List responseHeaders)
         : this(new com.gargoylesoftware.htmlunit.WebResponseData(body, statusCode, statusMessage, responseHeaders)) {}


      public IList<NHtmlUnit.Util.NameValuePair> ResponseHeaders
      {
         get
         {
            return new ListWrapper<NHtmlUnit.Util.NameValuePair>(
               WObj.getResponseHeaders());
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

      public System.Int64 ContentLength
      {
         get
         {
            return WObj.getContentLength();
         }
      }

      public java.io.InputStream InputStream
      {
         get
         {
            return WObj.getInputStream();
         }
      }

      public System.Byte[] Body
      {
         get
         {
            return WObj.getBody();
         }
      }
// Generating method code for getInputStreamWithBomIfApplicable
      public virtual java.io.InputStream GetInputStreamWithBomIfApplicable(org.apache.commons.io.ByteOrderMark[] bomHeaders)
      {
         return WObj.getInputStreamWithBomIfApplicable(bomHeaders);
      }

// Generating method code for cleanUp
      public virtual void CleanUp()
      {
         WObj.cleanUp();
      }

   }


}
