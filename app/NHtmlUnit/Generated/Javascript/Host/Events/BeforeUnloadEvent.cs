// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class BeforeUnloadEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static BeforeUnloadEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent o) =>
            new BeforeUnloadEvent(o));
      }

      public BeforeUnloadEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent)WrappedObject; }
      }

      public BeforeUnloadEvent(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

      public BeforeUnloadEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.BeforeUnloadEvent()) {}

// Generating method code for jConstructor
      public virtual void JConstructor()
      {
         WObj.jConstructor();
      }

   }


}
