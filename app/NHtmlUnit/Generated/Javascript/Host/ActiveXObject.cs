// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ActiveXObject : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ActiveXObject()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ActiveXObject o) =>
            new ActiveXObject(o));
      }

      public ActiveXObject(com.gargoylesoftware.htmlunit.javascript.host.ActiveXObject wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ActiveXObject WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ActiveXObject)WrappedObject; }
      }

      public ActiveXObject()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ActiveXObject()) {}

   }


}
