// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class AutocompleteErrorEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static AutocompleteErrorEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.AutocompleteErrorEvent o) =>
            new AutocompleteErrorEvent(o));
      }

      public AutocompleteErrorEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.AutocompleteErrorEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.AutocompleteErrorEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.AutocompleteErrorEvent)WrappedObject; }
      }

      public AutocompleteErrorEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.AutocompleteErrorEvent()) {}

   }


}
