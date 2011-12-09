// Generated class v4, don't modify

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

// Generating method code for jsxSet_hash
      public virtual void JsxSet_hash(string hash)
      {
         WObj.jsxSet_hash(hash);
      }

// Generating method code for jsxSet_href
      public virtual void JsxSet_href(string newLocation)
      {
         WObj.jsxSet_href(newLocation);
      }

// Generating method code for initialize
      public virtual void Initialize(NHtmlUnit.Javascript.Host.Window window)
      {
         WObj.initialize((com.gargoylesoftware.htmlunit.javascript.host.Window)window.WrappedObject);
      }

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxFunction_assign
      public virtual void JsxFunction_assign(string url)
      {
         WObj.jsxFunction_assign(url);
      }

// Generating method code for jsxFunction_reload
      public virtual void JsxFunction_reload(bool force)
      {
         WObj.jsxFunction_reload(force);
      }

// Generating method code for jsxFunction_replace
      public virtual void JsxFunction_replace(string url)
      {
         WObj.jsxFunction_replace(url);
      }

// Generating method code for jsxFunction_toString
      public virtual string JsxFunction_toString()
      {
         return WObj.jsxFunction_toString();
      }

// Generating method code for jsxGet_search
      public virtual string JsxGet_search()
      {
         return WObj.jsxGet_search();
      }

// Generating method code for jsxSet_search
      public virtual void JsxSet_search(string search)
      {
         WObj.jsxSet_search(search);
      }

// Generating method code for jsxGet_hash
      public virtual string JsxGet_hash()
      {
         return WObj.jsxGet_hash();
      }

// Generating method code for jsxGet_hostname
      public virtual string JsxGet_hostname()
      {
         return WObj.jsxGet_hostname();
      }

// Generating method code for jsxSet_hostname
      public virtual void JsxSet_hostname(string hostname)
      {
         WObj.jsxSet_hostname(hostname);
      }

// Generating method code for jsxGet_host
      public virtual string JsxGet_host()
      {
         return WObj.jsxGet_host();
      }

// Generating method code for jsxSet_host
      public virtual void JsxSet_host(string host)
      {
         WObj.jsxSet_host(host);
      }

// Generating method code for jsxGet_pathname
      public virtual string JsxGet_pathname()
      {
         return WObj.jsxGet_pathname();
      }

// Generating method code for jsxSet_pathname
      public virtual void JsxSet_pathname(string pathname)
      {
         WObj.jsxSet_pathname(pathname);
      }

// Generating method code for jsxGet_port
      public virtual string JsxGet_port()
      {
         return WObj.jsxGet_port();
      }

// Generating method code for jsxSet_port
      public virtual void JsxSet_port(string port)
      {
         WObj.jsxSet_port(port);
      }

// Generating method code for jsxGet_protocol
      public virtual string JsxGet_protocol()
      {
         return WObj.jsxGet_protocol();
      }

// Generating method code for jsxSet_protocol
      public virtual void JsxSet_protocol(string protocol)
      {
         WObj.jsxSet_protocol(protocol);
      }

   }


}
