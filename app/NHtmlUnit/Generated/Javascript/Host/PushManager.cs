// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PushManager : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PushManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PushManager o) =>
            new PushManager(o));
      }

      public PushManager(com.gargoylesoftware.htmlunit.javascript.host.PushManager wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PushManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PushManager)WrappedObject; }
      }

      public PushManager()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PushManager()) {}

   }


}
