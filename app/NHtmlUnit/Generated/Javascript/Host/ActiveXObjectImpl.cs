// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ActiveXObjectImpl : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ActiveXObjectImpl()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ActiveXObjectImpl o) =>
            new ActiveXObjectImpl(o));
      }

      public ActiveXObjectImpl(com.gargoylesoftware.htmlunit.javascript.host.ActiveXObjectImpl wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ActiveXObjectImpl WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ActiveXObjectImpl)WrappedObject; }
      }

      public ActiveXObjectImpl(string activeXName)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ActiveXObjectImpl(activeXName)) {}

   }


}
