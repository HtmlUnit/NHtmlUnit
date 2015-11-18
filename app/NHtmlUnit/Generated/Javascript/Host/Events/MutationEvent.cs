// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class MutationEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static MutationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.MutationEvent o) =>
            new MutationEvent(o));
      }

      public MutationEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.MutationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.MutationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.MutationEvent)WrappedObject; }
      }

      public MutationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.MutationEvent()) {}

   }


}
