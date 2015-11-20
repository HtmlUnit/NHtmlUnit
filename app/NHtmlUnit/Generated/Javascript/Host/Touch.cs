// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Touch : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Touch()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Touch o) =>
            new Touch(o));
      }

      public Touch(com.gargoylesoftware.htmlunit.javascript.host.Touch wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Touch WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Touch)WrappedObject; }
      }

      public Touch()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Touch()) {}

   }


}
