// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Presentation
{
   public partial class PresentationAvailability : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PresentationAvailability()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationAvailability o) =>
            new PresentationAvailability(o));
      }

      public PresentationAvailability(com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationAvailability wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationAvailability WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationAvailability)WrappedObject; }
      }

      public PresentationAvailability()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationAvailability()) {}

   }


}
