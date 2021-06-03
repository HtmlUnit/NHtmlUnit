// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class Audio : NHtmlUnit.Javascript.Host.Html.HTMLAudioElement
   {
      static Audio()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.Audio o) =>
            new Audio(o));
      }

      public Audio(com.gargoylesoftware.htmlunit.javascript.host.html.Audio wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.Audio WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.Audio)WrappedObject; }
      }

      public Audio()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.Audio()) {}

   }


}
