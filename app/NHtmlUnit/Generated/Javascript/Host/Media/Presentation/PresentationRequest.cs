// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Presentation
{
   public partial class PresentationRequest : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PresentationRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationRequest o) =>
            new PresentationRequest(o));
      }

      public PresentationRequest(com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationRequest)WrappedObject; }
      }

      public PresentationRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationRequest()) {}

   }


}
