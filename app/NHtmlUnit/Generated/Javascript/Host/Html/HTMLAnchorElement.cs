// Generated class v2.14.1.0, don't modify

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

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
         set
         {
            WObj.setName(value);
         }

      }

      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
         set
         {
            WObj.setTarget(value);
         }

      }

      public System.String Rel
      {
         get
         {
            return WObj.getRel();
         }
         set
         {
            WObj.setRel(value);
         }

      }

      public System.String Rev
      {
         get
         {
            return WObj.getRev();
         }
         set
         {
            WObj.setRev(value);
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
   }


}
