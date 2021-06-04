// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media.Presentation
{
   public partial class Presentation : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Presentation()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.presentation.Presentation o) =>
            new Presentation(o));
      }

      public Presentation(com.gargoylesoftware.htmlunit.javascript.host.media.presentation.Presentation wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.Presentation WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.presentation.Presentation)WrappedObject; }
      }

      public Presentation()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.presentation.Presentation()) {}

   }


}
