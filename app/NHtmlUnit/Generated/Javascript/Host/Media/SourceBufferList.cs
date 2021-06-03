// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class SourceBufferList : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static SourceBufferList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.SourceBufferList o) =>
            new SourceBufferList(o));
      }

      public SourceBufferList(com.gargoylesoftware.htmlunit.javascript.host.media.SourceBufferList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.SourceBufferList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.SourceBufferList)WrappedObject; }
      }

      public SourceBufferList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.SourceBufferList()) {}

   }


}
