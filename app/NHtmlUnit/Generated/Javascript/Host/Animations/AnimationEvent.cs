// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Animations
{
   public partial class AnimationEvent : NHtmlUnit.Javascript.Host.Events.Event
   {
      static AnimationEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.animations.AnimationEvent o) =>
            new AnimationEvent(o));
      }

      public AnimationEvent(com.gargoylesoftware.htmlunit.javascript.host.animations.AnimationEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.animations.AnimationEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.animations.AnimationEvent)WrappedObject; }
      }

      public AnimationEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.animations.AnimationEvent()) {}

   }


}
