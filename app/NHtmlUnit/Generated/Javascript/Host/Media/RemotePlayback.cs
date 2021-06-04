// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class RemotePlayback : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static RemotePlayback()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.RemotePlayback o) =>
            new RemotePlayback(o));
      }

      public RemotePlayback(com.gargoylesoftware.htmlunit.javascript.host.media.RemotePlayback wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.RemotePlayback WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.RemotePlayback)WrappedObject; }
      }

      public RemotePlayback()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.RemotePlayback()) {}

   }


}
