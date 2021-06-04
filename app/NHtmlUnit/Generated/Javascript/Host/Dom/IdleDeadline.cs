// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class IdleDeadline : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IdleDeadline()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.IdleDeadline o) =>
            new IdleDeadline(o));
      }

      public IdleDeadline(com.gargoylesoftware.htmlunit.javascript.host.dom.IdleDeadline wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.IdleDeadline WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.IdleDeadline)WrappedObject; }
      }

      public IdleDeadline()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.IdleDeadline()) {}

   }


}
