// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class SourceBuffer : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static SourceBuffer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.SourceBuffer o) =>
            new SourceBuffer(o));
      }

      public SourceBuffer(com.gargoylesoftware.htmlunit.javascript.host.media.SourceBuffer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.SourceBuffer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.SourceBuffer)WrappedObject; }
      }

      public SourceBuffer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.SourceBuffer()) {}

   }


}
