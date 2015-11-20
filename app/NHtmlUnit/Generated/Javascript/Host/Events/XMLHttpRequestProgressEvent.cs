// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Events
{
   public partial class XMLHttpRequestProgressEvent : NHtmlUnit.Javascript.Host.Events.ProgressEvent
   {
      static XMLHttpRequestProgressEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent o) =>
            new XMLHttpRequestProgressEvent(o));
      }

      public XMLHttpRequestProgressEvent(com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent)WrappedObject; }
      }

      public XMLHttpRequestProgressEvent()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent()) {}

      public XMLHttpRequestProgressEvent(NHtmlUnit.Javascript.SimpleScriptable scriptable, string type)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.@event.XMLHttpRequestProgressEvent((com.gargoylesoftware.htmlunit.javascript.SimpleScriptable)scriptable.WrappedObject, type)) {}

   }


}
