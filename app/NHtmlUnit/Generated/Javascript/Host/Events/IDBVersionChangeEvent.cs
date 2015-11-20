// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class IDBVersionChangeEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static IDBVersionChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.IDBVersionChangeEvent o) =>
            new IDBVersionChangeEvent(o));
      }

      public IDBVersionChangeEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.IDBVersionChangeEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.IDBVersionChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.IDBVersionChangeEvent)WrappedObject; }
      }

      public IDBVersionChangeEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.IDBVersionChangeEvent()) {}

   }


}
