// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Util
{
   public partial class KeyDataPair : NHtmlUnit.Util.NameValuePair
   {
      static KeyDataPair()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.util.KeyDataPair o) =>
            new KeyDataPair(o));
      }

      public KeyDataPair(com.gargoylesoftware.htmlunit.util.KeyDataPair wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.util.KeyDataPair WObj
      {
         get { return (com.gargoylesoftware.htmlunit.util.KeyDataPair)WrappedObject; }
      }

      public KeyDataPair(string key, java.io.File file, string fileName, string mimeType, java.nio.charset.Charset charset)
         : this(new com.gargoylesoftware.htmlunit.util.KeyDataPair(key, file, fileName, mimeType, charset)) {}

      public KeyDataPair(string key, java.io.File file, string fileName, string mimeType, string charset)
         : this(new com.gargoylesoftware.htmlunit.util.KeyDataPair(key, file, fileName, mimeType, charset)) {}


      public System.Byte[] Data
      {
         get
         {
            return WObj.getData();
         }
         set
         {
            WObj.setData(value);
         }

      }

      public java.io.File File
      {
         get
         {
            return WObj.getFile();
         }
      }

      public System.String MimeType
      {
         get
         {
            return WObj.getMimeType();
         }
      }

      public System.String FileName
      {
         get
         {
            return WObj.getFileName();
         }
      }

      public java.nio.charset.Charset Charset
      {
         get
         {
            return WObj.getCharset();
         }
      }
   }


}
