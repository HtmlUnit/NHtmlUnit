// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Moz
{
   public partial class MozSmsFilter : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MozSmsFilter()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsFilter o) =>
            new MozSmsFilter(o));
      }

      public MozSmsFilter(com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsFilter wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsFilter WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsFilter)WrappedObject; }
      }

      public MozSmsFilter()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.moz.MozSmsFilter()) {}

   }


}
