// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class ProgressEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static ProgressEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent o) =>
            new ProgressEvent(o));
      }

      public ProgressEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent)WrappedObject; }
      }

      public ProgressEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent()) {}

      public ProgressEvent(NHtmlUnit.Javascript.Host.Events.EventTarget target, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent((com.gargoylesoftware.htmlunit.javascript.host.@event.EventTarget)target.WrappedObject, type)) {}


      public System.Object Loaded
      {
         get
         {
            return WObj.getLoaded();
         }
         set
         {
            WObj.setLoaded(value);
         }

      }

      public System.Int64 Total
      {
         get
         {
            return WObj.getTotal();
         }
         set
         {
            WObj.setTotal(value);
         }

      }
// Generating method code for isLengthComputable
      public virtual bool IsLengthComputable()
      {
         return WObj.isLengthComputable();
      }

   }


}
