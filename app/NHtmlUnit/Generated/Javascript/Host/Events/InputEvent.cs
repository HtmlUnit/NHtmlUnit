// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class InputEvent : NHtmlUnit.Javascript.Host.Events.UIEvent
   {
      static InputEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent o) =>
            new InputEvent(o));
      }

      public InputEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent)WrappedObject; }
      }

      public InputEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.InputEvent()) {}


      public System.Boolean IsComposing
      {
         get
         {
            return WObj.getIsComposing();
         }
      }

      public System.Object Data
      {
         get
         {
            return WObj.getData();
         }
      }

      public System.Object InputType
      {
         get
         {
            return WObj.getInputType();
         }
      }
   }


}
