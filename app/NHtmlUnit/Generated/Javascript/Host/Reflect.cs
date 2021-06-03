// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Reflect : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Reflect()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Reflect o) =>
            new Reflect(o));
      }

      public Reflect(com.gargoylesoftware.htmlunit.javascript.host.Reflect wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Reflect WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Reflect)WrappedObject; }
      }

      public Reflect()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Reflect()) {}

// Generating method code for has
      public virtual bool Has(net.sourceforge.htmlunit.corejs.javascript.Scriptable target, string propertyKey)
      {
         return WObj.has(target, propertyKey);
      }

   }


}
