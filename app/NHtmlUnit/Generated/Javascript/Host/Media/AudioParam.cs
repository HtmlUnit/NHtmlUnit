// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioParam : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AudioParam()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam o) =>
            new AudioParam(o));
      }

      public AudioParam(com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam)WrappedObject; }
      }

      public AudioParam()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam()) {}

   }


}
