// Generated class v2.19.0.0, don't modify

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

      public System.String Text
      {
         get
         {
            return WObj.getText();
         }
         set
         {
            WObj.setText(value);
         }

      }

      public System.String Charset
      {
         get
         {
            return WObj.getCharset();
         }
         set
         {
            WObj.setCharset(value);
         }

      }

      public System.String Coords
      {
         get
         {
            return WObj.getCoords();
         }
         set
         {
            WObj.setCoords(value);
         }

      }

      public System.String Hreflang
      {
         get
         {
            return WObj.getHreflang();
         }
         set
         {
            WObj.setHreflang(value);
         }

      }

      public System.String Origin
      {
         get
         {
            return WObj.getOrigin();
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

      public System.String Download
      {
         get
         {
            return WObj.getDownload();
         }
         set
         {
            WObj.setDownload(value);
         }

      }

      public System.String Ping
      {
         get
         {
            return WObj.getPing();
         }
         set
         {
            WObj.setPing(value);
         }

      }

      public System.String Shape
      {
         get
         {
            return WObj.getShape();
         }
         set
         {
            WObj.setShape(value);
         }

      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
         set
         {
            WObj.setType(value);
         }

      }

      public NHtmlUnit.Javascript.Host.Dom.DOMTokenList RelList
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.DOMTokenList>(
               WObj.getRelList());
         }
      }


      public System.String ProtocolLong
      {
         get
         {
            return WObj.getProtocolLong();
         }
      }

      public System.String Methods
      {
         get
         {
            return WObj.getMethods();
         }
         set
         {
            WObj.setMethods(value);
         }

      }

      public System.String MimeType
      {
         get
         {
            return WObj.getMimeType();
         }
         set
         {
            WObj.setMimeType(value);
         }

      }

      public System.String NameProp
      {
         get
         {
            return WObj.getNameProp();
         }
      }

      public System.String Urn
      {
         get
         {
            return WObj.getUrn();
         }
         set
         {
            WObj.setUrn(value);
         }

      }

      public System.String DataFld
      {
         get
         {
            return WObj.getDataFld();
         }
         set
         {
            WObj.setDataFld(value);
         }

      }

      public System.String DataFormatAs
      {
         get
         {
            return WObj.getDataFormatAs();
         }
         set
         {
            WObj.setDataFormatAs(value);
         }

      }

      public System.String DataSrc
      {
         get
         {
            return WObj.getDataSrc();
         }
         set
         {
            WObj.setDataSrc(value);
         }

      }
// Generating method code for getSearchParams
      public virtual string GetSearchParams()
      {
         return WObj.getSearchParams();
      }

// Generating method code for setSearchParams
      public virtual void SetSearchParams(NHtmlUnit.Javascript.Host.URLSearchParams searchParams)
      {
         WObj.setSearchParams((com.gargoylesoftware.htmlunit.javascript.host.URLSearchParams)searchParams.WrappedObject);
      }

   }


}
