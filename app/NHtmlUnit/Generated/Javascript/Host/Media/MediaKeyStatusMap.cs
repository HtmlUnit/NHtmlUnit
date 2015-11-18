// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class MediaKeyStatusMap : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaKeyStatusMap()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyStatusMap o) =>
            new MediaKeyStatusMap(o));
      }

      public MediaKeyStatusMap(com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyStatusMap wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyStatusMap WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyStatusMap)WrappedObject; }
      }

      public MediaKeyStatusMap()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.MediaKeyStatusMap()) {}

   }


}
