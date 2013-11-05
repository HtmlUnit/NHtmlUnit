// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MutationEvent : NHtmlUnit.Javascript.Host.Event
   {
      static MutationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MutationEvent o) =>
            new MutationEvent(o));
      }

      public MutationEvent(com.gargoylesoftware.htmlunit.javascript.host.MutationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MutationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MutationEvent)WrappedObject; }
      }

      public MutationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MutationEvent()) {}

   }


}
