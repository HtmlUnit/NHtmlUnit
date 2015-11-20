// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BarProp : NHtmlUnit.Javascript.SimpleScriptable
   {
      static BarProp()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BarProp o) =>
            new BarProp(o));
      }

      public BarProp(com.gargoylesoftware.htmlunit.javascript.host.BarProp wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BarProp WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BarProp)WrappedObject; }
      }

      public BarProp()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BarProp()) {}

   }


}
