// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Intl
{
   public partial class NumberFormat : NHtmlUnit.Javascript.SimpleScriptable
   {
      static NumberFormat()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.intl.NumberFormat o) =>
            new NumberFormat(o));
      }

      public NumberFormat(com.gargoylesoftware.htmlunit.javascript.host.intl.NumberFormat wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.intl.NumberFormat WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.intl.NumberFormat)WrappedObject; }
      }

      public NumberFormat()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.NumberFormat()) {}

   }


}
