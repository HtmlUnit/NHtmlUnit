// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class DragEvent : NHtmlUnit.Javascript.Host.Events.MouseEvent
   {
      static DragEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.DragEvent o) =>
            new DragEvent(o));
      }

      public DragEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.DragEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.DragEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.DragEvent)WrappedObject; }
      }

      public DragEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.DragEvent()) {}

   }


}
