// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class WebSocket : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static WebSocket()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.WebSocket o) =>
            new WebSocket(o));
      }

      public WebSocket(com.gargoylesoftware.htmlunit.javascript.host.WebSocket wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.WebSocket WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.WebSocket)WrappedObject; }
      }

      public WebSocket()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.WebSocket()) {}


      public System.String Url
      {
         get
         {
            return WObj.getUrl();
         }
      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onclose
      {
         get
         {
            return WObj.getOnclose();
         }
         set
         {
            WObj.setOnclose(value);
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

      public net.sourceforge.htmlunit.corejs.javascript.Function Onmessage
      {
         get
         {
            return WObj.getOnmessage();
         }
         set
         {
            WObj.setOnmessage(value);
         }

      }

      public net.sourceforge.htmlunit.corejs.javascript.Function Onopen
      {
         get
         {
            return WObj.getOnopen();
         }
         set
         {
            WObj.setOnopen(value);
         }

      }

      public System.Int32 ReadyState
      {
         get
         {
            return WObj.getReadyState();
         }
      }

      public System.String Protocol
      {
         get
         {
            return WObj.getProtocol();
         }
      }

      public System.Int64 BufferedAmount
      {
         get
         {
            return WObj.getBufferedAmount();
         }
      }

      public System.String BinaryType
      {
         get
         {
            return WObj.getBinaryType();
         }
         set
         {
            WObj.setBinaryType(value);
         }

      }
// Generating method code for close
      public virtual void Close(object code, object reason)
      {
         WObj.close(code, reason);
      }

// Generating method code for close
      public virtual void Close()
      {
         WObj.close();
      }

// Generating method code for send
      public virtual void Send(object content)
      {
         WObj.send(content);
      }

   }


}
