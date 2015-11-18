// Generated class v2.19.0.0, don't modify

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

      public ProgressEvent(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.ProgressEvent((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type)) {}


      public System.Boolean LengthComputable
      {
         get
         {
            return WObj.getLengthComputable();
         }
         set
         {
            WObj.setLengthComputable(value);
         }

      }

      public System.Int64 Loaded
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
   }


}
