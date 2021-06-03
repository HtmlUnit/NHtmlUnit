// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Animations
{
   public partial class KeyframeEffect : NHtmlUnit.Javascript.SimpleScriptable
   {
      static KeyframeEffect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.animations.KeyframeEffect o) =>
            new KeyframeEffect(o));
      }

      public KeyframeEffect(com.gargoylesoftware.htmlunit.javascript.host.animations.KeyframeEffect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.animations.KeyframeEffect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.animations.KeyframeEffect)WrappedObject; }
      }

      public KeyframeEffect()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.animations.KeyframeEffect()) {}

   }


}
