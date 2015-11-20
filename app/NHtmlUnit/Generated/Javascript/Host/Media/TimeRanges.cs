// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class TimeRanges : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TimeRanges()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.TimeRanges o) =>
            new TimeRanges(o));
      }

      public TimeRanges(com.gargoylesoftware.htmlunit.javascript.host.media.TimeRanges wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.TimeRanges WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.TimeRanges)WrappedObject; }
      }

      public TimeRanges()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.TimeRanges()) {}

   }


}
