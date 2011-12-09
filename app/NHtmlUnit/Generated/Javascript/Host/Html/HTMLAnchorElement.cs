// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLAnchorElement : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static HTMLAnchorElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAnchorElement o) =>
            new HTMLAnchorElement(o));
      }

      public HTMLAnchorElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAnchorElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAnchorElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAnchorElement)WrappedObject; }
      }

      public HTMLAnchorElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLAnchorElement()) {}

// Generating method code for jsxSet_href
      public virtual void JsxSet_href(string href)
      {
         WObj.jsxSet_href(href);
      }

// Generating method code for jsxGet_href
      public virtual string JsxGet_href()
      {
         return WObj.jsxGet_href();
      }

// Generating method code for jsxSet_name
      public virtual void JsxSet_name(string name)
      {
         WObj.jsxSet_name(name);
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxSet_target
      public virtual void JsxSet_target(string target)
      {
         WObj.jsxSet_target(target);
      }

// Generating method code for jsxGet_target
      public virtual string JsxGet_target()
      {
         return WObj.jsxGet_target();
      }

// Generating method code for jsxSet_rel
      public virtual void JsxSet_rel(string rel)
      {
         WObj.jsxSet_rel(rel);
      }

// Generating method code for jsxGet_rel
      public virtual string JsxGet_rel()
      {
         return WObj.jsxGet_rel();
      }

// Generating method code for jsxSet_rev
      public virtual void JsxSet_rev(string rel)
      {
         WObj.jsxSet_rev(rel);
      }

// Generating method code for jsxGet_rev
      public virtual string JsxGet_rev()
      {
         return WObj.jsxGet_rev();
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

// Generating method code for jsxSet_hash
      public virtual void JsxSet_hash(string hash)
      {
         WObj.jsxSet_hash(hash);
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
