// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class URL : NHtmlUnit.Javascript.SimpleScriptable
   {
      static URL()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.URL o) =>
            new URL(o));
      }

      public URL(com.gargoylesoftware.htmlunit.javascript.host.URL wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.URL WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.URL)WrappedObject; }
      }

      public URL()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URL()) {}

      public URL(string url, object baseUrl)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.URL(url, baseUrl)) {}


      public System.String Hash
      {
         get
         {
            return WObj.getHash();
         }
         set
         {
            WObj.setHash(value);
         }

      }

      public System.String Host
      {
         get
         {
            return WObj.getHost();
         }
         set
         {
            WObj.setHost(value);
         }

      }

      public System.String Hostname
      {
         get
         {
            return WObj.getHostname();
         }
         set
         {
            WObj.setHostname(value);
         }

      }

      public System.String Href
      {
         get
         {
            return WObj.getHref();
         }
         set
         {
            WObj.setHref(value);
         }

      }

      public System.Object Origin
      {
         get
         {
            return WObj.getOrigin();
         }
      }

      public NHtmlUnit.Javascript.Host.URLSearchParams SearchParams
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.URLSearchParams>(
               WObj.getSearchParams());
         }
      }


      public System.String Password
      {
         get
         {
            return WObj.getPassword();
         }
         set
         {
            WObj.setPassword(value);
         }

      }

      public System.String Pathname
      {
         get
         {
            return WObj.getPathname();
         }
         set
         {
            WObj.setPathname(value);
         }

      }

      public System.String Port
      {
         get
         {
            return WObj.getPort();
         }
         set
         {
            WObj.setPort(value);
         }

      }

      public System.String Protocol
      {
         get
         {
            return WObj.getProtocol();
         }
         set
         {
            WObj.setProtocol(value);
         }

      }

      public System.String Search
      {
         get
         {
            return WObj.getSearch();
         }
         set
         {
            WObj.setSearch(value);
         }

      }

      public System.String Username
      {
         get
         {
            return WObj.getUsername();
         }
         set
         {
            WObj.setUsername(value);
         }

      }
// Generating method code for jsToString
      public virtual string JsToString()
      {
         return WObj.jsToString();
      }

// Generating method code for toJSON
      public virtual string ToJSON()
      {
         return WObj.toJSON();
      }

   }


}
