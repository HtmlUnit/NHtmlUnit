// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Location : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Location()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Location o) =>
            new Location(o));
      }

      public Location(com.gargoylesoftware.htmlunit.javascript.host.Location wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Location WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Location)WrappedObject; }
      }

      public Location()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Location()) {}


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
// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.Javascript.Host.Window window)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.javascript.host.Window)window.WrappedObject);
      }

// Generating method code for assign
      public virtual void Assign(string url)
      {
         WObj.assign(url);
      }

// Generating method code for reload
      public virtual void Reload(bool force)
      {
         WObj.reload(force);
      }

// Generating method code for replace
      public virtual void Replace(string url)
      {
         WObj.replace(url);
      }

   }


}
