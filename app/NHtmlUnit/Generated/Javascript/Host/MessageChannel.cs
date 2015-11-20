// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MessageChannel : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MessageChannel()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MessageChannel o) =>
            new MessageChannel(o));
      }

      public MessageChannel(com.gargoylesoftware.htmlunit.javascript.host.MessageChannel wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MessageChannel WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MessageChannel)WrappedObject; }
      }

      public MessageChannel()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MessageChannel()) {}


      public NHtmlUnit.Javascript.Host.MessagePort Port1
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.MessagePort>(
               WObj.getPort1());
         }
      }


      public NHtmlUnit.Javascript.Host.MessagePort Port2
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.MessagePort>(
               WObj.getPort2());
         }
      }

   }


}
