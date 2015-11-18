// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Symbol : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Symbol()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Symbol o) =>
            new Symbol(o));
      }

      public Symbol(com.gargoylesoftware.htmlunit.javascript.host.Symbol wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Symbol WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Symbol)WrappedObject; }
      }

      public Symbol(string name)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Symbol(name)) {}

      public Symbol()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Symbol()) {}

   }


}
