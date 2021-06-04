// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Intl
{
   public partial class DateTimeFormat : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DateTimeFormat()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.intl.DateTimeFormat o) =>
            new DateTimeFormat(o));
      }

      public DateTimeFormat(com.gargoylesoftware.htmlunit.javascript.host.intl.DateTimeFormat wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.intl.DateTimeFormat WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.intl.DateTimeFormat)WrappedObject; }
      }

      public DateTimeFormat()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.DateTimeFormat()) {}

// Generating method code for format
      public virtual string Format(object objectArg)
      {
         return WObj.format(objectArg);
      }

// Generating method code for resolvedOptions
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable ResolvedOptions()
      {
         return WObj.resolvedOptions();
      }

   }


}
