// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class LocalMediaStream : NHtmlUnit.Javascript.SimpleScriptable
   {
      static LocalMediaStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.LocalMediaStream o) =>
            new LocalMediaStream(o));
      }

      public LocalMediaStream(com.gargoylesoftware.htmlunit.javascript.host.media.LocalMediaStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.LocalMediaStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.LocalMediaStream)WrappedObject; }
      }

      public LocalMediaStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.LocalMediaStream()) {}

   }


}
