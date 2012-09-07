// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Util
{
   public partial class Cookie : ObjectWrapper
   {
      static Cookie()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.util.Cookie o) =>
            new Cookie(o));
      }

      public Cookie(com.gargoylesoftware.htmlunit.util.Cookie wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.util.Cookie WObj
      {
         get { return (com.gargoylesoftware.htmlunit.util.Cookie)WrappedObject; }
      }

      public Cookie(string domain, string name, string value, string path, java.util.Date expires, bool secure)
         : this(new com.gargoylesoftware.htmlunit.util.Cookie(domain, name, value, path, expires, secure)) {}

      public Cookie(org.apache.http.cookie.Cookie c)
         : this(new com.gargoylesoftware.htmlunit.util.Cookie(c)) {}

      public Cookie(string domain, string name, string value)
         : this(new com.gargoylesoftware.htmlunit.util.Cookie(domain, name, value)) {}

      public Cookie(string domain, string name, string value, string path, java.util.Date expires, bool secure, bool httpOnly)
         : this(new com.gargoylesoftware.htmlunit.util.Cookie(domain, name, value, path, expires, secure, httpOnly)) {}

      public Cookie(string domain, string name, string value, string path, int maxAge, bool secure)
         : this(new com.gargoylesoftware.htmlunit.util.Cookie(domain, name, value, path, maxAge, secure)) {}


      public java.util.Date Expires
      {
         get
         {
            return WObj.getExpires();
         }
      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.String Value
      {
         get
         {
            return WObj.getValue();
         }
      }

      public System.String Domain
      {
         get
         {
            return WObj.getDomain();
         }
      }

      public System.String Path
      {
         get
         {
            return WObj.getPath();
         }
      }
// Generating method code for isHttpOnly
      public virtual bool IsHttpOnly()
      {
         return WObj.isHttpOnly();
      }

// Generating method code for toHttpClient
      public virtual org.apache.http.cookie.Cookie ToHttpClient()
      {
         return WObj.toHttpClient();
      }

// Generating method code for isSecure
      public virtual bool IsSecure()
      {
         return WObj.isSecure();
      }

   }


}
