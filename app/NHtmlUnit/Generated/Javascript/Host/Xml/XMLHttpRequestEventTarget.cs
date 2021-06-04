// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class XMLHttpRequestEventTarget : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static XMLHttpRequestEventTarget()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget o) =>
            new XMLHttpRequestEventTarget(o));
      }

      public XMLHttpRequestEventTarget(com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget)WrappedObject; }
      }

      public XMLHttpRequestEventTarget()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.XMLHttpRequestEventTarget()) {}


      public net.sourceforge.htmlunit.corejs.javascript.Function Onload
      {
         get
         {
            return WObj.getOnload();
         }
         set
         {
            WObj.setOnload(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onerror
      {
         get
         {
            return WObj.getOnerror();
         }
         set
         {
            WObj.setOnerror(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onloadstart
      {
         get
         {
            return WObj.getOnloadstart();
         }
         set
         {
            WObj.setOnloadstart(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onloadend
      {
         get
         {
            return WObj.getOnloadend();
         }
         set
         {
            WObj.setOnloadend(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onprogress
      {
         get
         {
            return WObj.getOnprogress();
         }
         set
         {
            WObj.setOnprogress(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Ontimeout
      {
         get
         {
            return WObj.getOntimeout();
         }
         set
         {
            WObj.setOntimeout(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onreadystatechange
      {
         get
         {
            return WObj.getOnreadystatechange();
         }
         set
         {
            WObj.setOnreadystatechange(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onabort
      {
         get
         {
            return WObj.getOnabort();
         }
         set
         {
            WObj.setOnabort(value);
         }

      }
   }


}
