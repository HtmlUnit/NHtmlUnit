// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class BeforeUnloadEvent : NHtmlUnit.Javascript.Host.Event
   {
      static BeforeUnloadEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent o) =>
            new BeforeUnloadEvent(o));
      }

      public BeforeUnloadEvent(com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent)WrappedObject; }
      }

      public BeforeUnloadEvent(NHtmlUnit.Html.DomNode domNode, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent((com.gargoylesoftware.htmlunit.html.DomNode)domNode.WrappedObject, type)) {}

      public BeforeUnloadEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.BeforeUnloadEvent()) {}

   }


}
