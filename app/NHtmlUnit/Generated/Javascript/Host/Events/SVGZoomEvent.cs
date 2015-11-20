// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class SVGZoomEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static SVGZoomEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.SVGZoomEvent o) =>
            new SVGZoomEvent(o));
      }

      public SVGZoomEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.SVGZoomEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.SVGZoomEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.SVGZoomEvent)WrappedObject; }
      }

      public SVGZoomEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.SVGZoomEvent()) {}

   }


}
