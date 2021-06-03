// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Animations
{
   public partial class Animation : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static Animation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.animations.Animation o) =>
            new Animation(o));
      }

      public Animation(com.gargoylesoftware.htmlunit.javascript.host.animations.Animation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.animations.Animation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.animations.Animation)WrappedObject; }
      }

      public Animation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.animations.Animation()) {}

   }


}
