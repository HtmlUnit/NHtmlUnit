// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Intl
{
   public partial class Collator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Collator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.intl.Collator o) =>
            new Collator(o));
      }

      public Collator(com.gargoylesoftware.htmlunit.javascript.host.intl.Collator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.intl.Collator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.intl.Collator)WrappedObject; }
      }

      public Collator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.Collator()) {}

   }


}
