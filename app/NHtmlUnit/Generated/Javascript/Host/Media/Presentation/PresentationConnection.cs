// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Presentation
{
   public partial class PresentationConnection : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PresentationConnection()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationConnection o) =>
            new PresentationConnection(o));
      }

      public PresentationConnection(com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationConnection wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationConnection WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationConnection)WrappedObject; }
      }

      public PresentationConnection()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.PresentationConnection()) {}

   }


}
