// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozSmsSegmentInfo : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozSmsSegmentInfo()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsSegmentInfo o) =>
            new MozSmsSegmentInfo(o));
      }

      public MozSmsSegmentInfo(com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsSegmentInfo wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsSegmentInfo WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsSegmentInfo)WrappedObject; }
      }

      public MozSmsSegmentInfo()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsSegmentInfo()) {}

   }


}
